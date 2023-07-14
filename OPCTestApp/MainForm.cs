using OPCLib.Models;
using OPCLib.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPCTestApp
{
   public partial class MainForm : Form
   {
      IOPCClient _client;
      BindingList<OPCTag> _listAllTags = new BindingList<OPCTag>();
      BindingList<OPCTag> _getValuesTags = new BindingList<OPCTag>();
      BindingList<OPCTag> _subscribedTags = new BindingList<OPCTag>();
      BindingList<TraceLog> _logs = new BindingList<TraceLog>();

      public MainForm()
      {
         InitializeComponent();

         this.listTagValues.DataSource = _getValuesTags;
         this.listTagValues.DisplayMember = "Name";
         this.listTagValues.ValueMember = "Id";

         this.listSubscribed.DataSource = _subscribedTags;
         this.listSubscribed.DisplayMember = "Name";
         this.listSubscribed.ValueMember = "Id";
      }

      private void btnConnectOPCLabs_Click(object sender, EventArgs e)
      {
         if (_client != null && _client.IsConnected)
         {
            _client.CloseConnection();
            _client.TagValueChanged -= _client_TagValueChanged;
         }
         _client = new OPCLabsClient();
         var response = _client.OpenConnection(new OPCLib.Models.OPCConnectionString()
         {
            Name = tbUser.Text,
            URL = tbServer.Text,
            Password = tbPassword.Text,
         });
         DebugLog(response);
         _client.TagValueChanged += _client_TagValueChanged;
         ToggleGroupBoxes(true);
      }

      private void _client_TagValueChanged(object sender, TagValueChangedArgument e)
      {
         rtbSubscriptionUpdate.AppendText($"{e.TagName} = {e.NewValue} \n");
      }

      private void btnConnectTraeger_Click(object sender, EventArgs e)
      {
         if (_client != null && _client.IsConnected)
         {
            _client.CloseConnection();
            _client.TagValueChanged -= _client_TagValueChanged;
         }
         _client = new TraegarClient();
         var response = _client.OpenConnection(new OPCLib.Models.OPCConnectionString()
         {
            Name = tbUser.Text,
            URL = tbServer.Text,
            Password = tbPassword.Text,
         });
         DebugLog(response);
         _client.TagValueChanged += _client_TagValueChanged;
         ToggleGroupBoxes(true);
      }

      private void btnAllTags_Click(object sender, EventArgs e)
      {
         var response = _client.GetAllTags();
         this.listTags.DataSource = response.Value;
         this.listTags.DisplayMember = "Display";
         this.listTags.ValueMember = "Id";
         foreach (var tag in response.Value)
         {
            _listAllTags.Add(tag);
         }
         DebugLog(response);
      }

      private void btnTagValues_Click(object sender, EventArgs e)
      {
         var response = _client.GetTagValues(_getValuesTags.ToList());
         if (response.IsSuccess)
         {
            dgTagValues.DataSource = response.Value.Select(f => new TagValuePair() { Tag = f.Name, Value = f.Value }).ToList().AsEnumerable();
         }
         DebugLog(response);
      }

      private void cmTreeView_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
      {
         if (e.ClickedItem == null && listTags.SelectedIndex <= 0)
         {
            MessageBox.Show("Please select a tag to continue..");
            return;
         }
         string menu = e.ClickedItem.Text;
         if (menu.Equals("Get TagValue(s)"))
         {
            _getValuesTags.Add(listTags.SelectedItem as OPCTag);
         }
         else if (menu.Equals("Update TagValue(s)"))
         {
            var tag = (OPCTag)listTags.SelectedItem;
            tbTagId.Text = tag.Id;
            tbTagName.Text = tag.Name;
            tbValueUpdate.Text = string.Empty;
            string type = tag.Type.ToLower();
            if (type.Contains("int"))
               cbDataType.SelectedIndex = (int)OPCDataType.Integer;
            else if (type.Contains("bool"))
               cbDataType.SelectedIndex = (int)OPCDataType.Boolean;
            else if (type.Contains("float") || type.Contains("real"))
               cbDataType.SelectedIndex = (int)OPCDataType.Float;
            else
               cbDataType.SelectedIndex = (int)OPCDataType.String;
         }
         else if (menu.Equals("Subscribe TagValue(s) Change(s)"))
         {
            var tag = (OPCTag)listTags.SelectedItem;
            _subscribedTags.Add(tag);
            var response = _client.SubscribeValueChange(tag);
            DebugLog(response);
         }
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         tbServer.Text = "opc.tcp://127.0.0.1:49320";
         ToggleGroupBoxes(false);
         listTags.ContextMenuStrip = cmTreeView;
         cbDataType.Items.Clear();
         foreach (OPCDataType val in Enum.GetValues(typeof(OPCDataType)))
         {
            cbDataType.Items.Add(val.ToString());
         }
         dgDebug.DataSource = _logs;

         for (int i = 0; i <= dgDebug.Columns.Count - 1; i++)
         {
            dgDebug.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDebug.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDebug.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
         }

         for (int i = 0; i <= dgDebug.Columns.Count - 1; i++)
         {
            int colw = dgDebug.Columns[i].Width;
            dgDebug.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgDebug.Columns[i].Width = colw;
         }
      }

      private void ToggleGroupBoxes(bool toggle)
      {
         grpAllTags.Enabled = toggle;
         grpSubscribe.Enabled = toggle;
         grpTagUpdates.Enabled = toggle;
         grpTagValues.Enabled = toggle;
      }

      private void btnUnSubscribe_Click(object sender, EventArgs e)
      {
         _subscribedTags.Clear();
         rtbSubscriptionUpdate.Clear();
         var response = _client.UnSubscribeAllValueChanges();
         DebugLog(response);
      }

      private void btnClearValues_Click(object sender, EventArgs e)
      {
         _getValuesTags.Clear();
         dgTagValues.DataSource = null;
      }

      private void btnTagUpdate_Click(object sender, EventArgs e)
      {
         OPCTag updateTag = new OPCTag()
         {
            Id = tbTagId.Text,
            Name = tbTagName.Text,
         };
         OPCDataType type = (OPCDataType)Enum.Parse(typeof(OPCDataType), cbDataType.SelectedIndex.ToString());
         try
         {
            switch (type)
            {
               case OPCDataType.Integer:
                  updateTag.Value = int.Parse(tbValueUpdate.Text);
                  break;
               case OPCDataType.Boolean:
                  updateTag.Value = bool.Parse(tbValueUpdate.Text);
                  break;
               case OPCDataType.Float:
                  updateTag.Value = float.Parse(tbValueUpdate.Text);
                  break;
               default:
                  updateTag.Value = tbValueUpdate.Text;
                  break;
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Parsing Error : {ex.Message}");
         }
         var response = _client.WriteTagValue(updateTag);
         DebugLog(response);
      }

      private void btnSimulation_Click(object sender, EventArgs e)
      {
         SimulationForm simulationForm = new SimulationForm();
         simulationForm.Show();
      }

      private void DebugLog<T>(ClientResponse<T> response)
      {
         _logs.Add(new TraceLog()
         {
            IsSuccess = response.IsSuccess,
            Operation = response.Operation,
            Error = response.ErrorMessage,
            TimeElapsed = response.TimeElapsed
         });
      }
   }
}

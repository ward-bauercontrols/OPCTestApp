using MathNet.Numerics.Random;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OPCTestApp
{
   public partial class SimulationForm : Form
   {
      public SimulationForm()
      {
         InitializeComponent();
      }

      private void btnAddChart_Click(object sender, EventArgs e)
      {
         if (listTags.SelectedIndex >= 0)
         {
            OPCTag tag = (OPCTag)listTags.SelectedItem;
            ChartControl readingControl = new ChartControl(client, tag);
            this.flowLayout2.Controls.Add(readingControl);
         }
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {

      }
      string tagIdentifier(int id) => $"Channel2.Device1.TestReadingValue{id}";
      string tagQualIdentifier(int id) => $"nsu=KEPServerEX ;ns=2;s={tagIdentifier(id)}";
      List<OPCTag> tags = new List<OPCTag>();
      IOPCClient client = new OPCLabsClient();
      private void SimulationForm_Load(object sender, EventArgs e)
      {
         ntbDuration.Value = 100;
         cbWrite.Enabled = true;
         client = new OPCLabsClient();
         client.OpenConnection(new OPCLib.Models.OPCConnectionString()
         {
            URL = "opc.tcp://127.0.0.1:49320"
         });
         tags = new List<OPCTag>();
         for (int i = 1; i <= 10; i++)
         {
            OPCTag tag = new OPCLib.Models.OPCTag()
            {
               Id = tagQualIdentifier(i),
               Name = tagIdentifier(i),
               Namespace = "KEPServerEX"
            };
            tags.Add(tag);
         }
         foreach (OPCTag tag in tags)
         {
            ReadingControl readingControl = new ReadingControl(client, tag);
            this.flowLayout1.Controls.Add(readingControl);
         }
         client.SubscribeValueChange(tags);
         listTags.Items.Clear();
         listTags.Items.AddRange(tags.ToArray());
         listTags.DisplayMember = "Name";
         listTags.ValueMember = "Id";
         RandomizeData();
      }

      private void RandomizeData()
      {
         if (cbWrite.Checked)
         {
            if (timer1 != null)
            {
               timer1.Stop();
               timer1.Tick -= Timer1_Tick;
            }
            timer1 = new System.Windows.Forms.Timer
            {
               Interval = 10, //(int)ntbDuration.Value,
            };
            timer1.Tick += Timer1_Tick;
            timer1.Start();
         }
         else
         {

         }
      }

      private void Timer1_Tick(object sender, EventArgs e)
      {
         Random random = new Random();
         byte[] bytes = new byte[tags.Count];
         random.NextBytes(bytes);
         for(int i=tags.Count-1;i>=0; i--)
         {
            tags[i].Value = random.Next((int)bytes[i]);
         }
         client.WriteTagValues(tags);
      }
   }
}

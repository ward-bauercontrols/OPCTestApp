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
   public partial class ReadingControl : UserControl
   {
      private readonly IOPCClient _client;
      private readonly string _tag;
      public ReadingControl(IOPCClient client, OPCTag tag)
      {
         InitializeComponent();
         _client = client;
         _tag = tag.Id;
         lblTagName.Text = tag.Name;
         _client.TagValueChanged += _client_TagValueChanged;
      }

      private void _client_TagValueChanged(object sender, OPCLib.Models.TagValueChangedArgument e)
      {
         if (e.NodeId == _tag)
         {
            lblTagValue.Text = e.NewValue.ToString();
         }
      }

      private void ReadingControl_Load(object sender, EventArgs e)
      {

      }


   }
}

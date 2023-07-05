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
      public MainForm()
      {
         InitializeComponent();
      }

      private void btnConnectOPCLabs_Click(object sender, EventArgs e)
      {
         if(_client != null && _client.IsConnected)
         {
            _client.CloseConnection();
         }
         _client = new OPCLabsClient();
         _client.OpenConnection(new OPCLib.Models.OPCConnectionString()
         {
             Name = tbUser.Text,
             URL  = tbServer.Text,
             Password = tbPassword.Text,
         });
      }

      private void btnConnectTraeger_Click(object sender, EventArgs e)
      {

      }

      private void btnAllTags_Click(object sender, EventArgs e)
      {
         _client.GetAllTags();
      }

      private void btnTagValues_Click(object sender, EventArgs e)
      {

      }

      private void btnSubscribe_Click(object sender, EventArgs e)
      {

      }
   }
}

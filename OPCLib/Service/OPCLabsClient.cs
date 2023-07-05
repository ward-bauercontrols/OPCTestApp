using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.Extensions;
using OPCLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCLib.Service
{
   public class OPCLabsClient : IOPCClient
   {
      private bool _isConnected { get; set; }
      private List<string> _subscribedTags
      {
         get;
         set;
      }
      private EasyUAClient _opcClient = new EasyUAClient();
      private OPCConnectionString _connectionString;
      private UAEndpointDescriptor _endpoint;
      /// <summary>
      /// Flag indicates whether OPC session connected or not yet
      /// </summary>
      public bool IsConnected => _isConnected;
      /// <summary>
      /// Event hanlder for Tag value changed
      /// </summary>
      public event EventHandler<TagValueChanged> TagValueChanged;
      public event EventHandler<OPCExceptionMsg> OPCException;
      /// <summary>
      /// Open new OPC Session
      /// </summary>
      /// <param name="connectionString"></param>
      public void OpenConnection(OPCConnectionString connectionString)
      {
         _connectionString = connectionString;
         _endpoint = UAEndpointDescriptor.FromString(_connectionString.URL);
         if(!string.IsNullOrEmpty(_connectionString.Name) && !string.IsNullOrEmpty(_connectionString.Password))
         {
            _endpoint.UserName = _connectionString.Name;
            _endpoint.Password = _connectionString.Password;
         }
      }
      /// <summary>
      /// Close current OPC Session
      /// </summary>
      public void CloseConnection()
      {
         _connectionString = null;
         _endpoint = null;
      }
      /// <summary>
      /// Get All OPC Tags
      /// </summary>
      /// <returns></returns>
      /// <exception cref="NotImplementedException"></exception>
      public IEnumerable<OPCTag> GetAllTags()
      {
         var items = _opcClient.BrowseDataNodes(_endpoint);
         var list = new List<OPCTag>();
         foreach(var tag in items) 
         {
            list.Add(new OPCTag()
            {
               Id = tag.NodeId,
               Name = tag.DisplayName,
               Description = tag.NodeId.ExpandedText,
            });
         }
         return list.AsEnumerable();
      }
      /// <summary>
      /// Get the current Tag Values
      /// </summary>
      /// <param name="tags"></param>
      /// <returns></returns>
      /// <exception cref="NotImplementedException"></exception>
      public IEnumerable<Dictionary<string, object>> GetTagValues(IEnumerable<string> tags)
      {
         throw new NotImplementedException();
      }
      /// <summary>
      /// Subscribe Tag value change
      /// </summary>
      /// <param name="tag"></param>
      /// <exception cref="NotImplementedException"></exception>
      public void SubscribeValueChange(string tag)
      {
         throw new NotImplementedException();
      }
      /// <summary>
      /// Write Tag Value / update
      /// </summary>
      /// <param name="tag"></param>
      /// <param name="value"></param>
      /// <exception cref="NotImplementedException"></exception>
      public void WriteTagValue(string tag, object value)
      {
         throw new NotImplementedException();
      }
      /// <summary>
      /// Check connection string established
      /// </summary>
      /// <returns></returns>
      private bool AssertConnected()
      {
         if (!_isConnected)
            OPCException?.Invoke(this, new OPCExceptionMsg()
            {
               ErrorMessage = "OPC Server is not connected"
            });
         return _isConnected;
      }
   }
}

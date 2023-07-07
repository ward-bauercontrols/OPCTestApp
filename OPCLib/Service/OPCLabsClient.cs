using Opc.Ua;
using OpcLabs.BaseLib;
using OpcLabs.BaseLib.ComTypes;
using OpcLabs.BaseLib.Extensions.Internal;
using OpcLabs.EasyOpc;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.AddressSpace;
using OpcLabs.EasyOpc.UA.AddressSpace.Standard;
using OpcLabs.EasyOpc.UA.Extensions;
using OpcLabs.EasyOpc.UA.Generic;
using OpcLabs.EasyOpc.UA.OperationModel;
using OPCLib.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
      private List<OPCTag> _tags;
      /// <summary>
      /// Flag indicates whether OPC session connected or not yet
      /// </summary>
      public bool IsConnected => _isConnected;
      /// <summary>
      /// Event hanlder for Tag value changed
      /// </summary>
      public event EventHandler<TagValueChangedArgument> TagValueChanged;
      /// <summary>
      /// Open new OPC Session
      /// </summary>
      /// <param name="connectionString"></param>
      public ClientResponse<bool> OpenConnection(OPCConnectionString connectionString)
      {
         ClientResponse<bool> response = new ClientResponse<bool>() { Operation = "Open Connection" };
         Stopwatch sw = new Stopwatch();
         sw.Start();
         try
         {
            _connectionString = connectionString;
            _endpoint = UAEndpointDescriptor.FromString(_connectionString.URL);
            if (!string.IsNullOrEmpty(_connectionString.Name) && !string.IsNullOrEmpty(_connectionString.Password))
            {
               _endpoint.UserName = _connectionString.Name;
               _endpoint.Password = _connectionString.Password;
            }
            _opcClient.DataChangeNotification += _opcClient_DataChangeNotification;
            response.IsSuccess = true;
         }
         catch (Exception ex)
         {
            response.IsSuccess = false;
            response.ErrorMessage = ex.Message;
         }
         finally
         {
            sw.Stop();
            response.TimeElapsed = sw.ElapsedMilliseconds;
         }
         return response;
      }
      /// <summary>
      /// Close current OPC Session
      /// </summary>
      public ClientResponse<bool> CloseConnection()
      {
         ClientResponse<bool> response = new ClientResponse<bool>() { Operation = "Close Connection" };
         Stopwatch sw = new Stopwatch();
         sw.Start();
         try
         {
            _opcClient.DataChangeNotification -= _opcClient_DataChangeNotification;
            _opcClient.UnsubscribeAllMonitoredItems();
            _connectionString = null;
            _endpoint = null;
            response.IsSuccess = true;
         }
         catch (Exception ex)
         {
            response.IsSuccess = false;
            response.ErrorMessage = ex.Message;
         }
         finally
         {
            sw.Stop();
            response.TimeElapsed = sw.ElapsedMilliseconds;
         }
         return response;
      }
      /// <summary>
      /// Get All OPC Tags
      /// </summary>
      /// <returns></returns>
      /// <exception cref="NotImplementedException"></exception>
      public ClientResponse<IEnumerable<OPCTag>> GetAllTags()
      {
         List<OPCTag> tags = new List<OPCTag>();
         Stopwatch sw = new Stopwatch();
         ClientResponse<IEnumerable<OPCTag>> response = new ClientResponse<IEnumerable<OPCTag>>()
         {
            Operation = "Get All Tags"
         };
         sw.Start();
         try
         {
            List<OPCTag> itemsList = new List<OPCTag>();
            UANodeElementCollection nodeElementCollection = _opcClient.BrowseDataNodes(_endpoint, UAObjectIds.ObjectsFolder);
            foreach (var nodeElement in nodeElementCollection)
            {
               itemsList.AddRange(browseFromNode(nodeElement));
            }
            var dtPairs = getNodeDataTypes(itemsList.Select(f=>f.Id).ToList());
            for(int i=0;i < itemsList.Count; i++)
            {
               itemsList[i].Type = dtPairs.Values.ToArray()[i];
               itemsList[i].Display = !string.IsNullOrEmpty(itemsList[i].Type) ? $"{itemsList[i].Name} ({itemsList[i].Type})" : $"{itemsList[i].Name}";
            }
            response.Value = itemsList.AsEnumerable();
            response.IsSuccess = true;
            _tags = tags;
         }
         catch (Exception ex)
         {
            response.IsSuccess = false;
            response.ErrorMessage = ex.Message;
         }
         finally 
         { 
            sw.Stop();
            response.TimeElapsed = sw.ElapsedMilliseconds;
         }
         return response;
      }
      /// <summary>
      /// Get the current Tag Values
      /// </summary>
      /// <param name="tags"></param>
      /// <returns></returns>
      /// <exception cref="NotImplementedException"></exception>
      public ClientResponse<IEnumerable<OPCTag>> GetTagValues(List<OPCTag> tags)
      {
         List<OPCTag> values = new List<OPCTag>();
         Stopwatch sw = new Stopwatch();
         ClientResponse<IEnumerable<OPCTag>> response = new ClientResponse<IEnumerable<OPCTag>>()
         {
            Operation = "Get Tag Values"
         };
         sw.Start();
         try
         {
            List<UAReadArguments> arguments = new List<UAReadArguments>();
            foreach(var tag in tags)
            {
               arguments.Add(new UAReadArguments(_endpoint, tag.Id));
            };
            UAAttributeDataResult[] attributeDataResultArray = _opcClient.ReadMultiple(arguments.ToArray());
            int i = 0;
            foreach(UAAttributeDataResult attributeDataResult in attributeDataResultArray)
            {
               OPCTag value = tags[i++];
               value.Value = attributeDataResult.Succeeded ? attributeDataResult.AttributeData.Value : null;
               values.Add(value);
            }
            response.IsSuccess = true;
         }
         catch (Exception ex)
         {
            response.IsSuccess = false;
            response.ErrorMessage = ex.Message;
         }
         finally
         {
            sw.Stop();
            response.Value = values.AsEnumerable();
            response.TimeElapsed = sw.ElapsedMilliseconds;
         }
         return response;
      }
      /// <summary>
      /// Subscribe Tag value change
      /// </summary>
      /// <param name="tag"></param>
      /// <exception cref="NotImplementedException"></exception>
      public ClientResponse<bool> SubscribeValueChange(OPCTag tag)
      {
         ClientResponse<bool> response = new ClientResponse<bool>()
         {
            Operation = "Monitor Value Change"
         };
         Stopwatch sw = new Stopwatch();
         sw.Start();
         try
         {
            List<EasyUAMonitoredItemArguments> arguments = new List<EasyUAMonitoredItemArguments>();
            arguments.Add(new EasyUAMonitoredItemArguments(null, _endpoint, tag.Id));
            _opcClient.SubscribeMultipleMonitoredItems(arguments.ToArray());
            response.IsSuccess = true;
         }
         catch (Exception ex)
         {
            response.IsSuccess = false;
            response.ErrorMessage = ex.Message;
         }
         finally
         {
            sw.Stop();
            response.TimeElapsed = sw.ElapsedMilliseconds;
         }
         return response;
      }
      /// <summary>
      /// Write Tag Value / update
      /// </summary>
      /// <param name="tag"></param>
      /// <param name="value"></param>
      /// <exception cref="NotImplementedException"></exception>
      public ClientResponse<bool> WriteTagValue(OPCTag writeTag)
      {
         ClientResponse<bool> response = new ClientResponse<bool>()
         {
            Operation = "Write Tag Value"
         };
         Stopwatch sw = new Stopwatch();
         sw.Start();
         try
         {
            _opcClient.WriteValue(_endpoint,writeTag.Id,writeTag.Value);
            response.IsSuccess = true;
         }
         catch (Exception ex)
         {
            response.IsSuccess = false;
            response.ErrorMessage = ex.Message;
         }
         finally
         {
            sw.Stop();
            response.TimeElapsed = sw.ElapsedMilliseconds;
         }
         return response;
      }
      /// <summary>
      /// Un subscribe all
      /// </summary>
      /// <returns></returns>
      /// <exception cref="NotImplementedException"></exception>
      public ClientResponse<bool> UnSubscribeAllValueChanges()
      {
         ClientResponse<bool> response = new ClientResponse<bool>()
         {
            Operation = "Unmonitor All Value Changes"
         };
         Stopwatch sw = new Stopwatch();
         sw.Start();
         try
         {
            _opcClient.UnsubscribeAllMonitoredItems();
            response.IsSuccess = true;
         }
         catch (Exception ex)
         {
            response.IsSuccess = false;
            response.ErrorMessage = ex.Message;
         }
         finally
         {
            sw.Stop();
            response.TimeElapsed = sw.ElapsedMilliseconds;
         }
         return response;
      }
      /// <summary>
      /// Client Data Change notifications
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <exception cref="NotImplementedException"></exception>
      private void _opcClient_DataChangeNotification(object sender, EasyUADataChangeNotificationEventArgs e)
      {
         TagValueChanged?.Invoke(this, new TagValueChangedArgument()
         {
            Tag = _opcClient.ReadDisplayName(_endpoint, e.Arguments.NodeDescriptor.NodeId),
            NewValue = e.AttributeData.Value.ToString()
         });
      }
      /// <summary>
      /// Browse from Node
      /// </summary>
      /// <param name="parentNode"></param>
      /// <param name="level"></param>
      private List<OPCTag> browseFromNode(UANodeDescriptor parentNode, string rootName="")
      {
         List<OPCTag> tags = new List<OPCTag>();
         UANodeElementCollection nodeElementCollection = _opcClient.BrowseDataNodes(_endpoint, parentNode);
         foreach(var node in nodeElementCollection)
         {
            if(node.NodeClass == UANodeClass.Variable)
            {
               OPCTag tag = new OPCTag()
               {
                  Id = node.NodeId.ExpandedText,
                  Name = $"{rootName}{node.DisplayName}",
                  Namespace = node.NodeId.NamespaceUriString,
                  //Type = getNodeDataType(node.NodeId.ExpandedText)
               };
               tags.Add(tag);
            }
            tags.AddRange(browseFromNode(node,$"{rootName}{node.DisplayName}."));

         }
         return tags;
      }
      private string getNodeDataType(string node)
      {
         try
         {
            return _opcClient.ReadValue(_endpoint, node, UAAttributeId.DataType).ToString();
         }
         catch 
         {
            return string.Empty;
         }
      }
      private Dictionary<string,string> getNodeDataTypes(List<string> nodes)
      {
         Stopwatch sw = new Stopwatch();
         sw.Start();
         Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
         List<UANodeArguments> arguments = new List<UANodeArguments>();
         foreach (var node in nodes)
         {
            arguments.Add(new UANodeArguments()
            {
               EndpointDescriptor = _endpoint,
               NodeDescriptor = node,
            });
         }
         var results = _opcClient.ReadMultipleDataTypes(arguments.ToArray());
         int i = 0;
         foreach (var result in results)
         {
            keyValuePairs.Add(nodes.ToArray()[i++], result.Succeeded ? result.Value.ToString() : string.Empty);
         }
         sw.Stop();
         return keyValuePairs;
      }
      
   }
}

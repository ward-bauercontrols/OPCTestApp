using OPCLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCLib.Service
{
   public interface IOPCClient
   {
      event EventHandler<TagValueChangedArgument> TagValueChanged;
      ClientResponse<bool> OpenConnection(OPCConnectionString connectionString);
      ClientResponse<bool> CloseConnection();
      ClientResponse<IEnumerable<OPCTag>> GetAllTags();
      ClientResponse<IEnumerable<OPCTag>> GetTagValues(List<OPCTag> tags);
      ClientResponse<bool> WriteTagValue(OPCTag writeTag);
      ClientResponse<bool> WriteTagValues(List<OPCTag> writeTags);
      ClientResponse<bool> SubscribeValueChange(OPCTag tag);
      ClientResponse<bool> SubscribeValueChange(List<OPCTag> tags);
      ClientResponse<bool> UnSubscribeAllValueChanges();
      bool IsConnected { get; }
   }
}

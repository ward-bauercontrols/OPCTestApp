using OPCLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCLib.Service
{
   public class TraegarClient : IOPCClient
   {
      public bool IsConnected => throw new NotImplementedException();

      public event EventHandler<TagValueChangedArgument> TagValueChanged;

      public ClientResponse<bool> CloseConnection()
      {
         throw new NotImplementedException();
      }

      public ClientResponse<IEnumerable<OPCTag>> GetAllTags()
      {
         throw new NotImplementedException();
      }

      public ClientResponse<IEnumerable<OPCTag>> GetTagValues(List<OPCTag> tags)
      {
         throw new NotImplementedException();
      }

      public ClientResponse<bool> OpenConnection(OPCConnectionString connectionString)
      {
         throw new NotImplementedException();
      }

      public ClientResponse<bool> SubscribeValueChange(OPCTag tag)
      {
         throw new NotImplementedException();
      }

      public ClientResponse<bool> UnSubscribeAllValueChanges()
      {
         throw new NotImplementedException();
      }

      public ClientResponse<bool> WriteTagValue(OPCTag writeTag)
      {
         throw new NotImplementedException();
      }
   }
}

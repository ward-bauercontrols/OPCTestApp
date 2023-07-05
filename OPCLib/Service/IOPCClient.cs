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
      event EventHandler<TagValueChanged> TagValueChanged;
      event EventHandler<OPCExceptionMsg> OPCException;
      void OpenConnection(OPCConnectionString connectionString);
      void CloseConnection();
      IEnumerable<OPCTag> GetAllTags();
      IEnumerable<Dictionary<string,object>> GetTagValues(IEnumerable<string> tags);
      void WriteTagValue(string tag, object value);
      void SubscribeValueChange(string tag);
      bool IsConnected { get; }
   }
}

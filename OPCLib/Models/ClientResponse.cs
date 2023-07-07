using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCLib.Models
{
   public class ClientResponse<T> 
   {
      public string Operation { get; set; }
      public bool IsSuccess { get; set; }
      public long TimeElapsed { get; set; }
      public string ErrorMessage { get; set; }
      public T Value { get; set; }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCLib.Models
{
   public class TraceLog
   {
      public TraceLog() 
      { 
         Timestamp = DateTime.Now;
      }
      public DateTime Timestamp { get; set; }
      public string Operation { get; set; }
      public bool IsSuccess { get; set; }
      public long TimeElapsed { get; set; }
      public string Error { get; set; }
   }
}

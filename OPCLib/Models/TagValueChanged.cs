using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCLib.Models
{
   public class TagValueChanged : EventArgs
   {
      public string Tag { get; set; }
      public object OldValue { get; set; }
      public object NewValue { get; set; }   
   }
}

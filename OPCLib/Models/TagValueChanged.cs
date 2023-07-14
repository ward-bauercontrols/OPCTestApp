using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCLib.Models
{
   public class TagValueChangedArgument : EventArgs
   {
      public string NodeId { get; set; }
      public string TagName { get; set; }
      public object NewValue { get; set; }   
   }
}

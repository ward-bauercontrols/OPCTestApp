﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCLib.Models
{
   public class OPCExceptionMsg : EventArgs
   {
      public string ErrorMessage { get; set; }
   }
}

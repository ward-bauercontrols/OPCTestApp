﻿using OpcLabs.EasyOpc.UA.AddressSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCLib.Models
{
   public class OPCTag
   {
      public string Id { get; set; }
      public string Name { get; set; }
      public string Namespace { get; set; }
      public string Type { get; set; }
      public object Value { get; set; }
      public string Display { get; set; }
   }
}

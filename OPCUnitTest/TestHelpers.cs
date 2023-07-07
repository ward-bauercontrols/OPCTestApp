using OPCLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCUnitTest
{
   internal static class TestHelpers
   {
      public static OPCConnectionString connStr = new OPCConnectionString()
      {
         URL = "opc.tcp://plydemo:49320",
      };
   }
}

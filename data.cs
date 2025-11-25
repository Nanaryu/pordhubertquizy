using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pordhubertquizy
{
    internal class data
    {
        private static data _instance;

        public static data Instance => _instance ??= new data();
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public int Round { get; set; }
    }
}

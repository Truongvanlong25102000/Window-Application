using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Store
    {
        public string idStore { get; set; }
        public Dictionary<string, string> directory { get; set; }
        public string imageStore { get; set; }
        public string name { get; set; }
        public string phone { get; set; }

        public string address { get; set; }

        public string toString() => idStore+ " - "+ imageStore+" - " + name+" "+phone ;
    }
}

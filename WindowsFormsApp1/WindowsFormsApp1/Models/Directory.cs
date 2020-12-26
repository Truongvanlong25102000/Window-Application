using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Directory
    {
        public Dictionary<string, string> idProduct { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public string id { get; set; }

        public Directory()
        {

        }
    }
}

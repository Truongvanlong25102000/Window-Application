using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Product: Store
    {
        public string idProduct { get; set; }
        public Dictionary<string,string> comment { get;set ;}
        public string description { get; set; }
        public string directoryId { get; set; }
        public Dictionary<string,string> image { get; set; }
        public string nameProduct { get; set; }
        public string nameStore { get; set; }
        public string price { get; set; }
        public string number { get; set; }
        public string nameDirectory { get; set; }
        public Product()
        {

        }
    }
}

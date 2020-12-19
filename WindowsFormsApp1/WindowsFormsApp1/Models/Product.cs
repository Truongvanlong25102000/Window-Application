using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Product
    {
        public string description { get; set; }
        public string directoryId { get; set; }
        public string idStore { get; set; }
        public Dictionary<string,string> image { get; set; }
        public string nameProduct { get; set; }
        public string nameStore { get; set; }
        public string price { get; set; }
        


        public Product(string directory,Dictionary<string,string> image, string nameProduct,string nameStore, string price)
        {
            this.directoryId = directory;
            this.image = image;
            this.nameProduct = nameProduct;
            this.nameStore = nameStore;
            this.price = price;
        }

        public Product()
        {

        }

    }
}

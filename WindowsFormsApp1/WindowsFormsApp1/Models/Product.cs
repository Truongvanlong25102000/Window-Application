using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Product
    {
        public String id { get; set; }
        public String name { get; set; }
        public String image { get; set; }
        public double price { get; set; }

        public Product(String id, String name,String image,double price)
        {
            this.id= id;
            this.name = name;
            this.id = image;
            this.price = price;
        }

        public Product()
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.View.Screen;

namespace WindowsFormsApp1.View.Item
{
    public delegate void DataSendHandler(bool isClick);
    public partial class ItemProduct : UserControl
    {
        Product product;
        public event DataSendHandler dataSend;

        public ItemProduct()
        {
            InitializeComponent();
        }

        public ItemProduct(dynamic product)
        {
            InitializeComponent();
            this.product = product;
            this.Size = new Size(100, 100);
            imageProduct.Size = new Size(100, 85);
            imageProduct.Load(this.product.image);
            nameProduct.Text= this.product.name;

            
        }

       

        private void ItemProduct_Load(object sender, EventArgs e)
        {

        }
      

        private void ViewDetailProduct(object sender, MouseEventArgs e)
        {
            this.dataSend(true);
        }

        private void nameStore_Click(object sender, EventArgs e)
        {

        }
    }
}

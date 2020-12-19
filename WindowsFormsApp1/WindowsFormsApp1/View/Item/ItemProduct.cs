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

        public ItemProduct(Product product)
        {
            InitializeComponent();
            this.product = product;
            imageProduct.Size = new Size(100, 85);
            priceProduct.Text = product.price;
            nameStore.Text = product.nameStore;
            System.Console.WriteLine("AHHAHAHAHAH" + product.price);
            System.Console.WriteLine("AHHAHAHAHAH" + product.nameStore);
            nameProduct.Text= this.product.nameProduct;
           foreach(String a in product.image.Values)
            {
                System.Console.WriteLine("AHHAHAHAHAH" + a);
                imageProduct.Load(a);
            }
           
        }

       

        private void ItemProduct_Load(object sender, EventArgs e)
        {
            this.Size = new Size(110, 160);
          //this.AutoSize = true;
            this.imageProduct.Size = new Size(110, 66);
            this.imageProduct.Location = new Point(0, 0);
            this.nameProduct.Location = new Point(0, 93);
            this.priceProduct.Location = new Point(0, 107);
            this.nameStore.Location = new Point(0, 120);
        }

        private void ViewDetailProduct(object sender, MouseEventArgs e)
        {
            this.dataSend(true);
        }

        private void nameStore_Click(object sender, EventArgs e)
        {
            this.dataSend(true);
        }

        private void ItemProduct_Click(object sender, EventArgs e)
        {
            this.dataSend(true);
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imageProduct_Click_1(object sender, EventArgs e)
        {

        }
    }
}

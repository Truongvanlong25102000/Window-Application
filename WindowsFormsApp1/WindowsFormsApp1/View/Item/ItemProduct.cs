using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.View.Screen;

namespace WindowsFormsApp1.View.Item
{
    public delegate void DataSendHandler(bool isClick,Product product);
    public partial class ItemProduct : UserControl
    {
        Product product;
        public event DataSendHandler dataSend;

        public ItemProduct()
        {
            InitializeComponent();
            this.imageProduct.Image = Properties.Resources.loadingImage;
        }

        public ItemProduct(Product product)
        {
            InitializeComponent();
            this.product = product;
            imageProduct.Size = new Size(100, 85);
            priceProduct.Text = product.price;
            nameStore.Text = product.nameStore;
            nameProduct.Text= this.product.nameProduct;
            /*foreach(string a in product.image.Values)
             {
                 System.Console.WriteLine("AHHAHAHAHAH" + a);
                 imageProduct.Load(a);
             }*/

            byte[] b = Convert.FromBase64String(product.image.Values.ElementAt(0));
            MemoryStream ms = new MemoryStream();
            ms.Write(b, 0, Convert.ToInt32(b.Length));
            imageProduct.Image= new Bitmap(ms, false);
            Console.WriteLine("DSFJDSFJDFSJDSFJDFSJ", product.imageStore);
        }

       

        private void ItemProduct_Load(object sender, EventArgs e)
        {
            this.Size = new Size(132, 163);
            //this.AutoSize = true;
            this.customgradienPanel.Size = new Size(130, 159);//159
            this.customgradienPanel.Location = new Point(0,0);
            this.imageProduct.Size = new Size(130, 86);
            this.imageProduct.Location = new Point(0, 0);
            this.panelPrice_name.Location = new Point(0,96);
            this.panelPrice_name.Size = new Size(130, nameProduct.Height);
            this.nameProduct.Location = new Point(2, 0);
            
            //priceProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
           // this.priceProduct.Location = new Point(2, 100+panelPrice_name.Height);
            this.ratingBar.Size = new Size(50,15);
            this.ratingBar.Location = new Point(4,100+panelPrice_name.Height);
            this.nameStore.Location = new Point(23,2);
            this.imgStore.Size = new Size(15, 15);
            this.imgStore.BorderRadius = 7;
            this.imgStore.Location = new Point(8, 0);
            this.pannelBottom.Location = new Point(0, 120 + ratingBar.Height);
            pannelBottom.Size = new Size(130,imgStore.Height);
            
            
        }

        private void ViewDetailProduct(object sender, MouseEventArgs e)
        {
            this.dataSend(true,product);
        }

        private void nameStore_Click(object sender, EventArgs e)
        {
            this.dataSend(true,product);
        }

        private void ItemProduct_Click(object sender, EventArgs e)
        {
            this.dataSend(true,product);
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imageProduct_Click_1(object sender, EventArgs e)
        {

        }

        private void imageProduct_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ratingBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void priceProduct_Click(object sender, EventArgs e)
        {

        }

        private void customgradienPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void priceProduct_Click_1(object sender, EventArgs e)
        {

        }

        private void pannelBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPrice_name_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgStore_Click(object sender, EventArgs e)
        {

        }
    }
}

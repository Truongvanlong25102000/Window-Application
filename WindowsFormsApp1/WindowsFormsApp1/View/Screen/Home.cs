using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interface;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.View.Item;

namespace WindowsFormsApp1.View.Screen
{
    public partial class Home : Form
    {

        public int poss = 40;
        Dictionary<string, Product> mapProduct=new Dictionary<string, Product>();

        public Home(Dictionary<string,Product> mapProduct)
        {
            InitializeComponent();
            this.mapProduct = mapProduct;
            Dictionary<string, ItemProduct> mapProduct1 = new Dictionary<string, ItemProduct>();

            foreach (Product product in mapProduct.Values)
            {
                ItemProduct item = new ItemProduct(product);
                item.dataSend += Item_dataSend;
                mapProduct1.Add(product.nameProduct, item);
            }
            PopularItem(mapProduct1);
        }

        private void Item_dataSend(bool isClick, Product product)
        {
            Form childForm = new DetailProductForm(product);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            this.Controls.Add(childForm);
            //Home.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //flowLayoutPanel.Size = new Size(969 - 234, 480);
            this.Size = new Size(816, 633);//603
            flowLayoutProduct.Size = new Size(880, 490);//830,480
            flowLayoutProduct.AutoScrollPosition = new Point(0, 0);

            

        }

        private void headerHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        public void PopularItem(Dictionary<String, ItemProduct> mapProduct)
        {
            List<ItemProduct> arrItemProduct = new List<ItemProduct>();
            foreach (ItemProduct item in mapProduct.Values)
            {
                //arrItemProduct.Add(new ItemProduct(item));
                // ItemProduct product = new ItemProduct(item);
                flowLayoutProduct.Controls.Add(item);
                item.Top = poss;
                poss = (item.Top + item.Height + 40);
            }
            flowLayoutProduct.AutoScroll = true;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

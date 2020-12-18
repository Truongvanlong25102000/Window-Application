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
using WindowsFormsApp1.View.Item;

namespace WindowsFormsApp1.View.Screen
{
    public partial class Home : Form
    {

        private int poss = 40;
       

        public Home()
        {
            InitializeComponent();
            this.Size = new Size(816, 633);//603
            //this.BackColor = Color.Red;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //flowLayoutPanel.Size = new Size(969 - 234, 480);
            flowLayoutProduct.Size = new Size(880, 490);//830,480
            flowLayoutProduct.AutoScrollPosition = new Point(0, 0);

            Dictionary<String, ItemProduct> mapProduct = new Dictionary<string, ItemProduct>();
            for (int i = 0; i < 20; i++)
            {
                ItemProduct item = new ItemProduct();
                item.dataSend += Item_dataSend;
                mapProduct.Add(i.ToString(),item);
            }
            PopularItem(mapProduct);

        }

        private void Item_dataSend(bool isClick)
        {
            //flowLayoutProduct.Visible = false;
            // flowLayoutProduct.Controls.Clear();
            // flowLayoutProduct.Controls.Add(new DetailProductForm());
            Form childForm = new DetailProductForm();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            this.Controls.Add(childForm);
           //Home.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void headerHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PopularItem(Dictionary<String, ItemProduct> mapProduct)
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
    }
}

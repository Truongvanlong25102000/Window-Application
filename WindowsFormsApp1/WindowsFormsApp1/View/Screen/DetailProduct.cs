using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View.Item;

namespace WindowsFormsApp1.View.Screen
{
    public partial class DetailProductForm : Form
    {
        Guna.UI2.WinForms.Guna2CustomGradientPanel panelUser;

        public DetailProductForm()
        {
            InitializeComponent();
        }
        public DetailProductForm(Guna.UI2.WinForms.Guna2CustomGradientPanel panelUser)
        {
            InitializeComponent();
            this.panelUser = panelUser;
           // panelUser.Visible = false;
        }

        private void DetailProduct_LoadAsync(object sender, EventArgs e)
        {
            this.Size = new Size(880,603);//880,490
            this.HeaderDetailProduct.Size = new Size(850, 340);//880,603//880 310
            this.flowLayoutParent.Size = new Size(850, 603);
            this.imgBack.Size = new Size(26,26);
            this.description.Text = "Hamburgers are traditionally made with ground beef and served with onions, tomatoes, lettuce, ketchup, and other garnishes. You can also make a hamburger with turkey or other kinds of meat — although rarely, if ever, is ham used in a hamburger. Hamburgers were originally called hamburg steak,named for the German city of Hamburg, although no actual connection between the place and the food has ever been documented.";
            this.imageProduct.Load("https://daylambanh.edu.vn/wp-content/uploads/2020/10/cong-thuc-lam-hamburger.jpg");
            this.priceProduct.Text = "0.5$";
            addComment();
        }

        private void addComment()
        {
            this.panelCenter.Size = new Size(850, 150);
            flowLayoutParent.AutoScrollPosition = new Point(0, 0);
            int top = 490;
            ItemComment item;
            for (int i = 0; i < 2; i++)
            {
                item = new ItemComment();
                flowLayoutParent.Controls.Add(item);
                item.Top = top;
                top = (item.Top + item.Height + 40);
            }
            flowLayoutParent.AutoScroll = true;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imageProduct_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void headerHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgStore_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }

        private void HeaderDetailProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flListReviews_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imageProduct_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }
    }
}

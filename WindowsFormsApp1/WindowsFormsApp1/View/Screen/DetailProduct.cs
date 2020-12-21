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
using WindowsFormsApp1.View.Item;

namespace WindowsFormsApp1.View.Screen
{
    public delegate void DataSendHandler(bool isClick);
    public partial class DetailProductForm : Form
    {
        public event DataSendHandler addCmt;
        List<String> listImage=new List<string>();
        Product product;
        public DetailProductForm()
        {
            InitializeComponent();
        }

        public DetailProductForm(Product product)
        {
            InitializeComponent();
            this.product = product;
            loadData();
        }

        async private void loadData()
        {
            this.imageProduct.Image = Properties.Resources.loadingImage;
            this.imgStore.Image= Properties.Resources.loadingImage;
            this.titleForm.Text = titleForm.Text + product.nameProduct;
            foreach (string i in product.image.Values)
            {
                listImage.Add(i);
            }
            this.imageProduct.LoadAsync(listImage[0]);
            this.imageProduct1.LoadAsync(listImage[0]);
            if (listImage.Count >= 2)
            {
                this.imageProduct2.LoadAsync(listImage[1]);
                this.imageProduct3.LoadAsync(listImage[2]);
            }

            this.nameProduct.Text = product.nameProduct;
            this.priceProduct.Text = product.price;
            this.description.Text = product.description;
            this.imgStore.LoadAsync(product.imageStore);
            this.nameStore.Text = product.nameStore;
            this.lbAddressStore.Text = product.address;
        }

        public DetailProductForm(Guna.UI2.WinForms.Guna2CustomGradientPanel panelUser)
        {
            InitializeComponent();
           // this.panelUser = panelUser;
           // panelUser.Visible = false;
        }

        private void DetailProduct_LoadAsync(object sender, EventArgs e)
        {
           
            this.Size = new Size(880,603);//880,490
            this.HeaderDetailProduct.Size = new Size(850, 340);//880,603//880 310
            this.flowLayoutParent.Size = new Size(850, 603);
            this.imgBack.Size = new Size(26,26);
            addComment();
        }

        private void addComment()
        {
            this.panelCenter.Size = new Size(500, 150);
          //  flowLayoutParent.AutoScrollPosition = new Point(0, 0);
            int top = 490;
            ItemComment item;
            int count = 0;
            foreach(String idComment in product.comment.Values)
            {
                count++;
                if (count == product.comment.Count)
                    break;
                item = new ItemComment(idComment);
                flowLayoutParent.Controls.Add(item);
                item.Top = top;
                top = (item.Top + item.Height + 40);
            }
            
            flowLayoutParent.AutoScroll = true;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            //formParent.panelUsers.Visible = true;
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

        private void lbAddressStore_Click(object sender, EventArgs e)
        {

        }

        private void imageProduct2_Click(object sender, EventArgs e)
        {
            if (listImage.Count>=2)
            {
                this.imageProduct.LoadAsync(listImage[1]);
            }
            else
            {
                this.imageProduct.Image = Properties.Resources.imagePlacehodel;
            }
        }

        private void imageProduct3_Click(object sender, EventArgs e)
        {
            if (listImage.Count >= 2)
            {
                this.imageProduct.LoadAsync(listImage[1]);
            }
            else
            {
                this.imageProduct.Image = Properties.Resources.imagePlacehodel;
            }
        }

        private void imageProduct1_Click(object sender, EventArgs e)
        {
            this.imageProduct.Image = Properties.Resources.loadingImage;
            this.imageProduct.LoadAsync(listImage[0]);
        }

        private void imgStore_Click_1(object sender, EventArgs e)
        {

        }

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void priceProduct_Click(object sender, EventArgs e)
        {

        }

        private void addCommentToSerer(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter)&&edtComment.Text.Length>0)
            {
                if (Config.Config.userName.Length > 0)
                {

                }
                else
                {
                    this.addCmt(true);
                }
            }
        }
    }
}

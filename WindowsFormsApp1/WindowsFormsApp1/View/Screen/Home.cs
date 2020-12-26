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
        public static Guna.UI2.WinForms.Guna2PictureBox avatarTopbar;
        //public static 
        public Home()
        {
            InitializeComponent();
            LoadHomeScreen();
        }

        private void LoadHomeScreen()
        {
            CheckIsLogin();
            avatarTopbar = this.avatarTopBar;
            Dictionary<string, ItemProduct> mapProduct1 = new Dictionary<string, ItemProduct>();

            for (int i = 0; i < formParent.mapProduct.Count; i++)
            {
                formParent.mapProduct.Values.ElementAt(i).idProduct = formParent.mapProduct.Keys.ElementAt(i);
                ItemProduct item = new ItemProduct(formParent.mapProduct.Values.ElementAt(i));
                item.dataSend += Item_dataSend;

                mapProduct1.Add(formParent.mapProduct.Values.ElementAt(i).nameProduct, item);
                // Console.WriteLine("ABCABCABCABC: KEY : " + mapProduct.Values.ElementAt(i).idProduct);
            }

            PopularItem(mapProduct1);
        }

        private void CheckIsLogin()
        {
            if (Config.Config.userName.Length>0)
            {

            }
        }

        private void Item_dataSend(bool isClick, Product product)
        {
            DetailProductForm childForm = new DetailProductForm(product);
            childForm.addCmt += ChildForm_addCmt;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            this.Controls.Add(childForm);
            //Home.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ChildForm_addCmt(bool isLogin)
        {
            if (isLogin)
            {

            }
            else
            {
                this.Size = new Size(969, 603);
                formParent.panelUsers.Visible = false;
                this.TopMost = true;
                LoginRegister currentChildForm = new LoginRegister();
                currentChildForm.isLogin += CurrentChildForm_isLogin;
                currentChildForm.TopLevel = false;
                currentChildForm.FormBorderStyle = FormBorderStyle.None;

                this.Controls.Add(currentChildForm);
                this.Tag = currentChildForm;
                currentChildForm.BringToFront();
                currentChildForm.Show();
            }
        }

        private void CurrentChildForm_isLogin(bool isClick)
        {
            Home.avatarTopbar.Image = Properties.Resources.loadingImage;
            Home.avatarTopbar.LoadAsync(Config.Config.user.avatar);
            formParent.imgAvatar.Image= Properties.Resources.loadingImage;
            formParent.imgAvatar.LoadAsync(Config.Config.user.avatar);
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
            if (Config.Config.userName.Length > 1)
            {
                this.avatarTopBar.LoadAsync(Config.Config.user.avatar);
            }
        }

        private async void flowLayoutProduct_Paint(object sender, PaintEventArgs e)
        {
         //   Console.WriteLine("HOMEMEMEMEMEM");
           // Config.Config.response = await Config.Config.client.GetTaskAsync("product/");
            //formParent.mapProduct = Config.Config.response.ResultAs<Dictionary<string, Product>>();
            //Console.WriteLine("HOMEMEMEMEMEM"+formParent.mapProduct.Values.ElementAt(2).price);
            //LoadHomeScreen();
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

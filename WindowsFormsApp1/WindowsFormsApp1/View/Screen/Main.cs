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
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.View.Screen;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1
{
   
    public partial class formParent : Form
    {
        
        public static Guna.UI2.WinForms.Guna2CustomGradientPanel panelUsers;
        public static Guna.UI2.WinForms.Guna2PictureBox imgAvatar;
        private bool drag=false;
        private Point startPoint = new Point(0, 0);
        public static Dictionary<string, Product> mapProduct;
        public static Home home;
        private Form currentChildForm;

        public formParent()
        {
            InitializeComponent();
            panelUsers = this.panelUser;
            imgAvatar = this.avatar;
            this.Size = new Size(969,603);
            int locationn = (panelUser.Size.Width - lbNameStore.Size.Width) / 2;
            lbNameStore.Location = new Point(locationn, lbNameStore.Location.Y);

            int loactionButtonMenu = (panelUser.Size.Width - btnDashBoard.Size.Width) / 2;
            btnDashBoard.Location = new Point(loactionButtonMenu, btnDashBoard.Location.Y);
            btnOrders.Location = new Point(loactionButtonMenu, btnOrders.Location.Y);
            btnRestaurants.Location = new Point(loactionButtonMenu, btnRestaurants.Location.Y);
            btnFinace.Location = new Point(loactionButtonMenu, btnFinace.Location.Y);
            btnLogout.Location = new Point(loactionButtonMenu, btnLogout.Location.Y);
            System.Console.WriteLine("DAY LA MAIN");


            //test
            openChildForm(new StoreManager());
            /*
              loadData();
             // user pannel
             checkIsLogin();
             */

        }

        async public void checkIsLogin()
        {
            if ((Config.Config.userName.Length > 0) && (Config.Config.user != null))
            {
                this.avatar.Image = Properties.Resources.loadingImage;
                this.avatar.LoadAsync(Config.Config.user.avatar);
                Home.avatarTopbar.Image = Properties.Resources.loadingImage;
                Home.avatarTopbar.LoadAsync(Config.Config.user.avatar);
                Console.WriteLine("HEHEHEHLLLLLOOO");
            }
        }

        private void openChildForm(Form childForm)
        {
           /* if (currentChildForm != null)
            {
                currentChildForm.Close();
            }*/
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
           
            this.guna2Panel2.Controls.Add(childForm);
            this.guna2Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public async Task updateValue()
        {
            Store store;

            foreach (Product product in mapProduct.Values)
            {

                Config.Config.response = await Config.Config.client.GetTaskAsync("store/" + product.idStore);
                store = Config.Config.response.ResultAs<Store>();
                store.idStore = product.idStore;
                product.directory = store.directory;
                product.address = store.address;
                product.imageStore = store.imageStore;
                store.name = product.nameStore;
                product.phone = store.phone;
                System.Console.WriteLine("HEHEHEH: " + product.comment.Count);
            }

        }

        public async void loadFormHome()
        {
            home = new Home();
            Form childForm = new Home();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            this.guna2Panel2.Controls.Add(childForm);
            this.guna2Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        public async void loadData()
        {
            Config.Config.response = await Config.Config.client.GetTaskAsync("product/");
            mapProduct = Config.Config.response.ResultAs<Dictionary<string, Product>>();

            await updateValue();
            loadFormHome();
        }


        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            btnDashBoard.Checked = true;
            setCheckedButton(btnDashBoard);
           // openChildForm(home);
            Home childForm = home;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            this.guna2Panel2.Controls.Add(childForm);
            this.guna2Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void lbNameStore_Click(object sender, EventArgs e)
        {
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            btnOrders.Checked = true;
            setCheckedButton(btnOrders);
            openChildForm(new LoginRegister());
        }

        private void btnRestaurants_Click(object sender, EventArgs e)
        {
            btnRestaurants.Checked = true;
            setCheckedButton(btnRestaurants);
            openChildForm(new LoginRegister());
        }

        private void btnFinace_Click(object sender, EventArgs e)
        {
            btnFinace.Checked = true;
            setCheckedButton(btnFinace);
            openChildForm(new StoreManager());
            /*
            
            StoreManager childForm = new StoreManager();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            this.guna2Panel2.Controls.Add(childForm);
            this.guna2Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

             */
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnDashBoard.Checked = true;
            btnFinace.Checked = false;
            btnOrders.Checked = false;
            btnRestaurants.Checked = false;
            this.TopMost = true;
            if (this.currentChildForm != null)
            {
                this.currentChildForm.Close();
            }
            LoginRegister currentChildForm =new LoginRegister(panelUser);
            currentChildForm.isLogin += CurrentChildForm_isLogin;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;

            this.guna2Panel2.Controls.Add(currentChildForm);
            this.guna2Panel2.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
        }

        private void CurrentChildForm_isLogin(bool isClick)
        {
            checkIsLogin();
        }

        private void setCheckedButton(Guna.UI2.WinForms.Guna2Button btn)
        {
            List<dynamic> listButton = new List<dynamic>() { btnDashBoard,btnOrders,btnRestaurants,btnFinace};
            foreach(Guna.UI2.WinForms.Guna2Button button in listButton)
            {
                if (button.Text.Equals(btn.Text)==false){
                    button.Checked = false;
                }
            }
        }

        private void formParent_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);

            }
        }

        private void formParent_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void formParent_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutProduct_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            //btnOrders.Location = new Point(loactionButtonMenu, btnOrders.Location.Y);
            btnRestaurants.Location = new Point(loactionButtonMenu, btnRestaurants.Location.Y);
            btnFinace.Location = new Point(loactionButtonMenu, btnFinace.Location.Y);
            btnLogout.Location = new Point(loactionButtonMenu, btnLogout.Location.Y);

            /*StoreManager childForm = new StoreManager();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();*/
            loadData();
        }

        public void checkIsLogin()
        {
            if ((Config.Config.userName.Length > 0) && (Config.Config.user != null))
            {
              //  this.avatar.Image = Properties.Resources.loadingImage;
               // this.avatar.LoadAsync(Config.Config.user.avatar);
            //    Home.avatarTopbar.Image = Properties.Resources.loadingImage;
                Home.avatarTopbar.LoadAsync(Config.Config.user.avatar);
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

        public void updateValue()
        {
            Store store;

            foreach (Product product in mapProduct.Values)
            {

                Config.Config.response = Config.Config.client.Get(@"store/" + product.idStore);
                store = Config.Config.response.ResultAs<Store>();
                store.idStore = product.idStore;
                product.directory = store.directory;
                product.address = store.address;
                product.imageStore = store.imageStore;
                Console.WriteLine("ADSJADSJADSJADS"+store.imageStore);
                store.name = product.nameStore;
                product.phone = store.phone;
            }

        }

        public void loadFormHome()
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


        public async Task loadData()
        {
            Config.Config.response = await Config.Config.client.GetTaskAsync("product/");
            mapProduct = Config.Config.response.ResultAs<Dictionary<string, Product>>();
            checkIsLogin();
            updateValue();
            loadFormHome();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btnDashBoard.Checked = true;
            setCheckedButton(btnDashBoard);
            // openChildForm(home);
            
                Home childForm = home;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                this.Location = new Point(100, 100);
                this.guna2Panel2.Controls.Add(childForm);
                this.guna2Panel2.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }

        private void lbNameStore_Click(object sender, EventArgs e)
        {
        }

       

        private void btnRestaurants_Click(object sender, EventArgs e)
        {
            /*    btnRestaurants.Checked = true;
                setCheckedButton(btnRestaurants);
                openChildForm(new LoginRegister());*/
            Application.Exit();
        }

        private void btnFinace_Click(object sender, EventArgs e)
        {
            //btnFinace.Checked = true;
            //setCheckedButton(btnFinace);

            // openChildForm(new StoreManager());
            if ((Config.Config.userName.Length > 0) && (Config.Config.user != null))
            {
                StoreManager childForm = new StoreManager();
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;

                this.Controls.Add(childForm);
                this.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                this.panelUser.Visible = false;
                openChildForm(new LoginRegister());
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnDashBoard.Checked = true;
            btnFinace.Checked = false;
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
            List<dynamic> listButton = new List<dynamic>() { btnDashBoard,btnRestaurants,btnFinace};
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
            if (Config.Config.user != null)
            {
                this.btnLogout.Text = "Logout";
                this.btnLogout.Image = Properties.Resources.ic_logout_white;
            }
            else
            {
                this.btnLogout.Text = "Login";
                this.btnLogout.Image=Properties.Resources.ic_login_white;
            }
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

        private void formParent_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}

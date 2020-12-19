﻿using System;
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
        
       
        private bool drag=false;
        private Point startPoint = new Point(0, 0);
        public Dictionary<string, Product> mapProduct;
        public Home home;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ODk7Qlr8hR80rttKSI41lfaYR7ywCvCBo9XEUfIH",
            BasePath = "https://foodappdesktop-default-rtdb.firebaseio.com/",
        };

        IFirebaseClient client;
        private Form currentChildForm;

        public formParent()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
            // this.flowLayoutProduct.WrapContents = false;
           
            this.Size = new Size(969,603);
            int locationn = (panelUser.Size.Width - lbNameStore.Size.Width) / 2;
            lbNameStore.Location = new Point(locationn, lbNameStore.Location.Y);

            int loactionButtonMenu = (panelUser.Size.Width - btnDashBoard.Size.Width) / 2;
            btnDashBoard.Location = new Point(loactionButtonMenu, btnDashBoard.Location.Y);
            btnOrders.Location = new Point(loactionButtonMenu, btnOrders.Location.Y);
            btnRestaurants.Location = new Point(loactionButtonMenu, btnRestaurants.Location.Y);
            btnFinace.Location = new Point(loactionButtonMenu, btnFinace.Location.Y);
            btnLogout.Location = new Point(loactionButtonMenu, btnLogout.Location.Y);
            loadData();

            
            //openChildForm(new LoginRegister(panelUser: this.panelUser));
        }


        private void openChildForm(Form childForm)
        {
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
            FirebaseResponse response = await client.GetTaskAsync("product/");
            mapProduct = response.ResultAs<Dictionary<string, Product>>();

            foreach(Product product in mapProduct.Values)
            {
                System.Console.WriteLine("HEHEHEH: "+product.directoryId);
            }
            home = new Home(mapProduct);
            Form childForm = new Home(mapProduct);
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

       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btnDashBoard.Checked = true;
            setCheckedButton(btnDashBoard);
            openChildForm(home);
            
        }

        private void lbNameStore_Click(object sender, EventArgs e)
        {
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            btnOrders.Checked = true;
            setCheckedButton(btnOrders);
        }

        private void btnRestaurants_Click(object sender, EventArgs e)
        {
            btnRestaurants.Checked = true;
            setCheckedButton(btnRestaurants);
        }

        private void btnFinace_Click(object sender, EventArgs e)
        {
            btnFinace.Checked = true;
            setCheckedButton(btnFinace);
            // openChildForm(new DetailProductForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            

            Form currentChildForm =new LoginRegister(panelUser);
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;

            this.guna2Panel2.Controls.Add(currentChildForm);
            this.guna2Panel2.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();

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
    }
}

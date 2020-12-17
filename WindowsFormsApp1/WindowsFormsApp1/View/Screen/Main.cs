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

namespace WindowsFormsApp1
{
   
    public partial class formParent : Form
    {
        private int poss =40;
        private bool drag=false;
        private Point startPoint = new Point(0, 0);
        

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ODk7Qlr8hR80rttKSI41lfaYR7ywCvCBo9XEUfIH",
            BasePath = "https://foodappdesktop-default-rtdb.firebaseio.com/",
        };

        IFirebaseClient client;
        private Form currentChildForm;

        public formParent()
        {
            //client = new FireSharp.FirebaseClient(config);
            //loadData();
            InitializeComponent();
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

            flowLayoutPanel.Size = new Size(969-234,480);
            flowLayoutProduct.Size = new Size(755, 480);//735
            flowLayoutProduct.AutoScrollPosition = new Point(0, 0);

            Dictionary<String, ItemProduct> mapProduct = new Dictionary<string, ItemProduct>();
            for(int i=0;i<20;i++){
                mapProduct.Add(i.ToString(), new ItemProduct());
            }
            PopularItem(mapProduct);
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
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private async void loadData()
        {
            FirebaseResponse response = await client.GetTaskAsync("product/");
            Dictionary<String,Product> product = response.ResultAs<Dictionary<String, Product>>();
           // PopularItem(product);
        }

        private void PopularItem(Dictionary<String,ItemProduct> mapProduct)
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
            flowLayoutProduct.VerticalScroll.Visible = false;
            flowLayoutProduct.VerticalScroll.Enabled = false;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btnDashBoard.Checked = true;
            setCheckedButton(btnDashBoard);
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
            openChildForm(new DetailProductForm());
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
           // this.FormBorderStyle = FormBorderStyle.None;
           //this.WindowState = FormWindowState.Maximized;
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

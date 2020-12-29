using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View.Screen
{
    public partial class StoreManager : Form
    {
        public StoreManager()
        {
            InitializeComponent();
        }

        dynamic currenForm;

        private void StoreManager_Load(object sender, EventArgs e)
        {
            this.Size = new Size(969, 603);
           // this.subLayoutParent.Size = new Size(969-formParent.panelUsers.Width,603);
          //  this.subLayoutParent.Location = new Point(panelUser.Width, 0);
              formParent.panelUsers.Visible =true;
            LoadForm();
        }

        private async Task LoadForm()
        {
            // this.TopMost = true;

            /*DirectoryManager currenForm = new DirectoryManager();
            currenForm.Location = new Point(0,0);
            currenForm.TopLevel =false;
            currenForm.FormBorderStyle = FormBorderStyle.None;
            this.subPanel.Controls.Add(currenForm);
             currenForm.Dock = DockStyle.Fill;
            this.Tag = currenForm;
            currenForm.BringToFront();
            currenForm.Show();
            */
            this.btnDirectory.Checked = false;
            this.btnProduct.Checked = true;
            ProductManager currenForm = new ProductManager();
            currenForm.Location = new Point(0, 0);
            currenForm.TopLevel = false;
            this.Controls.Add(currenForm);
            currenForm.FormBorderStyle = FormBorderStyle.None;
            this.subPanel.Controls.Add(currenForm);
            currenForm.Dock = DockStyle.Fill;
            this.Tag = currenForm;
            currenForm.BringToFront();
            currenForm.Show();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formParent.panelUsers.Visible = true;
            this.Controls.Clear();
            this.Close();
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            // this.TopMost = true;
            btnProduct.Checked = false;
            btnDirectory.Checked = true;
            DirectoryManager currenForm = new DirectoryManager();
            currenForm.Location = new Point(0, 0);
            currenForm.TopLevel = false;
            this.Controls.Add(currenForm);
            currenForm.FormBorderStyle = FormBorderStyle.None;
            this.subPanel.Controls.Add(currenForm);
            currenForm.Dock = DockStyle.Fill;
            this.Tag = currenForm;
            currenForm.BringToFront();
            currenForm.Show();
        }

        private void subLayoutParent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subLayoutParent_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void subPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductManager currenForm = new ProductManager();
            currenForm.TopLevel = false;
            this.Controls.Add(currenForm);
            currenForm.Show();
        }
    }
}

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

        private void StoreManager_Load(object sender, EventArgs e)
        {
            this.Size = new Size(969, 603);
            formParent.panelUsers.Visible = false;
            LoadForm();
        }

        private async Task LoadForm()
        {
            DirectoryManager childForm = new DirectoryManager();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            this.guna2Panel2.Controls.Add(childForm);
            this.guna2Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
            DirectoryManager childForm = new DirectoryManager();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            this.guna2Panel2.Controls.Add(childForm);
            this.guna2Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}

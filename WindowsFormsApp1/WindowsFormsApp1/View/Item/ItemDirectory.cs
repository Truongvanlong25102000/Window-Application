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

namespace WindowsFormsApp1.View.Item
{
    public partial class ItemDirectory : UserControl
    {
        public ItemDirectory(Directory directory)
        {
            InitializeComponent();
            this.Size = new Size(160, 90);
            this.imageDirectory.LoadAsync(directory.image);
         //   Console.WriteLine("IMAMAMAGGEEEEL ", directory.name.Values);

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

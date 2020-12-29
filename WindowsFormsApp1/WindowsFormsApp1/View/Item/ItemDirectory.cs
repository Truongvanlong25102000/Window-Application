using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.View.Item
{
    public delegate void RemoveItem(bool isRemove, Models.Directory directory, int index, ItemDirectory itemDirectory);
    public partial class ItemDirectory : UserControl
    {
        public event RemoveItem removeItem;
        public ItemDirectory(Models.Directory directory)
        {
            InitializeComponent();
            this.Size = new Size(160, 90);
            try
            {
                if (directory.image.Contains("http"))
                {
                    this.imageDirectory.LoadAsync(directory.image);
                }
                else
                {
                    byte[] b = Convert.FromBase64String(directory.image);
                    MemoryStream ms = new MemoryStream();
                    ms.Write(b, 0, Convert.ToInt32(b.Length));
                    Bitmap bitmap = new Bitmap(ms, false);
                    ms.Dispose();
                    this.imageDirectory.Image = bitmap;
                }
            }catch(Exception ex)
            {

            }
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

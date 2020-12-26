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
    public partial class RowDirectory : UserControl
    {
        Directory directory; 
        public RowDirectory()
        {
            this.Size = new Size(560,92);

        }

        public RowDirectory(int index,Models.Directory directory)
        {
            InitializeComponent();
            this.directory = directory;
            lbIndex.Text = index.ToString();
            lbName.Text = directory.name;
            countProduct.Text = directory.idProduct.Count.ToString();
            this.imgDirectory.LoadAsync(directory.image);

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RowDirectory_Load(object sender, EventArgs e)
        {
            this.lbName.Location = new Point(30 + TitleTableDictonary.textIndex.Width, 15);
            countProduct.Location = new Point(55 + TitleTableDictonary.textIndex.Width + TitleTableDictonary.name.Width, 15);
            this.imgDirectory.Location = new Point(90 + TitleTableDictonary.textIndex.Width + TitleTableDictonary.name.Width + TitleTableDictonary.count.Width, 0);
            btnSeting.Location = new Point(120+20 + +TitleTableDictonary.textIndex.Width + TitleTableDictonary.name.Width + TitleTableDictonary.count.Width+TitleTableDictonary.image.Width, 15);
            btnRemove.Location = new Point(140 + +20+TitleTableDictonary.textIndex.Width + TitleTableDictonary.name.Width + TitleTableDictonary.count.Width+TitleTableDictonary.image.Width+TitleTableDictonary.lbSetting.Width, 15);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < directory.idProduct.Count; i++)
            {
                var delete = Config.Config.client.Delete("product/" + directory.idProduct.ElementAt(i));
            }
            var delete1 = Config.Config.client.Delete("directory/" + directory.id);
            MessageBox.Show("Success");
            this.Visible = false;
        }
    }
}

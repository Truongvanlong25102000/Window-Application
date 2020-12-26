using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View.Item
{
    public partial class TitleTableDictonary : UserControl
    {
        public static Label textIndex;
        public static Label name;
        public static Label count;
        public static Label image;
        public static Label lbSetting;
        public static Label lbRemoves;

        public TitleTableDictonary()
        {
            InitializeComponent();
            this.Size = new Size(560,lbIndex.Height+30);
            this.subLayoutParent.Size=new Size(560, lbIndex.Height+30);
            this.lbIndex.Location = new Point(0, 15);
            this.lbName.Location = new Point(30 + lbIndex.Width, 15);
            this.countProduct.Location = new Point(55 + lbIndex.Width + lbName.Width, 15);
            this.Image.Location = new Point(90+lbIndex.Width+lbName.Width+countProduct.Width,15);
            this.lbUpdate.Location = new Point(120 + lbName.Width + lbIndex.Width + countProduct.Width + Image.Width, 15);
            this.lbRemove.Location = new Point(140 + lbName.Width + lbIndex.Width + countProduct.Width + Image.Width+lbUpdate.Width, 15);

            textIndex = lbIndex;
            name = lbName;
            count = countProduct;
            image = this.Image;
            lbSetting = lbUpdate;
            lbRemoves = lbRemove;

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}

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
    public partial class DetailProductForm : Form
    {
        public DetailProductForm()
        {
            InitializeComponent();
        }

        private void DetailProduct_Load(object sender, EventArgs e)
        {
            this.Size = new Size(603, 603);
            this.BackColor = Color.Red;
        }
    }
}

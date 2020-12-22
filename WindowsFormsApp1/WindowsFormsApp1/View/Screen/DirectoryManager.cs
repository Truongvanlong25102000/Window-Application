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

namespace WindowsFormsApp1.View.Screen
{
    public partial class DirectoryManager : Form
    {
        public DirectoryManager()
        {
            InitializeComponent();
        }

        private void DirectoryManager_Load(object sender, EventArgs e)
        {
            this.Size = new Size(816, 633);//603
            this.flListItemDirectory.Location = new Point(0,0);
            this.flListItemDirectory.Size = new Size(816,90);
            this.BackColor = Color.Red;

            
            addListDirectory();
        }

        private void addListDirectory()
        {
           for(int i = 0; i < 10; i++)
            {
                flListItemDirectory.Controls.Add(new ItemDirectory());
                //item.Top = poss;
                //poss = (item.Top + item.Height + 40);
            }

            this.flListItemDirectory.AutoSize = true;
            flListItemDirectory.AutoScroll = true;
            this.flListItemDirectory.AutoSizeMode= System.Windows.Forms.AutoSizeMode.GrowAndShrink; 
            
        }

        private void flListItemDirectory_Move(object sender, EventArgs e)
        {

        }
    }
}

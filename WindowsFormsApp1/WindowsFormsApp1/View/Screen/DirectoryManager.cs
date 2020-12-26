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
using WindowsFormsApp1.View.Item;

namespace WindowsFormsApp1.View.Screen
{
    public partial class DirectoryManager : Form
    {
        ItemDirectory item;
        TitleTableDictonary title;

        public DirectoryManager()
        {
            InitializeComponent();
        }

        private void DirectoryManager_Load(object sender, EventArgs e)
        {
            this.Size = new Size(816, 633);//816 633
            btnAdd.Image = Properties.Resources.ic_adds;
            btnAdd.Location = new Point(750,30);
            //this.flListItemDirectory.Location = new Point(300,30);
            this.flListItemDirectory.Size = new Size(160,633);
            flListItemDirectory.Location = new Point(30,86);
            this.searchView.Location = new Point(30,30);
            addTable();
           // addTable();
        }

        private async Task addTable()
        {
            title = new TitleTableDictonary();
            this.Controls.Add(title);
            title.Location = new Point(30,200);
            Config.Config.response = await Config.Config.client.GetTaskAsync("directory/");
            Dictionary<string, Directory> mapDirectory = Config.Config.response.ResultAs<Dictionary<string, Directory>>();
            ///Console.WriteLine("DIRRRREECCC: "+Config.Config.response.Body.ToString());
          //  Console.WriteLine("DIRRRREECCC: "+mapDirectory.Count);

            await addListDirectory(mapDirectory);
            await addRowItemDirectory(mapDirectory);
        }

        private async Task addRowItemDirectory(Dictionary<string, Directory> mapDirectory)
        {
            int top = 195 + title.Height+20;
            for(int i = 0; i < mapDirectory.Count; i++)
            {
                mapDirectory.Values.ElementAt(i).id = mapDirectory.Keys.ElementAt(i);
                Console.WriteLine("AAAAAAAAAAAAaP: "+ mapDirectory.Values.ElementAt(i).id);
                RowDirectory rowDirectory = new RowDirectory(i+1,mapDirectory.Values.ElementAt(i));
                this.Controls.Add(rowDirectory);
                rowDirectory.Location = new Point(30,top);
                Panel panel = new Panel();
                panel.Size = new Size(rowDirectory.Width-50,1);
                this.Controls.Add(panel);
                panel.BackColor = Color.DimGray;
                panel.Location = new Point(30,top+rowDirectory.Height);
                top += rowDirectory.Height+20;
            }
            this.AutoScroll = true;
        }

        private async Task addListDirectory(Dictionary<string, Directory> mapDirectory)
        {
           for(int i = 0; i < mapDirectory.Count; i++)
            {
                item = new ItemDirectory(mapDirectory.Values.ElementAt(i));
                flListItemDirectory.Controls.Add(item);
               // Panel panel = new Panel();
               // panel.Size = new Size(10,0);
              //  flListItemDirectory.Controls.Add(panel);
            }

            this.flListItemDirectory.AutoSize = true;
            flListItemDirectory.AutoScroll = true;
            this.flListItemDirectory.AutoSizeMode= System.Windows.Forms.AutoSizeMode.GrowAndShrink; 
            
        }

        private void flListItemDirectory_Move(object sender, EventArgs e)
        {

        }

        private void flListItemDirectory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchView_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}

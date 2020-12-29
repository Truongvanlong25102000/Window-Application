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
        List<ItemDirectory> listItemDirectory = new List<ItemDirectory>();
        string key1;
        int top = 0;
        ItemDirectory item;
        TitleTableDictonary title;
        Dictionary<string, Directory> mapDirectory;
        Panel panel = new Panel();
        public DirectoryManager()
        {
            InitializeComponent();
        }

        private void DirectoryManager_Load(object sender, EventArgs e)
        {
            //    this.Size = new Size(969,603);
            LoadForm();
        }

        private async Task LoadForm()
        {
            this.Width = 1800;
            this.Height = 620;

            this.Location = new Point(formParent.panelUsers.Width, 0);
            this.panel1.Size = new Size(780, flListItemDirectory.Width);
            this.panel1.Location = new Point(30, 86);
            this.panel1.Controls.Add(flListItemDirectory);
            this.panel1.AutoScroll = true;

            this.flListItemDirectory.Size = new Size(969, 633);
            flListItemDirectory.Location = new Point(0, 0);
            this.searchView.Location = new Point(30, 30);
            panel1.Controls.Add(btnAddDirectory);
            btnAddDirectory.Location = new Point(0, 86 + 30);
            btnAdd1.Visible = false;

            await addTable();
        }

        private async Task addTable()
        {

            try
            {
                Config.Config.response = await Config.Config.client.GetTaskAsync("directory/");
                if (Config.Config.response.Body.ToString().Equals("null"))
                {
                    
                }
                else
                {
                    Dictionary<string, Directory> mapDirectory = Config.Config.response.ResultAs<Dictionary<string, Directory>>();
                    Console.WriteLine("DIRRRREECCC: " + Config.Config.response.Body.ToString());
                    Console.WriteLine("DIRRRREECCC: " + mapDirectory.Count);
                    this.mapDirectory = mapDirectory;
                    await addListDirectory(mapDirectory);
                    title = new TitleTableDictonary();
                    this.panel1.Controls.Add(title);
                    title.Location = new Point(0, btnAddDirectory.Location.Y + btnAddDirectory.Height + 10);
                    panel2.Size = new Size(969, 603 - btnAddDirectory.Location.Y - btnAddDirectory.Height - 100);
                    panel1.Controls.Add(panel2);
                    panel2.Location = new Point(0, title.Location.Y + title.Height);
                    panel2.Controls.Add(tableDirectory);
                    tableDirectory.Size = new Size(400, 603 - btnAddDirectory.Location.Y - btnAddDirectory.Height - 100);

                    addRowItemDirectory(mapDirectory);
                }
            }catch(Exception ex)
            {

            }
        }

        private async Task addRowItemDirectory(Dictionary<string, Directory> mapDirectory)
        {
            int top =title.Location.Y + title.Height+20;
            for(int i = 0; i < mapDirectory.Count; i++)
            {
                Panel panel = new Panel();
                mapDirectory.Values.ElementAt(i).id = mapDirectory.Keys.ElementAt(i);
                Console.WriteLine("AAAAAAAAAAAAaP: "+ mapDirectory.Values.ElementAt(i).id);
                RowDirectory rowDirectory = new RowDirectory(i+1,mapDirectory.Values.ElementAt(i),panel);
                rowDirectory.removeDirectory += RowDirectory_removeDirectory1;
                this.tableDirectory.Controls.Add(rowDirectory);
                rowDirectory.Location = new Point(30,top);
                
                panel.Size = new Size(rowDirectory.Width-50,1);
                this.tableDirectory.Controls.Add(panel);
                panel.BackColor = Color.DimGray;
                panel.Location = new Point(30,top+rowDirectory.Height);
                top += rowDirectory.Height+20;
            }
            this.tableDirectory.AutoScroll = true;
            this.tableDirectory.WrapContents = true;
            this.top = top;
        }

        private void RowDirectory_removeDirectory1(bool isRemove, Directory directory, int index, RowDirectory rowDirectory)
        {
            if (isRemove == true)
            {
                flListItemDirectory.Controls.RemoveAt(index - 1);
            }
            else
            {
                if (directory.idProduct == null)
                {
                    flListItemDirectory.Controls.Add(new ItemDirectory(directory));
                }
                else
                {
                    flListItemDirectory.Controls.RemoveAt(index - 1);
                    flListItemDirectory.Controls.Add(new ItemDirectory(directory));
                }
            }
            flListItemDirectory.WrapContents = false;
        }

        private async Task addListDirectory(Dictionary<string, Directory> mapDirectory)
        {
           for(int i = 0; i < mapDirectory.Count; i++)
            {
                item = new ItemDirectory(mapDirectory.Values.ElementAt(i));
                flListItemDirectory.Controls.Add(item);
                listItemDirectory.Add(item);
               // Panel panel = new Panel();
               // panel.Size = new Size(10,0);
              //  flListItemDirectory.Controls.Add(panel);
            }

            this.flListItemDirectory.AutoSize = true;
          //  flListItemDirectory.AutoScroll = true;
            this.flListItemDirectory.AutoSizeMode= System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            
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

        private void flListItemDirectory_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAddDirectory_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.UtcNow;
            int year = d.Year;
            int month = d.Month;
            int day = d.Day;
            key1 = ((d.Hour * 3600000) + (d.Minute * 60000) + (d.Second * 1000) + d.Millisecond).ToString();
            if (mapDirectory!=null)
            {
                if(mapDirectory.Values.ElementAt(mapDirectory.Count - 1).image != null && mapDirectory.Count >= 1)
                {
                    Directory directory = new Directory();
                    directory.SetStateDirectory(true);
                    RowDirectory rowDirectory = new RowDirectory(mapDirectory.Count + 1, directory, panel);
                    rowDirectory.removeDirectory += RowDirectory_removeDirectory;
                    mapDirectory.Add(key1, directory);
                    this.tableDirectory.Controls.Add(rowDirectory);
                    rowDirectory.Location = new Point(30, top);
                    panel.Size = new Size(rowDirectory.Width - 50, 1);
                    this.tableDirectory.Controls.Add(panel);
                    panel.BackColor = Color.DimGray;
                    panel.Location = new Point(30, top + rowDirectory.Height);
                    top += rowDirectory.Height + 20;
                    this.tableDirectory.AutoScroll = true;
                    this.tableDirectory.ScrollControlIntoView(rowDirectory);
                }
                
            }
            else
            {
                
            }
        }

        private void RowDirectory_removeDirectory(bool isRemove, Directory directory, int index, RowDirectory rowDirectory)
        {
            if (isRemove == true)
            {
                flListItemDirectory.Controls.RemoveAt(index - 1);
            }
            else
            {
                if (directory.idProduct == null)
                {
                    flListItemDirectory.Controls.Add(new ItemDirectory(directory));
                }
                else
                {
                    flListItemDirectory.Controls.RemoveAt(index - 1);
                    flListItemDirectory.Controls.Add(new ItemDirectory(directory));
                }
            }
            flListItemDirectory.WrapContents = false;
        }

        private void tableDirectory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableDirectory_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgNoDirectory_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            btnAddDirectory_Click(sender, e);
        }

        private void DirectoryManager_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

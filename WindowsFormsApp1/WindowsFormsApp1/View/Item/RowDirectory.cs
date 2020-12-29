using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.View.Screen;

namespace WindowsFormsApp1.View.Item
{
    public delegate void RemoveDirectory(bool isRemove,Models.Directory directory,int index, RowDirectory rowDirectory);
    public partial class RowDirectory : UserControl
    {
        public event RemoveDirectory removeDirectory;
        public Models.Directory directory;
        Panel panel;
        int index = 0;
        public RowDirectory()
        {
         
           this.Size = new Size(610,92);
           //this.lbIndex.Text = "100";
           //this.lbName.Text = "ANC";
        }

        public RowDirectory(int index,Models.Directory directory, Panel panel)
        {
            InitializeComponent();
            this.index = index;
            this.panel = panel;
            this.directory = directory;
            lbIndex.Text = index.ToString();
            lbName.Text = directory.name;
            countProduct.Text = (directory.idProduct==null)?"": directory.idProduct.Count.ToString();
            if (directory.image != null)
            {
                //  this.imgDirectory.LoadAsync(directory.image);
                if (directory.image.Contains("http"))
                {
                    this.imgDirectory.LoadAsync(directory.image);
                }
                else
                {

                    byte[] b = Convert.FromBase64String(directory.image);
                    MemoryStream ms = new MemoryStream();
                    ms.Write(b,0,Convert .ToInt32(b.Length ));
                    Bitmap bitmap = new Bitmap(ms,false);
                    ms.Dispose();
                    this.imgDirectory.Image = bitmap;
                    Console.WriteLine("SDFJDSFJDSFJSDFJSDFJ" +directory.image);
                }
            }
            else
            {
                this.imgDirectory.Image = Properties.Resources.loadingImage;
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RowDirectory_Load(object sender, EventArgs e)
        {
            this.lbName.Location = new Point(20 + TitleTableDictonary.textIndex.Width, 15);
            countProduct.Location = new Point(55 + TitleTableDictonary.textIndex.Width + TitleTableDictonary.name.Width, 15);
            this.imgDirectory.Location = new Point(90 + TitleTableDictonary.textIndex.Width + TitleTableDictonary.name.Width + TitleTableDictonary.count.Width, 7);
            btnSeting.Location = new Point(120+20 + +TitleTableDictonary.textIndex.Width + TitleTableDictonary.name.Width + TitleTableDictonary.count.Width+TitleTableDictonary.image.Width, 15);
            btnRemove.Location = new Point(140 + +20+TitleTableDictonary.textIndex.Width + TitleTableDictonary.name.Width + TitleTableDictonary.count.Width+TitleTableDictonary.image.Width+TitleTableDictonary.lbSetting.Width, 15);
            //   btnPush.Location=new Point(140 + +20 + TitleTableDictonary.textIndex.Width + TitleTableDictonary.name.Width + TitleTableDictonary.count.Width + TitleTableDictonary.image.Width + TitleTableDictonary.lbSetting.Width+TitleTableDictonary.lbRemoves.Width, 15);
            btnPush.Visible = false;
            if (directory.isNew)
            {
                this.countProduct.Text = "0";
                this.btnSeting.Image = Properties.Resources.ic_push;
            }
            if (directory.idProduct == null)
            {
                this.countProduct.Text = "0";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            panel.Visible = false;
            MessageBox.Show("Success");
            this.removeDirectory(true, directory, index, this);
            var delete1 = Config.Config.client.Delete("directory/" + directory.id);

        }

        private void btnSeting_Click(object sender, EventArgs e)
        {
            try
            {
                if (directory.isNew)
                {
                    if (lbName.Text.Length > 0)
                    {
                        MemoryStream ms = new MemoryStream();
                        this.imgDirectory.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] b = ms.GetBuffer();
                        string imageToString = Convert.ToBase64String(b);
                        directory.image = imageToString;
                        directory.name = lbName.Text.Trim();
                        directory.idProduct = null;
                        directory.isNew = false;
                        btnPush.Visible = false;
                        this.btnSeting.Image = Properties.Resources.ic_update;
                        this.removeDirectory(false, directory, index, this);
                        MessageBox.Show("Please wait a moment");

                        addTofirebase();


                    }
                    else
                    {
                        MessageBox.Show("Name Directory Not Null");
                    }
                }
                else
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        this.imgDirectory.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] b = ms.GetBuffer();
                        string imageToString = Convert.ToBase64String(b);
                        directory.image = imageToString;
                        directory.name = lbName.Text.Trim();

                        directory.isNew = false;
                        // directory.id = null;
                        MessageBox.Show("Success");
                        this.removeDirectory(false, directory, index, this);
                        var set1 = Config.Config.client.Set(@"directory/" + directory.id, directory);
                        
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }catch(Exception ex)
            {

            }
        }

        async private void addTofirebase()
        {
            DateTime d = DateTime.UtcNow;
            int year = d.Year;
            int month = d.Month;
            int day = d.Day;
            string key1 = ((d.Hour * 3600000) + (d.Minute * 60000) + (d.Second * 1000) + d.Millisecond).ToString();
            
            var set1 =await Config.Config.client.SetTaskAsync(@"directory/" + key1, directory);
            MessageBox.Show("Success");
        }

        private void imgDirectory_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            try
            {
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    this.imgDirectory.Image = new Bitmap(open.FileName).GetThumbnailImage(1080, 720, null, new IntPtr());
                    // image file path  
                    // lbName.Text = open.FileName;
                    //    lbName.Enabled = true;

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Select Again");
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {

        }
    }
}

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

namespace WindowsFormsApp1.View.Item
{
    public partial class ItemProductManager : UserControl
    {
        Dictionary<string, Models.Directory> mapDirectory;
        Product product;
        public bool isNew = false;
        
        public ItemProductManager(Product product)
        {
            InitializeComponent();
            this.product = product;
            getDataDirectory();
            if (product.image != null)
            {
                //  this.imgDirectory.LoadAsync(directory.image);
                if (product.image.Values.ElementAt(0).Contains("http"))
                {
                    this.imgProduct.LoadAsync((product.image.Values.ElementAt(0)));
                    this.img1.LoadAsync((product.image.Values.ElementAt(0)));
                    if (product.image.Count == 2)
                    {
                        this.img2.LoadAsync(product.image.Values.ElementAt(1));
                    }
                    if (product.image.Count == 3)
                    {
                        this.img3.LoadAsync(product.image.Values.ElementAt(2));
                    }
                }
                else
                {

                   
                    this.imgProduct.Image = loadImageByte(product,0);
                    this.img1.Image = loadImageByte(product,0);
                    if (product.image.Count == 2)
                    {
                        this.img2.Image = loadImageByte(product, 1);
                    }
                    else if (product.image.Count == 3)
                    {
                        
                        this.img3.Image = loadImageByte(product, 2);
                    }
                }
            }
            else
            {
                this.imgProduct.Image = Properties.Resources.loadingImage;
                
            }
            this.edtCountProduct.Text = product.number.ToString();
            this.edtName.Text = product.nameProduct;
            this.edtDescription.Text = product.description;
            this.edtPrice.Text = product.price;
            /*this.dropDownDirectory.Items.AddRange(new object[] {"Item 1",
                        "Item 2",
                        "Item 3",
                        "Item 4",
                        "Item 5"});
            dropDownDirectory.SelectedIndex = 1;*/
        }

        public void setIsNew(bool isNew)
        {
            this.isNew = isNew;
        }
        public ItemProductManager()
        {
           
        }


        private void getDataDirectory()
        {
            for (int i = 0; i < formParent.mapProduct.Values.Count; i++)
            {
                this.dropDownDirectory.Items.AddRange(new object[] { formParent.mapProduct.Values.ElementAt(i).nameDirectory });
                if (formParent.mapProduct.Values.ElementAt(i).nameDirectory.Equals(product.nameDirectory))
                {
                    dropDownDirectory.SelectedIndex = i;
                    Console.WriteLine("TTTTTURURURUURURUR");
                }
            }
        }

        private Bitmap loadImageByte(Product product,int index)
        {
            
            byte[] b = Convert.FromBase64String(product.image.Values.ElementAt(index));
            MemoryStream ms = new MemoryStream();
            ms.Write(b, 0, Convert.ToInt32(b.Length));
            return new Bitmap(ms, false);
        }

        private void ItemProductManager_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Red;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            try
            {
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    this.imgProduct.Image = new Bitmap(open.FileName).GetThumbnailImage(1080, 720, null, new IntPtr());
                    this.img1.Image = new Bitmap(open.FileName).GetThumbnailImage(1080, 720, null, new IntPtr());
                    
                    // image file path  
                    // lbName.Text = open.FileName;
                    //    lbName.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select Again");
            }
        }

        private void edtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void img1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            try
            {
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    this.imgProduct.Image = new Bitmap(open.FileName).GetThumbnailImage(1080, 720, null, new IntPtr());
                    this.img1.Image = new Bitmap(open.FileName).GetThumbnailImage(1080, 720, null, new IntPtr());

                    // image file path  
                    // lbName.Text = open.FileName;
                    //    lbName.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select Again");
            }
        }

        private void img2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            try
            {
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    this.img2.Image = new Bitmap(open.FileName).GetThumbnailImage(1080, 720, null, new IntPtr());

                    // image file path  
                    // lbName.Text = open.FileName;
                    //    lbName.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select Again");
            }
        }

        private void img3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            try
            {
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    this.img3.Image = new Bitmap(open.FileName).GetThumbnailImage(1080, 720, null, new IntPtr());

                    // image file path  
                    // lbName.Text = open.FileName;
                    //    lbName.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select Again");
            }
        }

        private void dropDownDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                MessageBox.Show("Wait...");
                addToFirebase();
            }
            else
            {
                addToFirebase1();
            }
        }

        private async void addToFirebase1()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add(this.product.image.Keys.ElementAt(0), ImageToString(img1));
            if (this.product.image.Count == 2)
            {
                dictionary.Add(this.product.image.Keys.ElementAt(1), ImageToString(img2));
            }
            if (this.product.image.Count == 3)
            {
                dictionary.Add(this.product.image.Keys.ElementAt(2), ImageToString(img3));
            }
            if(this.product.image.Count == 1)
            {
                DateTime d = DateTime.UtcNow;
                int year = d.Year;
                int month = d.Month;
                int day = d.Day;
                string key1 = ((d.Hour * 3600000) + (d.Minute * 60000) + (d.Second * 1000) + d.Millisecond).ToString();

                dictionary.Add(key1+1, ImageToString(img2));
                dictionary.Add(key1+2, ImageToString(img3));
            }
            Product product = new Product()
            {
                description = edtDescription.Text.Trim(),
                nameDirectory = dropDownDirectory.Text,
                image = dictionary,
                nameProduct = edtName.Text.Trim(),
                number = edtName.Text.ToString(),
                price = edtPrice.Text.Trim(),
            };
            var set1 = await Config.Config.client.SetTaskAsync(@"product/" +this.product.idProduct, product);
            MessageBox.Show("Success");
        }

        async private void addToFirebase()
        {
            DateTime d = DateTime.UtcNow;
            int year = d.Year;
            int month = d.Month;
            int day = d.Day;
            string key1 = ((d.Hour * 3600000) + (d.Minute * 60000) + (d.Second * 1000) + d.Millisecond).ToString();

           
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add(key1+1,ImageToString(img1));
            dictionary.Add(key1+2,ImageToString(img2));
            dictionary.Add(key1+3,ImageToString(img3));
            Product product = new Product()
            {
                description = edtDescription.Text.Trim(),
                nameDirectory = dropDownDirectory.Text,
                image = dictionary,
                nameProduct=edtName.Text.Trim(),
                number= edtName.Text.ToString(),
                price=edtPrice.Text.Trim(),
        };
            var set1 = await Config.Config.client.SetTaskAsync(@"product/" + key1,product);
            MessageBox.Show("Success");
        }

        private string ImageToString(Guna.UI2.WinForms.Guna2PictureBox img)
        {
            MemoryStream ms = new MemoryStream();
            img.Image.Save(ms, ImageFormat.Jpeg);
            byte[] b = ms.GetBuffer();
            return Convert.ToBase64String(b);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeProduct();
        }

        private async void removeProduct()
        {
            MessageBox.Show(this.product.idProduct);
            var set1 = await Config.Config.client.DeleteTaskAsync(@"product/"+this.product.idProduct);
            this.Visible = false;
            MessageBox.Show("Success");
        }
    }
}

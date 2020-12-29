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
using WindowsFormsApp1.View.Item;

namespace WindowsFormsApp1.View.Screen
{
    public delegate void DataSendHandler(bool isLogin);
    public partial class DetailProductForm : Form
    {
        public event DataSendHandler addCmt;
        List<string> listImage=new List<string>();
        Product product;
        int top = 490;
        public DetailProductForm()
        {
            InitializeComponent();
        }

        public DetailProductForm(Product product)
        {
            InitializeComponent();
            this.product = product;
            loadData(product);
        }

        async private void loadData(Product product)
        {
            this.imageProduct.Image = Properties.Resources.loadingImage;
            this.imgStore.Image= Properties.Resources.loadingImage;
            this.titleForm.Text = titleForm.Text + product.nameProduct;

            loadImageByte(imageProduct,0);
            loadImageByte(imageProduct1,0);
            if (product.image.Count == 2)
            {
                loadImageByte(imageProduct2, 1);

            }

            if (product.image.Count == 3)
            {
                loadImageByte(imageProduct3, 2);

            }
            this.nameProduct.Text = product.nameProduct;
            this.priceProduct.Text = product.price;
            this.description.Text = product.description;
            

            this.nameStore.Text = product.nameStore;
            this.lbAddressStore.Text = product.address;
        }

        private void loadImageByte(Guna.UI2.WinForms.Guna2PictureBox pictureBox,int index)
        {

            if (index == -1)
            {
                
            }
            else
            {
                byte[] b = Convert.FromBase64String(product.image.Values.ElementAt(index));
                MemoryStream ms = new MemoryStream();
                ms.Write(b, 0, Convert.ToInt32(b.Length));
                pictureBox.Image = new Bitmap(ms, false);
            }
        }
        

        public DetailProductForm(Guna.UI2.WinForms.Guna2CustomGradientPanel panelUser)
        {
            InitializeComponent();
           // this.panelUser = panelUser;
           // panelUser.Visible = false;
        }

        private void DetailProduct_LoadAsync(object sender, EventArgs e)
        {
           
            this.Size = new Size(880,603);//880,490
            this.HeaderDetailProduct.Size = new Size(850, 340);//880,603//880 310
            this.flowLayoutParent.Size = new Size(850, 603);
            this.imgBack.Size = new Size(26,26);
            addComment();
        }

        private void addComment()
        {
            this.panelCenter.Size = new Size(500, 150);
          //  flowLayoutParent.AutoScrollPosition = new Point(0, 0);
           
            ItemComment item;
            int count = 0;
            if (product.comment != null)
            {
                foreach (String idComment in product.comment.Values)
                {
                    count++;
                    if (count == product.comment.Count)
                        break;
                    item = new ItemComment(idComment);
                    flowLayoutParent.Controls.Add(item);
                    item.Top = top;
                    top = (item.Top + item.Height + 40);
                }
            }
            
            flowLayoutParent.AutoScroll = true;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            //formParent.panelUsers.Visible = true;
            //this.edtComment.Clear();
            this.Close();
           
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imageProduct_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void headerHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgStore_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }

        private void HeaderDetailProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flListReviews_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imageProduct_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }

        private void lbAddressStore_Click(object sender, EventArgs e)
        {

        }

        private void imageProduct2_Click(object sender, EventArgs e)
        {
            if (listImage.Count>=2)
            {
                this.imageProduct.LoadAsync(listImage[1]);
            }
            else
            {
                this.imageProduct.Image = Properties.Resources.imagePlacehodel;
            }
        }

        private void imageProduct3_Click(object sender, EventArgs e)
        {
            if (listImage.Count >= 2)
            {
                this.imageProduct.LoadAsync(listImage[1]);
            }
            else
            {
                this.imageProduct.Image = Properties.Resources.imagePlacehodel;
            }
        }

        private void imageProduct1_Click(object sender, EventArgs e)
        {
            this.imageProduct.Image = Properties.Resources.loadingImage;
            loadImageByte(imageProduct, 0);
        }

        private void imgStore_Click_1(object sender, EventArgs e)
        {

        }

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void priceProduct_Click(object sender, EventArgs e)
        {

        }

        private async void addCommentToSerer(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter)&&edtComment.Text.Length>0)
            {
                if (Config.Config.userName.Length > 0)
                {
                    DateTime d = DateTime.UtcNow;
                    int year = d.Year;
                    int month = d.Month;
                    int day = d.Day;
                    string key1 = ((d.Hour * 3600000) + (d.Minute * 60000) + (d.Second * 1000) + d.Millisecond).ToString();
                    string time = month.ToString() + "/" + day.ToString() + "/"+year.ToString();
                    Console.WriteLine("LLLLLLLLL:{0}, KEYYYYYY:{1} ", time,key1);
                    Comment cmt = new Comment()
                    {
                        avatarCustomer = Config.Config.user.avatar,
                        content = edtComment.Text.Trim(),
                        nameCustomer = Config.Config.user.name,
                        time = time,
                    };
                    //Console.WriteLine("ALAOALOALO: ");
                    var set = Config.Config.client.Set(@"comment/"+key1,cmt);
                    var set1= Config.Config.client.Set(@"product/"+product.idProduct+"/comment/" + key1+d.Millisecond.ToString(), key1);

                    this.edtComment.Clear();
                    // this.imgBack.Focus();
                    
                    ItemComment item = new ItemComment(key1);
                    flowLayoutParent.Controls.Add(item);
                    item.Top = top;
                    top = (item.Top + item.Height + 40);
                    this.flowLayoutParent.ScrollControlIntoView(item);

                    Config.Config.response = await Config.Config.client.GetTaskAsync("product/");
                    formParent.mapProduct = Config.Config.response.ResultAs<Dictionary<string, Product>>();
                }
                else
                {
                    this.addCmt(false);
                }
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void edtComment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

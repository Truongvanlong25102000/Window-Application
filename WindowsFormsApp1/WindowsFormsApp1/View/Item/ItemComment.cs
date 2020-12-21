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
    public partial class ItemComment : UserControl
    {
        public ItemComment(string idComment)
        {
            InitializeComponent();
            loadData(idComment);
            this.Size = new Size(500,70);
            this.avatar.Size = new Size(30, 30);
            this.avatar.BorderRadius = 15;
        }

        private async Task loadData(string idComment)
        {
            Comment comment;
            try
            {
                Config.Config.response = await Config.Config.client.GetTaskAsync("comment/" +idComment);
                comment = Config.Config.response.ResultAs<Comment>();

                this.avatar.LoadAsync(comment.avatarCustomer);
                this.lbContent.Text = comment.content;
                this.timeComment.Text = comment.time;
                System.Console.WriteLine("HEHEHEH: " + idComment);
            }
            catch (Exception e) { }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ItemComment_Load(object sender, EventArgs e)
        {

        }
    }
}

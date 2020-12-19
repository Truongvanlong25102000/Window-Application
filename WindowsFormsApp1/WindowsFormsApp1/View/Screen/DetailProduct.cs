﻿using System;
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
    public partial class DetailProductForm : Form
    {
        Guna.UI2.WinForms.Guna2CustomGradientPanel panelUser;
        List<String> listImage=new List<string>();
        Product product;
        public DetailProductForm()
        {
            InitializeComponent();
        }

        public DetailProductForm(Product product)
        {
            InitializeComponent();
            this.product = product;
            loadData();
        }

        async private void loadData()
        {
            foreach(string i in product.image.Values)
            {
                listImage.Add(i);
            }
            this.imageProduct.LoadAsync(listImage[0]);
            this.imageProduct1.LoadAsync(listImage[0]);
            if (listImage.Count >= 2)
            {
                this.imageProduct2.LoadAsync(listImage[1]);
                this.imageProduct3.LoadAsync(listImage[2]);
            }

            this.nameProduct.Text = product.nameProduct;
            this.priceProduct.Text = product.price;
            this.description.Text = product.description;

        }

        public DetailProductForm(Guna.UI2.WinForms.Guna2CustomGradientPanel panelUser)
        {
            InitializeComponent();
            this.panelUser = panelUser;
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
            this.panelCenter.Size = new Size(850, 150);
            flowLayoutParent.AutoScrollPosition = new Point(0, 0);
            int top = 490;
            ItemComment item;
            for (int i = 0; i < 2; i++)
            {
                item = new ItemComment();
                flowLayoutParent.Controls.Add(item);
                item.Top = top;
                top = (item.Top + item.Height + 40);
            }
            flowLayoutParent.AutoScroll = true;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
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

        }
    }
}

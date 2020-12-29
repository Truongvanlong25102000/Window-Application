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
    public partial class ProductManager : Form
    {
        int top = 0;
        public ProductManager()
        {
            InitializeComponent();
        }

        private void searchView_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            Console.WriteLine("PRODUCT");
            this.Size = new Size(675, 603);
            this.searchView.Location = new Point(30, 30);
            this.btnAddDirectory.Location = new Point(735 - searchView.Width+btnAddDirectory.Width+30, 40);
            this.panel1.Location = new Point(30,searchView.Height+20+searchView.Location.Y);
            this.panel1.Size = new Size(675, 603-40-searchView.Height-50);
            this.flListProduct.Size = new Size(675, 603 - 40 - searchView.Height +150);
            panel1.Controls.Add(flListProduct);
            flListProduct.Location = new Point(0, 0);
            addListProduct();
        }


        private void addListProduct()
        {
            try
            {
                ItemProductManager item;
                for (int i = 0; i < formParent.mapProduct.Count; i++)
                {
                    item = new ItemProductManager(formParent.mapProduct.Values.ElementAt(i));
                    item.setIsNew(false);
                    item.Top = top;
                    top = item.Height + 30;
                    flListProduct.Controls.Add(item);
                }
                flListProduct.WrapContents = true;
                flListProduct.AutoScroll = true;
            }catch(Exception ex)
            {

            }
        }

        private void btnAddDirectory_Click(object sender, EventArgs e)
        {
            Product product = new Product() {
                address = "",
                nameProduct = "",
                price = "1$",
                number = "",
                description="",
            };
            ItemProductManager item = new ItemProductManager(product);
            item.setIsNew(true);
            item.Top = top;
            top = item.Height + 30;
            flListProduct.Controls.Add(item);
            flListProduct.ScrollControlIntoView(item);
           
        }

        private void flListProduct_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

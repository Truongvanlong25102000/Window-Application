﻿
using System;

namespace WindowsFormsApp1.View.Item
{
    partial class ItemProduct
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemProduct));
            this.nameProduct = new System.Windows.Forms.Label();
            this.priceProduct = new System.Windows.Forms.Label();
            this.nameStore = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.imageProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSize = true;
            this.nameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProduct.Location = new System.Drawing.Point(6, 190);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(109, 25);
            this.nameProduct.TabIndex = 1;
            this.nameProduct.Text = "Humberger";
            this.nameProduct.Click += new System.EventHandler(this.label1_Click);
            // 
            // priceProduct
            // 
            this.priceProduct.AutoSize = true;
            this.priceProduct.ForeColor = System.Drawing.Color.DimGray;
            this.priceProduct.Location = new System.Drawing.Point(7, 228);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Size = new System.Drawing.Size(40, 20);
            this.priceProduct.TabIndex = 2;
            this.priceProduct.Text = "0.5$";
            this.priceProduct.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // nameStore
            // 
            this.nameStore.AutoSize = true;
            this.nameStore.ForeColor = System.Drawing.Color.DimGray;
            this.nameStore.Location = new System.Drawing.Point(7, 262);
            this.nameStore.Name = "nameStore";
            this.nameStore.Size = new System.Drawing.Size(109, 20);
            this.nameStore.TabIndex = 3;
            this.nameStore.Text = "Burger Queen";
            this.nameStore.Click += new System.EventHandler(this.nameStore_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // imageProduct
            // 
            this.imageProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageProduct.FillColor = System.Drawing.Color.White;
            this.imageProduct.Image = ((System.Drawing.Image)(resources.GetObject("imageProduct.Image")));
            this.imageProduct.Location = new System.Drawing.Point(0, 0);
            this.imageProduct.Name = "imageProduct";
            this.imageProduct.ShadowDecoration.Parent = this.imageProduct;
            this.imageProduct.Size = new System.Drawing.Size(220, 175);
            this.imageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageProduct.TabIndex = 0;
            this.imageProduct.TabStop = false;
            this.imageProduct.Click += new System.EventHandler(this.imageProduct_Click);
            // 
            // ItemProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.nameStore);
            this.Controls.Add(this.priceProduct);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.imageProduct);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 20, 40);
            this.Name = "ItemProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(220, 293);
            this.Load += new System.EventHandler(this.ItemProduct_Load);
            this.Click += new System.EventHandler(this.ItemProduct_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewDetailProduct);
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.dataSend(true);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.dataSend(true);
        }

        private void imageProduct_Click(object sender, EventArgs e)
        {
            this.dataSend(true);
        }

        #endregion

        private System.Windows.Forms.Label nameProduct;
        private System.Windows.Forms.Label priceProduct;
        private System.Windows.Forms.Label nameStore;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox imageProduct;
    }
}

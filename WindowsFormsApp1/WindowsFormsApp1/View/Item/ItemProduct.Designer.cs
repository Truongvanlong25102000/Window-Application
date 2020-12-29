
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.customgradienPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pannelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.imgStore = new Guna.UI2.WinForms.Guna2PictureBox();
            this.nameStore = new System.Windows.Forms.Label();
            this.panelPrice_name = new Guna.UI2.WinForms.Guna2Panel();
            this.priceProduct = new System.Windows.Forms.Label();
            this.nameProduct = new System.Windows.Forms.Label();
            this.ratingBar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.imageProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.customgradienPanel.SuspendLayout();
            this.pannelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStore)).BeginInit();
            this.panelPrice_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // customgradienPanel
            // 
            this.customgradienPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customgradienPanel.BackColor = System.Drawing.Color.Transparent;
            this.customgradienPanel.BorderColor = System.Drawing.Color.Transparent;
            this.customgradienPanel.BorderRadius = 12;
            this.customgradienPanel.BorderThickness = 1;
            this.customgradienPanel.Controls.Add(this.pannelBottom);
            this.customgradienPanel.Controls.Add(this.panelPrice_name);
            this.customgradienPanel.Controls.Add(this.ratingBar);
            this.customgradienPanel.Controls.Add(this.imageProduct);
            this.customgradienPanel.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.customgradienPanel.Location = new System.Drawing.Point(0, 0);
            this.customgradienPanel.Margin = new System.Windows.Forms.Padding(0);
            this.customgradienPanel.Name = "customgradienPanel";
            this.customgradienPanel.ShadowDecoration.BorderRadius = 27;
            this.customgradienPanel.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.customgradienPanel.ShadowDecoration.Depth = 50;
            this.customgradienPanel.ShadowDecoration.Enabled = true;
            this.customgradienPanel.ShadowDecoration.Parent = this.customgradienPanel;
            this.customgradienPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(8, 5, 5, 8);
            this.customgradienPanel.Size = new System.Drawing.Size(246, 308);
            this.customgradienPanel.TabIndex = 0;
            this.customgradienPanel.Click += new System.EventHandler(this.ItemProduct_Click);
            this.customgradienPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.customgradienPanel_Paint);
            this.customgradienPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewDetailProduct);
            // 
            // pannelBottom
            // 
            this.pannelBottom.Controls.Add(this.imgStore);
            this.pannelBottom.Controls.Add(this.nameStore);
            this.pannelBottom.Location = new System.Drawing.Point(5, 261);
            this.pannelBottom.Name = "pannelBottom";
            this.pannelBottom.ShadowDecoration.Parent = this.pannelBottom;
            this.pannelBottom.Size = new System.Drawing.Size(238, 44);
            this.pannelBottom.TabIndex = 11;
            this.pannelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.pannelBottom_Paint);
            this.pannelBottom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewDetailProduct);
            // 
            // imgStore
            // 
            this.imgStore.BorderRadius = 12;
            this.imgStore.Image = ((System.Drawing.Image)(resources.GetObject("imgStore.Image")));
            this.imgStore.Location = new System.Drawing.Point(3, 3);
            this.imgStore.Name = "imgStore";
            this.imgStore.ShadowDecoration.Parent = this.imgStore;
            this.imgStore.Size = new System.Drawing.Size(24, 24);
            this.imgStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStore.TabIndex = 10;
            this.imgStore.TabStop = false;
            this.imgStore.Click += new System.EventHandler(this.imgStore_Click);
            this.imgStore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewDetailProduct);
            // 
            // nameStore
            // 
            this.nameStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameStore.AutoSize = true;
            this.nameStore.ForeColor = System.Drawing.Color.DimGray;
            this.nameStore.Location = new System.Drawing.Point(52, 7);
            this.nameStore.Name = "nameStore";
            this.nameStore.Size = new System.Drawing.Size(109, 20);
            this.nameStore.TabIndex = 9;
            this.nameStore.Text = "Burger Queen";
            this.nameStore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewDetailProduct);
            // 
            // panelPrice_name
            // 
            this.panelPrice_name.Controls.Add(this.priceProduct);
            this.panelPrice_name.Controls.Add(this.nameProduct);
            this.panelPrice_name.Location = new System.Drawing.Point(0, 194);
            this.panelPrice_name.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrice_name.Name = "panelPrice_name";
            this.panelPrice_name.ShadowDecoration.Parent = this.panelPrice_name;
            this.panelPrice_name.Size = new System.Drawing.Size(246, 38);
            this.panelPrice_name.TabIndex = 10;
            this.panelPrice_name.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrice_name_Paint);
            this.panelPrice_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewDetailProduct);
            // 
            // priceProduct
            // 
            this.priceProduct.AutoSize = true;
            this.priceProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.priceProduct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceProduct.ForeColor = System.Drawing.Color.Black;
            this.priceProduct.Location = new System.Drawing.Point(191, 0);
            this.priceProduct.Margin = new System.Windows.Forms.Padding(0);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Size = new System.Drawing.Size(55, 24);
            this.priceProduct.TabIndex = 8;
            this.priceProduct.Text = "0.5$";
            this.priceProduct.Click += new System.EventHandler(this.priceProduct_Click_1);
            this.priceProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewDetailProduct);
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSize = true;
            this.nameProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProduct.Location = new System.Drawing.Point(0, 0);
            this.nameProduct.Margin = new System.Windows.Forms.Padding(0);
            this.nameProduct.MaximumSize = new System.Drawing.Size(125, 25);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.nameProduct.Size = new System.Drawing.Size(113, 25);
            this.nameProduct.TabIndex = 7;
            this.nameProduct.Text = "Humberger";
            // 
            // ratingBar
            // 
            this.ratingBar.Location = new System.Drawing.Point(3, 235);
            this.ratingBar.Margin = new System.Windows.Forms.Padding(0);
            this.ratingBar.Name = "ratingBar";
            this.ratingBar.Size = new System.Drawing.Size(116, 22);
            this.ratingBar.TabIndex = 9;
            this.ratingBar.ValueChanged += new System.EventHandler(this.ratingBar_ValueChanged);
            // 
            // imageProduct
            // 
            this.imageProduct.BorderRadius = 4;
            this.imageProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageProduct.FillColor = System.Drawing.Color.White;
            this.imageProduct.Image = ((System.Drawing.Image)(resources.GetObject("imageProduct.Image")));
            this.imageProduct.Location = new System.Drawing.Point(0, 0);
            this.imageProduct.Margin = new System.Windows.Forms.Padding(0);
            this.imageProduct.Name = "imageProduct";
            this.imageProduct.ShadowDecoration.Parent = this.imageProduct;
            this.imageProduct.Size = new System.Drawing.Size(246, 175);
            this.imageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageProduct.TabIndex = 4;
            this.imageProduct.TabStop = false;
            this.imageProduct.Click += new System.EventHandler(this.imageProduct_Click_2);
            this.imageProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewDetailProduct);
            // 
            // ItemProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.customgradienPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 20, 40);
            this.Name = "ItemProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(246, 323);
            this.Load += new System.EventHandler(this.ItemProduct_Load);
            this.Click += new System.EventHandler(this.ItemProduct_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewDetailProduct);
            this.customgradienPanel.ResumeLayout(false);
            this.pannelBottom.ResumeLayout(false);
            this.pannelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStore)).EndInit();
            this.panelPrice_name.ResumeLayout(false);
            this.panelPrice_name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct)).EndInit();
            this.ResumeLayout(false);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.dataSend(true,product);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.dataSend(true,product);
        }

        private void imageProduct_Click(object sender, EventArgs e)
        {
            this.dataSend(true,product);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel customgradienPanel;
        private Guna.UI2.WinForms.Guna2PictureBox imageProduct;
        private Guna.UI2.WinForms.Guna2Panel panelPrice_name;
        private System.Windows.Forms.Label nameProduct;
        private System.Windows.Forms.Label priceProduct;
        private Guna.UI2.WinForms.Guna2RatingStar ratingBar;
        private Guna.UI2.WinForms.Guna2Panel pannelBottom;
        private Guna.UI2.WinForms.Guna2PictureBox imgStore;
        private System.Windows.Forms.Label nameStore;
    }
}

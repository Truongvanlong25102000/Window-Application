
namespace WindowsFormsApp1.View.Screen
{
    partial class DetailProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailProductForm));
            this.connerRadiusParent = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.imageProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.nameProduct = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.headerHome = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imageProduct1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.imageProduct2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.imageProduct3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.priceProduct = new System.Windows.Forms.Label();
            this.imgStore = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBuy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.headerHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStore)).BeginInit();
            this.SuspendLayout();
            // 
            // connerRadiusParent
            // 
            this.connerRadiusParent.BorderRadius = 30;
            this.connerRadiusParent.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.imageProduct;
            // 
            // imageProduct
            // 
            this.imageProduct.Image = ((System.Drawing.Image)(resources.GetObject("imageProduct.Image")));
            this.imageProduct.Location = new System.Drawing.Point(189, 188);
            this.imageProduct.Name = "imageProduct";
            this.imageProduct.ShadowDecoration.Parent = this.imageProduct;
            this.imageProduct.Size = new System.Drawing.Size(355, 351);
            this.imageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageProduct.TabIndex = 2;
            this.imageProduct.TabStop = false;
            this.imageProduct.Click += new System.EventHandler(this.imageProduct_Click);
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSize = true;
            this.nameProduct.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProduct.ForeColor = System.Drawing.Color.Black;
            this.nameProduct.Location = new System.Drawing.Point(594, 188);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(189, 36);
            this.nameProduct.TabIndex = 4;
            this.nameProduct.Text = "HumberGer";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(596, 294);
            this.description.MaximumSize = new System.Drawing.Size(500, 500);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(107, 24);
            this.description.TabIndex = 5;
            this.description.Text = "description";
            this.description.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(60, 65);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(50, 45);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(1104, 56);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(50, 45);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(1208, 56);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(50, 50);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 3;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.AutoRoundedCorners = true;
            this.guna2PictureBox4.BorderRadius = 24;
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.Location = new System.Drawing.Point(1318, 56);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.ShadowDecoration.Parent = this.guna2PictureBox4;
            this.guna2PictureBox4.Size = new System.Drawing.Size(50, 50);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 4;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.Click += new System.EventHandler(this.guna2PictureBox4_Click);
            // 
            // headerHome
            // 
            this.headerHome.BackColor = System.Drawing.Color.White;
            this.headerHome.Controls.Add(this.label1);
            this.headerHome.Controls.Add(this.guna2PictureBox4);
            this.headerHome.Controls.Add(this.guna2PictureBox3);
            this.headerHome.Controls.Add(this.guna2PictureBox2);
            this.headerHome.Controls.Add(this.guna2PictureBox1);
            this.headerHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerHome.Location = new System.Drawing.Point(0, 0);
            this.headerHome.Name = "headerHome";
            this.headerHome.ShadowDecoration.Parent = this.headerHome;
            this.headerHome.Size = new System.Drawing.Size(1187, 155);
            this.headerHome.TabIndex = 6;
            this.headerHome.Paint += new System.Windows.Forms.PaintEventHandler(this.headerHome_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(183, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categori > FastFood > Cake > Humberger";
            // 
            // imageProduct1
            // 
            this.imageProduct1.Image = ((System.Drawing.Image)(resources.GetObject("imageProduct1.Image")));
            this.imageProduct1.Location = new System.Drawing.Point(60, 188);
            this.imageProduct1.Name = "imageProduct1";
            this.imageProduct1.ShadowDecoration.Parent = this.imageProduct1;
            this.imageProduct1.Size = new System.Drawing.Size(100, 100);
            this.imageProduct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageProduct1.TabIndex = 7;
            this.imageProduct1.TabStop = false;
            this.imageProduct1.Click += new System.EventHandler(this.guna2PictureBox5_Click);
            // 
            // imageProduct2
            // 
            this.imageProduct2.Image = ((System.Drawing.Image)(resources.GetObject("imageProduct2.Image")));
            this.imageProduct2.Location = new System.Drawing.Point(60, 311);
            this.imageProduct2.Name = "imageProduct2";
            this.imageProduct2.ShadowDecoration.Parent = this.imageProduct2;
            this.imageProduct2.Size = new System.Drawing.Size(100, 100);
            this.imageProduct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageProduct2.TabIndex = 8;
            this.imageProduct2.TabStop = false;
            // 
            // imageProduct3
            // 
            this.imageProduct3.Image = ((System.Drawing.Image)(resources.GetObject("imageProduct3.Image")));
            this.imageProduct3.Location = new System.Drawing.Point(60, 439);
            this.imageProduct3.Name = "imageProduct3";
            this.imageProduct3.ShadowDecoration.Parent = this.imageProduct3;
            this.imageProduct3.Size = new System.Drawing.Size(100, 100);
            this.imageProduct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageProduct3.TabIndex = 9;
            this.imageProduct3.TabStop = false;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.imageProduct1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 10;
            this.guna2Elipse3.TargetControl = this.imageProduct2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 10;
            this.guna2Elipse4.TargetControl = this.imageProduct3;
            // 
            // priceProduct
            // 
            this.priceProduct.AutoSize = true;
            this.priceProduct.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceProduct.Location = new System.Drawing.Point(596, 245);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Size = new System.Drawing.Size(156, 31);
            this.priceProduct.TabIndex = 10;
            this.priceProduct.Text = "PriceProduct";
            // 
            // imgStore
            // 
            this.imgStore.BackColor = System.Drawing.Color.Transparent;
            this.imgStore.BorderRadius = 25;
            this.imgStore.FillColor = System.Drawing.Color.Transparent;
            this.imgStore.Image = ((System.Drawing.Image)(resources.GetObject("imgStore.Image")));
            this.imgStore.Location = new System.Drawing.Point(60, 580);
            this.imgStore.Name = "imgStore";
            this.imgStore.ShadowDecoration.BorderRadius = 10;
            this.imgStore.ShadowDecoration.Parent = this.imgStore;
            this.imgStore.Size = new System.Drawing.Size(50, 50);
            this.imgStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStore.TabIndex = 11;
            this.imgStore.TabStop = false;
            this.imgStore.Click += new System.EventHandler(this.imgStore_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BorderRadius = 10;
            this.btnBuy.CheckedState.Parent = this.btnBuy;
            this.btnBuy.CustomImages.Parent = this.btnBuy;
            this.btnBuy.FillColor = System.Drawing.Color.Silver;
            this.btnBuy.FillColor2 = System.Drawing.Color.Silver;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnBuy.HoverState.FillColor2 = System.Drawing.Color.Red;
            this.btnBuy.HoverState.Parent = this.btnBuy;
            this.btnBuy.Location = new System.Drawing.Point(602, 580);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.ShadowDecoration.Parent = this.btnBuy;
            this.btnBuy.Size = new System.Drawing.Size(235, 45);
            this.btnBuy.TabIndex = 12;
            this.btnBuy.Text = "Buy";
            this.btnBuy.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BorderRadius = 10;
            this.btnAddToCart.CheckedState.Parent = this.btnAddToCart;
            this.btnAddToCart.CustomImages.Parent = this.btnAddToCart;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.Parent = this.btnAddToCart;
            this.btnAddToCart.Location = new System.Drawing.Point(968, 188);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.ShadowDecoration.Parent = this.btnAddToCart;
            this.btnAddToCart.Size = new System.Drawing.Size(120, 45);
            this.btnAddToCart.TabIndex = 13;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Burger Queen";
            // 
            // DetailProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 1027);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.imgStore);
            this.Controls.Add(this.priceProduct);
            this.Controls.Add(this.imageProduct3);
            this.Controls.Add(this.imageProduct2);
            this.Controls.Add(this.imageProduct1);
            this.Controls.Add(this.headerHome);
            this.Controls.Add(this.description);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.imageProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailProduct";
            this.Load += new System.EventHandler(this.DetailProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.headerHome.ResumeLayout(false);
            this.headerHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse connerRadiusParent;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel headerHome;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label nameProduct;
        private Guna.UI2.WinForms.Guna2PictureBox imageProduct;
        private Guna.UI2.WinForms.Guna2PictureBox imageProduct1;
        private Guna.UI2.WinForms.Guna2PictureBox imageProduct3;
        private Guna.UI2.WinForms.Guna2PictureBox imageProduct2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceProduct;
        private Guna.UI2.WinForms.Guna2PictureBox imgStore;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddToCart;
        private Guna.UI2.WinForms.Guna2GradientButton btnBuy;
        private System.Windows.Forms.Label label2;
    }
}
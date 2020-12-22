
namespace WindowsFormsApp1.View.Screen
{
    partial class StoreManager
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
            this.connerFormParent = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelUser = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ratingBar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.subLayoutParent = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnDirectory = new Guna.UI2.WinForms.Guna2Button();
            this.btnStatistical = new Guna.UI2.WinForms.Guna2Button();
            this.avatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // connerFormParent
            // 
            this.connerFormParent.BorderRadius = 30;
            this.connerFormParent.TargetControl = this;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.subLayoutParent);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(234, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(986, 928);
            this.guna2Panel2.TabIndex = 5;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello Tony";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.Transparent;
            this.panelUser.Controls.Add(this.ratingBar);
            this.panelUser.Controls.Add(this.btnBack);
            this.panelUser.Controls.Add(this.btnDirectory);
            this.panelUser.Controls.Add(this.btnStatistical);
            this.panelUser.Controls.Add(this.avatar);
            this.panelUser.Controls.Add(this.btnOrder);
            this.panelUser.Controls.Add(this.btnProduct);
            this.panelUser.Controls.Add(this.label1);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.panelUser.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.panelUser.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.panelUser.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Margin = new System.Windows.Forms.Padding(0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Quality = 100;
            this.panelUser.ShadowDecoration.Parent = this.panelUser;
            this.panelUser.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.panelUser.Size = new System.Drawing.Size(234, 928);
            this.panelUser.TabIndex = 4;
            // 
            // ratingBar
            // 
            this.ratingBar.Location = new System.Drawing.Point(39, 307);
            this.ratingBar.Margin = new System.Windows.Forms.Padding(0);
            this.ratingBar.Name = "ratingBar";
            this.ratingBar.RatingColor = System.Drawing.Color.Yellow;
            this.ratingBar.Size = new System.Drawing.Size(162, 40);
            this.ratingBar.TabIndex = 0;
            this.ratingBar.Value = 3F;
            // 
            // subLayoutParent
            // 
            this.subLayoutParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subLayoutParent.Location = new System.Drawing.Point(0, 0);
            this.subLayoutParent.Name = "subLayoutParent";
            this.subLayoutParent.ShadowDecoration.Parent = this.subLayoutParent;
            this.subLayoutParent.Size = new System.Drawing.Size(986, 928);
            this.subLayoutParent.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnBack.BorderRadius = 33;
            this.btnBack.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = global::WindowsFormsApp1.Properties.Resources.ic_back;
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnBack.ImageSize = new System.Drawing.Size(24, 24);
            this.btnBack.Location = new System.Drawing.Point(15, 708);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(206, 69);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.TextOffset = new System.Drawing.Point(10, 0);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDirectory
            // 
            this.btnDirectory.AutoRoundedCorners = true;
            this.btnDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnDirectory.BorderRadius = 33;
            this.btnDirectory.Checked = true;
            this.btnDirectory.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDirectory.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnDirectory.CheckedState.Image = global::WindowsFormsApp1.Properties.Resources.ic_directory_green;
            this.btnDirectory.CheckedState.Parent = this.btnDirectory;
            this.btnDirectory.CustomImages.Parent = this.btnDirectory;
            this.btnDirectory.FillColor = System.Drawing.Color.Transparent;
            this.btnDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDirectory.ForeColor = System.Drawing.Color.White;
            this.btnDirectory.HoverState.Parent = this.btnDirectory;
            this.btnDirectory.Image = global::WindowsFormsApp1.Properties.Resources.ic_directory_white;
            this.btnDirectory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDirectory.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnDirectory.ImageSize = new System.Drawing.Size(24, 24);
            this.btnDirectory.Location = new System.Drawing.Point(15, 394);
            this.btnDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.PressedColor = System.Drawing.Color.White;
            this.btnDirectory.ShadowDecoration.Parent = this.btnDirectory;
            this.btnDirectory.Size = new System.Drawing.Size(206, 69);
            this.btnDirectory.TabIndex = 3;
            this.btnDirectory.Text = "Directory";
            this.btnDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDirectory.TextOffset = new System.Drawing.Point(10, 0);
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // btnStatistical
            // 
            this.btnStatistical.AutoRoundedCorners = true;
            this.btnStatistical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnStatistical.BorderRadius = 33;
            this.btnStatistical.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStatistical.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnStatistical.CheckedState.Image = global::WindowsFormsApp1.Properties.Resources.ic_Statistical_green;
            this.btnStatistical.CheckedState.Parent = this.btnStatistical;
            this.btnStatistical.CustomImages.Parent = this.btnStatistical;
            this.btnStatistical.FillColor = System.Drawing.Color.Transparent;
            this.btnStatistical.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnStatistical.ForeColor = System.Drawing.Color.White;
            this.btnStatistical.HoverState.Parent = this.btnStatistical;
            this.btnStatistical.Image = global::WindowsFormsApp1.Properties.Resources.ic_Statistical_white;
            this.btnStatistical.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistical.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnStatistical.ImageSize = new System.Drawing.Size(24, 24);
            this.btnStatistical.Location = new System.Drawing.Point(15, 630);
            this.btnStatistical.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.ShadowDecoration.Parent = this.btnStatistical;
            this.btnStatistical.Size = new System.Drawing.Size(206, 69);
            this.btnStatistical.TabIndex = 6;
            this.btnStatistical.Text = "Statistical";
            this.btnStatistical.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistical.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // avatar
            // 
            this.avatar.BorderRadius = 50;
            this.avatar.Image = global::WindowsFormsApp1.Properties.Resources.imgUser;
            this.avatar.Location = new System.Drawing.Point(39, 78);
            this.avatar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avatar.Name = "avatar";
            this.avatar.ShadowDecoration.Parent = this.avatar;
            this.avatar.Size = new System.Drawing.Size(150, 154);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // btnOrder
            // 
            this.btnOrder.AutoRoundedCorners = true;
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnOrder.BorderRadius = 33;
            this.btnOrder.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnOrder.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnOrder.CheckedState.Image = global::WindowsFormsApp1.Properties.Resources.ic_order_green;
            this.btnOrder.CheckedState.Parent = this.btnOrder;
            this.btnOrder.CustomImages.Parent = this.btnOrder;
            this.btnOrder.FillColor = System.Drawing.Color.Transparent;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.HoverState.Parent = this.btnOrder;
            this.btnOrder.Image = global::WindowsFormsApp1.Properties.Resources.ic_order_white;
            this.btnOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrder.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnOrder.ImageSize = new System.Drawing.Size(24, 24);
            this.btnOrder.Location = new System.Drawing.Point(15, 551);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.ShadowDecoration.Parent = this.btnOrder;
            this.btnOrder.Size = new System.Drawing.Size(206, 69);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Orders";
            this.btnOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrder.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnProduct
            // 
            this.btnProduct.AutoRoundedCorners = true;
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnProduct.BorderRadius = 33;
            this.btnProduct.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnProduct.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnProduct.CheckedState.Image = global::WindowsFormsApp1.Properties.Resources.ic_product_green;
            this.btnProduct.CheckedState.Parent = this.btnProduct;
            this.btnProduct.CustomImages.Parent = this.btnProduct;
            this.btnProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.HoverState.Parent = this.btnProduct;
            this.btnProduct.Image = global::WindowsFormsApp1.Properties.Resources.ic_product_white;
            this.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnProduct.ImageSize = new System.Drawing.Size(24, 24);
            this.btnProduct.Location = new System.Drawing.Point(15, 473);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.ShadowDecoration.Parent = this.btnProduct;
            this.btnProduct.Size = new System.Drawing.Size(206, 69);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "Products";
            this.btnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // StoreManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 928);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreManager";
            this.Text = "StoreManager";
            this.Load += new System.EventHandler(this.StoreManager_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse connerFormParent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelUser;
        private Guna.UI2.WinForms.Guna2RatingStar ratingBar;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnStatistical;
        private Guna.UI2.WinForms.Guna2PictureBox avatar;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnDirectory;
        private Guna.UI2.WinForms.Guna2Panel subLayoutParent;
    }
}
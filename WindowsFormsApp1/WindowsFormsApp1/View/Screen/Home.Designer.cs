
namespace WindowsFormsApp1.View.Screen
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.headerHome = new Guna.UI2.WinForms.Guna2Panel();
            this.avatarTopBar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.searchView = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.headerHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarTopBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // headerHome
            // 
            this.headerHome.BackColor = System.Drawing.Color.White;
            this.headerHome.Controls.Add(this.avatarTopBar);
            this.headerHome.Controls.Add(this.guna2PictureBox3);
            this.headerHome.Controls.Add(this.guna2PictureBox2);
            this.headerHome.Controls.Add(this.searchView);
            this.headerHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerHome.Location = new System.Drawing.Point(0, 0);
            this.headerHome.Name = "headerHome";
            this.headerHome.ShadowDecoration.Parent = this.headerHome;
            this.headerHome.Size = new System.Drawing.Size(1198, 160);
            this.headerHome.TabIndex = 3;
            this.headerHome.Paint += new System.Windows.Forms.PaintEventHandler(this.headerHome_Paint);
            // 
            // avatarTopBar
            // 
            this.avatarTopBar.AutoRoundedCorners = true;
            this.avatarTopBar.BorderRadius = 24;
            this.avatarTopBar.Image = global::WindowsFormsApp1.Properties.Resources.ic_user_green;
            this.avatarTopBar.Location = new System.Drawing.Point(1080, 56);
            this.avatarTopBar.Margin = new System.Windows.Forms.Padding(0);
            this.avatarTopBar.Name = "avatarTopBar";
            this.avatarTopBar.ShadowDecoration.Parent = this.avatarTopBar;
            this.avatarTopBar.Size = new System.Drawing.Size(50, 50);
            this.avatarTopBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarTopBar.TabIndex = 4;
            this.avatarTopBar.TabStop = false;
            this.avatarTopBar.Click += new System.EventHandler(this.guna2PictureBox4_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.ic_notification;
            this.guna2PictureBox3.Location = new System.Drawing.Point(974, 56);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(50, 50);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 3;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.Click += new System.EventHandler(this.guna2PictureBox3_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.ic_cart;
            this.guna2PictureBox2.Location = new System.Drawing.Point(865, 56);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(50, 50);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            // 
            // searchView
            // 
            this.searchView.AutoRoundedCorners = true;
            this.searchView.BackColor = System.Drawing.Color.Transparent;
            this.searchView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.searchView.BorderRadius = 27;
            this.searchView.BorderThickness = 2;
            this.searchView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchView.DefaultText = "";
            this.searchView.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchView.DisabledState.Parent = this.searchView;
            this.searchView.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(240)))), ((int)(((byte)(234)))));
            this.searchView.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.searchView.FocusedState.Parent = this.searchView;
            this.searchView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchView.ForeColor = System.Drawing.Color.Gray;
            this.searchView.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.searchView.HoverState.Parent = this.searchView;
            this.searchView.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchView.IconLeft")));
            this.searchView.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.searchView.Location = new System.Drawing.Point(47, 50);
            this.searchView.Name = "searchView";
            this.searchView.PasswordChar = '\0';
            this.searchView.PlaceholderText = "Search";
            this.searchView.SelectedText = "";
            this.searchView.ShadowDecoration.Parent = this.searchView;
            this.searchView.Size = new System.Drawing.Size(350, 56);
            this.searchView.TabIndex = 1;
            this.searchView.TextOffset = new System.Drawing.Point(10, 0);
            this.searchView.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // flowLayoutProduct
            // 
            this.flowLayoutProduct.BackColor = System.Drawing.Color.White;
            this.flowLayoutProduct.Location = new System.Drawing.Point(0, 160);
            this.flowLayoutProduct.Name = "flowLayoutProduct";
            this.flowLayoutProduct.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.flowLayoutProduct.Size = new System.Drawing.Size(1198, 712);
            this.flowLayoutProduct.TabIndex = 4;
            this.flowLayoutProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutProduct_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 872);
            this.Controls.Add(this.flowLayoutProduct);
            this.Controls.Add(this.headerHome);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.headerHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarTopBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headerHome;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox searchView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutProduct;
        private Guna.UI2.WinForms.Guna2PictureBox avatarTopBar;
    }
}
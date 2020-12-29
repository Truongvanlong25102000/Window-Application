
namespace WindowsFormsApp1
{
    partial class formParent
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNameStore = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelUser = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.btnFinace = new Guna.UI2.WinForms.Guna2Button();
            this.avatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnRestaurants = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNameStore
            // 
            this.lbNameStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNameStore.AutoSize = true;
            this.lbNameStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameStore.ForeColor = System.Drawing.Color.White;
            this.lbNameStore.Location = new System.Drawing.Point(35, 69);
            this.lbNameStore.Margin = new System.Windows.Forms.Padding(0);
            this.lbNameStore.MaximumSize = new System.Drawing.Size(150, 0);
            this.lbNameStore.Name = "lbNameStore";
            this.lbNameStore.Size = new System.Drawing.Size(125, 20);
            this.lbNameStore.TabIndex = 1;
            this.lbNameStore.Text = "Food Delivery";
            this.lbNameStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNameStore.Click += new System.EventHandler(this.lbNameStore_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.Transparent;
            this.panelUser.Controls.Add(this.btnLogout);
            this.panelUser.Controls.Add(this.btnDashBoard);
            this.panelUser.Controls.Add(this.btnFinace);
            this.panelUser.Controls.Add(this.avatar);
            this.panelUser.Controls.Add(this.btnRestaurants);
            this.panelUser.Controls.Add(this.lbNameStore);
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
            this.panelUser.TabIndex = 1;
            this.panelUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUser_Paint);
            this.panelUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formParent_MouseDown);
            this.panelUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formParent_MouseMove);
            this.panelUser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formParent_MouseUp);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoRoundedCorners = true;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnLogout.BorderRadius = 33;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::WindowsFormsApp1.Properties.Resources.ic_login_white;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnLogout.Location = new System.Drawing.Point(13, 578);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(206, 69);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Login";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.TextOffset = new System.Drawing.Point(10, 0);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.AutoRoundedCorners = true;
            this.btnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnDashBoard.BorderRadius = 33;
            this.btnDashBoard.Checked = true;
            this.btnDashBoard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashBoard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnDashBoard.CheckedState.Image = global::WindowsFormsApp1.Properties.Resources.ic_home_green;
            this.btnDashBoard.CheckedState.Parent = this.btnDashBoard;
            this.btnDashBoard.CustomImages.Parent = this.btnDashBoard;
            this.btnDashBoard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.HoverState.Parent = this.btnDashBoard;
            this.btnDashBoard.Image = global::WindowsFormsApp1.Properties.Resources.ic_home_white;
            this.btnDashBoard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashBoard.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnDashBoard.ImageSize = new System.Drawing.Size(24, 24);
            this.btnDashBoard.Location = new System.Drawing.Point(9, 425);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.PressedColor = System.Drawing.Color.White;
            this.btnDashBoard.ShadowDecoration.Parent = this.btnDashBoard;
            this.btnDashBoard.Size = new System.Drawing.Size(206, 69);
            this.btnDashBoard.TabIndex = 3;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashBoard.TextOffset = new System.Drawing.Point(4, 0);
            this.btnDashBoard.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnFinace
            // 
            this.btnFinace.AutoRoundedCorners = true;
            this.btnFinace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnFinace.BorderRadius = 33;
            this.btnFinace.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnFinace.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnFinace.CheckedState.Parent = this.btnFinace;
            this.btnFinace.CustomImages.Parent = this.btnFinace;
            this.btnFinace.FillColor = System.Drawing.Color.Transparent;
            this.btnFinace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFinace.ForeColor = System.Drawing.Color.White;
            this.btnFinace.HoverState.Parent = this.btnFinace;
            this.btnFinace.Image = global::WindowsFormsApp1.Properties.Resources.ic_manager;
            this.btnFinace.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFinace.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnFinace.Location = new System.Drawing.Point(13, 499);
            this.btnFinace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinace.Name = "btnFinace";
            this.btnFinace.ShadowDecoration.Parent = this.btnFinace;
            this.btnFinace.Size = new System.Drawing.Size(206, 69);
            this.btnFinace.TabIndex = 6;
            this.btnFinace.Text = "Manager";
            this.btnFinace.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFinace.TextOffset = new System.Drawing.Point(10, 0);
            this.btnFinace.Click += new System.EventHandler(this.btnFinace_Click);
            // 
            // avatar
            // 
            this.avatar.BorderRadius = 50;
            this.avatar.Image = global::WindowsFormsApp1.Properties.Resources.imgUser;
            this.avatar.Location = new System.Drawing.Point(39, 164);
            this.avatar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avatar.Name = "avatar";
            this.avatar.ShadowDecoration.Parent = this.avatar;
            this.avatar.Size = new System.Drawing.Size(150, 154);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // btnRestaurants
            // 
            this.btnRestaurants.AutoRoundedCorners = true;
            this.btnRestaurants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnRestaurants.BorderRadius = 33;
            this.btnRestaurants.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnRestaurants.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnRestaurants.CheckedState.Image = global::WindowsFormsApp1.Properties.Resources.ic_shutdown_green;
            this.btnRestaurants.CheckedState.Parent = this.btnRestaurants;
            this.btnRestaurants.CustomImages.Parent = this.btnRestaurants;
            this.btnRestaurants.FillColor = System.Drawing.Color.Transparent;
            this.btnRestaurants.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRestaurants.ForeColor = System.Drawing.Color.White;
            this.btnRestaurants.HoverState.Parent = this.btnRestaurants;
            this.btnRestaurants.Image = global::WindowsFormsApp1.Properties.Resources.ic_shutdown;
            this.btnRestaurants.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRestaurants.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnRestaurants.Location = new System.Drawing.Point(13, 657);
            this.btnRestaurants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRestaurants.Name = "btnRestaurants";
            this.btnRestaurants.ShadowDecoration.Parent = this.btnRestaurants;
            this.btnRestaurants.Size = new System.Drawing.Size(206, 69);
            this.btnRestaurants.TabIndex = 5;
            this.btnRestaurants.Text = "Exit";
            this.btnRestaurants.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRestaurants.TextOffset = new System.Drawing.Point(10, 0);
            this.btnRestaurants.Click += new System.EventHandler(this.btnRestaurants_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(234, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1220, 928);
            this.guna2Panel2.TabIndex = 3;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // formParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1454, 928);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.formParent_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formParent_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formParent_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formParent_MouseUp);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnDashBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNameStore;
        private Guna.UI2.WinForms.Guna2PictureBox avatar;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnFinace;
        private Guna.UI2.WinForms.Guna2Button btnRestaurants;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelUser;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}


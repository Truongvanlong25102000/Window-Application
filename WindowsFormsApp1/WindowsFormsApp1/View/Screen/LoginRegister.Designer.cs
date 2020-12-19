
namespace WindowsFormsApp1.View.Screen
{
    partial class LoginRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegister));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.img = new Guna.UI2.WinForms.Guna2PictureBox();
            this.appName = new System.Windows.Forms.Label();
            this.lbCaption = new System.Windows.Forms.Label();
            this.edtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.edtPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbForgetPassword = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExitApp = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbOr = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApp)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(722, 406);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // img
            // 
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(150, 266);
            this.img.Name = "img";
            this.img.ShadowDecoration.Parent = this.img;
            this.img.Size = new System.Drawing.Size(300, 200);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 1;
            this.img.TabStop = false;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.appName.Location = new System.Drawing.Point(659, 152);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(282, 48);
            this.appName.TabIndex = 2;
            this.appName.Text = "SUPER FOOD";
            // 
            // lbCaption
            // 
            this.lbCaption.AutoSize = true;
            this.lbCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaption.ForeColor = System.Drawing.Color.Gray;
            this.lbCaption.Location = new System.Drawing.Point(614, 200);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(365, 24);
            this.lbCaption.TabIndex = 3;
            this.lbCaption.Text = "Lorem ipsum dolor sit amet ipsum dolor";
            // 
            // edtUserName
            // 
            this.edtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.edtUserName.BorderRadius = 20;
            this.edtUserName.BorderThickness = 2;
            this.edtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtUserName.DefaultText = "";
            this.edtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.edtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.edtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtUserName.DisabledState.Parent = this.edtUserName;
            this.edtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtUserName.FocusedState.Parent = this.edtUserName;
            this.edtUserName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtUserName.ForeColor = System.Drawing.Color.Black;
            this.edtUserName.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.edtUserName.HoverState.Parent = this.edtUserName;
            this.edtUserName.IconRight = ((System.Drawing.Image)(resources.GetObject("edtUserName.IconRight")));
            this.edtUserName.IconRightOffset = new System.Drawing.Point(10, 0);
            this.edtUserName.Location = new System.Drawing.Point(602, 233);
            this.edtUserName.Name = "edtUserName";
            this.edtUserName.PasswordChar = '\0';
            this.edtUserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.edtUserName.PlaceholderText = "Username";
            this.edtUserName.SelectedText = "";
            this.edtUserName.ShadowDecoration.Parent = this.edtUserName;
            this.edtUserName.Size = new System.Drawing.Size(424, 43);
            this.edtUserName.TabIndex = 4;
            this.edtUserName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // edtPassWord
            // 
            this.edtPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.edtPassWord.BorderRadius = 20;
            this.edtPassWord.BorderThickness = 2;
            this.edtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPassWord.DefaultText = "";
            this.edtPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.edtPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.edtPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtPassWord.DisabledState.Parent = this.edtPassWord;
            this.edtPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtPassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtPassWord.FocusedState.Parent = this.edtPassWord;
            this.edtPassWord.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtPassWord.ForeColor = System.Drawing.Color.Black;
            this.edtPassWord.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.edtPassWord.HoverState.Parent = this.edtPassWord;
            this.edtPassWord.IconLeftOffset = new System.Drawing.Point(0, 10);
            this.edtPassWord.IconRight = ((System.Drawing.Image)(resources.GetObject("edtPassWord.IconRight")));
            this.edtPassWord.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.edtPassWord.IconRightOffset = new System.Drawing.Point(10, 0);
            this.edtPassWord.Location = new System.Drawing.Point(602, 295);
            this.edtPassWord.MaxLength = 100;
            this.edtPassWord.Name = "edtPassWord";
            this.edtPassWord.PasswordChar = '\0';
            this.edtPassWord.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.edtPassWord.PlaceholderText = "Password";
            this.edtPassWord.SelectedText = "";
            this.edtPassWord.ShadowDecoration.Parent = this.edtPassWord;
            this.edtPassWord.Size = new System.Drawing.Size(424, 43);
            this.edtPassWord.TabIndex = 5;
            this.edtPassWord.TextOffset = new System.Drawing.Point(10, 0);
            this.edtPassWord.IconRightClick += new System.EventHandler(this.edtPassWord_TextChanged);
            // 
            // lbForgetPassword
            // 
            this.lbForgetPassword.AutoSize = true;
            this.lbForgetPassword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgetPassword.ForeColor = System.Drawing.Color.Gray;
            this.lbForgetPassword.Location = new System.Drawing.Point(745, 364);
            this.lbForgetPassword.Name = "lbForgetPassword";
            this.lbForgetPassword.Size = new System.Drawing.Size(135, 19);
            this.lbForgetPassword.TabIndex = 6;
            this.lbForgetPassword.Text = "Forgot Password?";
            this.lbForgetPassword.Click += new System.EventHandler(this.lbForgetPassword_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(47, 49);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(49, 49);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Image = ((System.Drawing.Image)(resources.GetObject("btnExitApp.Image")));
            this.btnExitApp.Location = new System.Drawing.Point(1351, 49);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.ShadowDecoration.Parent = this.btnExitApp;
            this.btnExitApp.Size = new System.Drawing.Size(49, 49);
            this.btnExitApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExitApp.TabIndex = 8;
            this.btnExitApp.TabStop = false;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // lbOr
            // 
            this.lbOr.AutoSize = true;
            this.lbOr.ForeColor = System.Drawing.Color.Gray;
            this.lbOr.Location = new System.Drawing.Point(886, 363);
            this.lbOr.Name = "lbOr";
            this.lbOr.Size = new System.Drawing.Size(23, 20);
            this.lbOr.TabIndex = 9;
            this.lbOr.Text = "or";
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.lbRegister.Location = new System.Drawing.Point(930, 363);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(66, 19);
            this.lbRegister.TabIndex = 10;
            this.lbRegister.Text = "Register";
            this.lbRegister.Click += new System.EventHandler(this.lbRegister_Click);
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1134, 704);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.lbOr);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lbForgetPassword);
            this.Controls.Add(this.edtPassWord);
            this.Controls.Add(this.edtUserName);
            this.Controls.Add(this.lbCaption);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.img);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginRegister";
            this.Text = "LoginRegister";
            this.Load += new System.EventHandler(this.formLoginRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox img;
        private System.Windows.Forms.Label appName;
        private Guna.UI2.WinForms.Guna2TextBox edtUserName;
        private System.Windows.Forms.Label lbCaption;
        private Guna.UI2.WinForms.Guna2TextBox edtPassWord;
        private System.Windows.Forms.Label lbForgetPassword;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox btnExitApp;
        private System.Windows.Forms.Label lbOr;
        private System.Windows.Forms.Label lbRegister;
    }
}
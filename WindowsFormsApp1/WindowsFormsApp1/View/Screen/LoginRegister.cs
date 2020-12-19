using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View.Screen
{
    public partial class LoginRegister : Form
    {
        Guna.UI2.WinForms.Guna2CustomGradientPanel panelUser;
        public LoginRegister(Guna.UI2.WinForms.Guna2CustomGradientPanel panelUser)
        {
            InitializeComponent();
            this.panelUser = panelUser;
            panelUser.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelUser.Visible = true;
            this.Close();
        }

        private void formLoginRegister_Load(object sender, EventArgs e)
        {
            this.Size = new Size(969, 603);
            this.img.Size = new Size(528,329);
            this.img.Location = new Point(70,164);
            this.appName.Location = new Point(659, 152);
            this.lbCaption.Location = new Point(614, 200);
            this.edtUserName.Location = new Point(622, 233);
            this.edtUserName.Size = new Size(258, 38);
            this.edtUserName.BorderRadius = 16;

            this.edtPassWord.Location = new Point(622, 291);
            this.edtPassWord.Size = new Size(258, 38);
            this.edtPassWord.BorderRadius = 16;
            this.lbForgetPassword.Location = new Point(670,349);

           
            this.btnLogin.Location = new Point(670,379);
            this.btnLogin.Size = new Size(152, 38);

            this.lbOr.Location = new Point(761, 348);
            this.lbRegister.Location = new Point(780, 348);
            edtPassWord.UseSystemPasswordChar = true;

        }

        private void lbForgetPassword_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.panelUser.Visible = true;
            this.Close();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {

        }

        bool showPass = false;
        private void edtPassWord_TextChanged(object sender, EventArgs e)
        {
            showPass = !showPass;
            if (showPass)
            {
                edtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                edtPassWord.UseSystemPasswordChar = true;
            }
        }
    }
}

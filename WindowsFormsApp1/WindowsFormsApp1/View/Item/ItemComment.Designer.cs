
namespace WindowsFormsApp1.View.Item
{
    partial class ItemComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemComment));
            this.avatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbContent = new System.Windows.Forms.Label();
            this.timeComment = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // avatar
            // 
            this.avatar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.avatar.BorderRadius = 10;
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.Location = new System.Drawing.Point(57, 12);
            this.avatar.Name = "avatar";
            this.avatar.ShadowDecoration.Parent = this.avatar;
            this.avatar.Size = new System.Drawing.Size(50, 50);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // lbContent
            // 
            this.lbContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbContent.AutoSize = true;
            this.lbContent.Location = new System.Drawing.Point(125, 27);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(49, 20);
            this.lbContent.TabIndex = 1;
            this.lbContent.Text = "Good";
            // 
            // timeComment
            // 
            this.timeComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.timeComment.AutoSize = true;
            this.timeComment.ForeColor = System.Drawing.Color.Silver;
            this.timeComment.Location = new System.Drawing.Point(624, 27);
            this.timeComment.Name = "timeComment";
            this.timeComment.Size = new System.Drawing.Size(89, 20);
            this.timeComment.TabIndex = 2;
            this.timeComment.Text = "18/12/2020";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(805, 23);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(24, 24);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ItemComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.timeComment);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.avatar);
            this.Name = "ItemComment";
            this.Size = new System.Drawing.Size(871, 70);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox avatar;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label timeComment;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

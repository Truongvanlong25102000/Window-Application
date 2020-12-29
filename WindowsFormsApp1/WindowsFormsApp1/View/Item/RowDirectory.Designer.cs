
namespace WindowsFormsApp1.View.Item
{
    partial class RowDirectory
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
            this.countProduct = new System.Windows.Forms.Label();
            this.lbIndex = new System.Windows.Forms.Label();
            this.lbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPush = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnRemove = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSeting = new Guna.UI2.WinForms.Guna2PictureBox();
            this.imgDirectory = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDirectory)).BeginInit();
            this.SuspendLayout();
            // 
            // countProduct
            // 
            this.countProduct.AutoSize = true;
            this.countProduct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countProduct.Location = new System.Drawing.Point(307, 27);
            this.countProduct.Name = "countProduct";
            this.countProduct.Size = new System.Drawing.Size(32, 24);
            this.countProduct.TabIndex = 14;
            this.countProduct.Text = "10";
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.BackColor = System.Drawing.Color.Transparent;
            this.lbIndex.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndex.Location = new System.Drawing.Point(1, 27);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(32, 24);
            this.lbIndex.TabIndex = 12;
            this.lbIndex.Text = "01";
            // 
            // lbName
            // 
            this.lbName.BorderThickness = 0;
            this.lbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbName.DefaultText = "lbName";
            this.lbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lbName.DisabledState.Parent = this.lbName;
            this.lbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbName.FocusedState.Parent = this.lbName;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbName.HoverState.Parent = this.lbName;
            this.lbName.Location = new System.Drawing.Point(73, 24);
            this.lbName.Name = "lbName";
            this.lbName.PasswordChar = '\0';
            this.lbName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.lbName.PlaceholderText = "Name Directory";
            this.lbName.SelectedText = "";
            this.lbName.SelectionStart = 6;
            this.lbName.ShadowDecoration.Parent = this.lbName;
            this.lbName.Size = new System.Drawing.Size(200, 32);
            this.lbName.TabIndex = 18;
            // 
            // btnPush
            // 
            this.btnPush.Image = global::WindowsFormsApp1.Properties.Resources.ic_push;
            this.btnPush.Location = new System.Drawing.Point(681, 21);
            this.btnPush.Name = "btnPush";
            this.btnPush.ShadowDecoration.Parent = this.btnPush;
            this.btnPush.Size = new System.Drawing.Size(30, 30);
            this.btnPush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPush.TabIndex = 19;
            this.btnPush.TabStop = false;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::WindowsFormsApp1.Properties.Resources.ic_delete;
            this.btnRemove.Location = new System.Drawing.Point(602, 21);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(30, 30);
            this.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRemove.TabIndex = 17;
            this.btnRemove.TabStop = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSeting
            // 
            this.btnSeting.Image = global::WindowsFormsApp1.Properties.Resources.ic_update;
            this.btnSeting.Location = new System.Drawing.Point(526, 21);
            this.btnSeting.Name = "btnSeting";
            this.btnSeting.ShadowDecoration.Parent = this.btnSeting;
            this.btnSeting.Size = new System.Drawing.Size(30, 30);
            this.btnSeting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSeting.TabIndex = 16;
            this.btnSeting.TabStop = false;
            this.btnSeting.Click += new System.EventHandler(this.btnSeting_Click);
            // 
            // imgDirectory
            // 
            this.imgDirectory.BorderRadius = 12;
            this.imgDirectory.ErrorImage = global::WindowsFormsApp1.Properties.Resources.loadingImage;
            this.imgDirectory.Image = global::WindowsFormsApp1.Properties.Resources.imagePlacehodel;
            this.imgDirectory.Location = new System.Drawing.Point(392, 11);
            this.imgDirectory.Name = "imgDirectory";
            this.imgDirectory.ShadowDecoration.Parent = this.imgDirectory;
            this.imgDirectory.Size = new System.Drawing.Size(77, 55);
            this.imgDirectory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDirectory.TabIndex = 15;
            this.imgDirectory.TabStop = false;
            this.imgDirectory.Click += new System.EventHandler(this.imgDirectory_Click);
            // 
            // RowDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSeting);
            this.Controls.Add(this.imgDirectory);
            this.Controls.Add(this.countProduct);
            this.Controls.Add(this.lbIndex);
            this.Name = "RowDirectory";
            this.Size = new System.Drawing.Size(910, 79);
            this.Load += new System.EventHandler(this.RowDirectory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnPush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDirectory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox btnRemove;
        private Guna.UI2.WinForms.Guna2PictureBox btnSeting;
        private Guna.UI2.WinForms.Guna2PictureBox imgDirectory;
        private System.Windows.Forms.Label countProduct;
        private System.Windows.Forms.Label lbIndex;
        private Guna.UI2.WinForms.Guna2TextBox lbName;
        private Guna.UI2.WinForms.Guna2PictureBox btnPush;
    }
}

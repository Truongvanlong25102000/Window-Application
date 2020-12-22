
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnRemove = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSeting = new Guna.UI2.WinForms.Guna2PictureBox();
            this.imgDirectory = new Guna.UI2.WinForms.Guna2PictureBox();
            this.countProduct = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbIndex = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDirectory)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.BorderThickness = 2;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnRemove);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSeting);
            this.guna2CustomGradientPanel1.Controls.Add(this.imgDirectory);
            this.guna2CustomGradientPanel1.Controls.Add(this.countProduct);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbName);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbIndex);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(656, 85);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::WindowsFormsApp1.Properties.Resources.ic_remove;
            this.btnRemove.Location = new System.Drawing.Point(601, 25);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(30, 30);
            this.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRemove.TabIndex = 11;
            this.btnRemove.TabStop = false;
            // 
            // btnSeting
            // 
            this.btnSeting.Image = global::WindowsFormsApp1.Properties.Resources.ic_pencil;
            this.btnSeting.Location = new System.Drawing.Point(525, 25);
            this.btnSeting.Name = "btnSeting";
            this.btnSeting.ShadowDecoration.Parent = this.btnSeting;
            this.btnSeting.Size = new System.Drawing.Size(30, 30);
            this.btnSeting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSeting.TabIndex = 10;
            this.btnSeting.TabStop = false;
            // 
            // imgDirectory
            // 
            this.imgDirectory.Image = global::WindowsFormsApp1.Properties.Resources.imagePlacehodel;
            this.imgDirectory.Location = new System.Drawing.Point(391, 15);
            this.imgDirectory.Name = "imgDirectory";
            this.imgDirectory.ShadowDecoration.Parent = this.imgDirectory;
            this.imgDirectory.Size = new System.Drawing.Size(77, 55);
            this.imgDirectory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDirectory.TabIndex = 9;
            this.imgDirectory.TabStop = false;
            // 
            // countProduct
            // 
            this.countProduct.AutoSize = true;
            this.countProduct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countProduct.Location = new System.Drawing.Point(306, 31);
            this.countProduct.Name = "countProduct";
            this.countProduct.Size = new System.Drawing.Size(32, 24);
            this.countProduct.TabIndex = 8;
            this.countProduct.Text = "10";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(99, 31);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(153, 24);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "FastFood - Cake";
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndex.Location = new System.Drawing.Point(26, 31);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(32, 24);
            this.lbIndex.TabIndex = 6;
            this.lbIndex.Text = "01";
            // 
            // RowDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "RowDirectory";
            this.Size = new System.Drawing.Size(656, 85);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDirectory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox btnRemove;
        private Guna.UI2.WinForms.Guna2PictureBox btnSeting;
        private Guna.UI2.WinForms.Guna2PictureBox imgDirectory;
        private System.Windows.Forms.Label countProduct;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbIndex;
    }
}


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
            this.lbName = new System.Windows.Forms.Label();
            this.lbIndex = new System.Windows.Forms.Label();
            this.btnRemove = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSeting = new Guna.UI2.WinForms.Guna2PictureBox();
            this.imgDirectory = new Guna.UI2.WinForms.Guna2PictureBox();
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
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(100, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(153, 24);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "FastFood - Cake";
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
            // btnRemove
            // 
            this.btnRemove.Image = global::WindowsFormsApp1.Properties.Resources.ic_remove;
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
            this.btnSeting.Image = global::WindowsFormsApp1.Properties.Resources.ic_pencil;
            this.btnSeting.Location = new System.Drawing.Point(526, 21);
            this.btnSeting.Name = "btnSeting";
            this.btnSeting.ShadowDecoration.Parent = this.btnSeting;
            this.btnSeting.Size = new System.Drawing.Size(30, 30);
            this.btnSeting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSeting.TabIndex = 16;
            this.btnSeting.TabStop = false;
            // 
            // imgDirectory
            // 
            this.imgDirectory.BorderRadius = 12;
            this.imgDirectory.Image = global::WindowsFormsApp1.Properties.Resources.imagePlacehodel;
            this.imgDirectory.Location = new System.Drawing.Point(392, 11);
            this.imgDirectory.Name = "imgDirectory";
            this.imgDirectory.ShadowDecoration.Parent = this.imgDirectory;
            this.imgDirectory.Size = new System.Drawing.Size(77, 55);
            this.imgDirectory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDirectory.TabIndex = 15;
            this.imgDirectory.TabStop = false;
            // 
            // RowDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSeting);
            this.Controls.Add(this.imgDirectory);
            this.Controls.Add(this.countProduct);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbIndex);
            this.Name = "RowDirectory";
            this.Size = new System.Drawing.Size(910, 79);
            this.Load += new System.EventHandler(this.RowDirectory_Load);
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
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbIndex;
    }
}

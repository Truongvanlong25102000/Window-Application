
namespace WindowsFormsApp1.View.Item
{
    partial class ItemProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemProduct));
            this.imageProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.nameProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // imageProduct
            // 
            this.imageProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageProduct.FillColor = System.Drawing.Color.White;
            this.imageProduct.Image = ((System.Drawing.Image)(resources.GetObject("imageProduct.Image")));
            this.imageProduct.Location = new System.Drawing.Point(0, 0);
            this.imageProduct.Name = "imageProduct";
            this.imageProduct.ShadowDecoration.Parent = this.imageProduct;
            this.imageProduct.Size = new System.Drawing.Size(162, 110);
            this.imageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageProduct.TabIndex = 0;
            this.imageProduct.TabStop = false;
            this.imageProduct.Click += new System.EventHandler(this.imageProduct_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSize = true;
            this.nameProduct.Location = new System.Drawing.Point(35, 126);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(89, 20);
            this.nameProduct.TabIndex = 1;
            this.nameProduct.Text = "Humberger";
            this.nameProduct.Click += new System.EventHandler(this.label1_Click);
            // 
            // ItemProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.imageProduct);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 20, 40);
            this.Name = "ItemProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(162, 162);
            this.Load += new System.EventHandler(this.ItemProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox imageProduct;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label nameProduct;
    }
}

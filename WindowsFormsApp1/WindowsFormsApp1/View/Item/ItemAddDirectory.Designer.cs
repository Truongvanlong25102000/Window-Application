
namespace WindowsFormsApp1.View.Item
{
    partial class ItemAddDirectory
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
            this.btnRemove = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSeting = new Guna.UI2.WinForms.Guna2PictureBox();
            this.imgDirectory = new Guna.UI2.WinForms.Guna2PictureBox();
            this.countProduct = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbIndex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDirectory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::WindowsFormsApp1.Properties.Resources.ic_remove;
            this.btnRemove.Location = new System.Drawing.Point(625, 24);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(30, 30);
            this.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRemove.TabIndex = 23;
            this.btnRemove.TabStop = false;
            // 
            // btnSeting
            // 
            this.btnSeting.Image = global::WindowsFormsApp1.Properties.Resources.ic_pencil;
            this.btnSeting.Location = new System.Drawing.Point(549, 24);
            this.btnSeting.Name = "btnSeting";
            this.btnSeting.ShadowDecoration.Parent = this.btnSeting;
            this.btnSeting.Size = new System.Drawing.Size(30, 30);
            this.btnSeting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSeting.TabIndex = 22;
            this.btnSeting.TabStop = false;
            // 
            // imgDirectory
            // 
            this.imgDirectory.BorderRadius = 12;
            this.imgDirectory.Image = global::WindowsFormsApp1.Properties.Resources.imagePlacehodel;
            this.imgDirectory.Location = new System.Drawing.Point(415, 14);
            this.imgDirectory.Name = "imgDirectory";
            this.imgDirectory.ShadowDecoration.Parent = this.imgDirectory;
            this.imgDirectory.Size = new System.Drawing.Size(77, 55);
            this.imgDirectory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDirectory.TabIndex = 21;
            this.imgDirectory.TabStop = false;
            // 
            // countProduct
            // 
            this.countProduct.AutoSize = true;
            this.countProduct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countProduct.Location = new System.Drawing.Point(330, 30);
            this.countProduct.Name = "countProduct";
            this.countProduct.Size = new System.Drawing.Size(32, 24);
            this.countProduct.TabIndex = 20;
            this.countProduct.Text = "10";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(123, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(153, 24);
            this.lbName.TabIndex = 19;
            this.lbName.Text = "FastFood - Cake";
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.BackColor = System.Drawing.Color.Transparent;
            this.lbIndex.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndex.Location = new System.Drawing.Point(24, 30);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(32, 24);
            this.lbIndex.TabIndex = 18;
            this.lbIndex.Text = "01";
            // 
            // ItemAddDirectory
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
            this.Name = "ItemAddDirectory";
            this.Size = new System.Drawing.Size(910, 79);
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

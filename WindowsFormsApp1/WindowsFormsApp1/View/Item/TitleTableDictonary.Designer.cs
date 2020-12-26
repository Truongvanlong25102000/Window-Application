
namespace WindowsFormsApp1.View.Item
{
    partial class TitleTableDictonary
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
            this.lbName = new System.Windows.Forms.Label();
            this.subLayoutParent = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Image = new System.Windows.Forms.Label();
            this.lbRemove = new System.Windows.Forms.Label();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.countProduct = new System.Windows.Forms.Label();
            this.lbIndex = new System.Windows.Forms.Label();
            this.subLayoutParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(125, 15);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(149, 24);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Name Directory";
            // 
            // subLayoutParent
            // 
            this.subLayoutParent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subLayoutParent.Controls.Add(this.Image);
            this.subLayoutParent.Controls.Add(this.lbRemove);
            this.subLayoutParent.Controls.Add(this.lbUpdate);
            this.subLayoutParent.Controls.Add(this.countProduct);
            this.subLayoutParent.Controls.Add(this.lbName);
            this.subLayoutParent.Controls.Add(this.lbIndex);
            this.subLayoutParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subLayoutParent.Location = new System.Drawing.Point(0, 0);
            this.subLayoutParent.Margin = new System.Windows.Forms.Padding(0);
            this.subLayoutParent.Name = "subLayoutParent";
            this.subLayoutParent.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.subLayoutParent.ShadowDecoration.Parent = this.subLayoutParent;
            this.subLayoutParent.Size = new System.Drawing.Size(910, 79);
            this.subLayoutParent.TabIndex = 1;
            this.subLayoutParent.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // Image
            // 
            this.Image.AutoSize = true;
            this.Image.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Image.Location = new System.Drawing.Point(535, 18);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(67, 24);
            this.Image.TabIndex = 11;
            this.Image.Text = "Image";
            // 
            // lbRemove
            // 
            this.lbRemove.AutoSize = true;
            this.lbRemove.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemove.Location = new System.Drawing.Point(813, 15);
            this.lbRemove.Name = "lbRemove";
            this.lbRemove.Size = new System.Drawing.Size(82, 24);
            this.lbRemove.TabIndex = 10;
            this.lbRemove.Text = "Remove";
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdate.Location = new System.Drawing.Point(696, 15);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(74, 24);
            this.lbUpdate.TabIndex = 9;
            this.lbUpdate.Text = "Update";
            // 
            // countProduct
            // 
            this.countProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.countProduct.AutoSize = true;
            this.countProduct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countProduct.Location = new System.Drawing.Point(311, 15);
            this.countProduct.Margin = new System.Windows.Forms.Padding(0);
            this.countProduct.Name = "countProduct";
            this.countProduct.Size = new System.Drawing.Size(135, 24);
            this.countProduct.TabIndex = 8;
            this.countProduct.Text = "Count Product";
            // 
            // lbIndex
            // 
            this.lbIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbIndex.AutoSize = true;
            this.lbIndex.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndex.Location = new System.Drawing.Point(33, 15);
            this.lbIndex.Margin = new System.Windows.Forms.Padding(0);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(60, 24);
            this.lbIndex.TabIndex = 6;
            this.lbIndex.Text = "Index";
            // 
            // TitleTableDictonary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.subLayoutParent);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "TitleTableDictonary";
            this.Size = new System.Drawing.Size(910, 79);
            this.subLayoutParent.ResumeLayout(false);
            this.subLayoutParent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel subLayoutParent;
        private System.Windows.Forms.Label countProduct;
        private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.Label lbRemove;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label Image;
    }
}

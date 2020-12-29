
namespace WindowsFormsApp1.View.Item
{
    partial class ItemProductManager
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
            this.imgProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.edtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.edtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.edtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.dropDownDirectory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.edtCountProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnRemove = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.img1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.img2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.img3 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            this.SuspendLayout();
            // 
            // imgProduct
            // 
            this.imgProduct.BorderRadius = 12;
            this.imgProduct.Image = global::WindowsFormsApp1.Properties.Resources.loadingImage;
            this.imgProduct.Location = new System.Drawing.Point(124, 17);
            this.imgProduct.Name = "imgProduct";
            this.imgProduct.ShadowDecoration.Parent = this.imgProduct;
            this.imgProduct.Size = new System.Drawing.Size(178, 146);
            this.imgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProduct.TabIndex = 0;
            this.imgProduct.TabStop = false;
            this.imgProduct.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // edtName
            // 
            this.edtName.BorderRadius = 12;
            this.edtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtName.DefaultText = "Name Product";
            this.edtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.edtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.edtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtName.DisabledState.Parent = this.edtName;
            this.edtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtName.FocusedState.Parent = this.edtName;
            this.edtName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtName.ForeColor = System.Drawing.Color.Black;
            this.edtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtName.HoverState.Parent = this.edtName;
            this.edtName.Location = new System.Drawing.Point(329, 17);
            this.edtName.Name = "edtName";
            this.edtName.PasswordChar = '\0';
            this.edtName.PlaceholderText = "Name Product";
            this.edtName.SelectedText = "";
            this.edtName.SelectionStart = 12;
            this.edtName.ShadowDecoration.Parent = this.edtName;
            this.edtName.Size = new System.Drawing.Size(220, 42);
            this.edtName.TabIndex = 1;
            this.edtName.TextChanged += new System.EventHandler(this.edtName_TextChanged);
            // 
            // edtPrice
            // 
            this.edtPrice.BorderRadius = 12;
            this.edtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPrice.DefaultText = "Price";
            this.edtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.edtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.edtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtPrice.DisabledState.Parent = this.edtPrice;
            this.edtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtPrice.FocusedState.Parent = this.edtPrice;
            this.edtPrice.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtPrice.ForeColor = System.Drawing.Color.Black;
            this.edtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtPrice.HoverState.Parent = this.edtPrice;
            this.edtPrice.Location = new System.Drawing.Point(329, 71);
            this.edtPrice.Name = "edtPrice";
            this.edtPrice.PasswordChar = '\0';
            this.edtPrice.PlaceholderText = "Price Product";
            this.edtPrice.SelectedText = "";
            this.edtPrice.SelectionStart = 5;
            this.edtPrice.ShadowDecoration.Parent = this.edtPrice;
            this.edtPrice.Size = new System.Drawing.Size(220, 40);
            this.edtPrice.TabIndex = 2;
            // 
            // edtDescription
            // 
            this.edtDescription.AutoScroll = true;
            this.edtDescription.BorderRadius = 12;
            this.edtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtDescription.DefaultText = "Description";
            this.edtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.edtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.edtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtDescription.DisabledState.Parent = this.edtDescription;
            this.edtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtDescription.FocusedState.Parent = this.edtDescription;
            this.edtDescription.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtDescription.ForeColor = System.Drawing.Color.Black;
            this.edtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtDescription.HoverState.Parent = this.edtDescription;
            this.edtDescription.Location = new System.Drawing.Point(329, 123);
            this.edtDescription.Multiline = true;
            this.edtDescription.Name = "edtDescription";
            this.edtDescription.PasswordChar = '\0';
            this.edtDescription.PlaceholderText = "Description";
            this.edtDescription.SelectedText = "";
            this.edtDescription.SelectionStart = 11;
            this.edtDescription.ShadowDecoration.Parent = this.edtDescription;
            this.edtDescription.Size = new System.Drawing.Size(220, 171);
            this.edtDescription.TabIndex = 3;
            // 
            // dropDownDirectory
            // 
            this.dropDownDirectory.BackColor = System.Drawing.Color.Transparent;
            this.dropDownDirectory.BorderRadius = 12;
            this.dropDownDirectory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropDownDirectory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownDirectory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dropDownDirectory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dropDownDirectory.FocusedState.Parent = this.dropDownDirectory;
            this.dropDownDirectory.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dropDownDirectory.ForeColor = System.Drawing.Color.Black;
            this.dropDownDirectory.HoverState.Parent = this.dropDownDirectory;
            this.dropDownDirectory.ItemHeight = 30;
            this.dropDownDirectory.ItemsAppearance.Parent = this.dropDownDirectory;
            this.dropDownDirectory.Location = new System.Drawing.Point(124, 239);
            this.dropDownDirectory.Name = "dropDownDirectory";
            this.dropDownDirectory.ShadowDecoration.Parent = this.dropDownDirectory;
            this.dropDownDirectory.Size = new System.Drawing.Size(178, 36);
            this.dropDownDirectory.TabIndex = 5;
            this.dropDownDirectory.SelectedIndexChanged += new System.EventHandler(this.dropDownDirectory_SelectedIndexChanged);
            // 
            // edtCountProduct
            // 
            this.edtCountProduct.BorderRadius = 12;
            this.edtCountProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtCountProduct.DefaultText = "";
            this.edtCountProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.edtCountProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.edtCountProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtCountProduct.DisabledState.Parent = this.edtCountProduct;
            this.edtCountProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtCountProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtCountProduct.FocusedState.Parent = this.edtCountProduct;
            this.edtCountProduct.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtCountProduct.ForeColor = System.Drawing.Color.Black;
            this.edtCountProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtCountProduct.HoverState.Parent = this.edtCountProduct;
            this.edtCountProduct.Location = new System.Drawing.Point(124, 183);
            this.edtCountProduct.Name = "edtCountProduct";
            this.edtCountProduct.PasswordChar = '\0';
            this.edtCountProduct.PlaceholderText = "Number Of Product";
            this.edtCountProduct.SelectedText = "";
            this.edtCountProduct.ShadowDecoration.Parent = this.edtCountProduct;
            this.edtCountProduct.Size = new System.Drawing.Size(178, 40);
            this.edtCountProduct.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::WindowsFormsApp1.Properties.Resources.ic_update;
            this.btnUpdate.Location = new System.Drawing.Point(767, 17);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(30, 30);
            this.btnUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::WindowsFormsApp1.Properties.Resources.ic_delete;
            this.btnRemove.Location = new System.Drawing.Point(839, 17);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(30, 30);
            this.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRemove.TabIndex = 8;
            this.btnRemove.TabStop = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
            this.guna2Elipse1.TargetControl = this;
            // 
            // img1
            // 
            this.img1.BorderRadius = 12;
            this.img1.Image = global::WindowsFormsApp1.Properties.Resources.loadingImage;
            this.img1.Location = new System.Drawing.Point(27, 17);
            this.img1.Name = "img1";
            this.img1.ShadowDecoration.Parent = this.img1;
            this.img1.Size = new System.Drawing.Size(76, 69);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1.TabIndex = 9;
            this.img1.TabStop = false;
            this.img1.Click += new System.EventHandler(this.img1_Click);
            // 
            // img2
            // 
            this.img2.BorderRadius = 12;
            this.img2.Image = global::WindowsFormsApp1.Properties.Resources.loadingImage;
            this.img2.Location = new System.Drawing.Point(27, 112);
            this.img2.Name = "img2";
            this.img2.ShadowDecoration.Parent = this.img2;
            this.img2.Size = new System.Drawing.Size(76, 69);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2.TabIndex = 10;
            this.img2.TabStop = false;
            this.img2.Click += new System.EventHandler(this.img2_Click);
            // 
            // img3
            // 
            this.img3.BorderRadius = 12;
            this.img3.Image = global::WindowsFormsApp1.Properties.Resources.loadingImage;
            this.img3.Location = new System.Drawing.Point(27, 206);
            this.img3.Name = "img3";
            this.img3.ShadowDecoration.Parent = this.img3;
            this.img3.Size = new System.Drawing.Size(76, 69);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img3.TabIndex = 11;
            this.img3.TabStop = false;
            this.img3.Click += new System.EventHandler(this.img3_Click);
            // 
            // ItemProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.edtCountProduct);
            this.Controls.Add(this.dropDownDirectory);
            this.Controls.Add(this.edtDescription);
            this.Controls.Add(this.edtPrice);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.imgProduct);
            this.Name = "ItemProductManager";
            this.Size = new System.Drawing.Size(914, 312);
            this.Load += new System.EventHandler(this.ItemProductManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox imgProduct;
        private Guna.UI2.WinForms.Guna2TextBox edtName;
        private Guna.UI2.WinForms.Guna2TextBox edtPrice;
        private Guna.UI2.WinForms.Guna2TextBox edtDescription;
        private Guna.UI2.WinForms.Guna2ComboBox dropDownDirectory;
        private Guna.UI2.WinForms.Guna2TextBox edtCountProduct;
        private Guna.UI2.WinForms.Guna2PictureBox btnUpdate;
        private Guna.UI2.WinForms.Guna2PictureBox btnRemove;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox img3;
        private Guna.UI2.WinForms.Guna2PictureBox img2;
        private Guna.UI2.WinForms.Guna2PictureBox img1;
    }
}

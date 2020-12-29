
namespace WindowsFormsApp1.View.Screen
{
    partial class ProductManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManager));
            this.btnAddDirectory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.searchView = new Guna.UI2.WinForms.Guna2TextBox();
            this.flListProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddDirectory
            // 
            this.btnAddDirectory.BorderRadius = 12;
            this.btnAddDirectory.CheckedState.Parent = this.btnAddDirectory;
            this.btnAddDirectory.CustomImages.Parent = this.btnAddDirectory;
            this.btnAddDirectory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(36)))));
            this.btnAddDirectory.FillColor2 = System.Drawing.Color.Black;
            this.btnAddDirectory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddDirectory.ForeColor = System.Drawing.Color.White;
            this.btnAddDirectory.HoverState.Parent = this.btnAddDirectory;
            this.btnAddDirectory.Location = new System.Drawing.Point(773, 34);
            this.btnAddDirectory.Name = "btnAddDirectory";
            this.btnAddDirectory.ShadowDecoration.Parent = this.btnAddDirectory;
            this.btnAddDirectory.Size = new System.Drawing.Size(180, 45);
            this.btnAddDirectory.TabIndex = 9;
            this.btnAddDirectory.Text = "Add";
            this.btnAddDirectory.Click += new System.EventHandler(this.btnAddDirectory_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.flListProduct);
            this.panel1.Location = new System.Drawing.Point(23, 122);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Parent = this.panel1;
            this.panel1.Size = new System.Drawing.Size(995, 626);
            this.panel1.TabIndex = 10;
            // 
            // searchView
            // 
            this.searchView.AutoRoundedCorners = true;
            this.searchView.BackColor = System.Drawing.Color.Transparent;
            this.searchView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.searchView.BorderRadius = 27;
            this.searchView.BorderThickness = 2;
            this.searchView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchView.DefaultText = "";
            this.searchView.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchView.DisabledState.Parent = this.searchView;
            this.searchView.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(240)))), ((int)(((byte)(234)))));
            this.searchView.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.searchView.FocusedState.Parent = this.searchView;
            this.searchView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchView.ForeColor = System.Drawing.Color.Gray;
            this.searchView.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.searchView.HoverState.Parent = this.searchView;
            this.searchView.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchView.IconLeft")));
            this.searchView.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.searchView.Location = new System.Drawing.Point(23, 23);
            this.searchView.Name = "searchView";
            this.searchView.PasswordChar = '\0';
            this.searchView.PlaceholderText = "Search";
            this.searchView.SelectedText = "";
            this.searchView.ShadowDecoration.Parent = this.searchView;
            this.searchView.Size = new System.Drawing.Size(350, 56);
            this.searchView.TabIndex = 5;
            this.searchView.TextOffset = new System.Drawing.Point(10, 0);
            this.searchView.TextChanged += new System.EventHandler(this.searchView_TextChanged);
            // 
            // flListProduct
            // 
            this.flListProduct.BackColor = System.Drawing.Color.White;
            this.flListProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flListProduct.Location = new System.Drawing.Point(0, 0);
            this.flListProduct.Name = "flListProduct";
            this.flListProduct.Size = new System.Drawing.Size(995, 626);
            this.flListProduct.TabIndex = 0;
            this.flListProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.flListProduct_Paint);
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddDirectory);
            this.Controls.Add(this.searchView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductManager";
            this.Text = "ProductManager";
            this.Load += new System.EventHandler(this.ProductManager_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox searchView;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddDirectory;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flListProduct;
    }
}
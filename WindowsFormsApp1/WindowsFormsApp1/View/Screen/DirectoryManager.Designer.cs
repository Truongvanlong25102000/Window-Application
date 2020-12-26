
namespace WindowsFormsApp1.View.Screen
{
    partial class DirectoryManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryManager));
            this.flListItemDirectory = new System.Windows.Forms.FlowLayoutPanel();
            this.searchView = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2PictureBox();
            this.rowDirectory1 = new WindowsFormsApp1.View.Item.RowDirectory();
            this.titleTableDictonary1 = new WindowsFormsApp1.View.Item.TitleTableDictonary();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // flListItemDirectory
            // 
            this.flListItemDirectory.AutoScroll = true;
            this.flListItemDirectory.BackColor = System.Drawing.Color.White;
            this.flListItemDirectory.Location = new System.Drawing.Point(9, 81);
            this.flListItemDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.flListItemDirectory.Name = "flListItemDirectory";
            this.flListItemDirectory.Size = new System.Drawing.Size(1065, 161);
            this.flListItemDirectory.TabIndex = 3;
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
            this.searchView.Location = new System.Drawing.Point(9, 12);
            this.searchView.Name = "searchView";
            this.searchView.PasswordChar = '\0';
            this.searchView.PlaceholderText = "Search";
            this.searchView.SelectedText = "";
            this.searchView.ShadowDecoration.Parent = this.searchView;
            this.searchView.Size = new System.Drawing.Size(350, 56);
            this.searchView.TabIndex = 4;
            this.searchView.TextOffset = new System.Drawing.Point(10, 0);
            this.searchView.TextChanged += new System.EventHandler(this.searchView_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(987, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdd.TabIndex = 7;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rowDirectory1
            // 
            this.rowDirectory1.BackColor = System.Drawing.Color.White;
            this.rowDirectory1.Location = new System.Drawing.Point(12, 329);
            this.rowDirectory1.Name = "rowDirectory1";
            this.rowDirectory1.Size = new System.Drawing.Size(656, 85);
            this.rowDirectory1.TabIndex = 6;
            this.rowDirectory1.Visible = false;
            // 
            // titleTableDictonary1
            // 
            this.titleTableDictonary1.BackColor = System.Drawing.Color.White;
            this.titleTableDictonary1.ForeColor = System.Drawing.Color.DimGray;
            this.titleTableDictonary1.Location = new System.Drawing.Point(12, 269);
            this.titleTableDictonary1.Name = "titleTableDictonary1";
            this.titleTableDictonary1.Size = new System.Drawing.Size(560, 54);
            this.titleTableDictonary1.TabIndex = 5;
            this.titleTableDictonary1.Visible = false;
            // 
            // DirectoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 710);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rowDirectory1);
            this.Controls.Add(this.titleTableDictonary1);
            this.Controls.Add(this.searchView);
            this.Controls.Add(this.flListItemDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DirectoryManager";
            this.Text = "DirectoryManager";
            this.Load += new System.EventHandler(this.DirectoryManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flListItemDirectory;
        private Guna.UI2.WinForms.Guna2TextBox searchView;
        private Item.TitleTableDictonary titleTableDictonary1;
        private Item.RowDirectory rowDirectory1;
        private Guna.UI2.WinForms.Guna2PictureBox btnAdd;
    }
}
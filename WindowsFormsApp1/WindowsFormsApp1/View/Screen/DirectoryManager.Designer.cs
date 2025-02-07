﻿
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
            this.btnAddDirectory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.searchView = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableDirectory = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.flListItemDirectory = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2.SuspendLayout();
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
            this.btnAddDirectory.Location = new System.Drawing.Point(50, 330);
            this.btnAddDirectory.Name = "btnAddDirectory";
            this.btnAddDirectory.ShadowDecoration.Parent = this.btnAddDirectory;
            this.btnAddDirectory.Size = new System.Drawing.Size(180, 45);
            this.btnAddDirectory.TabIndex = 8;
            this.btnAddDirectory.Text = "Add";
            this.btnAddDirectory.Click += new System.EventHandler(this.btnAddDirectory_Click);
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
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.tableDirectory);
            this.panel2.Location = new System.Drawing.Point(9, 427);
            this.panel2.Name = "panel2";
            this.panel2.ShadowDecoration.Parent = this.panel2;
            this.panel2.Size = new System.Drawing.Size(1065, 247);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableDirectory
            // 
            this.tableDirectory.AutoScroll = true;
            this.tableDirectory.AutoSize = true;
            this.tableDirectory.BackColor = System.Drawing.Color.White;
            this.tableDirectory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.tableDirectory.Location = new System.Drawing.Point(0, 0);
            this.tableDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.tableDirectory.Name = "tableDirectory";
            this.tableDirectory.Size = new System.Drawing.Size(1065, 161);
            this.tableDirectory.TabIndex = 10;
            this.tableDirectory.Paint += new System.Windows.Forms.PaintEventHandler(this.tableDirectory_Paint_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flListItemDirectory);
            this.panel1.Location = new System.Drawing.Point(12, 105);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Parent = this.panel1;
            this.panel1.Size = new System.Drawing.Size(1117, 180);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flListItemDirectory
            // 
            this.flListItemDirectory.AutoScroll = true;
            this.flListItemDirectory.AutoSize = true;
            this.flListItemDirectory.BackColor = System.Drawing.Color.White;
            this.flListItemDirectory.Location = new System.Drawing.Point(0, 0);
            this.flListItemDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.flListItemDirectory.Name = "flListItemDirectory";
            this.flListItemDirectory.Size = new System.Drawing.Size(1117, 78);
            this.flListItemDirectory.TabIndex = 4;
            // 
            // btnAdd1
            // 
            this.btnAdd1.BorderRadius = 12;
            this.btnAdd1.CheckedState.Parent = this.btnAdd1;
            this.btnAdd1.CustomImages.Parent = this.btnAdd1;
            this.btnAdd1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(36)))));
            this.btnAdd1.FillColor2 = System.Drawing.Color.Black;
            this.btnAdd1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd1.ForeColor = System.Drawing.Color.White;
            this.btnAdd1.HoverState.Parent = this.btnAdd1;
            this.btnAdd1.Location = new System.Drawing.Point(949, 50);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.ShadowDecoration.Parent = this.btnAdd1;
            this.btnAdd1.Size = new System.Drawing.Size(180, 45);
            this.btnAdd1.TabIndex = 11;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // DirectoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 710);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddDirectory);
            this.Controls.Add(this.searchView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DirectoryManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DirectoryManager";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DirectoryManager_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DirectoryManager_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox searchView;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddDirectory;
        private Guna.UI2.WinForms.Guna2Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel tableDirectory;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flListItemDirectory;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd1;
    }
}
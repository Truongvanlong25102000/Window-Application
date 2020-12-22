
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
            this.flListItemDirectory = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flListItemDirectory
            // 
            this.flListItemDirectory.AutoScroll = true;
            this.flListItemDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flListItemDirectory.Location = new System.Drawing.Point(0, 0);
            this.flListItemDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.flListItemDirectory.Name = "flListItemDirectory";
            this.flListItemDirectory.Size = new System.Drawing.Size(1082, 207);
            this.flListItemDirectory.TabIndex = 1;
            this.flListItemDirectory.WrapContents = false;
            this.flListItemDirectory.Move += new System.EventHandler(this.flListItemDirectory_Move);
            // 
            // DirectoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 710);
            this.Controls.Add(this.flListItemDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DirectoryManager";
            this.Text = "DirectoryManager";
            this.Load += new System.EventHandler(this.DirectoryManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flListItemDirectory;
    }
}
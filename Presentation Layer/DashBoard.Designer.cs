
namespace Restaurant_Management_System.Presentation_Layer
{
    partial class DashBoard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageRestaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFoodTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFoodMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageRestaurantToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageRestaurantToolStripMenuItem
            // 
            this.manageRestaurantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageFoodTypeToolStripMenuItem,
            this.manageFoodMenuToolStripMenuItem});
            this.manageRestaurantToolStripMenuItem.Name = "manageRestaurantToolStripMenuItem";
            this.manageRestaurantToolStripMenuItem.Size = new System.Drawing.Size(180, 29);
            this.manageRestaurantToolStripMenuItem.Text = "Manage Restaurant";
            // 
            // manageFoodTypeToolStripMenuItem
            // 
            this.manageFoodTypeToolStripMenuItem.Name = "manageFoodTypeToolStripMenuItem";
            this.manageFoodTypeToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.manageFoodTypeToolStripMenuItem.Text = "Manage Food Type";
            this.manageFoodTypeToolStripMenuItem.Click += new System.EventHandler(this.manageFoodTypeToolStripMenuItem_Click);
            // 
            // manageFoodMenuToolStripMenuItem
            // 
            this.manageFoodMenuToolStripMenuItem.Name = "manageFoodMenuToolStripMenuItem";
            this.manageFoodMenuToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.manageFoodMenuToolStripMenuItem.Text = "Manage Food Menu";
            this.manageFoodMenuToolStripMenuItem.Click += new System.EventHandler(this.manageFoodMenuToolStripMenuItem_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 279);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashBoard_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageRestaurantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageFoodTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageFoodMenuToolStripMenuItem;
    }
}
namespace MoveBrickMan
{
    partial class XMB
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
            this.MSAccounting = new System.Windows.Forms.ToolStripMenuItem();
            this.报表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSAccounting,
            this.报表查询ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MSAccounting
            // 
            this.MSAccounting.Image = global::MoveBrickMan.Properties.Resources.图标3;
            this.MSAccounting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MSAccounting.Name = "MSAccounting";
            this.MSAccounting.ShortcutKeyDisplayString = "A";
            this.MSAccounting.Size = new System.Drawing.Size(106, 26);
            this.MSAccounting.Text = "账务管理(&A)";
            this.MSAccounting.Click += new System.EventHandler(this.MSAccounting_Click);
            // 
            // 报表查询ToolStripMenuItem
            // 
            this.报表查询ToolStripMenuItem.Image = global::MoveBrickMan.Properties.Resources.图标1;
            this.报表查询ToolStripMenuItem.Name = "报表查询ToolStripMenuItem";
            this.报表查询ToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.报表查询ToolStripMenuItem.Text = "报表查询(&F)";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Image = global::MoveBrickMan.Properties.Resources.图标2;
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.设置ToolStripMenuItem.Text = "系统设置(&S)";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = global::MoveBrickMan.Properties.Resources.图标4;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.退出ToolStripMenuItem.Text = "退出系统(ESC)";
            // 
            // XMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MoveBrickMan.Properties.Resources.背景图1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "XMB";
            this.Text = "Set";
            this.Load += new System.EventHandler(this.XMB_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MSAccounting;
        private System.Windows.Forms.ToolStripMenuItem 报表查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}
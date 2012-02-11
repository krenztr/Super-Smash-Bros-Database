namespace SuperSmashBros
{
    partial class MainPage
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Location = new System.Drawing.Point(913, -1);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 32);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerInfoToolStripMenuItem,
            this.matchInfoToolStripMenuItem,
            this.gameInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerInfoToolStripMenuItem
            // 
            this.playerInfoToolStripMenuItem.Name = "playerInfoToolStripMenuItem";
            this.playerInfoToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.playerInfoToolStripMenuItem.Text = "Player Info";
            this.playerInfoToolStripMenuItem.Click += new System.EventHandler(this.playerInfoToolStripMenuItem_Click);
            // 
            // matchInfoToolStripMenuItem
            // 
            this.matchInfoToolStripMenuItem.Name = "matchInfoToolStripMenuItem";
            this.matchInfoToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.matchInfoToolStripMenuItem.Text = "Match Info";
            this.matchInfoToolStripMenuItem.Click += new System.EventHandler(this.matchInfoToolStripMenuItem_Click);
            // 
            // gameInfoToolStripMenuItem
            // 
            this.gameInfoToolStripMenuItem.Name = "gameInfoToolStripMenuItem";
            this.gameInfoToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.gameInfoToolStripMenuItem.Text = "Game Info";
            this.gameInfoToolStripMenuItem.Click += new System.EventHandler(this.gameInfoToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1006, 695);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameInfoToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
    }
}
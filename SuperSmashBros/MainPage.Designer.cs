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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Location = new System.Drawing.Point(898, -1);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 32);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerInfoToolStripMenuItem,
            this.matchInfoToolStripMenuItem,
            this.gameInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 28);
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
            // 
            // gameInfoToolStripMenuItem
            // 
            this.gameInfoToolStripMenuItem.Name = "gameInfoToolStripMenuItem";
            this.gameInfoToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.gameInfoToolStripMenuItem.Text = "Game Info";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 541);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
    }
}
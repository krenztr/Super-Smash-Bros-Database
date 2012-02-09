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
            this.tabController = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.playerInfoTab = new System.Windows.Forms.TabPage();
            this.gameInfoTab = new System.Windows.Forms.TabPage();
            this.matchInfoTab = new System.Windows.Forms.TabPage();
            this.logoutButton = new System.Windows.Forms.Button();
            this.tabController.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabController.Controls.Add(this.mainTab);
            this.tabController.Controls.Add(this.playerInfoTab);
            this.tabController.Controls.Add(this.gameInfoTab);
            this.tabController.Controls.Add(this.matchInfoTab);
            this.tabController.Location = new System.Drawing.Point(12, 12);
            this.tabController.Margin = new System.Windows.Forms.Padding(0);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(968, 517);
            this.tabController.TabIndex = 0;
            // 
            // mainTab
            // 
            this.mainTab.Location = new System.Drawing.Point(4, 25);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(960, 488);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            this.mainTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // playerInfoTab
            // 
            this.playerInfoTab.Location = new System.Drawing.Point(4, 25);
            this.playerInfoTab.Name = "playerInfoTab";
            this.playerInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.playerInfoTab.Size = new System.Drawing.Size(960, 488);
            this.playerInfoTab.TabIndex = 1;
            this.playerInfoTab.Text = "Player Info";
            this.playerInfoTab.UseVisualStyleBackColor = true;
            // 
            // gameInfoTab
            // 
            this.gameInfoTab.Location = new System.Drawing.Point(4, 25);
            this.gameInfoTab.Name = "gameInfoTab";
            this.gameInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameInfoTab.Size = new System.Drawing.Size(960, 488);
            this.gameInfoTab.TabIndex = 2;
            this.gameInfoTab.Text = "Game Info";
            this.gameInfoTab.UseVisualStyleBackColor = true;
            // 
            // matchInfoTab
            // 
            this.matchInfoTab.Location = new System.Drawing.Point(4, 25);
            this.matchInfoTab.Name = "matchInfoTab";
            this.matchInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.matchInfoTab.Size = new System.Drawing.Size(960, 488);
            this.matchInfoTab.TabIndex = 3;
            this.matchInfoTab.Text = "Match Info";
            this.matchInfoTab.UseVisualStyleBackColor = true;
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
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 541);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.tabController);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabController.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage playerInfoTab;
        private System.Windows.Forms.TabPage gameInfoTab;
        private System.Windows.Forms.TabPage matchInfoTab;
        private System.Windows.Forms.Button logoutButton;
    }
}
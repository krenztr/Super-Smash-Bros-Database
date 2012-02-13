namespace SuperSmashBros
{
    partial class PlayerInfoPage
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
            this.splitPanels = new System.Windows.Forms.SplitContainer();
            this.charsBox = new System.Windows.Forms.ComboBox();
            this.myFriends = new System.Windows.Forms.DataGridView();
            this.myAvatar = new System.Windows.Forms.PictureBox();
            this.myLossesCount = new System.Windows.Forms.Label();
            this.myWinsCount = new System.Windows.Forms.Label();
            this.myLossesLabel = new System.Windows.Forms.Label();
            this.myWinsLabel = new System.Windows.Forms.Label();
            this.changeFavCharButton = new System.Windows.Forms.Button();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.Label();
            this.playerFriends = new System.Windows.Forms.DataGridView();
            this.playerLossesCountLabel = new System.Windows.Forms.Label();
            this.playerWinsCountLabel = new System.Windows.Forms.Label();
            this.friendButton = new System.Windows.Forms.Button();
            this.playerLossesLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.playerWinsLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.searchUserLabel = new System.Windows.Forms.Label();
            this.playerAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanels)).BeginInit();
            this.splitPanels.Panel1.SuspendLayout();
            this.splitPanels.Panel2.SuspendLayout();
            this.splitPanels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitPanels
            // 
            this.splitPanels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitPanels.Location = new System.Drawing.Point(2, 2);
            this.splitPanels.Margin = new System.Windows.Forms.Padding(2);
            this.splitPanels.MinimumSize = new System.Drawing.Size(604, 476);
            this.splitPanels.Name = "splitPanels";
            // 
            // splitPanels.Panel1
            // 
            this.splitPanels.Panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.splitPanels.Panel1.Controls.Add(this.charsBox);
            this.splitPanels.Panel1.Controls.Add(this.myFriends);
            this.splitPanels.Panel1.Controls.Add(this.myAvatar);
            this.splitPanels.Panel1.Controls.Add(this.myLossesCount);
            this.splitPanels.Panel1.Controls.Add(this.myWinsCount);
            this.splitPanels.Panel1.Controls.Add(this.myLossesLabel);
            this.splitPanels.Panel1.Controls.Add(this.myWinsLabel);
            this.splitPanels.Panel1.Controls.Add(this.changeFavCharButton);
            this.splitPanels.Panel1.Controls.Add(this.playerNameLabel);
            this.splitPanels.Panel1.Controls.Add(this.hiLabel);
            // 
            // splitPanels.Panel2
            // 
            this.splitPanels.Panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.splitPanels.Panel2.Controls.Add(this.playerName);
            this.splitPanels.Panel2.Controls.Add(this.playerFriends);
            this.splitPanels.Panel2.Controls.Add(this.playerLossesCountLabel);
            this.splitPanels.Panel2.Controls.Add(this.playerWinsCountLabel);
            this.splitPanels.Panel2.Controls.Add(this.friendButton);
            this.splitPanels.Panel2.Controls.Add(this.playerLossesLabel);
            this.splitPanels.Panel2.Controls.Add(this.goButton);
            this.splitPanels.Panel2.Controls.Add(this.playerWinsLabel);
            this.splitPanels.Panel2.Controls.Add(this.usernameTextBox);
            this.splitPanels.Panel2.Controls.Add(this.searchUserLabel);
            this.splitPanels.Panel2.Controls.Add(this.playerAvatar);
            this.splitPanels.Size = new System.Drawing.Size(604, 476);
            this.splitPanels.SplitterDistance = 298;
            this.splitPanels.SplitterWidth = 3;
            this.splitPanels.TabIndex = 0;
            // 
            // charsBox
            // 
            this.charsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charsBox.FormattingEnabled = true;
            this.charsBox.Location = new System.Drawing.Point(150, 92);
            this.charsBox.Margin = new System.Windows.Forms.Padding(2);
            this.charsBox.Name = "charsBox";
            this.charsBox.Size = new System.Drawing.Size(132, 21);
            this.charsBox.TabIndex = 10;
            // 
            // myFriends
            // 
            this.myFriends.AllowUserToAddRows = false;
            this.myFriends.AllowUserToDeleteRows = false;
            this.myFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myFriends.Location = new System.Drawing.Point(18, 191);
            this.myFriends.Margin = new System.Windows.Forms.Padding(2);
            this.myFriends.Name = "myFriends";
            this.myFriends.RowTemplate.Height = 24;
            this.myFriends.Size = new System.Drawing.Size(263, 273);
            this.myFriends.TabIndex = 9;
            // 
            // myAvatar
            // 
            this.myAvatar.Location = new System.Drawing.Point(18, 60);
            this.myAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.myAvatar.Name = "myAvatar";
            this.myAvatar.Size = new System.Drawing.Size(128, 128);
            this.myAvatar.TabIndex = 0;
            this.myAvatar.TabStop = false;
            // 
            // myLossesCount
            // 
            this.myLossesCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myLossesCount.AutoSize = true;
            this.myLossesCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myLossesCount.Location = new System.Drawing.Point(226, 62);
            this.myLossesCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myLossesCount.Name = "myLossesCount";
            this.myLossesCount.Size = new System.Drawing.Size(13, 13);
            this.myLossesCount.TabIndex = 8;
            this.myLossesCount.Text = "0";
            // 
            // myWinsCount
            // 
            this.myWinsCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myWinsCount.AutoSize = true;
            this.myWinsCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myWinsCount.Location = new System.Drawing.Point(224, 25);
            this.myWinsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myWinsCount.Name = "myWinsCount";
            this.myWinsCount.Size = new System.Drawing.Size(13, 13);
            this.myWinsCount.TabIndex = 7;
            this.myWinsCount.Text = "0";
            // 
            // myLossesLabel
            // 
            this.myLossesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myLossesLabel.AutoSize = true;
            this.myLossesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myLossesLabel.Location = new System.Drawing.Point(164, 62);
            this.myLossesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myLossesLabel.Name = "myLossesLabel";
            this.myLossesLabel.Size = new System.Drawing.Size(46, 13);
            this.myLossesLabel.TabIndex = 6;
            this.myLossesLabel.Text = "Losses: ";
            // 
            // myWinsLabel
            // 
            this.myWinsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myWinsLabel.AutoSize = true;
            this.myWinsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myWinsLabel.Location = new System.Drawing.Point(164, 25);
            this.myWinsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myWinsLabel.Name = "myWinsLabel";
            this.myWinsLabel.Size = new System.Drawing.Size(37, 13);
            this.myWinsLabel.TabIndex = 5;
            this.myWinsLabel.Text = "Wins: ";
            // 
            // changeFavCharButton
            // 
            this.changeFavCharButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeFavCharButton.Location = new System.Drawing.Point(150, 117);
            this.changeFavCharButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeFavCharButton.Name = "changeFavCharButton";
            this.changeFavCharButton.Size = new System.Drawing.Size(131, 41);
            this.changeFavCharButton.TabIndex = 4;
            this.changeFavCharButton.Text = "Change Fav Character";
            this.changeFavCharButton.UseVisualStyleBackColor = true;
            this.changeFavCharButton.Click += new System.EventHandler(this.changeFavCharButton_Click);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerNameLabel.Location = new System.Drawing.Point(42, 25);
            this.playerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(36, 13);
            this.playerNameLabel.TabIndex = 2;
            this.playerNameLabel.Text = "Player";
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hiLabel.Location = new System.Drawing.Point(16, 25);
            this.hiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(23, 13);
            this.hiLabel.TabIndex = 1;
            this.hiLabel.Text = "Hi, ";
            // 
            // playerName
            // 
            this.playerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerName.Location = new System.Drawing.Point(172, 136);
            this.playerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(52, 20);
            this.playerName.TabIndex = 10;
            this.playerName.Text = "Player";
            // 
            // playerFriends
            // 
            this.playerFriends.AllowUserToAddRows = false;
            this.playerFriends.AllowUserToDeleteRows = false;
            this.playerFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerFriends.Location = new System.Drawing.Point(18, 191);
            this.playerFriends.Margin = new System.Windows.Forms.Padding(2);
            this.playerFriends.Name = "playerFriends";
            this.playerFriends.RowTemplate.Height = 24;
            this.playerFriends.Size = new System.Drawing.Size(264, 273);
            this.playerFriends.TabIndex = 13;
            // 
            // playerLossesCountLabel
            // 
            this.playerLossesCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerLossesCountLabel.AutoSize = true;
            this.playerLossesCountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerLossesCountLabel.Location = new System.Drawing.Point(235, 62);
            this.playerLossesCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLossesCountLabel.Name = "playerLossesCountLabel";
            this.playerLossesCountLabel.Size = new System.Drawing.Size(13, 13);
            this.playerLossesCountLabel.TabIndex = 12;
            this.playerLossesCountLabel.Text = "0";
            // 
            // playerWinsCountLabel
            // 
            this.playerWinsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerWinsCountLabel.AutoSize = true;
            this.playerWinsCountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerWinsCountLabel.Location = new System.Drawing.Point(232, 25);
            this.playerWinsCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerWinsCountLabel.Name = "playerWinsCountLabel";
            this.playerWinsCountLabel.Size = new System.Drawing.Size(13, 13);
            this.playerWinsCountLabel.TabIndex = 11;
            this.playerWinsCountLabel.Text = "0";
            // 
            // friendButton
            // 
            this.friendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendButton.Location = new System.Drawing.Point(176, 92);
            this.friendButton.Margin = new System.Windows.Forms.Padding(2);
            this.friendButton.Name = "friendButton";
            this.friendButton.Size = new System.Drawing.Size(96, 40);
            this.friendButton.TabIndex = 5;
            this.friendButton.Text = "Friend This Player";
            this.friendButton.UseVisualStyleBackColor = true;
            this.friendButton.Click += new System.EventHandler(this.friendButton_Click);
            // 
            // playerLossesLabel
            // 
            this.playerLossesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerLossesLabel.AutoSize = true;
            this.playerLossesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerLossesLabel.Location = new System.Drawing.Point(178, 62);
            this.playerLossesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLossesLabel.Name = "playerLossesLabel";
            this.playerLossesLabel.Size = new System.Drawing.Size(46, 13);
            this.playerLossesLabel.TabIndex = 10;
            this.playerLossesLabel.Text = "Losses: ";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(120, 30);
            this.goButton.Margin = new System.Windows.Forms.Padding(2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(48, 20);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // playerWinsLabel
            // 
            this.playerWinsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerWinsLabel.AutoSize = true;
            this.playerWinsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerWinsLabel.Location = new System.Drawing.Point(182, 25);
            this.playerWinsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerWinsLabel.Name = "playerWinsLabel";
            this.playerWinsLabel.Size = new System.Drawing.Size(37, 13);
            this.playerWinsLabel.TabIndex = 9;
            this.playerWinsLabel.Text = "Wins: ";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(18, 30);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.MaxLength = 15;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(98, 20);
            this.usernameTextBox.TabIndex = 3;
            // 
            // searchUserLabel
            // 
            this.searchUserLabel.AutoSize = true;
            this.searchUserLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchUserLabel.Location = new System.Drawing.Point(16, 14);
            this.searchUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchUserLabel.Name = "searchUserLabel";
            this.searchUserLabel.Size = new System.Drawing.Size(69, 13);
            this.searchUserLabel.TabIndex = 2;
            this.searchUserLabel.Text = "Search User:";
            // 
            // playerAvatar
            // 
            this.playerAvatar.Location = new System.Drawing.Point(18, 60);
            this.playerAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.playerAvatar.Name = "playerAvatar";
            this.playerAvatar.Size = new System.Drawing.Size(128, 128);
            this.playerAvatar.TabIndex = 1;
            this.playerAvatar.TabStop = false;
            // 
            // PlayerInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.splitPanels);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayerInfoPage";
            this.Size = new System.Drawing.Size(608, 481);
            this.splitPanels.Panel1.ResumeLayout(false);
            this.splitPanels.Panel1.PerformLayout();
            this.splitPanels.Panel2.ResumeLayout(false);
            this.splitPanels.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanels)).EndInit();
            this.splitPanels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitPanels;
        private System.Windows.Forms.PictureBox myAvatar;
        private System.Windows.Forms.PictureBox playerAvatar;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label searchUserLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button friendButton;
        private System.Windows.Forms.Button changeFavCharButton;
        private System.Windows.Forms.Label myLossesLabel;
        private System.Windows.Forms.Label myWinsLabel;
        private System.Windows.Forms.Label myWinsCount;
        private System.Windows.Forms.Label myLossesCount;
        private System.Windows.Forms.Label playerLossesCountLabel;
        private System.Windows.Forms.Label playerWinsCountLabel;
        private System.Windows.Forms.Label playerLossesLabel;
        private System.Windows.Forms.Label playerWinsLabel;
        private System.Windows.Forms.DataGridView myFriends;
        private System.Windows.Forms.DataGridView playerFriends;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.ComboBox charsBox;
    }
}

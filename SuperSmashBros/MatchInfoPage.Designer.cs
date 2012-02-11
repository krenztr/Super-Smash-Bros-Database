namespace SuperSmashBros
{
    partial class MatchInfoPage
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
            this.numPlayersBox = new System.Windows.Forms.ComboBox();
            this.playerALabel = new System.Windows.Forms.Label();
            this.playerAName = new System.Windows.Forms.TextBox();
            this.playerCName = new System.Windows.Forms.TextBox();
            this.playerCLabel = new System.Windows.Forms.Label();
            this.playerDName = new System.Windows.Forms.TextBox();
            this.playerDLabel = new System.Windows.Forms.Label();
            this.playerBName = new System.Windows.Forms.TextBox();
            this.playerBLabel = new System.Windows.Forms.Label();
            this.playerNumberLabel = new System.Windows.Forms.Label();
            this.matchDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matchDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // numPlayersBox
            // 
            this.numPlayersBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numPlayersBox.FormattingEnabled = true;
            this.numPlayersBox.Items.AddRange(new object[] {
            "1 Player",
            "2 Players",
            "3 Players",
            "4 Players"});
            this.numPlayersBox.Location = new System.Drawing.Point(347, 64);
            this.numPlayersBox.Name = "numPlayersBox";
            this.numPlayersBox.Size = new System.Drawing.Size(121, 24);
            this.numPlayersBox.TabIndex = 0;
            this.numPlayersBox.SelectedIndexChanged += new System.EventHandler(this.numPlayersBox_SelectedIndexChanged);
            // 
            // playerALabel
            // 
            this.playerALabel.AutoSize = true;
            this.playerALabel.Location = new System.Drawing.Point(51, 25);
            this.playerALabel.Name = "playerALabel";
            this.playerALabel.Size = new System.Drawing.Size(65, 17);
            this.playerALabel.TabIndex = 1;
            this.playerALabel.Text = "Player A:";
            // 
            // playerAName
            // 
            this.playerAName.Location = new System.Drawing.Point(122, 25);
            this.playerAName.Name = "playerAName";
            this.playerAName.Size = new System.Drawing.Size(98, 22);
            this.playerAName.TabIndex = 2;
            // 
            // playerCName
            // 
            this.playerCName.Location = new System.Drawing.Point(122, 71);
            this.playerCName.Name = "playerCName";
            this.playerCName.Size = new System.Drawing.Size(98, 22);
            this.playerCName.TabIndex = 4;
            // 
            // playerCLabel
            // 
            this.playerCLabel.AutoSize = true;
            this.playerCLabel.Location = new System.Drawing.Point(51, 71);
            this.playerCLabel.Name = "playerCLabel";
            this.playerCLabel.Size = new System.Drawing.Size(65, 17);
            this.playerCLabel.TabIndex = 3;
            this.playerCLabel.Text = "Player C:";
            // 
            // playerDName
            // 
            this.playerDName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerDName.Location = new System.Drawing.Point(639, 71);
            this.playerDName.Name = "playerDName";
            this.playerDName.Size = new System.Drawing.Size(98, 22);
            this.playerDName.TabIndex = 8;
            // 
            // playerDLabel
            // 
            this.playerDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerDLabel.AutoSize = true;
            this.playerDLabel.Location = new System.Drawing.Point(568, 71);
            this.playerDLabel.Name = "playerDLabel";
            this.playerDLabel.Size = new System.Drawing.Size(66, 17);
            this.playerDLabel.TabIndex = 7;
            this.playerDLabel.Text = "Player D:";
            // 
            // playerBName
            // 
            this.playerBName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerBName.Location = new System.Drawing.Point(639, 25);
            this.playerBName.Name = "playerBName";
            this.playerBName.Size = new System.Drawing.Size(98, 22);
            this.playerBName.TabIndex = 6;
            // 
            // playerBLabel
            // 
            this.playerBLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerBLabel.AutoSize = true;
            this.playerBLabel.Location = new System.Drawing.Point(568, 25);
            this.playerBLabel.Name = "playerBLabel";
            this.playerBLabel.Size = new System.Drawing.Size(65, 17);
            this.playerBLabel.TabIndex = 5;
            this.playerBLabel.Text = "Player B:";
            // 
            // playerNumberLabel
            // 
            this.playerNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.playerNumberLabel.AutoSize = true;
            this.playerNumberLabel.Location = new System.Drawing.Point(344, 30);
            this.playerNumberLabel.Name = "playerNumberLabel";
            this.playerNumberLabel.Size = new System.Drawing.Size(125, 17);
            this.playerNumberLabel.TabIndex = 9;
            this.playerNumberLabel.Text = "Number of Players";
            // 
            // matchDataGrid
            // 
            this.matchDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.matchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchDataGrid.Location = new System.Drawing.Point(3, 116);
            this.matchDataGrid.Name = "matchDataGrid";
            this.matchDataGrid.RowTemplate.Height = 24;
            this.matchDataGrid.Size = new System.Drawing.Size(805, 473);
            this.matchDataGrid.TabIndex = 10;
            // 
            // MatchInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.matchDataGrid);
            this.Controls.Add(this.playerNumberLabel);
            this.Controls.Add(this.playerDName);
            this.Controls.Add(this.playerDLabel);
            this.Controls.Add(this.playerBName);
            this.Controls.Add(this.playerBLabel);
            this.Controls.Add(this.playerCName);
            this.Controls.Add(this.playerCLabel);
            this.Controls.Add(this.playerAName);
            this.Controls.Add(this.playerALabel);
            this.Controls.Add(this.numPlayersBox);
            this.Name = "MatchInfoPage";
            this.Size = new System.Drawing.Size(811, 592);
            ((System.ComponentModel.ISupportInitialize)(this.matchDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox numPlayersBox;
        private System.Windows.Forms.Label playerALabel;
        private System.Windows.Forms.TextBox playerAName;
        private System.Windows.Forms.TextBox playerCName;
        private System.Windows.Forms.Label playerCLabel;
        private System.Windows.Forms.TextBox playerDName;
        private System.Windows.Forms.Label playerDLabel;
        private System.Windows.Forms.TextBox playerBName;
        private System.Windows.Forms.Label playerBLabel;
        private System.Windows.Forms.Label playerNumberLabel;
        private System.Windows.Forms.DataGridView matchDataGrid;
    }
}

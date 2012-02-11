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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hiLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanels)).BeginInit();
            this.splitPanels.Panel1.SuspendLayout();
            this.splitPanels.Panel2.SuspendLayout();
            this.splitPanels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitPanels
            // 
            this.splitPanels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitPanels.Location = new System.Drawing.Point(3, 3);
            this.splitPanels.Name = "splitPanels";
            // 
            // splitPanels.Panel1
            // 
            this.splitPanels.Panel1.Controls.Add(this.playerNameLabel);
            this.splitPanels.Panel1.Controls.Add(this.hiLabel);
            this.splitPanels.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitPanels.Panel2
            // 
            this.splitPanels.Panel2.Controls.Add(this.pictureBox2);
            this.splitPanels.Size = new System.Drawing.Size(805, 586);
            this.splitPanels.SplitterDistance = 399;
            this.splitPanels.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(31, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Location = new System.Drawing.Point(21, 31);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(29, 17);
            this.hiLabel.TabIndex = 1;
            this.hiLabel.Text = "Hi, ";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(56, 31);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(48, 17);
            this.playerNameLabel.TabIndex = 2;
            this.playerNameLabel.Text = "Player";
            // 
            // PlayerInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.splitPanels);
            this.Name = "PlayerInfoPage";
            this.Size = new System.Drawing.Size(811, 592);
            this.splitPanels.Panel1.ResumeLayout(false);
            this.splitPanels.Panel1.PerformLayout();
            this.splitPanels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanels)).EndInit();
            this.splitPanels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitPanels;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label playerNameLabel;
    }
}

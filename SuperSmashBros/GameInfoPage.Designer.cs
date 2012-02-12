namespace SuperSmashBros
{
    partial class GameInfoPage
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
            this.charsListView = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkBox = new System.Windows.Forms.PictureBox();
            this.charPicture = new System.Windows.Forms.PictureBox();
            this.charDescription = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // charsListView
            // 
            this.charsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charsListView.Location = new System.Drawing.Point(14, 18);
            this.charsListView.Margin = new System.Windows.Forms.Padding(2);
            this.charsListView.Name = "charsListView";
            this.charsListView.Size = new System.Drawing.Size(579, 256);
            this.charsListView.TabIndex = 0;
            this.charsListView.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.charDescription);
            this.panel1.Controls.Add(this.charPicture);
            this.panel1.Location = new System.Drawing.Point(14, 288);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 174);
            this.panel1.TabIndex = 1;
            // 
            // linkBox
            // 
            this.linkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.linkBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkBox.Image = global::SuperSmashBros.Properties.Resources.link;
            this.linkBox.Location = new System.Drawing.Point(20, 24);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(107, 100);
            this.linkBox.TabIndex = 2;
            this.linkBox.TabStop = false;
            this.linkBox.Click += new System.EventHandler(this.linkBox_Click);
            // 
            // charPicture
            // 
            this.charPicture.Location = new System.Drawing.Point(2, 6);
            this.charPicture.Margin = new System.Windows.Forms.Padding(2);
            this.charPicture.Name = "charPicture";
            this.charPicture.Size = new System.Drawing.Size(141, 162);
            this.charPicture.TabIndex = 0;
            this.charPicture.TabStop = false;
            // 
            // charDescription
            // 
            this.charDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charDescription.Location = new System.Drawing.Point(158, 3);
            this.charDescription.Name = "charDescription";
            this.charDescription.ReadOnly = true;
            this.charDescription.Size = new System.Drawing.Size(408, 164);
            this.charDescription.TabIndex = 1;
            this.charDescription.Text = "";
            // 
            // GameInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.charsListView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameInfoPage";
            this.Size = new System.Drawing.Size(608, 481);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.linkBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView charsListView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox charPicture;
        private System.Windows.Forms.PictureBox linkBox;
        private System.Windows.Forms.RichTextBox charDescription;
    }
}

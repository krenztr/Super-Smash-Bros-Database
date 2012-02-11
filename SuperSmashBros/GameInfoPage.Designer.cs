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
            this.charPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // charsListView
            // 
            this.charsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.charsListView.Location = new System.Drawing.Point(19, 22);
            this.charsListView.Name = "charsListView";
            this.charsListView.Size = new System.Drawing.Size(771, 314);
            this.charsListView.TabIndex = 0;
            this.charsListView.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.charPicture);
            this.panel1.Location = new System.Drawing.Point(19, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 213);
            this.panel1.TabIndex = 1;
            // 
            // charPicture
            // 
            this.charPicture.Location = new System.Drawing.Point(3, 7);
            this.charPicture.Name = "charPicture";
            this.charPicture.Size = new System.Drawing.Size(200, 200);
            this.charPicture.TabIndex = 0;
            this.charPicture.TabStop = false;
            // 
            // GameInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.charsListView);
            this.Name = "GameInfoPage";
            this.Size = new System.Drawing.Size(811, 592);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView charsListView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox charPicture;
    }
}

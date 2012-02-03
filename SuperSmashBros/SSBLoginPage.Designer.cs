namespace SuperSmashBros
{
    partial class SSBLoginPage
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
            this.enterButton = new System.Windows.Forms.Button();
            this.backgroundPicture = new System.Windows.Forms.PictureBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enterButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enterButton.Font = new System.Drawing.Font("ESSTIXThirteen", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterButton.Location = new System.Drawing.Point(487, 447);
            this.enterButton.Margin = new System.Windows.Forms.Padding(0);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(98, 30);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // backgroundPicture
            // 
            this.backgroundPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundPicture.BackgroundImage = global::SuperSmashBros.Properties.Resources.brawl_1024;
            this.backgroundPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPicture.Location = new System.Drawing.Point(7, 7);
            this.backgroundPicture.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundPicture.Name = "backgroundPicture";
            this.backgroundPicture.Size = new System.Drawing.Size(600, 488);
            this.backgroundPicture.TabIndex = 0;
            this.backgroundPicture.TabStop = false;
            // 
            // usernameBox
            // 
            this.usernameBox.AccessibleDescription = "";
            this.usernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameBox.BackColor = System.Drawing.SystemColors.Info;
            this.usernameBox.Location = new System.Drawing.Point(487, 398);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(98, 20);
            this.usernameBox.TabIndex = 1;
            this.usernameBox.Text = "Trevor";
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.AsciiOnly = true;
            this.passwordBox.BackColor = System.Drawing.SystemColors.Info;
            this.passwordBox.Location = new System.Drawing.Point(487, 422);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 6);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(98, 20);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.Text = "test123";
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(193, 456);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Not a User ?";
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registerButton.Font = new System.Drawing.Font("Consolas", 10F);
            this.registerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerButton.Location = new System.Drawing.Point(287, 451);
            this.registerButton.Margin = new System.Windows.Forms.Padding(0);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(88, 29);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register!";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // SSBLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 502);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.backgroundPicture);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SSBLoginPage";
            this.Text = "SuperSmashBrosDB - Login";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundPicture;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.MaskedTextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerButton;

    }
}


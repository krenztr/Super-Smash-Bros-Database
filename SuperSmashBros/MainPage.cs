using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SuperSmashBros
{
    public partial class MainPage : Form
    {
        private MatchInfoPage matchPage = null;

        private PlayerInfoPage playerPage = null;

        private GameInfoPage gamePage = null;

        private LoginPage loginPage = null;

        private Control activePage = null;

        private string username = null;

        private string password = null;

        public static SHA512 shaHash = new SHA512Managed();

        public MainPage(LoginPage loginPage, string username, string password)
        {
            InitializeComponent();
            this.loginPage = loginPage;
            this.username = username;
            this.password = password;
            this.StartPosition = FormStartPosition.CenterScreen;

            matchPage = new MatchInfoPage(username, password);
            matchPage.BackColor = Color.White;
            matchPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            matchPage.Anchor = (AnchorStyles.Left | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Bottom);
            matchPage.Hide();

            playerPage = new PlayerInfoPage(username, password);
            playerPage.BackColor = Color.White;
            playerPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            playerPage.Anchor = (AnchorStyles.Left | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Bottom);
            playerPage.Show();
            activePage = playerPage;

            gamePage = new GameInfoPage(username, password);
            gamePage.BackColor = Color.White;
            gamePage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            gamePage.Anchor = (AnchorStyles.Left | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Bottom);
            gamePage.Hide();

            this.FormClosing += new FormClosingEventHandler(MainPage_FormClosing);
        }

        public static bool IsLetterOrDigit(string s)
        {
            foreach (char c in s.ToCharArray())
            {
                if (!Char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }

        void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.loginPage.Close();
            this.mainPanel.Dispose();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Hide();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            Control[] pages = {playerPage, matchPage, gamePage};
            mainPanel.Controls.AddRange(pages);
            if (activePage != null)
            {
                int idx = mainPanel.Controls.IndexOf(activePage);
                mainPanel.Controls[idx].Show();
                matchPage.Size = mainPanel.Size;
                playerPage.Size = mainPanel.Size;
                gamePage.Size = mainPanel.Size;
            }
        }

        private void playerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activePage != playerPage || activePage == null)
            {
                if (activePage != null)
                    activePage.Hide();
                activePage = playerPage;
                mainPanel.Refresh();
            }
        }

        private void matchInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activePage != matchPage || activePage == null)
            {
                if (activePage != null)
                    activePage.Hide();
                activePage = matchPage;
                mainPanel.Refresh();
            }
        }

        private void gameInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activePage != gamePage || activePage == null)
            {
                if (activePage != null)
                    activePage.Hide();
                activePage = gamePage;
                mainPanel.Refresh();
            }
        }

        public static string GetSHAHash(string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = shaHash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}

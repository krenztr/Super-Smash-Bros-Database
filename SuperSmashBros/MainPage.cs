using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            playerPage.Hide();

            gamePage = new GameInfoPage(username, password);
            gamePage.BackColor = Color.White;
            gamePage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            gamePage.Anchor = (AnchorStyles.Left | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Bottom);
            gamePage.Hide();

            this.FormClosing += new FormClosingEventHandler(MainPage_FormClosing);
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
    }
}

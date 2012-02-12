using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperSmashBros
{
    public partial class MatchInfoPage : UserControl
    {
        string username;

        string password;

        public MatchInfoPage(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            numPlayersBox.SelectedIndex = 0;
        }

        private void numPlayersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerBName.Enabled = false;
            playerCName.Enabled = false;
            playerDName.Enabled = false;
            switch (numPlayersBox.SelectedIndex)
            {
                case 3:
                    playerDName.Enabled = true;
                    goto case 2;
                case 2:
                    playerCName.Enabled = true;
                    goto case 1;
                case 1:
                    playerBName.Enabled = true;
                    goto case 0;
                case 0:
                    break;
            }
        }
    }
}

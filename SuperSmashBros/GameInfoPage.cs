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
    public partial class GameInfoPage : UserControl
    {
        public GameInfoPage()
        {
            InitializeComponent();
        }

        private void linkBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.link;
        }
    }
}

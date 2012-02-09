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
        public MainPage()
        {
            InitializeComponent();
        }

        private object mainPageOnClosing()
        {
            MessageBox.Show("On closing.");
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void playerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Something");
        }
    }
}

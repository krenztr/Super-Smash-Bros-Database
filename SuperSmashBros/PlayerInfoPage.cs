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
    public partial class PlayerInfoPage : UserControl
    {
        string username;

        string password;

        public PlayerInfoPage(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.SizeChanged += new EventHandler(PlayerInfoPage_SizeChanged);

            this.splitPanels.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.splitPanels.Panel1.Anchor = (AnchorStyles.Left | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Bottom);

            this.splitPanels.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.splitPanels.Panel2.Anchor = (AnchorStyles.Left | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Bottom);
        }

        void PlayerInfoPage_SizeChanged(object sender, EventArgs e)
        {
            this.splitPanels.Size = this.Size;
            this.splitPanels.SplitterDistance = this.Width / 2;
        }
    }
}

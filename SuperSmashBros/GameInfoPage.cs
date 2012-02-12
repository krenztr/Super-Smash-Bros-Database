using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperSmashBros
{
    public partial class GameInfoPage : UserControl
    {
        string username;
        string password;
        string tier;
        string gname;
        string description;
        string cname;

        public GameInfoPage(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void linkBox_Click(object sender, EventArgs e)
        {
            this.cname = "Link";

            charPicture.Image = global::SuperSmashBros.Properties.Resources.link;

            string connectionString = "user id=CSSE333-201212-SuperSmashBros;" +
                           "Password=supersmashbros;" +
                           "server=whale.cs.rose-hulman.edu;" +
                           "Trusted_Connection=no;" +
                           "Database=SuperSmashBros;" +
                           "connection timeout=30;" +
                           "TrustServerCertificate=true";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataReader sdr = null;
            SqlCommand command = null;
            string cmd = "GetCharacterInfo";

            try
            {
                command = new SqlCommand(cmd, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add(new SqlParameter("@Name", this.cname));

                connection.Open();
                sdr = command.ExecuteReader();

                if (sdr.Read())
                {
                    this.tier = sdr[1].ToString();
                    this.gname = sdr[2].ToString();
                    this.description = sdr[3].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (sdr != null)
                    sdr.Close();
            }

            charDescription.Text = genCharDescription(this.cname, this.tier, this.gname, this.description);
        }

        private string genCharDescription(string character, string tier, string game, string desc)
        {
            return  "Character: " + character + "\n" +
                    "Tier: " + tier + "\n" +
                    "Game Name: " + game + "\n" +
                    "Description: " + desc + "\n";
        }
    }
}

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
        string boundarySize;
        string cname;
        string stage;

        public GameInfoPage(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private string genCharDescription(string character, string tier, string game, string desc)
        {
            return "Character: " + character + "\n" +
                    "Tier: " + tier + "\n" +
                    "Game Name: " + game + "\n" +
                    "Description: " + desc + "\n";
        }

        private string genStageDescription(string character, string boundary, string game, string desc)
        {
            return "Stage Name: " + character + "\n" +
                    "Boundary Size: " + boundary + "\n" +
                    "Game of Origin: " + game + "\n" +
                    "Description: " + desc + "\n";
        }

        private void getCharInfo(string cName)
        {
            this.cname = cName;

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
        }

        private void getStageInfo(string stage)
        {
            this.stage = stage;

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
            string cmd = "GetStageInfo";

            try
            {
                command = new SqlCommand(cmd, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add(new SqlParameter("@Name", this.stage));

                connection.Open();
                sdr = command.ExecuteReader();

                if (sdr.Read())
                {
                    this.boundarySize = sdr[1].ToString();
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
        }

        private void GameInfoPage_Load(object sender, EventArgs e)
        {

        }

        private void linkBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.link;
            getCharInfo("Link");
            profileDescription.Text = genCharDescription(this.cname, this.tier, this.gname, this.description);
        }

        private void marioBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Mario;
            getCharInfo("Mario");
            profileDescription.Text = genCharDescription(this.cname, this.tier, this.gname, this.description);
        }

        private void luigiBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Luigi;
            getCharInfo("Luigi");
            profileDescription.Text = genCharDescription(this.cname, this.tier, this.gname, this.description);
        }

        private void foxBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Fox;
            getCharInfo("Fox");
            profileDescription.Text = genCharDescription(this.cname, this.tier, this.gname, this.description);
        }

        private void olimarBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Olimar;
            getCharInfo("Olimar");
            profileDescription.Text = genCharDescription(this.cname, this.tier, this.gname, this.description);
        }

        private void samusBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Samus;
            getCharInfo("Samus");
            profileDescription.Text = genCharDescription(this.cname, this.tier, this.gname, this.description);
        }

        private void bowserBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Bowser;
            getCharInfo("Bowser");
            profileDescription.Text = genCharDescription(this.cname, this.tier, this.gname, this.description);
        }

        private void captainFalconBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Captain_Falcon;
            getCharInfo("Captain Falcon");
            profileDescription.Text = genCharDescription(this.cname, this.tier, this.gname, this.description);
        }

        private void marthBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Marth;
            getCharInfo("Marth");
            profileDescription.Text = genCharDescription(this.cname, this.tier, this.gname, this.description);
        }

        private void pikachuBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Pikachu;
            getCharInfo("Pikachu");
            profileDescription.Text = genCharDescription(this.cname, this.tier, this.gname, this.description);
        }

        private void jigglypuffBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Jigglypuff;
            getCharInfo("Jigglypuff");
            profileDescription.Text = genCharDescription(this.cname, this.tier, this.gname, this.description);
        }

        private void kirbyBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Kirby;
            getCharInfo("Kirby");
            profileDescription.Text = genCharDescription(this.cname, this.tier, this.gname, this.description);
        }

        private void finalDestinationBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Final_Destination;
            getStageInfo("Final Destination");
            profileDescription.Text = genStageDescription(this.stage, this.boundarySize, this.gname, this.description);
        }

        private void battlefieldBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Battlefield;
            getStageInfo("Battlefield");
            profileDescription.Text = genStageDescription(this.stage, this.boundarySize, this.gname, this.description);
        }

        private void pirateShipBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Pirate_Ship;
            getStageInfo("Pirate Ship");
            profileDescription.Text = genStageDescription(this.stage, this.boundarySize, this.gname, this.description);
        }

        private void luigisMansionBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Luigis_Mansion;
            getStageInfo("Luigi's Mansion");
            profileDescription.Text = genStageDescription(this.stage, this.boundarySize, this.gname, this.description);
        }

        private void hyruleTempleBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Hyrule_Temple;
            getStageInfo("Hyrule Temple");
            profileDescription.Text = genStageDescription(this.stage, this.boundarySize, this.gname, this.description);
        }

        private void castleSiegeBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Castle_Siege;
            getStageInfo("Castle Siege");
            profileDescription.Text = genStageDescription(this.stage, this.boundarySize, this.gname, this.description);
        }

        private void marioCircuitBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Mario_Circut;
            getStageInfo("Mario Circut");
            profileDescription.Text = genStageDescription(this.stage, this.boundarySize, this.gname, this.description);
        }

        private void mushroomyKingdomBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Mushroomy_Kingdom;
            getStageInfo("Mushroomy Kingdom");
            profileDescription.Text = genStageDescription(this.stage, this.boundarySize, this.gname, this.description);
        }

        private void fountainOfDreamsBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Fountain_of_Dreams;
            getStageInfo("Fountain of Dreams");
            profileDescription.Text = genStageDescription(this.stage, this.boundarySize, this.gname, this.description);
        }

        private void lylatCruiseBox_Click(object sender, EventArgs e)
        {
            charPicture.Image = global::SuperSmashBros.Properties.Resources.Lylat_Cruise;
            getStageInfo("Lylat Cruise");
            profileDescription.Text = genStageDescription(this.stage, this.boundarySize, this.gname, this.description);
        }
    }
}

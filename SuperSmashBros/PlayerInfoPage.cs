﻿using System;
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
    public partial class PlayerInfoPage : UserControl
    {
        string username;

        string password;

        string favCName;

        string wins;

        string losses;

        public PlayerInfoPage(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.SizeChanged += new EventHandler(PlayerInfoPage_SizeChanged);

            this.playerNameLabel.Text = this.username;

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
            string cmd = "GetPlayerInfo";

            try
            {
                command = new SqlCommand(cmd, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add(new SqlParameter("@Username", username));

                connection.Open();
                sdr = command.ExecuteReader();

                if (sdr.Read())
                {
                    this.wins = sdr[1].ToString();
                    this.myWinsCount.Text = wins;
                    this.losses = sdr[2].ToString();
                    this.myLossesCount.Text = losses;
                    this.favCName = sdr[3].ToString();
                    switch (favCName)
                    {
                        case "Link" :
                            myAvatar.Image = global::SuperSmashBros.Properties.Resources.link;
                            myAvatar.Show();
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: "+ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (sdr != null)
                    sdr.Close();
            }

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

        private void goButton_Click(object sender, EventArgs e)
        {
            if (this.usernameTextBox.Text.Equals(""))
                MessageBox.Show("Enter the name of the player you want to search !");
            else
            {
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
                string cmd = "GetPlayerInfo";

                try
                {
                    command = new SqlCommand(cmd, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("@Username", this.usernameTextBox.Text));

                    connection.Open();
                    sdr = command.ExecuteReader();

                    if (sdr.Read())
                    {
                        this.playerWinsCountLabel.Text = sdr[1].ToString();
                        this.playerLossesCountLabel.Text = sdr[2].ToString();
                        string playerFavCName = sdr[3].ToString();
                        switch (playerFavCName)
                        {
                            case "Link":
                                playerAvatar.Image = global::SuperSmashBros.Properties.Resources.link;
                                playerAvatar.Show();
                                break;
                            default:
                                break;
                        }
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
        }
    }
}

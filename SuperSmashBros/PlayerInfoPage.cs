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
    public partial class PlayerInfoPage : UserControl
    {
        string username;

        string password;

        string favCName;

        string wins;

        string losses;

        string player = null;

        public PlayerInfoPage(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.SizeChanged += new EventHandler(PlayerInfoPage_SizeChanged);
            this.myFriends.CellMouseClick += new DataGridViewCellMouseEventHandler(myFriends_CellMouseClick);
            this.playerFriends.CellMouseClick += new DataGridViewCellMouseEventHandler(playerFriends_CellMouseClick);
            this.charsBox.Text = "<Select a character>";
            this.charsBox.Items.Add("<Select a character>");
            this.charsBox.DropDown += new EventHandler(charsBox_DropDown);

            this.playerNameLabel.Text = this.username;
            playerName.Hide();

            updateProfile();

            this.splitPanels.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.splitPanels.Panel1.Anchor = (AnchorStyles.Left | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Bottom);

            this.splitPanels.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.splitPanels.Panel2.Anchor = (AnchorStyles.Left | AnchorStyles.Right
                | AnchorStyles.Top | AnchorStyles.Bottom);
        }

        void charsBox_DropDown(object sender, EventArgs e)
        {
            string connectionString = "user id=CSSE333-201212-SuperSmashBros;" +
                                       "Password=supersmashbros;" +
                                       "server=whale.cs.rose-hulman.edu;" +
                                       "Trusted_Connection=no;" +
                                       "Database=SuperSmashBros;" +
                                       "connection timeout=30;" +
                                       "TrustServerCertificate=true";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = null;
            SqlDataReader sdr = null;
            string cmd = "GetCharacterList";

            try
            {
                command = new SqlCommand(cmd, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                
                connection.Open();
                sdr = command.ExecuteReader();
                charsBox.Items.Clear();
                charsBox.Items.Add("<Select a character>");
                while (sdr.Read()) 
                {
                    charsBox.Items.Add(sdr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            finally
            {
                if (sdr != null)
                {
                    sdr.Close();
                }
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }       
        }

        void playerFriends_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                this.usernameTextBox.Text = this.playerFriends.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.goButton.PerformClick();
            }
        }

        void updateProfile()
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
                        case "Link":
                            myAvatar.Image = global::SuperSmashBros.Properties.Resources.link;
                            myAvatar.Show();
                            break;
                        case "Mario":
                            myAvatar.Image = global::SuperSmashBros.Properties.Resources.Mario;
                            break;
                        case "Luigi":
                            myAvatar.Image = global::SuperSmashBros.Properties.Resources.Luigi;
                            break;
                        case "Fox":
                            myAvatar.Image = global::SuperSmashBros.Properties.Resources.Fox;
                            break;
                        case "Olimar":
                            myAvatar.Image = global::SuperSmashBros.Properties.Resources.Olimar;
                            break;
                        case"Samus":
                            myAvatar.Image = global::SuperSmashBros.Properties.Resources.Samus;
                            break;
                        case"Bowser":
                            myAvatar.Image = global::SuperSmashBros.Properties.Resources.Bowser;
                            break;
                        case "Captain Falcon":
                            myAvatar.Image = global::SuperSmashBros.Properties.Resources.Captain_Falcon;
                            break;
                        case "Marth":
                            myAvatar.Image = global::SuperSmashBros.Properties.Resources.Marth;
                            break;
                        case "Pikachu":
                            myAvatar.Image = global::SuperSmashBros.Properties.Resources.Pikachu;
                            break;
                        case "Jigglypuff":
                            myAvatar.Image = global::SuperSmashBros.Properties.Resources.Jigglypuff;
                            break;
                        case "Kirby":
                            myAvatar.Image = global::SuperSmashBros.Properties.Resources.Kirby;
                            break;
                        default:
                            myAvatar.Image = null;
                            break;
                    }
                }
    
                sdr.Close();
                cmd = "GetFriends";
                command = new SqlCommand(cmd, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add(new SqlParameter("@Username", username));
                sdr = command.ExecuteReader();
                int count = 0;
                if (myFriends.Columns.Count < 1)
                    myFriends.Columns.Add("friendCol", "Friends");
                myFriends.Columns["friendCol"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                myFriends.Rows.Clear();
                while (sdr.Read())
                {
                    myFriends.Rows.Add();
                    myFriends.Rows[count++].Cells[0].Value = sdr[0].ToString();
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

        void myFriends_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                this.usernameTextBox.Text = this.myFriends.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.goButton.PerformClick();
            }
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
            else if (!MainPage.IsLetterOrDigit(usernameTextBox.Text))
                MessageBox.Show("Please don't try to break our database.");
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
                        this.player = sdr[0].ToString();
                        this.playerName.Text = sdr[0].ToString() + @"'s Profile";
                        this.playerName.Show();
                        this.playerWinsCountLabel.Text = sdr[1].ToString();
                        this.playerLossesCountLabel.Text = sdr[2].ToString();
                        string playerFavCName = sdr[3].ToString();
                        switch (playerFavCName)
                        {
                            case "Link":
                                playerAvatar.Image = global::SuperSmashBros.Properties.Resources.link;
                                break;
                            case "Mario":
                                playerAvatar.Image = global::SuperSmashBros.Properties.Resources.Mario;
                                break;
                            case "Luigi":
                                playerAvatar.Image = global::SuperSmashBros.Properties.Resources.Luigi;
                                break;
                            case "Fox":
                                playerAvatar.Image = global::SuperSmashBros.Properties.Resources.Fox;
                                break;
                            case "Olimar":
                                playerAvatar.Image = global::SuperSmashBros.Properties.Resources.Olimar;
                                break;
                            case "Samus":
                                playerAvatar.Image = global::SuperSmashBros.Properties.Resources.Samus;
                                break;
                            case "Bowser":
                                playerAvatar.Image = global::SuperSmashBros.Properties.Resources.Bowser;
                                break;
                            case "Captain Falcon":
                                playerAvatar.Image = global::SuperSmashBros.Properties.Resources.Captain_Falcon;
                                break;
                            case "Marth":
                                playerAvatar.Image = global::SuperSmashBros.Properties.Resources.Marth;
                                break;
                            case "Pikachu":
                                playerAvatar.Image = global::SuperSmashBros.Properties.Resources.Pikachu;
                                break;
                            case "Jigglypuff":
                                playerAvatar.Image = global::SuperSmashBros.Properties.Resources.Jigglypuff;
                                break;
                            case "Kirby":
                                playerAvatar.Image = global::SuperSmashBros.Properties.Resources.Kirby;
                                break;
                            default:
                                playerAvatar.Image = null;
                                break;
                        }
                    }

                    sdr.Close();
                    cmd = "GetFriends";
                    command = new SqlCommand(cmd, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("@Username", this.usernameTextBox.Text));
                    sdr = command.ExecuteReader();
                    int count = 0;
                    if (playerFriends.Columns.Count < 1)
                        playerFriends.Columns.Add("friendCol", "Friends");
                    playerFriends.Columns["friendCol"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    playerFriends.Rows.Clear();
                    while (sdr.Read())
                    {
                        playerFriends.Rows.Add();
                        playerFriends.Rows[count++].Cells[0].Value = sdr[0].ToString();
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
                    usernameTextBox.Text = "";
                }
            }
        }

        private void friendButton_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                string connectionString = "user id=CSSE333-201212-SuperSmashBros;" +
                                                       "Password=supersmashbros;" +
                                                       "server=whale.cs.rose-hulman.edu;" +
                                                       "Trusted_Connection=no;" +
                                                       "Database=SuperSmashBros;" +
                                                       "connection timeout=30;" +
                                                       "TrustServerCertificate=true";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = null;
                string cmd = "AddFriend";

                try
                {
                    command = new SqlCommand(cmd, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("@Username", this.username));
                    command.Parameters.Add(new SqlParameter("@Password", this.password));
                    command.Parameters.Add(new SqlParameter("@Friend", this.player));

                    connection.Open();
                    int row = command.ExecuteNonQuery();
                    if (row > 0)
                    {
                        updateProfile();
                        MessageBox.Show("Friend added successfully !");
                    } 
                    else
                        MessageBox.Show("Faile to add user " + player);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
                finally 
                {
                    if (connection != null) 
                    {
                        connection.Close();
                        connection.Dispose();
                    }
                }
            }
        }

        private void changeFavCharButton_Click(object sender, EventArgs e)
        {
            string character = charsBox.SelectedItem.ToString();
            if (character.Equals("<Select a character>"))
                return;
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
            SqlCommand command = null;
            string cmd = "SetFavoriteCharacter";

            try
            {
                command = new SqlCommand(cmd, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@Username", username);
                command.Parameters.Add("@Password", password);
                command.Parameters.Add("@Favorite", character);
                
                connection.Open();
                int row = command.ExecuteNonQuery();
                if (row > 0) 
                {
                    updateProfile();
                    MessageBox.Show("Favorite character updated !");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }      
            }
        }
    }
}

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

            foreach (DataGridViewColumn c in matchDataGrid.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
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

        private void goButton_Click(object sender, EventArgs e)
        {
            int numOfPlayer = numPlayersBox.SelectedIndex + 1;
            
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
            string cmd = "GetMatchInfo";

            try
            {
                command = new SqlCommand(cmd, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                switch (numOfPlayer)
                {
                    case 4:
                        if (playerDName.TextLength < 1)
                            MessageBox.Show("Enter a username for player D.");
                        command.Parameters.Add(new SqlParameter("@Username4", playerDName.Text));
                        goto case 3;
                    case 3:
                        if (playerCName.TextLength < 1)
                            MessageBox.Show("Enter a username for player C.");
                        command.Parameters.Add(new SqlParameter("@Username3", playerCName.Text));
                        goto case 2;
                    case 2:
                        if (playerBName.TextLength < 1)
                            MessageBox.Show("Enter a username for player B.");
                        command.Parameters.Add(new SqlParameter("@Username2", playerBName.Text));
                        goto case 1;
                    case 1:
                        if (playerAName.TextLength < 1)
                            MessageBox.Show("Enter a username for player A.");
                        command.Parameters.Add(new SqlParameter("@Username1", playerAName.Text));
                        break;

                }

                int row = 0;

                connection.Open();
                sdr = command.ExecuteReader();
                if (matchDataGrid.Columns.Count < 7)
                {
                    // Type
                    matchDataGrid.Columns.Add("type", "Type");
                    // Date
                    matchDataGrid.Columns.Add("date", "Date");
                    // Time
                    matchDataGrid.Columns.Add("time", "Time");
                    // A
                    matchDataGrid.Columns.Add("playerA", "Player A");
                    // B
                    matchDataGrid.Columns.Add("playerB", "Player B");
                    // C
                    matchDataGrid.Columns.Add("playerC", "Player C");
                    // D
                    matchDataGrid.Columns.Add("playerD", "Player D");
                }
                matchDataGrid.Rows.Clear();
                while (sdr.Read()) 
                {
                    matchDataGrid.Rows.Add();
                    // Type
                    matchDataGrid.Rows[row].Cells[0].Value = sdr[0].ToString();
                    // Date
                    matchDataGrid.Rows[row].Cells[1].Value = sdr[1].ToString();
                    // Time
                    matchDataGrid.Rows[row].Cells[2].Value = sdr[2].ToString();
                    // A
                    matchDataGrid.Rows[row].Cells[3].Value = sdr[3].ToString() +
                        " - " + sdr[4].ToString() + " - " + sdr[5].ToString();
                    // B
                    matchDataGrid.Rows[row].Cells[4].Value = sdr[6].ToString() +
                        " - " + sdr[7].ToString() + " - " + sdr[8].ToString();
                    // C
                    matchDataGrid.Rows[row].Cells[5].Value = sdr[9].ToString() +
                        " - " + sdr[10].ToString() + " - " + sdr[11].ToString();
                    // D
                    matchDataGrid.Rows[row].Cells[6].Value = sdr[12].ToString() +
                        " - " + sdr[13].ToString() + " - " + sdr[14].ToString();
                    row += 1;
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperSmashBros
{
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string password2 = passwordBox2.Text;

            if ("" == username)
            {
                MessageBox.Show("We don't take kindly to nameless folk around here.");
                return;
            }

            if (password != password2)
            {
                MessageBox.Show("Passwords do not match, please reenter them.");
                passwordBox.Clear();
                passwordBox2.Clear();

                return;
            }

            if ("" == password)
            {
                MessageBox.Show("What good is a lockless door?");
                return;
            }

            string connectionString = "user id=CSSE333-201212-SuperSmashBros;" +
                                       "Password=supersmashbros;" +
                                       "server=whale.cs.rose-hulman.edu;" +
                                       "Trusted_Connection=no;" +
                                       "Database=SuperSmashBros;" +
                                       "connection timeout=30;" +
                                       "TrustServerCertificate=true";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataReader sdr = null; // blah

            try
            {
                connection.Open();

                string commandString = "SELECT * FROM PLAYER AS p " +
                                        "WHERE p.Username = \'" + username + "\'";

                SqlCommand command = new SqlCommand(commandString, connection);
                sdr = command.ExecuteReader();
                
                if (sdr.Read())
                {
                    MessageBox.Show("Sorry, that username is already taken.");
                    sdr.Close();
                    return;
                }

                else
                {
                    sdr.Close();

                    commandString = "INSERT INTO PLAYER " +
                                    "(Username, Password, Wins, Losses) " +
                                    "VALUES " +
                                    "( \'" + username + "\',\'" + password + "\',0,0); " +
                                    "SELECT * FROM PLAYER AS p " +
                                    "WHERE p.Username = \'" + username + "\'";

                    command = new SqlCommand(commandString, connection);
                    sdr = command.ExecuteReader();

                    if (sdr.Read())
                        MessageBox.Show("You have been successfully registered!");

                    else
                        MessageBox.Show("Failure to register!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                sdr.Close();
            }

            this.Hide();

            LoginPage login_form = new LoginPage();
            login_form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginPage login_form = new LoginPage();
            login_form.ShowDialog();
        }
    }
}

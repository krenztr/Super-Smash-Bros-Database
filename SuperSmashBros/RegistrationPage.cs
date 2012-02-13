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
            string temp = username + password;

            if (!MainPage.IsLetterOrDigit(temp))
            {
                MessageBox.Show("Restrict your input to letters and numbers.  Or else.");
                return;
            }

            string connectionString = "user id=CSSE333-201212-SuperSmashBros;" +
                                       "Password=supersmashbros;" +
                                       "server=whale.cs.rose-hulman.edu;" +
                                       "Trusted_Connection=no;" +
                                       "Database=SuperSmashBros;" +
                                       "connection timeout=30;" +
                                       "TrustServerCertificate=true";

            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string cmd = "RegisterPlayer";

                SqlCommand command = new SqlCommand(cmd, connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@pUsername", username));

                string hashpasswd = MainPage.GetSHAHash("Richard!" + username + "Trevor@" + password + "Seth#");
                command.Parameters.Add(new SqlParameter("@pPassword", hashpasswd));

                int rows_affected = command.ExecuteNonQuery();

                if (rows_affected > 0)
                    MessageBox.Show("You have been successfully registered!");

                else
                {
                    MessageBox.Show("Sorry, that username is already taken.");
                    connection.Close();
                    connection.Dispose();
                    usernameBox.Clear();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
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

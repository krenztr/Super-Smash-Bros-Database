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
    public partial class SSBLoginPage : Form
    {
        readonly string pwd = "supersmashbros";
        public SSBLoginPage()
        {
            InitializeComponent();
            usernameBox.KeyPress += new KeyPressEventHandler(usernameBox_KeyPress);
            passwordBox.KeyDown += new KeyEventHandler(passwordBox_KeyDown);
            passwordBox.UseSystemPasswordChar = true;
        }

        private void SSBLoginPage_Load(object sender, EventArgs e)
        {
            
        }

        #region Events
        
        #region enterButton Event
        private void enterButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            string connectionString = "user id=CSSE333-201212-SuperSmashBros;" +
                                       "Password="+pwd+";" +
                                       "server=whale.cs.rose-hulman.edu;" +
                                       "Trusted_Connection=no;" +
                                       "Database=SuperSmashBros;" +
                                       "connection timeout=30;" +
                                       "TrustServerCertificate=true";

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string commandString = "SELECT * FROM PLAYER AS p WHERE p.Username = \'" +
                    username + "\' AND p.Password = \'" + password + "\'";
                MessageBox.Show(commandString);
                SqlDataReader sdr = null;
                SqlCommand command = new SqlCommand(commandString, connection);
                sdr = command.ExecuteReader();
                if (sdr.Read())
                    MessageBox.Show("Yeah");
                else
                    MessageBox.Show("Oops");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }
        #endregion

        #region registerButton Event
        private void registerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register Button Clicked");

            this.Hide();
            RegistrationPage register_form = new RegistrationPage();
            register_form.ShowDialog();
        }
        #endregion

        #region usernameBox Event
        void usernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 127 || e.KeyChar == 8)
                e.Handled = false;
            else if (!Char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #region passwordBox Event
        void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                enterButton.PerformClick();
        }
        #endregion 
        
        #endregion
    }
}

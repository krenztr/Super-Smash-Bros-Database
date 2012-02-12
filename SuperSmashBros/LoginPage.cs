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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            usernameBox.KeyPress += new KeyPressEventHandler(usernameBox_KeyPress);
            passwordBox.KeyDown += new KeyEventHandler(passwordBox_KeyDown);
            passwordBox.UseSystemPasswordChar = true;

            this.StartPosition = FormStartPosition.CenterScreen;
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
                                       "Password=supersmashbros;" +
                                       "server=whale.cs.rose-hulman.edu;" +
                                       "Trusted_Connection=no;" +
                                       "Database=SuperSmashBros;" +
                                       "connection timeout=30;" +
                                       "TrustServerCertificate=true";

            SqlConnection connection = null;
            SqlDataReader sdr = null;

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string cmd = "LoginPlayer";
                //"SELECT * " +
                //"FROM PLAYER AS p " +
                //"WHERE p.Username = \'" + username + "\' AND p.Password = \'" + password + "\'";

                SqlCommand command = new SqlCommand(cmd, connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter retval = new SqlParameter("@Return_Value", SqlDbType.Int);
                retval.Direction = ParameterDirection.ReturnValue;
                retval.Value = -1;

                command.Parameters.Add(new SqlParameter("@pUsername", username));
                command.Parameters.Add(new SqlParameter("@pPassword", password));
                command.Parameters.Add(retval);

                command.ExecuteNonQuery();

                int success = Int32.Parse(retval.Value.ToString());

                if (success > 0)
                {
                    connection.Close();
                    connection.Dispose();
                    MainPage main = new MainPage(this, username, password);
                    main.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Login failed.  Try again or register!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (null != connection)
                {
                    connection.Close();
                    connection.Dispose();
                }
                if (null != sdr)
                {
                    sdr.Close();
                }
            }
        }
        #endregion

        #region registerButton Event
        private void registerButton_Click(object sender, EventArgs e)
        {
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

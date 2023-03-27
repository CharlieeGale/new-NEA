using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace CAN_Software
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;

                CreateParams restrictClose = base.CreateParams;
                restrictClose.ClassStyle |= CS_NOCLOSE;
                return restrictClose;
            }
        }

        private void loginPage_Load(object sender, EventArgs e)
        {

        }
        static string hashPassword(String password)
        {

            string hashedResult = "";
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                foreach (byte h in hashedValue)
                {
                    hashedResult += $"{h:X2}";
                }
            }
            return hashedResult;
        }
        private bool loginCheck(string userLogin, string hashedPassword)
        {
            const string loginCheck = @"SELECT * from logins l WHERE l.userName = @userLogin AND l.userPassword = @hashedPassword;"; //creates an sql query to execute
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(loginCheck, connection))
            {
                command.Parameters.Add("@userLogin", SqlDbType.VarChar, 255).Value = userLogin;
                command.Parameters.Add("@hashedPassword", SqlDbType.VarChar, 255).Value = hashedPassword;
                connection.Open();
                using (SqlDataReader myReader = command.ExecuteReader())
                {
                    var isValid = myReader.Read();    // was there at least one row?
                    return isValid;
                }
            }
        }
        private bool priorityCheck(string userLogin, string hashedPassword)
        {
            {
                const string priorityCheck = @"SELECT * from logins l WHERE l.userName = @username AND l.userPassword = @hashedPassword AND l.priorityLevel = 1"; //creates an sql query to execute
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(priorityCheck, connection))
                {

                    command.Parameters.Add("@username", SqlDbType.VarChar, 255).Value = userLogin;
                    command.Parameters.Add("@hashedPassword", SqlDbType.VarChar, 255).Value = hashedPassword;
                    connection.Open();
                    using (SqlDataReader myReader = command.ExecuteReader())
                    {
                        var isValid = myReader.Read();    // was there at least one row?
                        return isValid;
                    }
                }
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = hashPassword(passwordBox.Text);
            bool detailCheck = loginCheck(username, password);
            if (detailCheck)
            {
                this.Close();
            }
            else
            {
                failedLogin();
            }
        }
        private void failedLogin()
        {
            failedLoginPage failedLogin = new failedLoginPage();
            failedLogin.Activate();
            failedLogin.ShowDialog();
        }
        private bool duplicateCheck(string username)
        {

            const string priorityCheck = @"SELECT * from logins l WHERE l.userName = @username"; //creates an sql query to execute
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(priorityCheck, connection))
            {

                command.Parameters.Add("@username", SqlDbType.VarChar, 255).Value = username;
                connection.Open();
                using (SqlDataReader myReader = command.ExecuteReader())
                {
                    var isValid = myReader.Read();    // was there at least one row?
                    return isValid;
                }
            }
        }
        private void newLoginButton_Click(object sender, EventArgs e)
        {


            string username = usernameBox.Text;
            string password = hashPassword(passwordBox.Text);
            string newUsername = newUsernameBox.Text;
            string newPassword = hashPassword(newPasswordBox.Text);
            bool priorityChecker = priorityCheck(username, password);
            if (priorityChecker && newUsername.Length > 0 && newPassword.Length > 0)
            {
                
                string newLoginInsert = "INSERT INTO logins (userName, userPassword, priorityLevel)VALUES (@username,@password,0);";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(newLoginInsert, connection))
                {
                    command.Parameters.Add("@username", SqlDbType.VarChar, 255).Value = newUsername;
                    command.Parameters.Add("@password", SqlDbType.VarChar, 255).Value = newPassword;
                    connection.Open();
                    using (SqlDataReader myReader = command.ExecuteReader())
                    {
                        newLogin successfulLoginAdded = new newLogin();
                        successfulLoginAdded.Activate();
                        successfulLoginAdded.ShowDialog();
                    }
                }
            }
            else
            {
                if (newUsername.Length < 0 || newPassword.Length < 0 || duplicateCheck(newUsername))
                {
                    failedLogin();
                }
				else
				{
                    bool details = loginCheck(username, password);
                    if (details)
                    {
                        failedPriority priorityTooLow = new failedPriority();
                        priorityTooLow.Activate();
                        priorityTooLow.ShowDialog();
                    }
                    else
                    {
                        failedLogin();
                    }
                }
            }
               
            }

            private void p_Click(object sender, EventArgs e)
            {

            }
        }
    }


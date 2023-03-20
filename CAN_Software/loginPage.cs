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
		}
        string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";


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
        bool loginCheck(string userLogin, string hashedPassword)
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
                failedLoginPage failedLogin = new failedLoginPage();
                failedLogin.Activate();
                failedLogin.ShowDialog();
            }
		}
	}
}

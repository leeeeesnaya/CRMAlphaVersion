using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CRMAlphaVersion
{
    public partial class Authentication : Form
    {
        public string UserName { get; set; }

        public string UserPosition { get; set; }

        public Authentication()
        {
            InitializeComponent();
        }


        private void Authentication_Load(object sender, EventArgs e)
        {
            LoginUser.Text = Properties.Settings.Default.Email;
            PasswordUser.Text = Properties.Settings.Default.Password;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Email) && !string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                rememberPassLog.Checked = true;
                SaveLogin();
            }
            else
            {
                rememberPassLog.Checked = false;
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            var lgnUser = LoginUser.Text;
            var passUser = PasswordUser.Text;

            DataBase dataBase = new DataBase();

            (string password, string userName, string userPosition) = GetUserCredentialsFromDatabase(dataBase, lgnUser);

            if (password != null && PasswordHasher.VerifyPassword(passUser, password))
            {
                SaveLogin();
                Main mainForm = new Main(userName, userPosition);
                this.Hide();
                mainForm.FormClosed += (s, args) => { this.Close(); };
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Please make sure your password is correct!", "Error Authorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveLogin()
        {
            if (rememberPassLog.Checked)
            {
                Properties.Settings.Default.Email = LoginUser.Text;
                Properties.Settings.Default.Password = PasswordUser.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Email = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
                Properties.Settings.Default.Save();
            }
        }

        private (string Password, string UserName, string userPosition) GetUserCredentialsFromDatabase(DataBase dataBase, string lgnUser)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dataBase.GetConnection().ConnectionString))
                {
                    connection.Open();

                    string queryString = "SELECT PasswordUser, NameUser, Position FROM Users WHERE EmailUser = @EmailUser";
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        command.Parameters.AddWithValue("@EmailUser", lgnUser);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string password = reader["PasswordUser"].ToString();
                                string userName = reader["NameUser"].ToString();
                                string userPosition = reader["Position"].ToString();

                                return (password, userName, userPosition);
                            }
                            else
                            {
                                // Вернуть значения по умолчанию, если пользователя не найдено
                                return (null, null, null);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при выполнении запроса: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null, null);
            }
        }

        private string GetUserPasswordFromDatabase(DataBase dataBase, string lgnUser)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dataBase.GetConnection().ConnectionString))
                {
                    connection.Open();

                    string queryString = "SELECT PasswordUser FROM Users WHERE EmailUser = @EmailUser";
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        command.Parameters.AddWithValue("@EmailUser", lgnUser);

                        object result = command.ExecuteScalar();

                        return result != null ? result.ToString() : null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при выполнении запроса: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void LoginUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

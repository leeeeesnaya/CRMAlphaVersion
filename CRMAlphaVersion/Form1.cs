using System;
using System.Text;
using System.Windows.Forms;
using Atlassian.Jira;
using OtpNet;
using System.Data.SqlClient;

namespace CRMAlphaVersion
{
    public partial class Form1 : Form
    {
        private Jira _jira;
        private AuthenticatorService authenticatorService;
        DataBase dataBase;

        public Form1()
        {
            InitializeComponent();
            authenticatorService = new AuthenticatorService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void SupportRequest_Click(object sender, EventArgs e)
        {
            SupportRequest newForm = new SupportRequest();
            newForm.Show();
        }

        private void GenerateKey_Click(object sender, EventArgs e)
        {
            string licenseKey = GenerateLicenseKey();
            textBox1.Text = licenseKey;
            Clipboard.SetText(textBox1.Text);
        }

        public static string GenerateLicenseKey()
        {
            int groupLength = 4;
            int totalLength = 20;

            // Генерируем случайные символы
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            StringBuilder keyBuilder = new StringBuilder();

            Random random = new Random();

            for (int i = 0; i < totalLength; i++)
            {
                if (i > 0 && i % groupLength == 0)
                {
                    keyBuilder.Append("-");
                }

                char randomChar = chars[random.Next(chars.Length)];
                keyBuilder.Append(randomChar);
            }

            return keyBuilder.ToString();
        }


        public class AuthenticatorService
        {
            private string GenerateSecretKey()
            {
                var key = KeyGeneration.GenerateRandomKey();
                return Base32Encoding.ToString(key);
            }

            public string GetSecretKey()
            {
                return GenerateSecretKey();
            }

            public string GenerateTotp(string secretKey)
            {
                var totp = new Totp(Base32Encoding.ToBytes(secretKey));
                return totp.ComputeTotp();
            }
        }

        private void GenerateSecretKey_Click(object sender, EventArgs e)
        {
            TestAuthenticator newForm = new TestAuthenticator();
            newForm.Show();
        }

        private void GenerateTotp_Click(object sender, EventArgs e)
        {
            string secretKey = "your-secret-key-here"; // Замените на реальный секретный ключ
            string totp = authenticatorService.GenerateTotp(secretKey);
            MessageBox.Show($"Generated TOTP: {totp}");
        }

        private void GeneratePassword_Click(object sender, EventArgs e)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(DefaultPassword.Text, salt);

            GeneratePasswordStr.Text =  hashedPassword;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            var lgnUser = LoginUser.Text;
            var passUser = PasswordUser.Text;

            DataBase dataBase = new DataBase();

            string storedHashedPassword = GetUserPasswordFromDatabase(dataBase, lgnUser);

            if (storedHashedPassword != null && PasswordHasher.VerifyPassword(passUser, storedHashedPassword))
            {
                MessageBox.Show("Успех успешный", "Успешная авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Лох ебаный", "Авторизация отклонена", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetUserPasswordFromDatabase(DataBase dataBase, string lgnUser)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dataBase.GetConnection().ConnectionString))
                {
                    connection.Open();

                    string queryString = "SELECT PasswordUser FROM Users WHERE NameUser = @NameUser";
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        command.Parameters.AddWithValue("@NameUser", lgnUser);

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
    }
}

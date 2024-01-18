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
        //Отправка письмом внутри приложения (под вопросом). Возможность сделать небольшие уведомление или что-то подобное, для того
        //Чтобы можно было отправить письмо с генерированным ключом.
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

        //Привязать под каждую учетную запись, сделать как второй этап входа в аккаунт и настроить правильное отображение.
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


        //Уже не помню для чего это, позже пересмотреть
        private void GenerateTotp_Click(object sender, EventArgs e)
        {
            string secretKey = "your-secret-key-here"; // Замените на реальный секретный ключ
            string totp = authenticatorService.GenerateTotp(secretKey);
            MessageBox.Show($"Generated TOTP: {totp}");
        }


        //Генерация хэш пароля, используем также и для сброса пароля, позже и для задавания нового пароля пользователем
        private void GeneratePassword_Click(object sender, EventArgs e)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(DefaultPassword.Text, salt);

            GeneratePasswordStr.Text =  hashedPassword;
        }

        private void GeneratePasswordStr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

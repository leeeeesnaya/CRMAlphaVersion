using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atlassian.Jira;
using Atlassian.Jira.Remote;
using Newtonsoft.Json;
using OtpNet;

namespace CRMAlphaVersion
{
    public partial class Form1 : Form
    {
        private Jira _jira;
        private AuthenticatorService authenticatorService;

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
            //string secretKey = authenticatorService.GetSecretKey();
            //MessageBox.Show($"Generated Secret Key: {secretKey}");
            TestAuthenticator newForm = new TestAuthenticator();
            newForm.Show();
        }

        private void GenerateTotp_Click(object sender, EventArgs e)
        {
            string secretKey = "your-secret-key-here"; // Замените на реальный секретный ключ
            string totp = authenticatorService.GenerateTotp(secretKey);
            MessageBox.Show($"Generated TOTP: {totp}");
        }
    }
}

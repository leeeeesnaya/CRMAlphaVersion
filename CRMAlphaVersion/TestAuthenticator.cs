using System;
using System.Drawing;
using System.Windows.Forms;
using OtpNet;
using QRCoder;

namespace CRMAlphaVersion
{
    public partial class TestAuthenticator : Form
    {
        public TestAuthenticator()
        {
            InitializeComponent();
        }

        private void GenerateSecretKey_Click(object sender, EventArgs e)
        {
            var secretKey = KeyGeneration.GenerateRandomKey(20);

            var secretKeyString = Base32Encoding.ToString(secretKey);

            CopyKey.Text = secretKeyString;
            Clipboard.SetText(CopyKey.Text);
        }

        private void GenerateTotp_Click(object sender, EventArgs e)
        {
            var secretKeyString = SecretKey.Text;
            var userEnteredCode = CodeAUTH.Text; // Предположим, что код вводится пользователем.

            var secretKey = Base32Encoding.ToBytes(secretKeyString);
            var totp = new Totp(secretKey);

            // Проверка совпадения введенного кода с текущим временным кодом
            bool isCodeValid = totp.VerifyTotp(userEnteredCode, out long timeStepMatched);

            if (isCodeValid)
            {
                MessageBox.Show("Код верен!");
            }
            else
            {
                MessageBox.Show("Код неверен.");
            }
        }

        private void qrcode_Click(object sender, EventArgs e)
        {
            string secretKey = SecretKey.Text;
            string issuer = "CRM Alpha";
            string accountName = "user@example.com";

            string totpUri = GenerateTotpUri(secretKey, issuer, accountName);

            // Генерация QR-кода
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(totpUri, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20); 

            pictureBoxQRCode.Image = qrCodeImage;
            pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        static string GenerateTotpUri(string secretKey, string issuer, string accountName)
        {
            return $"otpauth://totp/{Uri.EscapeDataString(issuer)}:{Uri.EscapeDataString(accountName)}?secret={secretKey}&issuer={Uri.EscapeDataString(issuer)}";
        }
    }
}

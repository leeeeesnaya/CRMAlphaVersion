namespace CRMAlphaVersion
{
    partial class TestAuthenticator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateTotp = new System.Windows.Forms.Button();
            this.GenerateSecretKey = new System.Windows.Forms.Button();
            this.SecretKey = new System.Windows.Forms.TextBox();
            this.CopyKey = new System.Windows.Forms.TextBox();
            this.CodeAUTH = new System.Windows.Forms.TextBox();
            this.qrcode = new System.Windows.Forms.Button();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateTotp
            // 
            this.GenerateTotp.Location = new System.Drawing.Point(69, 145);
            this.GenerateTotp.Name = "GenerateTotp";
            this.GenerateTotp.Size = new System.Drawing.Size(51, 47);
            this.GenerateTotp.TabIndex = 11;
            this.GenerateTotp.Text = "GTP";
            this.GenerateTotp.UseVisualStyleBackColor = true;
            this.GenerateTotp.Click += new System.EventHandler(this.GenerateTotp_Click);
            // 
            // GenerateSecretKey
            // 
            this.GenerateSecretKey.Location = new System.Drawing.Point(12, 145);
            this.GenerateSecretKey.Name = "GenerateSecretKey";
            this.GenerateSecretKey.Size = new System.Drawing.Size(51, 47);
            this.GenerateSecretKey.TabIndex = 10;
            this.GenerateSecretKey.Text = "GSK";
            this.GenerateSecretKey.UseVisualStyleBackColor = true;
            this.GenerateSecretKey.Click += new System.EventHandler(this.GenerateSecretKey_Click);
            // 
            // SecretKey
            // 
            this.SecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecretKey.Location = new System.Drawing.Point(126, 157);
            this.SecretKey.Name = "SecretKey";
            this.SecretKey.Size = new System.Drawing.Size(262, 22);
            this.SecretKey.TabIndex = 12;
            // 
            // CopyKey
            // 
            this.CopyKey.Enabled = false;
            this.CopyKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyKey.Location = new System.Drawing.Point(126, 185);
            this.CopyKey.Name = "CopyKey";
            this.CopyKey.ReadOnly = true;
            this.CopyKey.Size = new System.Drawing.Size(262, 22);
            this.CopyKey.TabIndex = 13;
            // 
            // CodeAUTH
            // 
            this.CodeAUTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeAUTH.Location = new System.Drawing.Point(126, 129);
            this.CodeAUTH.Name = "CodeAUTH";
            this.CodeAUTH.Size = new System.Drawing.Size(262, 22);
            this.CodeAUTH.TabIndex = 14;
            // 
            // qrcode
            // 
            this.qrcode.Location = new System.Drawing.Point(69, 198);
            this.qrcode.Name = "qrcode";
            this.qrcode.Size = new System.Drawing.Size(51, 47);
            this.qrcode.TabIndex = 15;
            this.qrcode.Text = "GTP";
            this.qrcode.UseVisualStyleBackColor = true;
            this.qrcode.Click += new System.EventHandler(this.qrcode_Click);
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(126, 213);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(251, 194);
            this.pictureBoxQRCode.TabIndex = 16;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // TestAuthenticator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.qrcode);
            this.Controls.Add(this.CodeAUTH);
            this.Controls.Add(this.CopyKey);
            this.Controls.Add(this.SecretKey);
            this.Controls.Add(this.GenerateTotp);
            this.Controls.Add(this.GenerateSecretKey);
            this.Name = "TestAuthenticator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestAuthenticator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateTotp;
        private System.Windows.Forms.Button GenerateSecretKey;
        private System.Windows.Forms.TextBox SecretKey;
        private System.Windows.Forms.TextBox CopyKey;
        private System.Windows.Forms.TextBox CodeAUTH;
        private System.Windows.Forms.Button qrcode;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
    }
}
namespace CRMAlphaVersion
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SupportRequest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.PasswordUser = new System.Windows.Forms.TextBox();
            this.LoginUser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GenerateKey = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GenerateSecretKey = new System.Windows.Forms.Button();
            this.GenerateTotp = new System.Windows.Forms.Button();
            this.GeneratePasswordStr = new System.Windows.Forms.TextBox();
            this.GeneratePassword = new System.Windows.Forms.Button();
            this.DefaultPassword = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SupportRequest
            // 
            this.SupportRequest.Location = new System.Drawing.Point(201, 62);
            this.SupportRequest.Name = "SupportRequest";
            this.SupportRequest.Size = new System.Drawing.Size(51, 47);
            this.SupportRequest.TabIndex = 3;
            this.SupportRequest.Text = "Test";
            this.SupportRequest.UseVisualStyleBackColor = true;
            this.SupportRequest.Click += new System.EventHandler(this.SupportRequest_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.ConnectButton);
            this.panel2.Controls.Add(this.PasswordUser);
            this.panel2.Controls.Add(this.LoginUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 394);
            this.panel2.TabIndex = 5;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 140);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(170, 25);
            this.ConnectButton.TabIndex = 13;
            this.ConnectButton.Text = "GP";
            this.ConnectButton.UseVisualStyleBackColor = true;
            // 
            // PasswordUser
            // 
            this.PasswordUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordUser.Location = new System.Drawing.Point(12, 112);
            this.PasswordUser.Name = "PasswordUser";
            this.PasswordUser.Size = new System.Drawing.Size(170, 22);
            this.PasswordUser.TabIndex = 14;
            // 
            // LoginUser
            // 
            this.LoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginUser.Location = new System.Drawing.Point(12, 84);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.Size = new System.Drawing.Size(170, 22);
            this.LoginUser.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 4;
            // 
            // GenerateKey
            // 
            this.GenerateKey.Location = new System.Drawing.Point(201, 115);
            this.GenerateKey.Name = "GenerateKey";
            this.GenerateKey.Size = new System.Drawing.Size(51, 47);
            this.GenerateKey.TabIndex = 6;
            this.GenerateKey.Text = "GK";
            this.GenerateKey.UseVisualStyleBackColor = true;
            this.GenerateKey.Click += new System.EventHandler(this.GenerateKey_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(258, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 7;
            // 
            // GenerateSecretKey
            // 
            this.GenerateSecretKey.Location = new System.Drawing.Point(201, 309);
            this.GenerateSecretKey.Name = "GenerateSecretKey";
            this.GenerateSecretKey.Size = new System.Drawing.Size(51, 47);
            this.GenerateSecretKey.TabIndex = 8;
            this.GenerateSecretKey.Text = "GSK";
            this.GenerateSecretKey.UseVisualStyleBackColor = true;
            this.GenerateSecretKey.Click += new System.EventHandler(this.GenerateSecretKey_Click);
            // 
            // GenerateTotp
            // 
            this.GenerateTotp.Location = new System.Drawing.Point(258, 309);
            this.GenerateTotp.Name = "GenerateTotp";
            this.GenerateTotp.Size = new System.Drawing.Size(51, 47);
            this.GenerateTotp.TabIndex = 9;
            this.GenerateTotp.Text = "GTP";
            this.GenerateTotp.UseVisualStyleBackColor = true;
            this.GenerateTotp.Click += new System.EventHandler(this.GenerateTotp_Click);
            // 
            // GeneratePasswordStr
            // 
            this.GeneratePasswordStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneratePasswordStr.Location = new System.Drawing.Point(618, 297);
            this.GeneratePasswordStr.Name = "GeneratePasswordStr";
            this.GeneratePasswordStr.Size = new System.Drawing.Size(170, 22);
            this.GeneratePasswordStr.TabIndex = 10;
            this.GeneratePasswordStr.TextChanged += new System.EventHandler(this.GeneratePasswordStr_TextChanged);
            // 
            // GeneratePassword
            // 
            this.GeneratePassword.Location = new System.Drawing.Point(561, 297);
            this.GeneratePassword.Name = "GeneratePassword";
            this.GeneratePassword.Size = new System.Drawing.Size(51, 50);
            this.GeneratePassword.TabIndex = 11;
            this.GeneratePassword.Text = "GP";
            this.GeneratePassword.UseVisualStyleBackColor = true;
            this.GeneratePassword.Click += new System.EventHandler(this.GeneratePassword_Click);
            // 
            // DefaultPassword
            // 
            this.DefaultPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefaultPassword.Location = new System.Drawing.Point(618, 325);
            this.DefaultPassword.Name = "DefaultPassword";
            this.DefaultPassword.Size = new System.Drawing.Size(170, 22);
            this.DefaultPassword.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DefaultPassword);
            this.Controls.Add(this.GeneratePassword);
            this.Controls.Add(this.GeneratePasswordStr);
            this.Controls.Add(this.GenerateTotp);
            this.Controls.Add(this.GenerateSecretKey);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GenerateKey);
            this.Controls.Add(this.SupportRequest);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flame CRM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SupportRequest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GenerateKey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GenerateSecretKey;
        private System.Windows.Forms.Button GenerateTotp;
        private System.Windows.Forms.TextBox GeneratePasswordStr;
        private System.Windows.Forms.Button GeneratePassword;
        private System.Windows.Forms.TextBox DefaultPassword;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox PasswordUser;
        private System.Windows.Forms.TextBox LoginUser;
    }
}


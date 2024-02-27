namespace CRMAlphaVersion
{
    partial class Authentication
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
            this.PasswordUser = new System.Windows.Forms.TextBox();
            this.LoginUser = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rememberPassLog = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.connectButton = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonClck = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxPASS = new System.Windows.Forms.TextBox();
            this.textBoxHASH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PasswordUser
            // 
            this.PasswordUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordUser.Location = new System.Drawing.Point(75, 295);
            this.PasswordUser.Name = "PasswordUser";
            this.PasswordUser.PasswordChar = '*';
            this.PasswordUser.Size = new System.Drawing.Size(325, 29);
            this.PasswordUser.TabIndex = 17;
            // 
            // LoginUser
            // 
            this.LoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginUser.Location = new System.Drawing.Point(75, 230);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.Size = new System.Drawing.Size(325, 29);
            this.LoginUser.TabIndex = 16;
            this.LoginUser.TextChanged += new System.EventHandler(this.LoginUser_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Email.Location = new System.Drawing.Point(75, 200);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(57, 24);
            this.Email.TabIndex = 19;
            this.Email.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(75, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(295, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Forgot Password";
            // 
            // rememberPassLog
            // 
            this.rememberPassLog.AutoSize = true;
            this.rememberPassLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rememberPassLog.Location = new System.Drawing.Point(75, 335);
            this.rememberPassLog.Name = "rememberPassLog";
            this.rememberPassLog.Size = new System.Drawing.Size(162, 20);
            this.rememberPassLog.TabIndex = 22;
            this.rememberPassLog.Text = "Remember for 30 days";
            this.rememberPassLog.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(74, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Welcome back";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(75, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Welcome back! Please enter your details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(120, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Don\'t have an account? ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(265, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Sign up";
            // 
            // connectButton
            // 
            this.connectButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.connectButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.connectButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.connectButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.connectButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.connectButton.ForeColor = System.Drawing.Color.White;
            this.connectButton.Location = new System.Drawing.Point(75, 367);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(329, 45);
            this.connectButton.TabIndex = 27;
            this.connectButton.Text = "Sign In";
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ButtonClck
            // 
            this.ButtonClck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonClck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonClck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonClck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonClck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonClck.ForeColor = System.Drawing.Color.White;
            this.ButtonClck.Location = new System.Drawing.Point(524, 344);
            this.ButtonClck.Name = "ButtonClck";
            this.ButtonClck.Size = new System.Drawing.Size(329, 45);
            this.ButtonClck.TabIndex = 30;
            this.ButtonClck.Text = "Sign In";
            this.ButtonClck.Click += new System.EventHandler(this.ButtonClck_Click);
            // 
            // textBoxPASS
            // 
            this.textBoxPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPASS.Location = new System.Drawing.Point(524, 230);
            this.textBoxPASS.Name = "textBoxPASS";
            this.textBoxPASS.Size = new System.Drawing.Size(325, 29);
            this.textBoxPASS.TabIndex = 28;
            // 
            // textBoxHASH
            // 
            this.textBoxHASH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHASH.Location = new System.Drawing.Point(528, 295);
            this.textBoxHASH.Name = "textBoxHASH";
            this.textBoxHASH.Size = new System.Drawing.Size(325, 29);
            this.textBoxHASH.TabIndex = 31;
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.textBoxHASH);
            this.Controls.Add(this.ButtonClck);
            this.Controls.Add(this.textBoxPASS);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rememberPassLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PasswordUser);
            this.Controls.Add(this.LoginUser);
            this.MaximizeBox = false;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flame CRM";
            this.Load += new System.EventHandler(this.Authentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PasswordUser;
        private System.Windows.Forms.TextBox LoginUser;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rememberPassLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button connectButton;
        private Guna.UI2.WinForms.Guna2Button ButtonClck;
        private System.Windows.Forms.TextBox textBoxPASS;
        private System.Windows.Forms.TextBox textBoxHASH;
    }
}
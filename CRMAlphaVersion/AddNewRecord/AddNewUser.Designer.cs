namespace CRMAlphaVersion
{
    partial class AddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.organization = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.firstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pos = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.mobilePhoneUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailaddress = new System.Windows.Forms.Label();
            this.Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.passwordUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.organizationUser = new System.Windows.Forms.ComboBox();
            this.positionUser = new System.Windows.Forms.ComboBox();
            this.stat = new System.Windows.Forms.Label();
            this.statusAcc = new System.Windows.Forms.ComboBox();
            this.birthday = new System.Windows.Forms.Label();
            this.secondName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.secName = new System.Windows.Forms.Label();
            this.thirdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.birthdayUser = new System.Windows.Forms.MonthCalendar();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.anotherButton = new Guna.UI2.WinForms.Guna2Button();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Додати нового користувача";
            // 
            // organization
            // 
            this.organization.AutoSize = true;
            this.organization.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organization.Location = new System.Drawing.Point(25, 425);
            this.organization.Name = "organization";
            this.organization.Size = new System.Drawing.Size(185, 21);
            this.organization.TabIndex = 2;
            this.organization.Text = "Організація працівників";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(30, 115);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(37, 21);
            this.Name.TabIndex = 4;
            this.Name.Text = "Ім\'я";
            // 
            // firstName
            // 
            this.firstName.BorderRadius = 5;
            this.firstName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.firstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstName.DefaultText = "";
            this.firstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstName.Location = new System.Drawing.Point(25, 140);
            this.firstName.Name = "firstName";
            this.firstName.PasswordChar = '\0';
            this.firstName.PlaceholderForeColor = System.Drawing.Color.DarkOrange;
            this.firstName.PlaceholderText = "Повне ім\'я користувача";
            this.firstName.SelectedText = "";
            this.firstName.Size = new System.Drawing.Size(250, 35);
            this.firstName.TabIndex = 3;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // pos
            // 
            this.pos.AutoSize = true;
            this.pos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos.Location = new System.Drawing.Point(231, 425);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(146, 21);
            this.pos.TabIndex = 6;
            this.pos.Text = "Позиція в компанії";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(30, 350);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(153, 21);
            this.phone.TabIndex = 8;
            this.phone.Text = "Мобільний телефон";
            // 
            // mobilePhoneUser
            // 
            this.mobilePhoneUser.BorderRadius = 5;
            this.mobilePhoneUser.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.mobilePhoneUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mobilePhoneUser.DefaultText = "";
            this.mobilePhoneUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mobilePhoneUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mobilePhoneUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mobilePhoneUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mobilePhoneUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mobilePhoneUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mobilePhoneUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mobilePhoneUser.Location = new System.Drawing.Point(25, 375);
            this.mobilePhoneUser.MaxLength = 12;
            this.mobilePhoneUser.Name = "mobilePhoneUser";
            this.mobilePhoneUser.PasswordChar = '\0';
            this.mobilePhoneUser.PlaceholderForeColor = System.Drawing.Color.DarkOrange;
            this.mobilePhoneUser.PlaceholderText = "+380668889900";
            this.mobilePhoneUser.SelectedText = "";
            this.mobilePhoneUser.Size = new System.Drawing.Size(225, 35);
            this.mobilePhoneUser.TabIndex = 7;
            // 
            // emailaddress
            // 
            this.emailaddress.AutoSize = true;
            this.emailaddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailaddress.Location = new System.Drawing.Point(30, 195);
            this.emailaddress.Name = "emailaddress";
            this.emailaddress.Size = new System.Drawing.Size(145, 21);
            this.emailaddress.TabIndex = 10;
            this.emailaddress.Text = "Поштова скринька";
            // 
            // Email
            // 
            this.Email.BorderRadius = 5;
            this.Email.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.DefaultText = "";
            this.Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.Location = new System.Drawing.Point(25, 220);
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.PlaceholderForeColor = System.Drawing.Color.DarkOrange;
            this.Email.PlaceholderText = "test@gmail.com";
            this.Email.SelectedText = "";
            this.Email.Size = new System.Drawing.Size(406, 36);
            this.Email.TabIndex = 9;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.Location = new System.Drawing.Point(30, 270);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(157, 21);
            this.pass.TabIndex = 12;
            this.pass.Text = "Пароль користувача";
            // 
            // passwordUser
            // 
            this.passwordUser.BorderRadius = 5;
            this.passwordUser.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.passwordUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordUser.DefaultText = "";
            this.passwordUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordUser.Location = new System.Drawing.Point(26, 295);
            this.passwordUser.Name = "passwordUser";
            this.passwordUser.PasswordChar = '\0';
            this.passwordUser.PlaceholderForeColor = System.Drawing.Color.DarkOrange;
            this.passwordUser.PlaceholderText = "66pV,CA#x8P3";
            this.passwordUser.SelectedText = "";
            this.passwordUser.Size = new System.Drawing.Size(406, 36);
            this.passwordUser.TabIndex = 11;
            // 
            // organizationUser
            // 
            this.organizationUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organizationUser.FormattingEnabled = true;
            this.organizationUser.Location = new System.Drawing.Point(25, 450);
            this.organizationUser.Name = "organizationUser";
            this.organizationUser.Size = new System.Drawing.Size(200, 25);
            this.organizationUser.TabIndex = 13;
            this.organizationUser.SelectedIndexChanged += new System.EventHandler(this.organizationUser_SelectedIndexChanged);
            // 
            // positionUser
            // 
            this.positionUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionUser.FormattingEnabled = true;
            this.positionUser.Items.AddRange(new object[] {
            "SuperAdministator",
            "Administrator",
            "Call-center",
            "Account Manager"});
            this.positionUser.Location = new System.Drawing.Point(230, 450);
            this.positionUser.Name = "positionUser";
            this.positionUser.Size = new System.Drawing.Size(200, 25);
            this.positionUser.TabIndex = 14;
            // 
            // stat
            // 
            this.stat.AutoSize = true;
            this.stat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stat.Location = new System.Drawing.Point(437, 425);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(125, 21);
            this.stat.TabIndex = 16;
            this.stat.Text = "Статус аккаунту";
            // 
            // statusAcc
            // 
            this.statusAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusAcc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAcc.FormattingEnabled = true;
            this.statusAcc.Items.AddRange(new object[] {
            "Active",
            "Unactive"});
            this.statusAcc.Location = new System.Drawing.Point(435, 450);
            this.statusAcc.Name = "statusAcc";
            this.statusAcc.Size = new System.Drawing.Size(200, 25);
            this.statusAcc.TabIndex = 17;
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthday.Location = new System.Drawing.Point(545, 195);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(138, 21);
            this.birthday.TabIndex = 18;
            this.birthday.Text = "Дата народження";
            // 
            // secondName
            // 
            this.secondName.BorderRadius = 5;
            this.secondName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.secondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secondName.DefaultText = "";
            this.secondName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.secondName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.secondName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secondName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secondName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secondName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.secondName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secondName.Location = new System.Drawing.Point(285, 140);
            this.secondName.Name = "secondName";
            this.secondName.PasswordChar = '\0';
            this.secondName.PlaceholderForeColor = System.Drawing.Color.DarkOrange;
            this.secondName.PlaceholderText = "Прізвище користувача";
            this.secondName.SelectedText = "";
            this.secondName.Size = new System.Drawing.Size(250, 35);
            this.secondName.TabIndex = 19;
            this.secondName.TextChanged += new System.EventHandler(this.secondName_TextChanged);
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(285, 115);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(79, 21);
            this.Surname.TabIndex = 20;
            this.Surname.Text = "Прізвище";
            // 
            // secName
            // 
            this.secName.AutoSize = true;
            this.secName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secName.Location = new System.Drawing.Point(545, 115);
            this.secName.Name = "secName";
            this.secName.Size = new System.Drawing.Size(97, 21);
            this.secName.TabIndex = 22;
            this.secName.Text = "По-батькові";
            // 
            // thirdName
            // 
            this.thirdName.BorderRadius = 5;
            this.thirdName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.thirdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.thirdName.DefaultText = "";
            this.thirdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.thirdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.thirdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thirdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thirdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thirdName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.thirdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thirdName.Location = new System.Drawing.Point(545, 140);
            this.thirdName.Name = "thirdName";
            this.thirdName.PasswordChar = '\0';
            this.thirdName.PlaceholderForeColor = System.Drawing.Color.DarkOrange;
            this.thirdName.PlaceholderText = "По-батькові користувача";
            this.thirdName.SelectedText = "";
            this.thirdName.Size = new System.Drawing.Size(250, 35);
            this.thirdName.TabIndex = 21;
            // 
            // birthdayUser
            // 
            this.birthdayUser.Location = new System.Drawing.Point(545, 225);
            this.birthdayUser.Name = "birthdayUser";
            this.birthdayUser.TabIndex = 24;
            this.birthdayUser.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.birthdayUser_DateChanged);
            // 
            // saveButton
            // 
            this.saveButton.Animated = true;
            this.saveButton.BorderColor = System.Drawing.Color.Gray;
            this.saveButton.BorderThickness = 1;
            this.saveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveButton.FillColor = System.Drawing.Color.Transparent;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.saveButton.ImageOffset = new System.Drawing.Point(2, 0);
            this.saveButton.Location = new System.Drawing.Point(25, 525);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 50);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Додати";
            this.saveButton.TextOffset = new System.Drawing.Point(7, 0);
            this.saveButton.Click += new System.EventHandler(this.addUser_Click);
            // 
            // anotherButton
            // 
            this.anotherButton.Animated = true;
            this.anotherButton.BorderColor = System.Drawing.Color.Gray;
            this.anotherButton.BorderThickness = 1;
            this.anotherButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.anotherButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.anotherButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.anotherButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.anotherButton.FillColor = System.Drawing.Color.Transparent;
            this.anotherButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.anotherButton.ForeColor = System.Drawing.Color.Black;
            this.anotherButton.Image = ((System.Drawing.Image)(resources.GetObject("anotherButton.Image")));
            this.anotherButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.anotherButton.ImageOffset = new System.Drawing.Point(2, 0);
            this.anotherButton.Location = new System.Drawing.Point(325, 525);
            this.anotherButton.Name = "anotherButton";
            this.anotherButton.Size = new System.Drawing.Size(150, 50);
            this.anotherButton.TabIndex = 26;
            this.anotherButton.Text = "Додати ще одного";
            this.anotherButton.TextOffset = new System.Drawing.Point(12, 0);
            this.anotherButton.Click += new System.EventHandler(this.anotherButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Animated = true;
            this.cancelButton.BorderColor = System.Drawing.Color.Gray;
            this.cancelButton.BorderThickness = 1;
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.FillColor = System.Drawing.Color.Transparent;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cancelButton.ImageOffset = new System.Drawing.Point(2, 0);
            this.cancelButton.Location = new System.Drawing.Point(645, 525);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 50);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Відмініти";
            this.cancelButton.TextOffset = new System.Drawing.Point(7, 0);
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.secondName);
            this.Controls.Add(this.secName);
            this.Controls.Add(this.thirdName);
            this.Controls.Add(this.emailaddress);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.passwordUser);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.mobilePhoneUser);
            this.Controls.Add(this.organization);
            this.Controls.Add(this.organizationUser);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.positionUser);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.statusAcc);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.birthdayUser);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.anotherButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewUser";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label organization;
        private System.Windows.Forms.Label Name;
        private Guna.UI2.WinForms.Guna2TextBox firstName;
        private System.Windows.Forms.Label pos;
        private System.Windows.Forms.Label phone;
        private Guna.UI2.WinForms.Guna2TextBox mobilePhoneUser;
        private System.Windows.Forms.Label emailaddress;
        private Guna.UI2.WinForms.Guna2TextBox Email;
        private System.Windows.Forms.Label pass;
        private Guna.UI2.WinForms.Guna2TextBox passwordUser;
        private System.Windows.Forms.ComboBox organizationUser;
        private System.Windows.Forms.ComboBox positionUser;
        private System.Windows.Forms.Label stat;
        private System.Windows.Forms.ComboBox statusAcc;
        private System.Windows.Forms.Label birthday;
        private Guna.UI2.WinForms.Guna2TextBox secondName;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label secName;
        private Guna.UI2.WinForms.Guna2TextBox thirdName;
        private System.Windows.Forms.MonthCalendar birthdayUser;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private Guna.UI2.WinForms.Guna2Button anotherButton;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
    }
}
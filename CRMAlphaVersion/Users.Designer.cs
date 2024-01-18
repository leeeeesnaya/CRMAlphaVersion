namespace CRMAlphaVersion
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.settingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.filterButton = new Guna.UI2.WinForms.Guna2Button();
            this.Birhday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityUsers = new System.Windows.Forms.Label();
            this.settingColumn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.quantity = new System.Windows.Forms.Label();
            this.StatusAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.Controls.Add(this.addUser);
            this.guna2Panel1.Controls.Add(this.quantity);
            this.guna2Panel1.Controls.Add(this.settingsButton);
            this.guna2Panel1.Controls.Add(this.filterButton);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1015, 65);
            this.guna2Panel1.TabIndex = 3;
            // 
            // settingsButton
            // 
            this.settingsButton.BorderColor = System.Drawing.Color.Gray;
            this.settingsButton.BorderThickness = 1;
            this.settingsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsButton.FillColor = System.Drawing.Color.Transparent;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingsButton.ForeColor = System.Drawing.Color.Black;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsButton.ImageOffset = new System.Drawing.Point(2, 0);
            this.settingsButton.Location = new System.Drawing.Point(780, 15);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(110, 35);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Setting";
            this.settingsButton.Click += new System.EventHandler(this.settingColumn_Click);
            // 
            // filterButton
            // 
            this.filterButton.BorderColor = System.Drawing.Color.Gray;
            this.filterButton.BorderThickness = 1;
            this.filterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.filterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.filterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.filterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.filterButton.FillColor = System.Drawing.Color.Transparent;
            this.filterButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterButton.ForeColor = System.Drawing.Color.Black;
            this.filterButton.Image = ((System.Drawing.Image)(resources.GetObject("filterButton.Image")));
            this.filterButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.filterButton.ImageOffset = new System.Drawing.Point(2, 0);
            this.filterButton.Location = new System.Drawing.Point(895, 15);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(110, 35);
            this.filterButton.TabIndex = 7;
            this.filterButton.Text = "Filter";
            // 
            // Birhday
            // 
            this.Birhday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Birhday.FillWeight = 0.9127185F;
            this.Birhday.HeaderText = "Дата народження";
            this.Birhday.Name = "Birhday";
            this.Birhday.ReadOnly = true;
            this.Birhday.Width = 125;
            // 
            // quantityUsers
            // 
            this.quantityUsers.AutoSize = true;
            this.quantityUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityUsers.ForeColor = System.Drawing.Color.DarkOrange;
            this.quantityUsers.Location = new System.Drawing.Point(15, 15);
            this.quantityUsers.Name = "quantityUsers";
            this.quantityUsers.Size = new System.Drawing.Size(49, 33);
            this.quantityUsers.TabIndex = 1;
            this.quantityUsers.Text = "75";
            // 
            // settingColumn
            // 
            this.settingColumn.BorderColor = System.Drawing.Color.Gray;
            this.settingColumn.BorderThickness = 1;
            this.settingColumn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingColumn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingColumn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingColumn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingColumn.FillColor = System.Drawing.Color.Transparent;
            this.settingColumn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingColumn.ForeColor = System.Drawing.Color.Black;
            this.settingColumn.Image = ((System.Drawing.Image)(resources.GetObject("settingColumn.Image")));
            this.settingColumn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingColumn.ImageOffset = new System.Drawing.Point(2, 0);
            this.settingColumn.Location = new System.Drawing.Point(785, 15);
            this.settingColumn.Name = "settingColumn";
            this.settingColumn.Size = new System.Drawing.Size(110, 35);
            this.settingColumn.TabIndex = 6;
            this.settingColumn.Text = "Setting";
            this.settingColumn.Click += new System.EventHandler(this.settingColumn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(2, 0);
            this.guna2Button1.Location = new System.Drawing.Point(900, 15);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(110, 35);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Users";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.ColumnHeadersHeight = 40;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusAcc,
            this.EmailUser,
            this.UsersID,
            this.NameUser,
            this.PhoneUser,
            this.Birthday});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dataGridViewUsers.Location = new System.Drawing.Point(20, 71);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowTemplate.Height = 40;
            this.dataGridViewUsers.Size = new System.Drawing.Size(985, 600);
            this.dataGridViewUsers.TabIndex = 1;
            this.dataGridViewUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dataGridViewUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dataGridViewUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridViewUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewUsers.ThemeStyle.ReadOnly = true;
            this.dataGridViewUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewUsers.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridViewUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quantity.Location = new System.Drawing.Point(15, 15);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(78, 32);
            this.quantity.TabIndex = 9;
            this.quantity.Text = "label2";
            // 
            // StatusAcc
            // 
            this.StatusAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StatusAcc.FillWeight = 18.31213F;
            this.StatusAcc.HeaderText = "Статус";
            this.StatusAcc.Name = "StatusAcc";
            this.StatusAcc.ReadOnly = true;
            this.StatusAcc.Width = 85;
            // 
            // EmailUser
            // 
            this.EmailUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmailUser.FillWeight = 5.781145F;
            this.EmailUser.HeaderText = "Email";
            this.EmailUser.Name = "EmailUser";
            this.EmailUser.ReadOnly = true;
            this.EmailUser.Width = 95;
            // 
            // UsersID
            // 
            this.UsersID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UsersID.FillWeight = 46.61516F;
            this.UsersID.HeaderText = "Код працівника";
            this.UsersID.Name = "UsersID";
            this.UsersID.ReadOnly = true;
            this.UsersID.Width = 75;
            // 
            // NameUser
            // 
            this.NameUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameUser.FillWeight = 120.9578F;
            this.NameUser.HeaderText = "Ім\'я працівника";
            this.NameUser.Name = "NameUser";
            this.NameUser.ReadOnly = true;
            this.NameUser.Width = 225;
            // 
            // PhoneUser
            // 
            this.PhoneUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PhoneUser.FillWeight = 0.9127185F;
            this.PhoneUser.HeaderText = "Номер телефону";
            this.PhoneUser.Name = "PhoneUser";
            this.PhoneUser.ReadOnly = true;
            this.PhoneUser.Width = 125;
            // 
            // Birthday
            // 
            this.Birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Birthday.FillWeight = 200.4169F;
            this.Birthday.HeaderText = "Дата народження";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Width = 355;
            // 
            // addUser
            // 
            this.addUser.BorderColor = System.Drawing.Color.Gray;
            this.addUser.BorderThickness = 1;
            this.addUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addUser.FillColor = System.Drawing.Color.Transparent;
            this.addUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addUser.ForeColor = System.Drawing.Color.Black;
            this.addUser.Image = ((System.Drawing.Image)(resources.GetObject("addUser.Image")));
            this.addUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addUser.ImageOffset = new System.Drawing.Point(2, 0);
            this.addUser.Location = new System.Drawing.Point(665, 15);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(110, 35);
            this.addUser.TabIndex = 10;
            this.addUser.Text = "New User";
            this.addUser.TextOffset = new System.Drawing.Point(7, 0);
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1015, 700);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dataGridViewUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "Users";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button settingsButton;
        private Guna.UI2.WinForms.Guna2Button filterButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birhday;
        private System.Windows.Forms.Label quantityUsers;
        private Guna.UI2.WinForms.Guna2Button settingColumn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsersID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private Guna.UI2.WinForms.Guna2Button addUser;
    }
}
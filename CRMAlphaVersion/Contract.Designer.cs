﻿namespace CRMAlphaVersion
{
    partial class Contract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contract));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birhday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addUser = new Guna.UI2.WinForms.Guna2Button();
            this.settingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.filterButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.quantityUsers = new System.Windows.Forms.Label();
            this.dataGridViewContracts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).BeginInit();
            this.SuspendLayout();
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
            // NameUser
            // 
            this.NameUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameUser.FillWeight = 120.9578F;
            this.NameUser.HeaderText = "Ім\'я працівника";
            this.NameUser.Name = "NameUser";
            this.NameUser.ReadOnly = true;
            this.NameUser.Width = 225;
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
            // EmailUser
            // 
            this.EmailUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmailUser.FillWeight = 5.781145F;
            this.EmailUser.HeaderText = "Email";
            this.EmailUser.Name = "EmailUser";
            this.EmailUser.ReadOnly = true;
            this.EmailUser.Width = 95;
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
            // PhoneUser
            // 
            this.PhoneUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PhoneUser.FillWeight = 0.9127185F;
            this.PhoneUser.HeaderText = "Номер телефону";
            this.PhoneUser.Name = "PhoneUser";
            this.PhoneUser.ReadOnly = true;
            this.PhoneUser.Width = 125;
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
            this.addUser.Click += new System.EventHandler(this.Uploadfile_Click);
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
            this.settingsButton.Click += new System.EventHandler(this.button2_Click);
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
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.addUser);
            this.guna2Panel1.Controls.Add(this.settingsButton);
            this.guna2Panel1.Controls.Add(this.filterButton);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1015, 65);
            this.guna2Panel1.TabIndex = 10;
            // 
            // quantityUsers
            // 
            this.quantityUsers.AutoSize = true;
            this.quantityUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityUsers.ForeColor = System.Drawing.Color.DarkOrange;
            this.quantityUsers.Location = new System.Drawing.Point(15, 30);
            this.quantityUsers.Name = "quantityUsers";
            this.quantityUsers.Size = new System.Drawing.Size(49, 33);
            this.quantityUsers.TabIndex = 7;
            this.quantityUsers.Text = "75";
            // 
            // dataGridViewContracts
            // 
            this.dataGridViewContracts.AllowUserToAddRows = false;
            this.dataGridViewContracts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewContracts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewContracts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewContracts.ColumnHeadersHeight = 40;
            this.dataGridViewContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewContracts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewContracts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dataGridViewContracts.Location = new System.Drawing.Point(12, 71);
            this.dataGridViewContracts.Name = "dataGridViewContracts";
            this.dataGridViewContracts.ReadOnly = true;
            this.dataGridViewContracts.RowHeadersVisible = false;
            this.dataGridViewContracts.RowTemplate.Height = 40;
            this.dataGridViewContracts.Size = new System.Drawing.Size(985, 600);
            this.dataGridViewContracts.TabIndex = 8;
            this.dataGridViewContracts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewContracts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewContracts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewContracts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewContracts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewContracts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewContracts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dataGridViewContracts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dataGridViewContracts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewContracts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewContracts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridViewContracts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewContracts.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewContracts.ThemeStyle.ReadOnly = true;
            this.dataGridViewContracts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewContracts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewContracts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewContracts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewContracts.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridViewContracts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewContracts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1015, 700);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.quantityUsers);
            this.Controls.Add(this.dataGridViewContracts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contract";
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.Contract_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsersID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birhday;
        private Guna.UI2.WinForms.Guna2Button addUser;
        private Guna.UI2.WinForms.Guna2Button settingsButton;
        private Guna.UI2.WinForms.Guna2Button filterButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label quantityUsers;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewContracts;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
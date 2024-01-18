namespace CRMAlphaVersion
{
    partial class Deals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deals));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UsersPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.settingColumn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Birhday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeEDRPOY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientOrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewOrganizations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.UsersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizations)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersPanel
            // 
            this.UsersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersPanel.Controls.Add(this.settingColumn);
            this.UsersPanel.Controls.Add(this.guna2Button1);
            this.UsersPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.UsersPanel.Location = new System.Drawing.Point(0, 0);
            this.UsersPanel.Name = "UsersPanel";
            this.UsersPanel.Size = new System.Drawing.Size(1015, 65);
            this.UsersPanel.TabIndex = 2;
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
            this.settingColumn.Location = new System.Drawing.Point(780, 15);
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
            this.guna2Button1.Location = new System.Drawing.Point(896, 15);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(110, 35);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Filter";
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
            // codeEDRPOY
            // 
            this.codeEDRPOY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codeEDRPOY.FillWeight = 0.9127185F;
            this.codeEDRPOY.HeaderText = "Код ЄДРПОУ";
            this.codeEDRPOY.MinimumWidth = 50;
            this.codeEDRPOY.Name = "codeEDRPOY";
            this.codeEDRPOY.ReadOnly = true;
            this.codeEDRPOY.Width = 200;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Email.FillWeight = 120.9578F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 50;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 225;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Phone.FillWeight = 46.61516F;
            this.Phone.HeaderText = "Номер мобільного телефону";
            this.Phone.MinimumWidth = 50;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 200;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Address.FillWeight = 5.781145F;
            this.Address.HeaderText = "Адреса";
            this.Address.MinimumWidth = 75;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 250;
            // 
            // clientOrganizationName
            // 
            this.clientOrganizationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clientOrganizationName.FillWeight = 18.31213F;
            this.clientOrganizationName.HeaderText = "Найменування контрагента";
            this.clientOrganizationName.MinimumWidth = 150;
            this.clientOrganizationName.Name = "clientOrganizationName";
            this.clientOrganizationName.ReadOnly = true;
            this.clientOrganizationName.Width = 250;
            // 
            // dataGridViewOrganizations
            // 
            this.dataGridViewOrganizations.AllowUserToAddRows = false;
            this.dataGridViewOrganizations.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewOrganizations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrganizations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrganizations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrganizations.ColumnHeadersHeight = 40;
            this.dataGridViewOrganizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewOrganizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientOrganizationName,
            this.Address,
            this.Phone,
            this.Email,
            this.codeEDRPOY});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrganizations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrganizations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dataGridViewOrganizations.Location = new System.Drawing.Point(20, 71);
            this.dataGridViewOrganizations.Name = "dataGridViewOrganizations";
            this.dataGridViewOrganizations.ReadOnly = true;
            this.dataGridViewOrganizations.RowHeadersVisible = false;
            this.dataGridViewOrganizations.RowTemplate.Height = 40;
            this.dataGridViewOrganizations.Size = new System.Drawing.Size(985, 600);
            this.dataGridViewOrganizations.TabIndex = 3;
            this.dataGridViewOrganizations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewOrganizations.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewOrganizations.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewOrganizations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewOrganizations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewOrganizations.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewOrganizations.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dataGridViewOrganizations.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dataGridViewOrganizations.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewOrganizations.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewOrganizations.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridViewOrganizations.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewOrganizations.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewOrganizations.ThemeStyle.ReadOnly = true;
            this.dataGridViewOrganizations.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewOrganizations.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOrganizations.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewOrganizations.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewOrganizations.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridViewOrganizations.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewOrganizations.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Leads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1015, 700);
            this.Controls.Add(this.UsersPanel);
            this.Controls.Add(this.dataGridViewOrganizations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leads";
            this.Text = "Leads";
            this.UsersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel UsersPanel;
        private Guna.UI2.WinForms.Guna2Button settingColumn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birhday;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeEDRPOY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientOrganizationName;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewOrganizations;
    }
}
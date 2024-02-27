namespace CRMAlphaVersion
{
    partial class Organizations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organizations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UsersPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.addNewOrganization = new Guna.UI2.WinForms.Guna2Button();
            this.settingColumn = new Guna.UI2.WinForms.Guna2Button();
            this.filterTable = new Guna.UI2.WinForms.Guna2Button();
            this.Birhday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewOrganizations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ClientOrganizationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientOrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeEDRPOY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuUser = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.підтвердитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizations)).BeginInit();
            this.menuUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersPanel
            // 
            this.UsersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersPanel.Controls.Add(this.addNewOrganization);
            this.UsersPanel.Controls.Add(this.settingColumn);
            this.UsersPanel.Controls.Add(this.filterTable);
            this.UsersPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.UsersPanel.Location = new System.Drawing.Point(0, 0);
            this.UsersPanel.Name = "UsersPanel";
            this.UsersPanel.Size = new System.Drawing.Size(1015, 65);
            this.UsersPanel.TabIndex = 2;
            // 
            // addNewOrganization
            // 
            this.addNewOrganization.Animated = true;
            this.addNewOrganization.BorderColor = System.Drawing.Color.Gray;
            this.addNewOrganization.BorderThickness = 1;
            this.addNewOrganization.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addNewOrganization.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addNewOrganization.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addNewOrganization.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addNewOrganization.FillColor = System.Drawing.Color.Transparent;
            this.addNewOrganization.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addNewOrganization.ForeColor = System.Drawing.Color.Black;
            this.addNewOrganization.Image = ((System.Drawing.Image)(resources.GetObject("addNewOrganization.Image")));
            this.addNewOrganization.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addNewOrganization.Location = new System.Drawing.Point(664, 15);
            this.addNewOrganization.Name = "addNewOrganization";
            this.addNewOrganization.Size = new System.Drawing.Size(110, 35);
            this.addNewOrganization.TabIndex = 7;
            this.addNewOrganization.Text = "Нова організація";
            this.addNewOrganization.TextOffset = new System.Drawing.Point(9, 0);
            this.addNewOrganization.Click += new System.EventHandler(this.addNewOrganization_Click);
            // 
            // settingColumn
            // 
            this.settingColumn.Animated = true;
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
            // filterTable
            // 
            this.filterTable.Animated = true;
            this.filterTable.BorderColor = System.Drawing.Color.Gray;
            this.filterTable.BorderThickness = 1;
            this.filterTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.filterTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.filterTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.filterTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.filterTable.FillColor = System.Drawing.Color.Transparent;
            this.filterTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterTable.ForeColor = System.Drawing.Color.Black;
            this.filterTable.Image = ((System.Drawing.Image)(resources.GetObject("filterTable.Image")));
            this.filterTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.filterTable.ImageOffset = new System.Drawing.Point(2, 0);
            this.filterTable.Location = new System.Drawing.Point(896, 15);
            this.filterTable.Name = "filterTable";
            this.filterTable.Size = new System.Drawing.Size(110, 35);
            this.filterTable.TabIndex = 5;
            this.filterTable.Text = "Filter";
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
            // dataGridViewOrganizations
            // 
            this.dataGridViewOrganizations.AllowUserToAddRows = false;
            this.dataGridViewOrganizations.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridViewOrganizations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewOrganizations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrganizations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewOrganizations.ColumnHeadersHeight = 40;
            this.dataGridViewOrganizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewOrganizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientOrganizationID,
            this.clientOrganizationName,
            this.Address,
            this.Phone,
            this.Email,
            this.codeEDRPOY});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrganizations.DefaultCellStyle = dataGridViewCellStyle9;
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
            this.dataGridViewOrganizations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrganizations_CellDoubleClick);
            // 
            // ClientOrganizationID
            // 
            this.ClientOrganizationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClientOrganizationID.HeaderText = "Код організації";
            this.ClientOrganizationID.Name = "ClientOrganizationID";
            this.ClientOrganizationID.ReadOnly = true;
            this.ClientOrganizationID.Width = 125;
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
            // menuUser
            // 
            this.menuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuUser.Name = "menuUser";
            this.menuUser.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.menuUser.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.menuUser.RenderStyle.ColorTable = null;
            this.menuUser.RenderStyle.RoundedEdges = true;
            this.menuUser.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.menuUser.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menuUser.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.menuUser.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.menuUser.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.menuUser.Size = new System.Drawing.Size(181, 70);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.підтвердитиToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // підтвердитиToolStripMenuItem
            // 
            this.підтвердитиToolStripMenuItem.Name = "підтвердитиToolStripMenuItem";
            this.підтвердитиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.підтвердитиToolStripMenuItem.Text = "Підтвердити";
            this.підтвердитиToolStripMenuItem.Click += new System.EventHandler(this.підтвердитиToolStripMenuItem_Click);
            // 
            // Organizations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1015, 700);
            this.Controls.Add(this.UsersPanel);
            this.Controls.Add(this.dataGridViewOrganizations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Organizations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leads";
            this.UsersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizations)).EndInit();
            this.menuUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel UsersPanel;
        private Guna.UI2.WinForms.Guna2Button settingColumn;
        private Guna.UI2.WinForms.Guna2Button filterTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birhday;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewOrganizations;
        private Guna.UI2.WinForms.Guna2Button addNewOrganization;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip menuUser;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientOrganizationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientOrganizationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeEDRPOY;
        private System.Windows.Forms.ToolStripMenuItem підтвердитиToolStripMenuItem;
    }
}
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
            this.Birhday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addUser = new Guna.UI2.WinForms.Guna2Button();
            this.settingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.filterButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.quantityUsers = new System.Windows.Forms.Label();
            this.dataGridViewContracts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.оновитиДанніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientOrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.ClientOrganizationName,
            this.ContractNumber,
            this.CreatedBy,
            this.CreatedDate,
            this.ContractStartDate,
            this.ContractEndDate});
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
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оновитиДанніToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // оновитиДанніToolStripMenuItem
            // 
            this.оновитиДанніToolStripMenuItem.Name = "оновитиДанніToolStripMenuItem";
            this.оновитиДанніToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.оновитиДанніToolStripMenuItem.Text = "Оновити данні";
            this.оновитиДанніToolStripMenuItem.Click += new System.EventHandler(this.оновитиДанніToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            // 
            // ClientOrganizationName
            // 
            this.ClientOrganizationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClientOrganizationName.FillWeight = 18.31213F;
            this.ClientOrganizationName.HeaderText = "Найменування організації";
            this.ClientOrganizationName.Name = "ClientOrganizationName";
            this.ClientOrganizationName.ReadOnly = true;
            this.ClientOrganizationName.Width = 85;
            // 
            // ContractNumber
            // 
            this.ContractNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ContractNumber.FillWeight = 5.781145F;
            this.ContractNumber.HeaderText = "Номер контракту";
            this.ContractNumber.Name = "ContractNumber";
            this.ContractNumber.ReadOnly = true;
            this.ContractNumber.Width = 95;
            // 
            // CreatedBy
            // 
            this.CreatedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CreatedBy.FillWeight = 46.61516F;
            this.CreatedBy.HeaderText = "Створено (ким)";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            this.CreatedBy.Width = 75;
            // 
            // CreatedDate
            // 
            this.CreatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CreatedDate.FillWeight = 120.9578F;
            this.CreatedDate.HeaderText = "Дата створення";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Width = 225;
            // 
            // ContractStartDate
            // 
            this.ContractStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ContractStartDate.FillWeight = 0.9127185F;
            this.ContractStartDate.HeaderText = "Початок дії контракту";
            this.ContractStartDate.Name = "ContractStartDate";
            this.ContractStartDate.ReadOnly = true;
            this.ContractStartDate.Width = 125;
            // 
            // ContractEndDate
            // 
            this.ContractEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ContractEndDate.FillWeight = 200.4169F;
            this.ContractEndDate.HeaderText = "Дата закінчення дії контратку";
            this.ContractEndDate.Name = "ContractEndDate";
            this.ContractEndDate.ReadOnly = true;
            this.ContractEndDate.Width = 355;
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
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Birhday;
        private Guna.UI2.WinForms.Guna2Button addUser;
        private Guna.UI2.WinForms.Guna2Button settingsButton;
        private Guna.UI2.WinForms.Guna2Button filterButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label quantityUsers;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewContracts;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оновитиДанніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientOrganizationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractEndDate;
    }
}
namespace CRMAlphaVersion.AddNewRecord
{
    partial class AddNewLeads
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewLeads));
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.responsible = new Guna.UI2.WinForms.Guna2TextBox();
            this.organization = new System.Windows.Forms.Label();
            this.Clients = new System.Windows.Forms.ComboBox();
            this.statusLead = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.anotherButton = new Guna.UI2.WinForms.Guna2Button();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.source = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(15, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 52;
            this.label1.Text = "Додати нового ліда";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(20, 180);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(122, 21);
            this.Name.TabIndex = 55;
            this.Name.Text = "Відповідальний";
            // 
            // responsible
            // 
            this.responsible.BorderRadius = 5;
            this.responsible.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.responsible.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.responsible.DefaultText = "";
            this.responsible.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.responsible.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.responsible.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.responsible.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.responsible.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.responsible.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.responsible.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.responsible.Location = new System.Drawing.Point(15, 205);
            this.responsible.Name = "responsible";
            this.responsible.PasswordChar = '\0';
            this.responsible.PlaceholderForeColor = System.Drawing.Color.DarkOrange;
            this.responsible.PlaceholderText = "Повне ім\'я користувача";
            this.responsible.ReadOnly = true;
            this.responsible.SelectedText = "";
            this.responsible.Size = new System.Drawing.Size(250, 35);
            this.responsible.TabIndex = 54;
            // 
            // organization
            // 
            this.organization.AutoSize = true;
            this.organization.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organization.Location = new System.Drawing.Point(295, 190);
            this.organization.Name = "organization";
            this.organization.Size = new System.Drawing.Size(63, 21);
            this.organization.TabIndex = 53;
            this.organization.Text = "Клієнти";
            // 
            // Clients
            // 
            this.Clients.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients.FormattingEnabled = true;
            this.Clients.Location = new System.Drawing.Point(295, 215);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(200, 25);
            this.Clients.TabIndex = 60;
            // 
            // statusLead
            // 
            this.statusLead.AutoSize = true;
            this.statusLead.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLead.Location = new System.Drawing.Point(505, 190);
            this.statusLead.Name = "statusLead";
            this.statusLead.Size = new System.Drawing.Size(57, 21);
            this.statusLead.TabIndex = 56;
            this.statusLead.Text = "Статус";
            // 
            // Status
            // 
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "SuperAdministator",
            "Administrator",
            "Call-center",
            "Account Manager"});
            this.Status.Location = new System.Drawing.Point(505, 215);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(200, 25);
            this.Status.TabIndex = 61;
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
            this.cancelButton.Location = new System.Drawing.Point(555, 502);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 50);
            this.cancelButton.TabIndex = 66;
            this.cancelButton.Text = "Відмініти";
            this.cancelButton.TextOffset = new System.Drawing.Point(7, 0);
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            this.anotherButton.Location = new System.Drawing.Point(295, 502);
            this.anotherButton.Name = "anotherButton";
            this.anotherButton.Size = new System.Drawing.Size(150, 50);
            this.anotherButton.TabIndex = 65;
            this.anotherButton.Text = "Додати ще одного";
            this.anotherButton.TextOffset = new System.Drawing.Point(12, 0);
            this.anotherButton.Click += new System.EventHandler(this.anotherButton_Click);
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
            this.saveButton.Location = new System.Drawing.Point(15, 502);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 50);
            this.saveButton.TabIndex = 64;
            this.saveButton.Text = "Додати";
            this.saveButton.TextOffset = new System.Drawing.Point(7, 0);
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceLabel.Location = new System.Drawing.Point(20, 256);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(77, 21);
            this.SourceLabel.TabIndex = 68;
            this.SourceLabel.Text = "Примітка";
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(15, 280);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(300, 150);
            this.source.TabIndex = 69;
            this.source.Text = "";
            // 
            // AddNewLeads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.source);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.responsible);
            this.Controls.Add(this.organization);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.statusLead);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.anotherButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewLeads";
            this.Load += new System.EventHandler(this.AddNewLeads_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name;
        private Guna.UI2.WinForms.Guna2TextBox responsible;
        private System.Windows.Forms.Label organization;
        private System.Windows.Forms.ComboBox Clients;
        private System.Windows.Forms.Label statusLead;
        private System.Windows.Forms.ComboBox Status;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2Button anotherButton;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.RichTextBox source;
    }
}
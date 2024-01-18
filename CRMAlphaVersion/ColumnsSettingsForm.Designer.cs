namespace CRMAlphaVersion
{
    partial class ColumnsSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnsSettingsForm));
            this.checkedListBoxColumns = new System.Windows.Forms.CheckedListBox();
            this.resetColumnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.buttonApplySettings = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBoxColumns
            // 
            this.checkedListBoxColumns.FormattingEnabled = true;
            this.checkedListBoxColumns.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxColumns.Name = "checkedListBoxColumns";
            this.checkedListBoxColumns.Size = new System.Drawing.Size(226, 184);
            this.checkedListBoxColumns.TabIndex = 0;
            // 
            // resetColumnSettings
            // 
            this.resetColumnSettings.BorderColor = System.Drawing.Color.Gray;
            this.resetColumnSettings.BorderThickness = 1;
            this.resetColumnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetColumnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetColumnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetColumnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetColumnSettings.FillColor = System.Drawing.Color.Transparent;
            this.resetColumnSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetColumnSettings.ForeColor = System.Drawing.Color.Black;
            this.resetColumnSettings.Image = ((System.Drawing.Image)(resources.GetObject("resetColumnSettings.Image")));
            this.resetColumnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.resetColumnSettings.ImageOffset = new System.Drawing.Point(2, 0);
            this.resetColumnSettings.Location = new System.Drawing.Point(3, 6);
            this.resetColumnSettings.Name = "resetColumnSettings";
            this.resetColumnSettings.Size = new System.Drawing.Size(110, 35);
            this.resetColumnSettings.TabIndex = 7;
            this.resetColumnSettings.Text = "Reset";
            this.resetColumnSettings.Click += new System.EventHandler(this.resetColumnSettings_Click);
            // 
            // buttonApplySettings
            // 
            this.buttonApplySettings.BorderColor = System.Drawing.Color.Gray;
            this.buttonApplySettings.BorderThickness = 1;
            this.buttonApplySettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonApplySettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonApplySettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonApplySettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonApplySettings.FillColor = System.Drawing.Color.Transparent;
            this.buttonApplySettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonApplySettings.ForeColor = System.Drawing.Color.Black;
            this.buttonApplySettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonApplySettings.Image")));
            this.buttonApplySettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonApplySettings.ImageOffset = new System.Drawing.Point(2, 0);
            this.buttonApplySettings.Location = new System.Drawing.Point(119, 6);
            this.buttonApplySettings.Name = "buttonApplySettings";
            this.buttonApplySettings.Size = new System.Drawing.Size(110, 35);
            this.buttonApplySettings.TabIndex = 8;
            this.buttonApplySettings.Text = "Apply";
            this.buttonApplySettings.Click += new System.EventHandler(this.buttonApplySettings_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkedListBoxColumns);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 191);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonApplySettings);
            this.panel2.Controls.Add(this.resetColumnSettings);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 47);
            this.panel2.TabIndex = 10;
            // 
            // ColumnsSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 238);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColumnsSettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ColumnsSettingsForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxColumns;
        private Guna.UI2.WinForms.Guna2Button resetColumnSettings;
        private Guna.UI2.WinForms.Guna2Button buttonApplySettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
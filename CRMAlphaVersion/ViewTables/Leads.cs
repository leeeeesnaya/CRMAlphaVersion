using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using CRMAlphaVersion.AddNewRecord;

namespace CRMAlphaVersion
{
    public partial class Leads : Form
    {
        public string UserName { get; set; }
        private DataBase database;
        public Leads(string userName)
        {
            InitializeComponent();
            Controls.Add(dataGridViewLeads);

            database = new DataBase();
            UserName = userName;
            LoadDataToDataGridView();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataToDataGridView()
        {
            try
            {
                database.OpenConnection();
                string query = "SELECT U.NameUser, C.ClientOrganizationName, L.Status, L.Source, L.CreatedDate" +
                    "\r\nFROM Leads L\r\n" +
                    "JOIN Users U ON L.UserID = U.UsersID\r\n" +
                    "JOIN ClientOrganizations C ON L.ClientOrganizationID = C.ClientOrganizationID;";

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, database.GetConnection()))
                {
                    using (DataSet dataSet = new DataSet())
                    {
                        dataAdapter.Fill(dataSet, "Leads");

                        foreach (DataRow row in dataSet.Tables["Leads"].Rows)
                        {
                            dataGridViewLeads.Rows.Add(
                                row["NameUser"],
                                row["ClientOrganizationName"],
                                row["Status"],
                                row["Source"],
                                ((DateTime)row["CreatedDate"]).ToShortDateString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
        }
        private void settingColumn_Click(object sender, EventArgs e)
        {
            List<string> allColumns = new List<string>
            {
                "NameUser2222", "ClientOrganizationName", "Status", "Source", "CreatedDate"
            };

            using (ColumnsSettingsForm columnsSettingsForm = new ColumnsSettingsForm(allColumns))
            {
                // Получаем позицию кнопки
                Point buttonLocation = settingsButton.PointToScreen(new Point(0, 0));

                // Установка позиции формы немного ниже кнопки
                columnsSettingsForm.StartPosition = FormStartPosition.Manual;
                columnsSettingsForm.Location = new System.Drawing.Point(buttonLocation.X, buttonLocation.Y + settingsButton.Height + 5);

                if (columnsSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataGridViewColumn column in dataGridViewLeads.Columns)
                    {
                        column.Visible = columnsSettingsForm.SelectedColumns.Contains(column.Name);
                    }
                }
            }
        }
        private void addUser_Click(object sender, EventArgs e)
        {
            AddNewUser mainForm = new AddNewUser();
            this.Hide();
            mainForm.FormClosed += (s, args) => { this.Close(); };
            mainForm.Show();
        }

        private void counteragent_Click(object sender, EventArgs e)
        {
            AddNewLeads addNewLeads = new AddNewLeads(UserName);
            addNewLeads.ShowDialog(); 
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace CRMAlphaVersion
{
    public partial class Deals : Form
    {
        private DataBase database;
        public Deals()
        {
            InitializeComponent();
            Controls.Add(dataGridViewOrganizations);

            database = new DataBase();

            LoadDataToDataGridView();
        }
        private void LoadDataToDataGridView()
        {
            try
            {
                database.OpenConnection();

                string query = "SELECT ClientOrganizationName, Address, Phone, Email, CodeEDRPOY FROM ClientOrganizations";

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, database.GetConnection()))
                {
                    using (DataSet dataSet = new DataSet())
                    {
                        dataAdapter.Fill(dataSet, "ClientOrganizations");

                        foreach (DataRow row in dataSet.Tables["ClientOrganizations"].Rows)
                        {
                            dataGridViewOrganizations.Rows.Add(
                                row["clientOrganizationName"],
                                row["Address"],
                                row["Phone"],
                                row["Email"],
                                row["codeEDRPOY"]
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
                "clientOrganizationName", "Address", "Phone", "Email", "codeEDRPOY"
            };

            using (ColumnsSettingsForm columnsSettingsForm = new ColumnsSettingsForm(allColumns))
            {
                // Получите позицию кнопки
                Point buttonLocation = settingColumn.PointToScreen(new Point(0, 0));

                // Установите позицию формы чуть ниже кнопки
                columnsSettingsForm.StartPosition = FormStartPosition.Manual;
                columnsSettingsForm.Location = new System.Drawing.Point(buttonLocation.X, buttonLocation.Y + settingColumn.Height + 5);

                if (columnsSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataGridViewColumn column in dataGridViewOrganizations.Columns)
                    {
                        column.Visible = columnsSettingsForm.SelectedColumns.Contains(column.Name);
                    }
                }
            }
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using CRMAlphaVersion.AddNewRecord;
using CRMAlphaVersion.UpdateRecord;
using CRMAlphaVersion.Scripts_Delete;

namespace CRMAlphaVersion
{
    public partial class Organizations : Form
    {
        private DataBase database;
        public int SelectedUserID { get; set; }
        public Organizations()
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

                string query = "SELECT ClientOrganizationID, ClientOrganizationName, Address, Phone, Email, CodeEDRPOY FROM ClientOrganizations";

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, database.GetConnection()))
                {
                    using (DataSet dataSet = new DataSet())
                    {
                        dataAdapter.Fill(dataSet, "ClientOrganizations");

                        foreach (DataRow row in dataSet.Tables["ClientOrganizations"].Rows)
                        {
                            dataGridViewOrganizations.Rows.Add(
                                row["ClientOrganizationID"],
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

        private void dataGridViewOrganizations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что двойной щелчок произошел внутри строки
            if (e.RowIndex >= 0)
            {
                // Получаем выбранную строку
                DataGridViewRow selectedRow = dataGridViewOrganizations.Rows[e.RowIndex];

                // Получаем идентификатор пользователя из выбранной строки
                int userID = Convert.ToInt32(selectedRow.Cells["ClientOrganizationID"].Value);

                // Устанавливаем этот идентификатор в контекстном меню
                updateToolStripMenuItem.Tag = userID;
                deleteToolStripMenuItem.Tag = userID;
                SelectedUserID = userID;

                // Отображаем контекстное меню рядом с курсором мыши
                menuUser.Show(Cursor.Position);
                Console.WriteLine(userID);
            }
        }
        private void dataGridUsers_MouseDown(object sender, MouseEventArgs e)
        {
            menuUser.Show(dataGridViewOrganizations, e.Location);
        }

        private void addNewOrganization_Click(object sender, EventArgs e)
        {
            AddNewOrganizations addNewOrganizations = new AddNewOrganizations();
            addNewOrganizations.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOrganization mainForm = new UpdateOrganization(SelectedUserID, this);
            this.Hide();
            mainForm.FormClosed += (s, args) => { this.Close(); };
            mainForm.Show();
        }

        private void підтвердитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteScriptOrganization deleter = new deleteScriptOrganization();
            deleter.DeleteOrganizationByID(SelectedUserID);
        }
    }
}

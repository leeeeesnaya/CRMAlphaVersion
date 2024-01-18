using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CRMAlphaVersion
{
    public partial class Users : Form
    {
        private DataBase database;
        public event EventHandler SearchTextChanged;
        public Users()
        {
            InitializeComponent();
            Controls.Add(dataGridViewUsers);

            database = new DataBase();

            LoadDataToDataGridView();
            //QuantityUser();
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                database.OpenConnection();
                string query = "SELECT StatusAcc, EmailUser, UsersID, NameUser, PhoneUser, Birhday FROM Users";

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, database.GetConnection()))
                {
                    using (DataSet dataSet = new DataSet())
                    {
                        dataAdapter.Fill(dataSet, "Users");

                        foreach (DataRow row in dataSet.Tables["Users"].Rows)
                        {
                            dataGridViewUsers.Rows.Add(
                                row["StatusAcc"],
                                row["EmailUser"],
                                row["UsersID"],
                                row["NameUser"],
                                row["PhoneUser"],
                                row["Birhday"]
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

        //private void QuantityUser()
        //{
        //    quantity.Text = string.Empty;
        //    try
        //    {
        //        database.OpenConnection();

        //        string query = "SELECT COUNT(*) AS UserCount FROM Users WHERE DataProviderOrganizationID = @DataProviderOrganizationID";

        //        using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
        //        {
        //            // Предположим, что у вас есть свойство UserID для хранения текущего пользователя
        //            // и DataProviderOrganizationID, чтобы получить организацию пользователя
        //            int currentUserID = GetCurrentUser().UserID;
        //            int organizationID = GetUserOrganizationID(currentUserID);

        //            command.Parameters.AddWithValue("@DataProviderOrganizationID", organizationID);

        //            object result = command.ExecuteScalar();

        //            if (result != null)
        //            {
        //                int userCount = Convert.ToInt32(result);
        //                MessageBox.Show($"Количество пользователей в вашей организации: {userCount}");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Не удалось получить данные.");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ошибка выполнения запроса: " + ex.Message);
        //    }
        //    finally
        //    {
        //        database.CloseConnection();
        //    }

        //}

        private void settingColumn_Click(object sender, EventArgs e)
        {
            List<string> allColumns = new List<string>
            {
                "StatusAcc", "EmailUser", "UsersID", "NameUser", "PhoneUser", "Birhday"
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
                    foreach (DataGridViewColumn column in dataGridViewUsers.Columns)
                    {
                        column.Visible = columnsSettingsForm.SelectedColumns.Contains(column.Name);
                    }
                }
            }
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            AddNewUser mainForm = new AddNewUser();
            this.Hide();
            mainForm.FormClosed += (s, args) => { this.Close(); };
            mainForm.Show();
        }
    }
}
using CRMAlphaVersion.UpdateRecord;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CRMAlphaVersion
{
    public partial class Users : Form
    {
        private DataBase database;
        public event EventHandler SearchTextChanged;
        public int SelectedUserID { get; set; }
        public Users()
        {
            InitializeComponent();
            Controls.Add(dataGridViewUsers);
            database = new DataBase();

            LoadDataToDataGridView();
        }

        public void LoadDataToDataGridView()
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
        private void dataGridUsers_MouseDown(object sender, MouseEventArgs e)
        {
            menuUser.Show(dataGridViewUsers, e.Location);
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            AddNewUser mainForm = new AddNewUser();
            this.Hide();
            mainForm.FormClosed += (s, args) => { this.Close(); };
            mainForm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accept mainForm = new accept(SelectedUserID);
            mainForm.Show();
        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что двойной щелчок произошел внутри строки
            if (e.RowIndex >= 0)
            {
                // Получаем выбранную строку
                DataGridViewRow selectedRow = dataGridViewUsers.Rows[e.RowIndex];

                // Получаем идентификатор пользователя из выбранной строки
                int userID = Convert.ToInt32(selectedRow.Cells["UsersID"].Value);

                // Устанавливаем этот идентификатор в контекстном меню
                updateToolStripMenuItem.Tag = userID;
                deleteToolStripMenuItem.Tag = userID;
                SelectedUserID = userID;

                // Отображаем контекстное меню рядом с курсором мыши
                menuUser.Show(Cursor.Position);
                Console.WriteLine(userID);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUser mainForm = new UpdateUser(SelectedUserID, this);
            this.Hide();
            mainForm.FormClosed += (s, args) => { this.Close(); };
            mainForm.Show();
        }
    }
}
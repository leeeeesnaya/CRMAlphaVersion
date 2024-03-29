﻿using CRMAlphaVersion.AddNewRecord;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CRMAlphaVersion
{
    public partial class Deals : Form
    {
        public string UserName { get; set; }
        DataBase database;

        public Deals(string userName)
        {
            InitializeComponent();
            Controls.Add(dataGridViewDeals);
            database = new DataBase();
            UserName = userName;
            LoadDataToDataGridView();
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                database.OpenConnection();
                string query = "SELECT U.NameUser, CO.ClientOrganizationName, CO.Email, CO.CodeEDRPOY, D.Amount, D.Stage, D.CloseDate\r\n" +
                    "FROM Deals D \r\n" +
                    "Join Users U ON D.UserID = U.UsersID\r\n" +
                    "JOIN Leads L ON D.LeadID = L.LeadID\r\n" +
                    "JOIN ClientOrganizations CO ON L.ClientOrganizationID = CO.ClientOrganizationID;";

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, database.GetConnection()))
                {
                    using (DataSet dataSet = new DataSet())
                    {
                        dataAdapter.Fill(dataSet, "Deals");

                        foreach (DataRow row in dataSet.Tables["Deals"].Rows)
                        {
                            dataGridViewDeals.Rows.Add(
                                row["NameUser"],
                                row["ClientOrganizationName"],
                                row["Email"],
                                row["CodeEDRPOY"],
                                row["Amount"],
                                row["Stage"],
                                ((DateTime)row["CloseDate"]).ToShortDateString()
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

        //private void settingColumn_Click(object sender, EventArgs e)
        //{
        //    List<string> allColumns = new List<string>
        //    {
        //        "StatusAcc", "EmailUser", "UsersID", "NameUser", "PhoneUser", "Birhday"
        //    };

        //    using (ColumnsSettingsForm columnsSettingsForm = new ColumnsSettingsForm(allColumns))
        //    {
        //        // Получите позицию кнопки
        //        Point buttonLocation = settingColumn.PointToScreen(new Point(0, 0));

        //        // Установите позицию формы чуть ниже кнопки
        //        columnsSettingsForm.StartPosition = FormStartPosition.Manual;
        //        columnsSettingsForm.Location = new System.Drawing.Point(buttonLocation.X, buttonLocation.Y + settingColumn.Height + 5);

        //        if (columnsSettingsForm.ShowDialog() == DialogResult.OK)
        //        {
        //            foreach (DataGridViewColumn column in dataGridViewUsers.Columns)
        //            {
        //                column.Visible = columnsSettingsForm.SelectedColumns.Contains(column.Name);
        //            }
        //        }
        //    }
        //}

        private void addUser_Click(object sender, EventArgs e)
        {
            AddNewUser mainForm = new AddNewUser();
            this.Hide();
            mainForm.FormClosed += (s, args) => { this.Close(); };
            mainForm.Show();
        }

        private void counteragent_Click(object sender, EventArgs e)
        {
            AddNewDeals addNewDeals = new AddNewDeals(UserName);
            addNewDeals.ShowDialog();
        }
    }
}

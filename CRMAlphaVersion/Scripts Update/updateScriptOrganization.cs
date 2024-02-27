using CRMAlphaVersion.UpdateRecord;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace CRMAlphaVersion.Scripts_Update
{
    internal class updateScriptOrganization
    {
        private DataBase database;

        public updateScriptOrganization()
        {
            database = new DataBase();
        }
        public void FillTextBoxesFromDatabase(int ClientOrganizationID, UpdateOrganization updateOrganization)
        {
            try
            {
                database.OpenConnection();
                MessageBox.Show($"Пытаемся загрузить данные для организации с ID: {ClientOrganizationID}");

                string query = "SELECT ClientOrganizationName, Email, Address, Phone, CodeEDRPOY FROM ClientOrganizations WHERE ClientOrganizationID = @ClientOrganizationID";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@ClientOrganizationID", ClientOrganizationID);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        updateOrganization.nameOrganization.Text = reader["ClientOrganizationName"].ToString();
                        updateOrganization.Email.Text = reader["Email"].ToString();
                        updateOrganization.addressOrganization.Text = reader["Address"].ToString();
                        updateOrganization.mobilePhoneOrganization.Text = reader["Phone"].ToString();
                        updateOrganization.codeEDRPOY.Text = reader["CodeEDRPOY"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Данные организации не найдены.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при загрузке данных: {ex.Message}");
            }
            finally
            {
                database.CloseConnection();
            }
        }



        public void UpdateOrganizationInfo(int ClientOrganizationID, 
            string ClientOrganizationName, string Address, string Phone, string Email, string CodeEDRPOY)
        {
            try
            {
                database.OpenConnection();

                string query = "UPDATE ClientOrganizations SET ClientOrganizationName = @ClientOrganizationName," +
                    "Address = @Address, Phone = @Phone, Email = @Email, CodeEDRPOY = @CodeEDRPOY " +
                    "WHERE ClientOrganizationID = @ClientOrganizationID";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    // Передаем параметры запроса
                    command.Parameters.AddWithValue("@ClientOrganizationName", ClientOrganizationName);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@CodeEDRPOY", CodeEDRPOY);
                    command.Parameters.AddWithValue("@ClientOrganizationID", ClientOrganizationID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Информация о пользователе успешно обновлена.");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось обновить информацию о пользователе.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении информации о пользователе: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
        }
    }
}

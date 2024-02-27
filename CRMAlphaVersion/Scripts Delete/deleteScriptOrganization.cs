using System;
using System.Data.SqlClient;
using System.Windows;

namespace CRMAlphaVersion.Scripts_Delete
{
    internal class deleteScriptOrganization
    {
        private DataBase database;
        public event EventHandler OrganizationDeleted;
        public deleteScriptOrganization()
        {
            database = new DataBase();
        }

        public void DeleteOrganizationByID(int userID)
        {
            try
            {
                database.OpenConnection();

                string query = "DELETE FROM ClientOrganizations WHERE ClientOrganizationID = @ClientOrganizationID";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@ClientOrganizationID", userID);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при удалении пользователя: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
            OnUserDeleted();
        }
        private void OnUserDeleted()
        {
            OrganizationDeleted?.Invoke(this, EventArgs.Empty);
        }
    }
}

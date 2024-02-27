using CRMAlphaVersion.UpdateRecord;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRMAlphaVersion.Scripts_Delete
{
    internal class deleteScriptUser
    {
        private DataBase database;
        public event EventHandler UserDeleted;
        public deleteScriptUser()
        {
            database = new DataBase();
        }

        public void DeleteUserByID(int userID)
        {
            try
            {
                database.OpenConnection();

                string query = "DELETE FROM Users WHERE UsersID = @UserID";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
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
            UserDeleted?.Invoke(this, EventArgs.Empty);
        }
    }
}

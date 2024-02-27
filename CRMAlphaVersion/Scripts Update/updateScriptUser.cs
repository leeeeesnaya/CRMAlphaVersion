using CRMAlphaVersion.UpdateRecord;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRMAlphaVersion.Scripts_Update
{
    public class updateScriptUser
    {
        private DataBase database;

        public updateScriptUser()
        {
            database = new DataBase();
        }

        public void FillTextBoxesFromDatabase(int userID, UpdateUser updateUser)
        {
            try
            {
                database.OpenConnection();

                string query = "SELECT NameUser, Position, PhoneUser, EmailUser, PasswordUser, StatusAcc FROM Users WHERE UsersID = @UsersID";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@UsersID", userID);

                    SqlDataReader reader = command.ExecuteReader();

                    // Проверяем, есть ли данные
                    if (reader.Read())
                    {
                        string fullName = reader["NameUser"].ToString();
                        updateUser.positionUser.Text = reader["Position"].ToString();
                        updateUser.mobilePhoneUser.Text = reader["PhoneUser"].ToString();
                        updateUser.Email.Text = reader["EmailUser"].ToString();
                        updateUser.passwordUser.Text = reader["PasswordUser"].ToString();
                        updateUser.statusAcc.Text = reader["StatusAcc"].ToString();

                        string[] nameParts = fullName.Split(' ');
                        if (nameParts.Length == 3)
                        {
                            updateUser.firstName.Text = nameParts[0];
                            updateUser.secondName.Text = nameParts[1];
                            updateUser.thirdName.Text = nameParts[2];
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при разделении имени на части.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данные пользователя не найдены.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
        }

        public void UpdateUsersInfo(int userID, string newName, string newPosition, string newPhone, string newEmail, string newPassword, string newStatus)
        {
            try
            {
                database.OpenConnection();

                string query = "UPDATE Users SET NameUser = @NewName, Position = @NewPosition, " +
                    "PhoneUser = @NewPhone, EmailUser = @NewEmail, PasswordUser = @NewPassword, StatusAcc = @NewStatus " +
                    "WHERE UsersID = @UserID";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    // Передаем параметры запроса
                    command.Parameters.AddWithValue("@NewName", newName);
                    command.Parameters.AddWithValue("@NewPosition", newPosition);
                    command.Parameters.AddWithValue("@NewPhone", newPhone);
                    command.Parameters.AddWithValue("@NewEmail", newEmail);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);
                    command.Parameters.AddWithValue("@NewStatus", newStatus);
                    command.Parameters.AddWithValue("@UserID", userID);

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
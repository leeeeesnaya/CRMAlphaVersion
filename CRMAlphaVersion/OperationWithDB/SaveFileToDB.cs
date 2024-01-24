using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using GemBox.Document;
using System.Text;
using Spire.Doc;
using System.Diagnostics;

namespace CRMAlphaVersion
{
    internal class SaveFileToDB
    {
        private DataBase database;
        public SaveFileToDB(DataBase db)
        {
            database = db;
        }
        public void SaveFileToDatabase(string fileName, byte[] fileData)
        {
            try
            {
                database.OpenConnection();

                string query = "INSERT INTO Files (FileName, FileData, FileType) VALUES (@FileName, @FileData, @FileType)";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@FileName", Path.GetFileName(fileName));
                    command.Parameters.AddWithValue("@FileData", fileData);
                    command.Parameters.AddWithValue("@FileType", "docx");

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки файла: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
        }
    }
}

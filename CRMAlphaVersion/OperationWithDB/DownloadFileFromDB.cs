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
    internal class DownloadFileFromDB
    {
        private DataBase database;
        public DownloadFileFromDB(DataBase db)
        {
            database = db;
        }
        public byte[] GetFileContent(int fileId)
        {
            byte[] fileContent = null;

            try
            {
                using (SqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT FileData FROM Files WHERE FileID = @FileId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FileId", fileId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Получение содержимого файла из БД
                                fileContent = (byte[])reader["FileData"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                Console.WriteLine("Ошибка при чтении файла из базы данных: " + ex.Message);
            }

            return fileContent;
        }

        public void DownloadFileFromDatabase()
        {
            // Здесь мы указываем какой ID файла в БД
            byte[] fileContent = GetFileContent(1);

            if (fileContent != null)
            {
                // Получаем путь к папке "Загрузки"
                string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                downloadsPath = Path.Combine(downloadsPath, "Downloads");

                // Создание папки "Загрузки", если её нет
                Directory.CreateDirectory(downloadsPath);

                // Формируем полный путь для сохранения файла
                string saveFilePath = Path.Combine(downloadsPath, "example.docx");  // Наименование файла на выходе

                // Сохраняем байты в файл на локальной машине
                File.WriteAllBytes(saveFilePath, fileContent);

                // Открываем файл в программе Word
                OpenFileInWord(saveFilePath);
            }
        }
        private void OpenFileInWord(string filePath)
        {
            try
            {
                // Открытие файла docx в программе Word
                Process.Start("WINWORD.EXE", filePath);
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                Console.WriteLine($"Ошибка при открытии файла в Word: {ex.Message}");
            }
        }
    }
}

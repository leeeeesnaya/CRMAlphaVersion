using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMAlphaVersion
{
    public partial class AddNewUser : Form
    {
        private DataBase database;

        public AddNewUser()
        {
            InitializeComponent();

            database = new DataBase();

            LoadOrganizationsToComboBox();
            organizationUser.TextChanged += OrganizationUser_TextChanged;

            birthdayUser.MaxDate = DateTime.Today;

            // Подписываемся на событие выбора даты
            birthdayUser.DateSelected += BirthdayUser_DateSelected;
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {

        }

        private void BirthdayUser_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = birthdayUser.SelectionStart;

            if (selectedDate > DateTime.Today)
            {
                MessageBox.Show("Выберите прошедшую дату или текущую дату.");
                birthdayUser.SetDate(DateTime.Today);
            }
        }

        private void LoadOrganizationsToComboBox()
        {
            try
            {
                database.OpenConnection();

                string query = "SELECT DataProviderOrganizationName FROM DataProviderOrganizations";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string organizationName = reader["DataProviderOrganizationName"].ToString();
                            organizationUser.Items.Add(organizationName);
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

        private void OrganizationUser_TextChanged(object sender, EventArgs e)
        {
            // Фильтруем элементы комбобокса в соответствии с введенным текстом
            // Первоначально скрываем выпадающий список, чтобы обновить его
            organizationUser.DroppedDown = false;
            organizationUser.Items.Clear();

            try
            {
                database.OpenConnection();

                string searchText = organizationUser.Text;
                string query = "SELECT DataProviderOrganizationName FROM DataProviderOrganizations WHERE DataProviderOrganizationName LIKE @searchText";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string organizationName = reader["DataProviderOrganizationName"].ToString();
                            organizationUser.Items.Add(organizationName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска данных: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
            //Теперь врубаем список
            organizationUser.DroppedDown = true;
        }

        private void addNewUser()
        {
            //Полное имя пользователя
            string fName = firstName.Text;
            string sName = secondName.Text;
            string tName = thirdName.Text;

            //Соединяем все вместе
            string name = string.Join(" ", fName, sName, tName);

            //Почта пользователя
            string email = Email.Text;

            //Хеширование пароля пользователя
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string password = BCrypt.Net.BCrypt.HashPassword(passwordUser.Text, salt);

            //Мобилка пользователя
            string phone = mobilePhoneUser.Text;

            //Организация, должность и статус аккаунта на текущий момент. Также дата рождения пользователя
            string organization = organizationUser.Text;
            string position = positionUser.Text;
            string status = statusAcc.Text;
            DateTime selectedDate = birthdayUser.SelectionStart;

            try
            {
                database.OpenConnection();

                string query = "INSERT INTO Users (DataProviderOrganizationID, NameUser, Position, PhoneUser, EmailUser, PasswordUser, StatusAcc, Birhday) " +
                               "VALUES ((SELECT DataProviderOrganizationID FROM DataProviderOrganizations WHERE DataProviderOrganizationName = @Organization), " +
                               "@Name, @Position, @Phone, @Email, @Password, @Status, @Birthday)";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Organization", organization);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Position", position);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Birthday", selectedDate);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Данные успешно добавлены.");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить данные.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения запроса: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void ClearFormFields()
        {
            firstName.Text = string.Empty;
            secondName.Text = string.Empty;
            thirdName.Text = string.Empty;
            Email.Text = string.Empty;
            passwordUser.Text = string.Empty;
            mobilePhoneUser.Text = string.Empty;
            organizationUser.SelectedIndex = -1;
            positionUser.SelectedIndex = -1;
            statusAcc.SelectedIndex = -1;
            DateTime selectedDate = birthdayUser.SelectionStart;
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            addNewUser();
            this.Close();
        }

        private void anotherButton_Click(object sender, EventArgs e)
        {
            addNewUser();
            ClearFormFields();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            this.Close();
        }

        //Проверяем, чтобы в текстовом поле были именно буквы
        private void textKeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешить только ввод букв и клавиш управления
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Отменить ввод символа
            }
        }

        //Проверяем, чтобы в текстовом поле были именно цифры

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            textKeyPress(sender, new KeyPressEventArgs('\0'));
        }
    }
}

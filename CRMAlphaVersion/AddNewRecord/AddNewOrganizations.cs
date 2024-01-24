using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRMAlphaVersion.AddNewRecord
{
    public partial class AddNewOrganizations : Form
    {
        private DataBase database;
        public AddNewOrganizations()
        {
            InitializeComponent();

            database = new DataBase();
        }

        private void AddNewOrganizations_Load(object sender, EventArgs e)
        {

        }

        private void addNewOrganization()
        {
            //Полное наименование Организации
            string nameOrgz = nameOrganization.Text;

            //Почта Организации
            string email = Email.Text;

            //Мобильный телефон Организации
            string phone = mobilePhoneOrganization.Text;

            //Код ЕДРПОУ Организации
            string codeEDR = codeEDRPOY.Text;

            //Адресс Организации
            string addressOrgz = addressOrganization.Text;

            try
            {
                database.OpenConnection();

                string query = "INSERT INTO ClientOrganizations (ClientOrganizationName, Address, Phone, Email, CodeEDRPOY) " +
                               "VALUES (@ClientOrganizationName, @Address, @Phone, @Email, @CodeEDRPOY)";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@ClientOrganizationName", nameOrgz);
                    command.Parameters.AddWithValue("@Address", addressOrgz);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@CodeEDRPOY", codeEDR);

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
            nameOrganization.Text = string.Empty;
            addressOrganization.Text = string.Empty;
            phone.Text = string.Empty;
            Email.Text = string.Empty;
            codeEDRPOY.Text = string.Empty;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            addNewOrganization();
            this.Close();
        }

        private void anotherButton_Click(object sender, EventArgs e)
        {
            addNewOrganization();
            ClearFormFields();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            this.Close();
        }
    }
}

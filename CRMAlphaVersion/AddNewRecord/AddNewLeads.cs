using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRMAlphaVersion.AddNewRecord
{
    public partial class AddNewLeads : Form
    {
        private DataBase database;
        public string UserName { get; set; }
        public AddNewLeads(string userName)
        {
            InitializeComponent();
            database = new DataBase();
            responsible.Text = userName;
            LoadLeadsToComboBox();
        }

        private void AddNewLeads_Load(object sender, EventArgs e)
        {

        }

        private void LoadLeadsToComboBox()
        {
            try
            {
                database.OpenConnection();

                string query = "SELECT CO.ClientOrganizationName\r\n" +
                    "FROM Leads L\r\n" +
                    "JOIN ClientOrganizations CO ON L.ClientOrganizationID = CO.ClientOrganizationID";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string organizationName = reader["ClientOrganizationName"].ToString();
                            Clients.Items.Add(organizationName);
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

        private void addNewLeads()
        {
            //Ответственный
            string responsibleName = responsible.Text;

            //Примечание
            string sourceText = source.Text;

            //Клиенты 
            string leads = Clients.Text;

            //Статус лида
            string stage = Status.Text;
            //Берем день создания (текущий)
            DateTime currentDate = DateTime.Now;

            try
            {
                database.OpenConnection();

                string query = "INSERT INTO Leads (UserID, ClientOrganizationID, Status, Source, CreatedDate)\r\n" +
                 "VALUES ((SELECT U.UsersID " +
                 "FROM Users U WHERE U.NameUser = @resName), " +
                 "(SELECT CO.ClientOrganizationID " +
                 "FROM Leads L JOIN ClientOrganizations CO ON L.ClientOrganizationID = CO.ClientOrganizationID WHERE CO.ClientOrganizationName = @ClientName), " +
                 "@Status, @Source, @CreatedDate);";



                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@resName", responsibleName);
                    command.Parameters.AddWithValue("@ClientName", leads);
                    command.Parameters.AddWithValue("@Status", stage);
                    command.Parameters.AddWithValue("@Source", sourceText);
                    command.Parameters.AddWithValue("@CreatedDate", currentDate);

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
            responsible.Text = string.Empty;
            source.Text = string.Empty;
            Clients.Text = string.Empty;
            Status.Text = string.Empty;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            addNewLeads();
            this.Close();
        }

        private void anotherButton_Click(object sender, EventArgs e)
        {
            addNewLeads();
            ClearFormFields();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            this.Close();
        }
    }
}

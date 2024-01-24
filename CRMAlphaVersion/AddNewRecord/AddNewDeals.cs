using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CRMAlphaVersion.AddNewRecord
{
    public partial class AddNewDeals : Form
    {
        private DataBase database;
        public string UserName { get; set; }
        public AddNewDeals(string userName)
        {
            InitializeComponent();
            database = new DataBase();
            LoadLeadsToComboBox();
            responsible.Text = userName;
        }

        private void AddNewDeals_Load(object sender, EventArgs e)
        {

        }

        private void LoadLeadsToComboBox()
        {
            try
            {
                database.OpenConnection();

                string query = "SELECT CO.ClientOrganizationName\r\n" +
                    "FROM Leads L\r\n" +
                    "JOIN ClientOrganizations CO ON L.ClientOrganizationID = CO.ClientOrganizationID;";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string organizationName = reader["ClientOrganizationName"].ToString();
                            LeadsBox.Items.Add(organizationName);
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

        private void addNewDeals()
        {
            //Ответственный
            string responsibleName = responsible.Text;

            //Цена
            string amountLeft = AmountLeft.Text;

            //Копейки
            string amountRight = AmountRight.Text;

            //Общая сумма цена + копейки
            string amount = amountLeft + "." + amountRight;

            //Мобильный телефон Организации
            string leads = LeadsBox.Text;

            //Код ЕДРПОУ Организации
            string stage = StageContract.Text;
            DateTime closeDate = Closedate.SelectionStart;

            try
            {
                database.OpenConnection();

                string query = "INSERT INTO Deals (UserID, LeadID, Amount, Stage, CloseDate)\r\n" +
                    "VALUES (\r\n" +
                    "(SELECT UsersID " +
                    "FROM Users " +
                    "WHERE NameUser = @resName),\r\n    " +
                    "(SELECT L.LeadID\r\n     " +
                    "FROM Leads L\r\n     " +
                    "JOIN ClientOrganizations CO ON L.ClientOrganizationID = CO.ClientOrganizationID\r\n     " +
                    "WHERE CO.ClientOrganizationName = @leadName),\r\n    " +
                    "@Amount, @Stage, @CloseDate\r\n);";

                using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@resName", responsibleName);
                    command.Parameters.AddWithValue("@leadName", leads);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@Stage", stage);
                    command.Parameters.AddWithValue("@CloseDate", closeDate);

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
            AmountLeft.Text = string.Empty;
            AmountRight.Text = string.Empty;
            AmountLeft.Text = string.Empty;
            LeadsBox.Text = string.Empty;
            StageContract.Text = string.Empty;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            addNewDeals();
            this.Close();
        }

        private void anotherButton_Click(object sender, EventArgs e)
        {
            addNewDeals();
            ClearFormFields();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            this.Close();
        }
    }
}

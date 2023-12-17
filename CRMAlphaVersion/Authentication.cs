using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRMAlphaVersion
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }


        private void Authentication_Load(object sender, EventArgs e)
        {
           
        }
        private void ConnectButton_Click(object sender, EventArgs e)
        {

            var lgnUser = LoginUser.Text;
            var passUser = PasswordUser.Text;

            DataBase dataBase = new DataBase();

            string storedHashedPassword = GetUserPasswordFromDatabase(dataBase, lgnUser);

            if (storedHashedPassword != null && PasswordHasher.VerifyPassword(passUser, storedHashedPassword))
            {
                Loading mainForm = new Loading();
                this.Hide();
                mainForm.FormClosed += (s, args) => { this.Close(); };
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Please make sure your password is correct!", "Error Authorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetUserPasswordFromDatabase(DataBase dataBase, string lgnUser)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dataBase.GetConnection().ConnectionString))
                {
                    connection.Open();

                    string queryString = "SELECT PasswordUser FROM Users WHERE NameUser = @NameUser";
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        command.Parameters.AddWithValue("@NameUser", lgnUser);

                        object result = command.ExecuteScalar();

                        return result != null ? result.ToString() : null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при выполнении запроса: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}

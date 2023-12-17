using System.Data.SqlClient;

namespace CRMAlphaVersion
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=Styx;Initial Catalog=CRM;Integrated Security=True");

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}

using System.Data.SqlClient;

namespace CRMAlphaVersion
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=127.0.0.1,1433; Initial Catalog=CRMFlame; Integrated Security=True");

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

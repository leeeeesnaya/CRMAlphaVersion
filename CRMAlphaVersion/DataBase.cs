using System.Data.SqlClient;

namespace CRMAlphaVersion
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=34.67.214.124,1433; Initial Catalog=CRMFlame; User ID=sqlserver; Password=1234;");

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

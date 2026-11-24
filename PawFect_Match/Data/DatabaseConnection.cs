using System.Data.SqlClient;

namespace PawFect_Match.Data
{
    public class DatabaseConnection
    {
        private static readonly string connectionString =
            @"Data Source=.\SQLEXPRESS;
              Initial Catalog=PawfectMatchDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
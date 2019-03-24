using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Static class for database connection
    /// </summary>
    public static class ClinicDBConnection
    {
        /// <summary>
        /// Returns the SQL Connection to Clinic Database
        /// </summary>
        /// <returns>SqlConnection to Clinic Database</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source =TRIFORCE\\DEKUTREE;Initial Catalog=CS6232_g3;" +
                "Integrated Security=True;";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

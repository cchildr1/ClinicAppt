using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Model;

namespace Clinic.DAL
{
    /// <summary>
    /// THis class connects to the database and returns queries relating to the status table
    /// </summary>
    class StatusDAL
    {
        /// <summary>
        /// This returns a list of all statuses
        /// </summary>
        /// <returns></returns>
        public List<Status> GetAllStatusTypes()
        {
            List<Status> statuses = new List<Status>();
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                string selectStatement = "SELECT id, status FROM status_code";
                using (SqlCommand select = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = select.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Status status = new Status();
                            status.StatusDescription = reader["status"].ToString();
                            status.StatusID = (int)reader["id"];
                            statuses.Add(status);
                        }
                    }
                }
                connection.Close();
            }
            return statuses;
        }

        /// <summary>
        /// This method returns the status equal to the accepted status
        /// </summary>
        /// <param name="statusID"></param>
        /// <returns></returns>
        public Status GetStatusByID(int statusID)
        {
            Status status = new Status();
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                string selectStatement = "SELECT id, status FROM status_code WHERE id = @statusID";
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("statusID", statusID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            status.StatusDescription = reader["status"].ToString();
                            status.StatusID = (int)reader["id"];
                        }
                    }
                }
                connection.Close();
            }
            return status;
        }
    }
}

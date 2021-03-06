﻿using System.Collections.Generic;
using System.Data.SqlClient;
using Clinic.Model;

namespace Clinic.DAL
{
    /// <summary>
    /// This class connects to the database and returns queries relating to the status table
    /// </summary>
    class StatusDAL
    {
        /// <summary>
        /// This returns a list of all statuses
        /// </summary>
        /// <returns>List of all status types</returns>
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
        /// <param name="statusID">Status ID value</param>
        /// <returns>Status object</returns>
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

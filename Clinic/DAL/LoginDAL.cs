using Clinic.Model;
using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Clinic.DAL
{
    /// <summary>
    /// DAL procedures for Logging in a user
    /// </summary>
    public class LoginDAL
    {
        /// <summary>
        /// Checks to see if employee exists in database by matching username and password
        /// </summary>
        /// <param name="username">username as string</param>
        /// <param name="password">password as string</param>
        /// <returns>either nurse or admin object containing the personal information depending on their role</returns>
        public Employee LoginEmployee(string username, string password)
        {
            string selectStatement = "SELECT u.id as employee_id, u.username, u.password, " +
                "u.person_id, n.id as nurse_id, a.id as admin_id, phi.first_name, phi.last_name, activeUser " +
                "FROM users u " +
                "LEFT JOIN nurse n ON u.person_id = n.person_id " +
                "LEFT JOIN administrator a ON u.person_id = a.person_id " +
                "JOIN person phi ON u.person_id = phi.id "  +
                "WHERE username = @username AND dbo.PasswordCheck(@password) = 'Valid'";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    selectCommand.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        Employee employee;
                        if (reader.Read())
                        {
                            if (reader["nurse_id"] != DBNull.Value && reader["admin_id"] == DBNull.Value)
                            {
                                employee = NurseDAL.GetNurseByID((int)reader["nurse_id"]);
                                return employee;
                            }
                            else if (reader["admin_id"] != DBNull.Value && reader["nurse_id"] == DBNull.Value)
                            {
                                employee = new Admin
                                {
                                    EmployeeID = (int)reader["employee_id"],
                                    UserName = reader["username"].ToString(),
                                    Password = reader["password"].ToString(),
                                    FirstName = reader["first_name"].ToString(),
                                    LastName = reader["last_name"].ToString(),
                                    AdminID = (int)reader["admin_id"],
                                    Active = this.ActiveHelper((byte)reader["activeUser"])
                                };
                                return employee;
                            }
                            else
                            {
                                return null;
                            }
                            
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        private bool ActiveHelper(byte sqlActive)
        {
            bool isActive;
            isActive = Convert.ToBoolean(sqlActive);
            return isActive;
        }
    }
}

using Clinic.Model;
using System;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// DAL procedures for Logging in a user
    /// </summary>
    public static class LoginDAL
    {
        /// <summary>
        /// Checks to see if employee exists in database by matching username and password
        /// </summary>
        /// <param name="username">username as string</param>
        /// <param name="password">password as string</param>
        /// <returns>either nurse or admin object containing the personal information depending on their role</returns>
        public static Employee LoginEmployee(string username, string password)
        {
            string selectStatement = "SELECT e.id as employee_id, e.username, e.password, e.personal_information_id, n.id as nurse_id, a.id as admin_id, phi.first_name, phi.last_name " +
                "FROM employees e " +
                "LEFT JOIN nurse n ON e.id = n.employee_id " +
                "LEFT JOIN administrator a ON e.id = a.employee_id " +
                "JOIN personal_information phi ON e.personal_information_id = phi.id " +
                "WHERE username = @username AND password = @password;";

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
                                employee = new Nurse
                                {
                                    EmployeeID = (int)reader["employee_id"],
                                    UserName = reader["username"].ToString(),
                                    Password = reader["password"].ToString(),
                                    FirstName = reader["first_name"].ToString(),
                                    LastName = reader["last_name"].ToString(),
                                    NurseID = (int)reader["nurse_id"]
                                    
                                };
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
                                    AdminID = (int)reader["admin_id"]
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
    }
}

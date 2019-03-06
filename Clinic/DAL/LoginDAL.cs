using Clinic.Model;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    public static class Login
    {
        public static Employee LoginEmployee(string username, string password)
        {
            string selectStatement = "SELECT * from employees WHERE username = @username AND password = @password";

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
                            employee = new Employee
                            {
                                EmployeeID = (int)reader["id"],
                                UserName = reader["username"].ToString(),
                                Password = reader["password"].ToString(),
                            };
                            return employee;
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

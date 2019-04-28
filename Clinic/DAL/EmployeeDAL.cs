using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Clinic.Model;

namespace Clinic.DAL
{
    class EmployeeDAL
    {
        /// <summary>
        /// Changes the employee credentials in the database..
        /// </summary>
        /// <param name="edited_employee">the new employee object</param>
        /// <param name="old_employee">the existing employee object</param>
        /// <returns></returns>
        public bool EditEmployeeInfo(Employee edited_employee, Employee old_employee)
        {
            string updateStatement = "UPDATE users " +
                "SET username = @new_username, " +
                "password = HASHBYTES('SHA2_256', @new_password) " +
                "WHERE username = @old_username AND " +
                "password = @old_password AND " +
                "id = @old_id AND " +
                "person_id = @old_personID;";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand update = new SqlCommand(updateStatement, connection))
                {
                    update.Parameters.AddWithValue("@new_username", edited_employee.UserName);
                    update.Parameters.AddWithValue("@new_password", edited_employee.Password); 
                    update.Parameters.AddWithValue("@old_username", old_employee.UserName);
                    update.Parameters.AddWithValue("@old_password", old_employee.HashedPassword);
                    update.Parameters.AddWithValue("@old_id", old_employee.EmployeeID);
                    update.Parameters.AddWithValue("@old_personID", old_employee.PersonId);
                    int count = update.ExecuteNonQuery();
                    connection.Close();
                    return count > 0;
                }
            }
        }
        
        /// <summary>
        /// This method allows users to add employee values to the database
        /// </summary>
        /// <param name="addedEmployee">The employee object to add to the db.</param>
        public void AddEmployee(Employee addedEmployee)
        {
            int employeeID = -1;
            string addEmployee = "INSERT users ( username, password, person_id) " +
                "VALUES (@username, @password, @person_id) ";

            string employeeIDStatement = "SELECT IDENT_CURRENT('users') FROM users";

            try
            {
                SqlConnection connection = ClinicDBConnection.GetConnection();
                connection.Open();
                    using (SqlCommand insertCommand = new SqlCommand(addEmployee, connection))
                    {
                        insertCommand.Parameters.AddWithValue("username", addedEmployee.UserName);
                        insertCommand.Parameters.AddWithValue("password", Encoding.Default.GetBytes("qwerty"));
                        insertCommand.Parameters.AddWithValue("person_id", addedEmployee.PersonId);

                        insertCommand.ExecuteNonQuery();

                        using (SqlCommand selectCommand = new SqlCommand(employeeIDStatement, connection))
                        {
                            employeeID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        }
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error " + addedEmployee.PersonId.ToString(), MessageBoxButtons.OK);
            }

        }

        /// <summary>
        /// Returns the employeeID equal to the accepted personID
        /// </summary>
        /// <param name="personID">ID of the person</param>
        /// <returns>Employee object</returns>
        public Employee GetEmployeeBy_PersonID(int personID)
        {
            Employee employee = new Employee();
            string selectStatement = "SELECT id, person_id, password, username " +
                "FROM users " +
                "WHERE person_id = @personID ";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@personID", personID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            {
                                employee.EmployeeID = (int)reader["id"];
                                employee.PersonId = (int)reader["person_id"];
                                employee.UserName = reader["username"].ToString();
                                employee.HashedPassword = (byte[])reader["password"];
                            }
                        }
                    }
                }
                connection.Close();
            }
            return employee;
        }
    }
}

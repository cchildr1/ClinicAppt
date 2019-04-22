using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Model;

namespace Clinic.DAL
{
    class EmployeeDAL
    {
        public bool EditEmployeeInfo(Employee edited_employee, Employee old_employee)
        {
            string updateStatement = "UPDATE users " +
                "SET username = @new_username " +
              //  "password = @new_password " +
                "WHERE username = @old_username AND " +
           //     "password = @old_password AND " +
                "id = @old_id AND " +
                "person_id = @old_personID;";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand update = new SqlCommand(updateStatement, connection))
                {
                    update.Parameters.AddWithValue("@new_username", edited_employee.UserName);
                    //     update.Parameters.AddWithValue("new_password", edited_employee.Password);
                    update.Parameters.AddWithValue("@old_username", old_employee.UserName);
                                                                            //     update.Parameters.AddWithValue("old_password", old_employee.Password);
                    update.Parameters.AddWithValue("@old_id", old_employee.EmployeeID);
                    update.Parameters.AddWithValue("@old_personID", old_employee.PersonId);

                    int count = update.ExecuteNonQuery();
                    connection.Close();
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Returns the employeeID equal to the accepted personID
        /// </summary>
        /// <param name="personID"></param>
        /// <returns></returns>
        public int GetEmployeeIDBy_PersonID(int personID)
        {
            int employeeID = 0;
            string selectStatement = "SELECT id " +
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
                                employeeID = (int)reader["id"];
                            }
                        }
                    }
                }
                connection.Close();
            }
            return employeeID;
        }
    }
}

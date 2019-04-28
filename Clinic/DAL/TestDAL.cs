using System.Collections.Generic;
using System.Data.SqlClient;
using Clinic.Model;

namespace Clinic.DAL
{
    /// <summary>
    /// Queries and returns all Test information from the database.
    /// </summary>
    public static class TestDAL
    {

        /// <summary>
        /// Gets all the test codes in the database.
        /// </summary>
        /// <returns>List of all Tests</returns>
        public static List<Test> GetAllTestCodes()
        {
            List<Test> tests = new List<Test>();
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                string selectStatement = "SELECT id, code FROM test_code";
                using (SqlCommand select = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = select.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Test test = new Test
                            {
                                Code = reader["code"].ToString(),
                                TestCodeID = (int)reader["id"]
                            };
                            tests.Add(test);
                        }
                    }
                }
                connection.Close();
            }
            return tests;
        }
    }
}












using Clinic.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Holds DAL methods for Test and test_code tables
    /// </summary>
    public static class TestDAL
    {

        /// <summary>
        /// Returns list of test codes
        /// </summary>
        /// <returns>list of test codes</returns>
        public static List<Test> getAllTestCodes() 
        {
            List <Test> tests = new List<Test>();
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                string selectStatement = "SELECT id, code FROM test_code;";
                connection.Open();
                using (SqlCommand select = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = select.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Test test = new Test
                            {
                                TestCodeID = (int)reader["id"],
                                Code = reader["code"].ToString()
                            };

                            tests.Add(test);
                        }
                    }
                }
                connection.Close();
            }
            return tests;
        }

        public static List<Test> getAllTestsForVisit(int visitID)
        {
            List<Test> tests = new List<Test>();
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                string selectStatement = "select * from test t JOIN test_code tc ON tc.id = t.test_code_id WHERE t.visit_id = @visitID;";

                using (SqlCommand select = new SqlCommand(selectStatement, connection))
                {
                    select.Parameters.AddWithValue("@visitID", visitID);
                    using (SqlDataReader reader = select.ExecuteReader())
                    {
                        Test test = new Test
                        {
                            TestID = (int)reader["id"]
                        }
                    }
                }
            }
        }
    }
}

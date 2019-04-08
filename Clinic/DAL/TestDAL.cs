using Clinic.Model;
using System;
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
                string selectStatement = "select t.id as testID, t.visit_id, t.date_available, t.date_performed, " +
                    "t.test_code_id as TestCodeID, t.abnormal_result, t.result, tc.code AS TestCode, tc.description " +
                    "FROM test t join test_code tc on t.test_code_id = tc.id WHERE t.visit_id = @visitID;";
                connection.Open();
                using (SqlCommand select = new SqlCommand(selectStatement, connection))
                {
                    select.Parameters.AddWithValue("@visitID", visitID);
                    using (SqlDataReader reader = select.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Test test = new Test
                            {
                                TestID = (int)reader["testID"],
                                VisitID = (int)reader["visit_id"],
                                DateAvailable = (DateTime)reader["date_available"],
                                DatePerformed = (DateTime)reader["date_performed"],
                                TestCodeID = (int)reader["TestCodeID"],
                                Result = reader["result"].ToString(),
                                Code = reader["TestCode"].ToString(),
                                Description = reader["description"].ToString(),
                               
                            };
                            test.AbnormalResult = (Byte)reader["abnormal_result"] != 0;
                            
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

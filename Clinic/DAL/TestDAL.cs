using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Model;

namespace Clinic.DAL
{
    public static class TestDAL
    {

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

using Clinic.Model;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Clinic.DAL
{
    /// <summary>
    /// This is the ZipcodeDAL class it will allow interface with the zipcode table
    /// </summary>
    class ZipcodeDAL
    {
        public string GetStateByZipcode(string zipcode)
        {
            string selectStatement = "SELECT * FROM zipcode WHERE zipcode = @zipcode;";
            string state = "";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@zipcode", @zipcode);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            state = reader["state"].ToString();
                        }
                    }
                }
                connection.Close();
                return state;
            }
        }

        public string GetCityByZipcode(string zipcode)
        {
            string selectStatement = "SELECT * FROM zipcode WHERE zipcode = @zipcode;";
            string city = "";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@zipcode", @zipcode);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            city = reader["city"].ToString();
                        }
                    }
                }
                connection.Close();
                return city;
            }
        }
    }
}

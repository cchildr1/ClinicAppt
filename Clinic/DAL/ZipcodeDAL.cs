using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Clinic.DAL
{
    /// <summary>
    /// This is the ZipcodeDAL class it will allow interface with the zipcode table
    /// </summary>
    class ZipcodeDAL
    {
        /// <summary>
        /// This method returns the State the zipcode is associated with
        /// </summary>
        /// <param name="zipcode"></param>
        /// <returns>the state the zipcode is associsated with</returns>
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

        /// <summary>
        /// This method returns the city the zipcode is associated with
        /// </summary>
        /// <param name="zipcode"></param>
        /// <returns>the city the zipcode is associsated with</returns>
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

        internal bool IsValidZipcode(string zipcode)
        {
            throw new NotImplementedException();
        }
    }
}

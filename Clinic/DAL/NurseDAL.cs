using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Retrieves Nurse information from the database
    /// </summary>
    public class NurseDAL
    {
        /// <summary>
        /// Retrieves all nurses from the database
        /// </summary>
        /// <returns>List of all nurses</returns>
        public List<Nurse> GetAllNurses()
        {
            string selectStatement = "SELECT * FROM nurse;";
            List<Nurse> nurses = new List<Nurse>();
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nurse nurse = new Nurse
                            {
                                NurseID = (int)reader["id"],
                                PersonId = (int)reader["person_id"]
                            };
                            PopulatePersonalInformation(nurse);
                            nurses.Add(nurse);
                        }
                    }
                }
                connection.Close();
            }
            return nurses;
        }
        
        /// <summary>
        /// This method will return a list of all Nurses with a lastname equal the the accepted lastname
        /// </summary>
        /// <param name="lastname"></param>
        /// <returns></returns>
        public List<Nurse> GetAllNursesByLastname(string lastname)
        {
            List<Nurse> nurses = new List<Nurse>();
            string selectStatement = "SELECT nurse.id, person_id FROM nurse " +
                "JOIN person person ON person_id = person.id " +
               "WHERE person.id IN (SELECT id FROM person WHERE last_name = @lastname_clean)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("lastname_clean", @lastname);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nurse nurse = new Nurse
                            {
                                NurseID = (int)reader["id"],
                                PersonId = (int)reader["person_id"]
                            };
                            PopulatePersonalInformation(nurse);
                            nurses.Add(nurse);
                        }

                    }

                }
                connection.Close();
            }
            return nurses;
        }

        /// <summary>
        /// Gets a specific nurse by their id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Nurse object</returns>
        public static Nurse GetNurseByID(int id)
        {
            string selectStatement = "SELECT * FROM nurse WHERE id = @NurseID;";
            Nurse nurse = new Nurse();
            
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@NurseID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nurse.NurseID = (int)reader["id"];
                            nurse.PersonId = (int)reader["person_id"];
                            PopulatePersonalInformation(nurse);
                        }
                    }
                }
                connection.Close();
            }
            return nurse;
        }

        private static Person PopulatePersonalInformation(Person person)
        {
            string selectStatement = "SELECT * FROM person WHERE id = @personID;";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@personID", person.PersonId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            person.LastName = reader["last_name"].ToString();
                            person.FirstName = reader["first_name"].ToString();
                            person.DateOfBirth = (DateTime)reader["date_of_birth"];
                            person.SocialSecurityNumber = reader["ssn"].ToString();
                            person.Gender = reader["gender"].ToString();
                            person.StreetAddress = reader["street_address"].ToString();
                            person.Phone = reader["phone"].ToString();
                            person.Zipcode = reader["zipcode"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return person;
        }
    }
}


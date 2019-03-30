using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Clinic.DAL
{

    /// <summary>
    /// Retrievs Doctor information from the Database
    /// </summary>
    public static class DoctorDAL
    {
        /// <summary>
        /// Returns a list of all Doctors
        /// </summary>
        /// <returns>list of all Doctors</returns>
        public static List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            string selectStatement = "SELECT * FROM doctor;";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Doctor doctor = new Doctor
                            {
                                DoctorId = (int)reader["id"],
                                PersonId = (int)reader["person_id"]
                            };
                            PopulatePersonalInformation(doctor);
                            doctors.Add(doctor);
                        }
                    }
                }
                connection.Close();
            }
            return doctors;
        }

        /// <summary>
        /// Returns a Doctor equal to the doctorID
        /// </summary>
        /// <param name="doctorID"></param>
        /// <returns>returns Doctor equal to the accepted DoctorID</returns>
        public static Doctor GetDoctorByID(int doctorID)
        {
            string selectStatement = "SELECT * FROM doctor WHERE id = @doctorID;";
            Doctor doctor = new Doctor();
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@doctorID", @doctorID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctor.DoctorId = (int)reader["id"];
                            doctor.PersonId = (int)reader["person_id"];
                        }
                        PopulatePersonalInformation(doctor);
                    }
                }
                connection.Close();

                return doctor;
            }
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


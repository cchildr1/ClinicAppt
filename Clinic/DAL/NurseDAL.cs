using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clinic.DAL
{
    /// <summary>
    /// Retrieves Nurse information from the database
    /// </summary>
    public class NurseDAL
    {

        /// <summary>
        /// Returns true if the accepted SSN value is NOT present in the database
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public bool IsSSN_Not_Duplicate(string ssn)
        {
            bool valid_SSN = true;

            string selectStatement = "SELECT COUNT(*) FROM nurse nur " +
                "JOIN person per ON per.id = nur.person_id " +
                "WHERE per.ssn = @ssn";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@ssn", @ssn);
                    Int32 count = Convert.ToInt32(selectCommand.ExecuteScalar());
                    if (count > 0)
                    {
                        valid_SSN = false;
                    }
                    connection.Close();
                    return valid_SSN;
                }
            }

        }


        /// <summary>
        /// Gets a specific nurse by their id
        /// </summary>
        /// <param name="id">is the id used to select the nurse</param>
        /// <returns>Nurse object</returns>
        public static Nurse GetNurseByID(int id)
        {
            string selectStatement = "SELECT n.*, username, password, u.id " +
                "FROM users AS u " +
                "JOIN nurse AS n ON n.person_id = u.person_id " +
                "WHERE n.id = @NurseID;";
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
                            nurse.StatusID = (int)reader["status_id"];
                            nurse.UserName = reader["username"].ToString();
                     //       nurse.EmployeeID = (int)reader["u.id"];
                            PopulatePersonalInformation(nurse);

                        }
                    }
                }
                connection.Close();
            }
            return nurse;
        }

        /// <summary> 
        /// Retrieves all nurses from the database
        /// </summary>
        /// <returns>List of all nurses</returns>
        public List<Nurse> GetAllNurses()
        {
            string selectStatement = "SELECT n.*, username, password, u.id " +
                "FROM users AS u " +
                "JOIN nurse AS n ON n.person_id = u.person_id;";
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
                                PersonId = (int)reader["person_id"],
                                StatusID = (int)reader["status_id"],
                                UserName = reader["username"].ToString(),
                           //     EmployeeID = (int)reader["users.id"]
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
        /// This method returns status description equal to the accepted ID
        /// </summary>
        /// <returns></returns>
        public string GetStatusByID(int statusID)
        {
            string status_description = "";
            string selectStatement = "Select status FROM status_code " +
                "WHERE id = @statusID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("statusID", statusID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           
                            {
                                status_description = reader["status"].ToString();                               
                            }
                        }
                    }
                }
                connection.Close();
            }
            return status_description;
        }

        /// <summary>
        /// This method will change the accpted nurse status to the value memeber
        /// </summary>
        /// <param name="valueMember"></param>
        public void ChangeStatus(int nurseID, int valueMember)
        {
            string updateStatus = "UPDATE nurse " +
                "SET status_id = @valuemember " +
                "WHERE id = @nurseID";
            try
            {
                using (SqlConnection connection = ClinicDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatus, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@valuemember", valueMember);
                        updateCommand.Parameters.AddWithValue("@nurseID", nurseID);
                        updateCommand.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    

        /// <summary>
        /// This method adds the accepted nurse to the database
        /// </summary>
        /// <param name="nurse"></param>
        public Nurse AddNurse(Nurse addedNurse)
        {
            Nurse returnedNurse = new Nurse();
            int addedNurse_PersonalInfoID = -1;
            try
            {
                using (SqlConnection connection = ClinicDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        string insertPerson = "INSERT PERSON (last_name, first_name, date_of_birth, ssn, gender, street_address, phone, zipcode)" +
                        "VALUES(@lastName, @firstName, @DOB, @SSN, @Gender, @streetAddress, @phoneNumber, @Zipcode)";
                        string insertNurse = "INSERT Nurse(person_id, status_id) VALUES (@personalID, @status_id)";

                        using (SqlCommand insertPersonCommand = new SqlCommand(insertPerson, connection))
                            {
                                insertPersonCommand.Transaction = transaction;
                                insertPersonCommand.Parameters.AddWithValue("lastName", addedNurse.LastName);
                                insertPersonCommand.Parameters.AddWithValue("firstName", addedNurse.FirstName);
                                insertPersonCommand.Parameters.AddWithValue("DOB", addedNurse.DateOfBirth);
                                insertPersonCommand.Parameters.AddWithValue("SSN", addedNurse.SocialSecurityNumber);
                                insertPersonCommand.Parameters.AddWithValue("Gender", addedNurse.Gender);
                                insertPersonCommand.Parameters.AddWithValue("streetAddress", addedNurse.StreetAddress);
                                insertPersonCommand.Parameters.AddWithValue("phoneNumber", addedNurse.Phone);
                                insertPersonCommand.Parameters.AddWithValue("Zipcode", addedNurse.Zipcode);
                 
                                insertPersonCommand.ExecuteNonQuery();

                                string selectStatement = "SELECT IDENT_CURRENT('Person') FROM Person";

                                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                                {
                                    selectCommand.Transaction = transaction;
                                    addedNurse_PersonalInfoID = Convert.ToInt32(selectCommand.ExecuteScalar());
                                }
                            }

                            using (SqlCommand insertNurseCommand = new SqlCommand(insertNurse, connection))
                            {
                                insertNurseCommand.Transaction = transaction;
                                insertNurseCommand.Parameters.AddWithValue("@personalID", addedNurse_PersonalInfoID);
                                insertNurseCommand.Parameters.AddWithValue("status_id", addedNurse.StatusID);
                                insertNurseCommand.ExecuteNonQuery();
                            }
                       
                            transaction.Commit();

                            addedNurse.PersonId = addedNurse_PersonalInfoID;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            return addedNurse;
        }

        /// <summary>
        /// Returns a list of all nurses with full names equal to the accepted first and last names
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <returns></returns>
        public List<Nurse> GetNurseByFullName(string firstname, string lastname)
        {
            List<Nurse> nurses = new List<Nurse>();
            string selectStatement = "SELECT nurse.id, person_id, status_id FROM nurse " +
                "JOIN person person ON person_id = person.id " +
               "WHERE person.id IN (SELECT id FROM person WHERE first_name = @firstname_clean AND  last_name = @lastname_clean)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("firstname_clean", @firstname);
                    command.Parameters.AddWithValue("lastname_clean", @lastname);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nurse nurse = new Nurse
                            {
                                NurseID = (int)reader["id"],
                                PersonId = (int)reader["person_id"],
                                StatusID = (int)reader["status_id"]
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
        /// Returns a list of all nurses with a first name equal to the accepted firstname
        /// </summary>
        /// <param name="firstname"></param>
        /// <returns></returns>
        public List<Nurse> GetAllNursesByFirstname(string firstname)
        {
            List<Nurse> nurses = new List<Nurse>();
            string selectStatement = "SELECT nurse.id, person_id, status_id  FROM nurse " +
                "JOIN person person ON person_id = person.id " +
               "WHERE person.id IN (SELECT id FROM person WHERE first_name = @firstname_clean)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("firstname_clean", @firstname);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nurse nurse = new Nurse
                            {
                                NurseID = (int)reader["id"],
                                PersonId = (int)reader["person_id"],
                                StatusID = (int)reader["status_id"]
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
            string selectStatement = "SELECT nurse.id, person_id, status_id  FROM nurse " +
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
                                PersonId = (int)reader["person_id"],
                                StatusID = (int)reader["status_id"]
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
        /// Updates a nurse object in the database.
        /// </summary>
        /// <param name="oldNurse">The old nurse object in the db</param>
        /// <param name="updatedNurse">The new nurse object in the view</param>
        /// <returns></returns>
        public bool UpdateNurse(Nurse updatedNurse, Nurse oldNurse)
        {
            string updateStatement = "UPDATE person " +
                "SET last_name = @new_last_name, " +
                "first_name = @new_first_name, " +
                "date_of_birth = @new_date_of_birth, " +
                "ssn = @new_ssn, " +
                "gender = @new_gender, " +
                "street_address = @new_street_address, " +
                "phone = @new_phone, " +
                "zipcode = @new_zipcode " +

                "WHERE id = @id AND " +
                "last_name = @old_last_name AND " +
                "first_name = @old_first_name AND " +
                "date_of_birth = @old_date_of_birth AND " +
                "ssn = @old_ssn AND " +
                "gender = @old_gender AND " +
                "street_address = @old_street_address AND " +
                "phone = @old_phone AND " +
                "zipcode = @old_zipcode " ;
            int count = 0;
            try
            {
                using (SqlConnection connection = ClinicDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@new_last_name", updatedNurse.LastName);
                        updateCommand.Parameters.AddWithValue("@new_first_name", updatedNurse.FirstName);
                        updateCommand.Parameters.AddWithValue("@new_date_of_birth", updatedNurse.DateOfBirth);
                        if (updatedNurse.SocialSecurityNumber == "")
                            updateCommand.Parameters.AddWithValue("@new_ssn", DBNull.Value);
                        else
                            updateCommand.Parameters.AddWithValue("@new_ssn", updatedNurse.SocialSecurityNumber);
                        updateCommand.Parameters.AddWithValue("@new_gender", updatedNurse.Gender);
                        updateCommand.Parameters.AddWithValue("@new_street_address", updatedNurse.StreetAddress);
                        updateCommand.Parameters.AddWithValue("@new_phone", updatedNurse.Phone);
                        updateCommand.Parameters.AddWithValue("@new_zipcode", updatedNurse.Zipcode);
                        
                        updateCommand.Parameters.AddWithValue("@id", oldNurse.PersonId);
                        updateCommand.Parameters.AddWithValue("@old_last_name", oldNurse.LastName);
                        updateCommand.Parameters.AddWithValue("@old_first_name", oldNurse.FirstName);
                        updateCommand.Parameters.AddWithValue("@old_date_of_birth", oldNurse.DateOfBirth);
                        if (updatedNurse.SocialSecurityNumber == "")
                            updateCommand.Parameters.AddWithValue("@old_ssn", DBNull.Value);
                        else
                            updateCommand.Parameters.AddWithValue("@old_ssn", oldNurse.SocialSecurityNumber);
                        updateCommand.Parameters.AddWithValue("@old_gender", oldNurse.Gender);
                        updateCommand.Parameters.AddWithValue("@old_street_address", oldNurse.StreetAddress);
                        updateCommand.Parameters.AddWithValue("@old_phone", oldNurse.Phone);
                        updateCommand.Parameters.AddWithValue("@old_zipcode", oldNurse.Zipcode);
                        
                        count = updateCommand.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return count > 0;
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


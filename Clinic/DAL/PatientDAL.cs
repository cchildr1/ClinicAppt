using Clinic.Model;
using Clinic.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clinic.DAL
{
    /// <summary>
    /// Returns information from DB regarding patients
    /// </summary>
    public class PatientDAL
    {
        private ZipcodeDAL zipcodeDAL = new ZipcodeDAL();
        /// <summary>
        /// Returns all visits for a specified patient
        /// </summary>
        /// <param name="patient">patient object, must contain a patient ID at minimum</param>
        /// <returns>List of all visits</returns>
        public List<Visit> GetAllVisitsByPatient(Patient patient)
        {
            List<Visit> visits = new List<Visit>();
            string selectStatement = "SELECT visit_datetime as visitTime, " +
                "weight, " +
                "bp_systolic AS bpSystolic, " +
                "bp_diastolic AS bpDiastolic, " +
                "body_temp AS bodyTemp, " +
                "pulse, " +
                "symptoms, " +
                "checkup_info AS checkupInfo, " +
                "nurse_id AS nurseID, " +
                "appointment_id AS appointmentID, " +
                "initial_diagnosis, " +
                "final_diagnosis, " +
                "scheduled_datetime AS appointmentTime, " +
                "reason_for_visit, " +
                "doctor_id AS doctorID, " +
                "patient_id AS patientID " +
                "FROM visit v " +
                "JOIN appointment a ON v.appointment_id = a.id AND a.patient_id = @patientID";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientID", patient.PatientID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Visit visit = new Visit
                            {
                                DateTime = (DateTime)reader["visitTime"],
                                Weight = (decimal)reader["weight"],
                                BpSystolic = (int)reader["bpSystolic"],
                                BpDiastolic = (int)reader["bpDiastolic"],
                                BodyTemperature = (decimal)reader["bodyTemp"],
                                Pulse = (int)reader["pulse"],
                                Symptoms = reader["symptoms"].ToString(),
                                Info = reader["checkupInfo"].ToString(),
                                InitialDiagnosis = reader["initial_diagnosis"].ToString(),
                                FinalDiagnosis = reader["final_diagnosis"].ToString(),
                                Nurse = new Nurse
                                {
                                    NurseID = (int)reader["nurseID"]
                                },
                                Appointment = new Appointment
                                {
                                    AppointmentID = (int)reader["appointmentID"],
                                    Scheduled_Date = (DateTime)reader["appointmentTime"],
                                    Doctor = new Doctor
                                    {
                                        DoctorId = (int)reader["doctorID"]
                                    },
                                    Patient = patient,
                                    Reason_For_Visit = reader["reason_for_visit"].ToString()
                                }
                            };
                            PopulatePersonalInformation(visit.Nurse);
                            PopulatePersonalInformation(visit.Appointment.Doctor);
                            visits.Add(visit);
                        }
                    }
                    return visits;
                }
            }
        }

        /// <summary>
        /// This method will add the accepted Patient to the database
        /// </summary>
        /// <param name="addedPatient"></param>
        public void AddPatient(Patient addedPatient)
        {
            int addedPatient_PersonalInfoID = -1;
            try
            {
                using (SqlConnection connection = ClinicDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        string insertPerson = "INSERT PERSON (last_name, first_name, date_of_birth, ssn, gender, street_address, phone, zipcode)" +
                            "VALUES(@lastName, @firstName, @DOB, @SSN, @Gender, @streetAddress, @phoneNumber, @Zipcode)";

                        string insertPatient = "INSERT Patient(personal_information_id) VALUES (@personalID)";

                        using (SqlCommand insertPersonCommand = new SqlCommand(insertPerson, connection))
                        {
                            insertPersonCommand.Transaction = transaction;
                            insertPersonCommand.Parameters.AddWithValue("lastName", addedPatient.LastName);
                            insertPersonCommand.Parameters.AddWithValue("firstName", addedPatient.FirstName);
                            insertPersonCommand.Parameters.AddWithValue("DOB", addedPatient.DateOfBirth);
                            insertPersonCommand.Parameters.AddWithValue("SSN", addedPatient.SocialSecurityNumber);
                            insertPersonCommand.Parameters.AddWithValue("Gender", addedPatient.Gender);
                            insertPersonCommand.Parameters.AddWithValue("streetAddress", addedPatient.StreetAddress);
                            insertPersonCommand.Parameters.AddWithValue("phoneNumber", addedPatient.Phone);
                            insertPersonCommand.Parameters.AddWithValue("Zipcode", addedPatient.Zipcode);
                            insertPersonCommand.ExecuteNonQuery();

                            string selectStatement = "SELECT IDENT_CURRENT('Person') FROM Person";

                            using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                            {
                                selectCommand.Transaction = transaction;
                                addedPatient_PersonalInfoID = Convert.ToInt32(selectCommand.ExecuteScalar());
                            }
                        }

                        using (SqlCommand insertPatientCommand = new SqlCommand(insertPatient, connection))
                        {
                            insertPatientCommand.Transaction = transaction;
                            insertPatientCommand.Parameters.AddWithValue("@personalID", addedPatient_PersonalInfoID);
                            insertPatientCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Returns a list of Patients equal to the accepted DateTime
        /// </summary>
        /// <param name="dateOfBirth">Accepted DateTime value - shorted to just Date</param>
        /// <returns>List of Patients equal to the accepted DateTime</returns>
        public List<Patient> GetAllPatients_DOB(DateTime dateOfBirth)
        {
            List<Patient> patients = new List<Patient>();
            string selectStatement = "SELECT patient.id, personal_information_id  FROM patient " +
           "JOIN person person ON personal_information_id = person.id " +
           "WHERE person.id IN (SELECT id FROM person WHERE date_of_birth = @dateOfBirthdate_clean)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("dateOfBirthdate_clean", @dateOfBirth);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient
                            {
                                PatientID = (int)reader["id"],
                                PersonId = (int)reader["personal_information_id"]
                            };
                            PopulatePersonalInformation(patient);
                            patients.Add(patient);
                        }
                    }
                }
                connection.Close();
            }
            return patients;
        }

        /// <summary>
        /// Gets a list of all patients with a lastname equal to the accepted string value
        /// </summary>
        /// <param name="lastname">Accepted Lastname value</param>
        /// <returns>All patients with a lastname equal to lastname</returns>
        public List<Patient> GetPatientByLastName_Only(string lastname)
        {
            List<Patient> patients = new List<Patient>();
            string selectStatement = "SELECT patient.id, personal_information_id  FROM patient " +
               "JOIN person person ON personal_information_id = person.id " +
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
                            Patient patient = new Patient
                            {
                                PatientID = (int)reader["id"],
                                PersonId = (int)reader["personal_information_id"]
                            };
                            PopulatePersonalInformation(patient);
                            patients.Add(patient);
                        }

                    }

                }
                connection.Close();
            }
            return patients;
        }

        /// <summary>
        /// Gets a list of all patients with a lastname equal to the accepted string value and datetime
        /// </summary>
        /// <param name="lastname">Accepted Lastname value</param>
        /// <param name="dateOfBirth">accepted datetime</param>
        /// <returns>All patients with a lastname equal to lastname and dateOfBirth equal to accepted dateOfBirth</returns>
        public List<Patient> GetPatientByLastName_DOB(string lastname, DateTime dateOfBirth)
        {
            List<Patient> patients = new List<Patient>();
            string selectStatement = "SELECT patient.id, personal_information_id  FROM patient " +
           "JOIN person person ON personal_information_id = person.id " +
           "WHERE person.id IN (SELECT id FROM person WHERE last_name = @lastname_clean AND date_of_birth = @dateOfBirthdate_clean)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
        
                    command.Parameters.AddWithValue("lastname_clean", @lastname);
                    command.Parameters.AddWithValue("dateOfBirthdate_clean", @dateOfBirth);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient
                            {
                                PatientID = (int)reader["id"],
                                PersonId = (int)reader["personal_information_id"]
                            };
                            PopulatePersonalInformation(patient);
                            patients.Add(patient);
                        }
                    }
                }
                connection.Close();
            }
            return patients;
        }

        /// <summary>
        /// Gets a list of all patients with a firstname equal to the accepted string value and datetime
        /// </summary>
        /// <param name="firstname">Accepted Lastname value</param>
        /// <param name="dateOfBirth">accepted datetime</param>
        /// <returns>All patients with a firstname equal to firstname and dateOfBirth equal to accepted dateOfBirth</returns>
        public List<Patient> GetPatientByFirstName_DOB(string firstname, DateTime dateOfBirth)
        {
            List<Patient> patients = new List<Patient>();
            string selectStatement = "SELECT patient.id, personal_information_id  FROM patient " +
           "JOIN person person ON personal_information_id = person.id " +
           "WHERE person.id IN (SELECT id FROM person WHERE first_name = @firstname_clean AND date_of_birth = @dateOfBirthdate_clean)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("firstname_clean", @firstname);
                    command.Parameters.AddWithValue("dateOfBirthdate_clean", @dateOfBirth);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient
                            {
                                PatientID = (int)reader["id"],
                                PersonId = (int)reader["personal_information_id"]
                            };
                            PopulatePersonalInformation(patient);
                            patients.Add(patient);
                        }
                    }
                }
                connection.Close();
            }
            return patients;
        }

        /// <summary>
        /// Gets a list of all patients with a firstname and lastname equal to the accepted values
        /// </summary>
        /// <param name="firstname">Accepted firstname value</param>
        /// <param name="lastname">accepted lastname</param>
        /// <returns>All patients with a first and last name equal to the respected accepted values</returns>
        public List<Patient> PatientByFirst_LastName(string firstname, string lastname)
        {
            List<Patient> patients = new List<Patient>();
            string selectStatement = "SELECT patient.id, personal_information_id  FROM patient " +
               "JOIN person person ON personal_information_id = person.id " +
               "WHERE person.id IN (SELECT id FROM person WHERE first_name = @firstname_clean AND last_name = @lastname_clean)";
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
                            Patient patient = new Patient
                            {
                                PatientID = (int)reader["id"],
                                PersonId = (int)reader["personal_information_id"]
                            };
                            PopulatePersonalInformation(patient);
                            patients.Add(patient);
                        }
                    }
                }
                connection.Close();
            }
            return patients;
        }

        /// <summary>
        /// Returns a list of patients with first last and DOB equal to the respective active values
        /// </summary>
        /// <param name="firstname">accepted Firstname</param>
        /// <param name="lastname">accepted lastname</param>
        /// <param name="dateOfBirth">accepted DateTime</param>
        /// <returns>Returns a list of patients with first last and DOB equal to the respective active values</returns>
        public List<Patient> GetPatientByFirst_Last_DOB(string firstname, string lastname, DateTime dateOfBirth)
        {
            List<Patient> patients = new List<Patient>();
            string selectStatement = "SELECT patient.id, personal_information_id  FROM patient " +
           "JOIN person person ON personal_information_id = person.id " +
           "WHERE person.id IN (SELECT id FROM person WHERE first_name = @firstname_clean AND last_name = @lastname_clean AND date_of_birth = @dateOfBirthdate_clean)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("firstname_clean", @firstname);
                    command.Parameters.AddWithValue("lastname_clean", @lastname);
                    command.Parameters.AddWithValue("dateOfBirthdate_clean", @dateOfBirth);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient
                            {
                                PatientID = (int)reader["id"],
                                PersonId = (int)reader["personal_information_id"]
                            };
                            PopulatePersonalInformation(patient);
                            patients.Add(patient);
                        }
                    }
                }
                connection.Close();
            }
            return patients;
        }

        /// <summary>
        /// Gets a list of all patients with a firstname equal to the accepted string value
        /// </summary>
        /// <param name="firstname">Accepted Lastname value</param>
        /// <returns>All patients with a firstname equal to firstname</returns>
        public List<Patient> GetPatientByFirstName_Only(string @firstname)
        {
            List<Patient> patients = new List<Patient>();
            string selectStatement = "SELECT patient.id, personal_information_id  FROM patient " +
               "JOIN person person ON personal_information_id = person.id " +
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
                            Patient patient = new Patient
                            {
                                PatientID = (int)reader["id"],
                                PersonId = (int)reader["personal_information_id"]
                            };
                            PopulatePersonalInformation(patient);
                            patients.Add(patient);
                        }
                    }
                }
                connection.Close();
            }
            return patients;
        }

        /// <summary>
        /// Gets all patients from DB with personal information populated
        /// </summary>
        /// <returns>List of all patients</returns>
        public List<Patient> GetAllPatients()
        {
            List<Patient> patients = new List<Patient>();
            string selectStatement = "SELECT * FROM patient;";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient
                            {
                                PatientID = (int)reader["id"],
                                PersonId = (int)reader["personal_information_id"]
                            };
                            PopulatePersonalInformation(patient);
                            patients.Add(patient);
                        }
                    }
                }
                connection.Close();
            }
            return patients;
        }

        /// <summary>
        /// Gets all the appointments for a specified patient.
        /// </summary>
        /// <param name="patient">Patient object</param>
        /// <returns>a List of appointment objects</returns>
        public List<Appointment> GetAllAppointmentsForPatient(Patient patient)
        {
            List<Appointment> appointments = new List<Appointment>();
            string selectStatement = "SELECT * FROM appointment WHERE patient_id = @patientID;";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientID", patient.PatientID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment
                            {
                                AppointmentID = (int)reader["id"],
                                Scheduled_Date = (DateTime)reader["scheduled_datetime"],
                                Reason_For_Visit = reader["reason_for_visit"].ToString(),
                                Doctor = new Doctor
                                {
                                    DoctorId = (int)reader["doctor_id"]
                                },
                                Patient = patient
                            };
                            PopulatePersonalInformation(appointment.Doctor);
                            appointments.Add(appointment);
                        }
                    }
                }
                connection.Close();
            }
            return appointments;
        }

        /// <summary>
        /// Returns a Patient equal to the accepted ID
        /// </summary>
        /// <param name="patientID">Accepted Patient ID</param>
        /// <returns>returns a patient equal to the accepted patientID</returns>
        public Patient GetPatientByID(int patientID)
        {
            string selectStatement = "SELECT * FROM patient WHERE id = @patientID;";
            Patient patient = new Patient();
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientID", @patientID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patient.PatientID = (int)reader["id"];
                            patient.PersonId = (int)reader["personal_information_id"];
                        }
                        PopulatePersonalInformation(patient);
                    }
                }
                connection.Close();

                return patient;
            }
        }

        /// *******  Private methods ******* ///

        /// <summary>
        /// Helper method to populate a Person object's information.
        /// </summary>
        /// <param name="person">Input person object without personal info</param>
        /// <returns>Input person object with personal info</returns>
        private Person PopulatePersonalInformation(Person person)
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
                            person.State = zipcodeDAL.GetStateByZipcode(reader["zipcode"].ToString());
                            person.City = zipcodeDAL.GetCityByZipcode(reader["zipcode"].ToString());
                        }
                    }
                }
                connection.Close();
            }
            return person;
        }
    }
}

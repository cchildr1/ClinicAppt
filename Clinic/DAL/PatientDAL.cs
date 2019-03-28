using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    /// <summary>
    /// Returns information from DB regarding patients
    /// </summary>
    public static class PatientDAL
    {
        /// <summary>
        /// Returns all visits for a specified patient
        /// </summary>
        /// <param name="patient">patient object, must contain a patient ID at minimum</param>
        /// <returns>List of all visits</returns>
        public static List<Visit> GetAllVisitsByPatient(Patient patient)
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

        public static List<Patient> GetAllPatients_DOB(DateTime dateOfBirth)
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

        public static List<Patient> GetPatientByLastName_Only(string lastname)
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

        public static List<Patient> GetPatientByLastName_DOB(string lastname, DateTime dateOfBirth)
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

        public static List<Patient> GetPatientByFirstName_DOB(string firstname, DateTime dateOfBirth)
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

        public static List<Patient> PatientByFirst_LastName(string firstname, string lastname)
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

        public static List<Patient> GetPatientByFirst_Last_DOB(string firstname, string lastname, DateTime dateOfBirth)
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

        public static List<Patient> GetPatientByFirstName_Only(string @firstname)
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
        public static List<Patient> GetAllPatients()
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
        public static List<Appointment> GetAllAppointmentsForPatient(Patient patient)
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

        public static Patient GetPatientByID(int patientID)
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
    }
}

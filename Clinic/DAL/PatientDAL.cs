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
        /// Gets any and all appointments for a provided patient.
        /// </summary>
        /// <param name="patient">input patient object</param>
        /// <returns>a list of appointments</returns>
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

        /// <summary>
        /// Gets a patient object by patient id number.
        /// </summary>
        /// <param name="patientID">patient id integer</param>
        /// <returns>the patient object</returns>
        public static Patient GetPatientByID(int patientID) {
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
                            patient.PersonId= (int)reader["personal_information_id"];
                        }
                        PopulatePersonalInformation(patient);
                    }
                }
                connection.Close();

                return patient;
            }
        }

        /// <summary>
        /// Inserts a patient object into the database by inserting a person and then a patient.
        /// </summary>
        /// <param name="patient">Patient object</param>
        /// <returns>A number indicating if the insert was successful</returns>
        public static int InsertPatient(Patient patient)
        {
            string insertPersonStatement = "INSERT INTO person (last_name, first_name, " +
                "date_of_birth, ssn, gender, street_address, phone, zipcode)" +
                "VALUES (@LastName, @FirstName, @Date_Of_Birth, @SSN, @Gender, " +
                "@Street_Address, @Phone, @ZipCode); ";
            string insertPatientStatement = "INSERT INTO patient (personal_information_id) " +
                "VALUES (@PersonalInformationID)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                try
                {
                    int personID;
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertPersonStatement, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@LastName", patient.LastName);
                        insertCommand.Parameters.AddWithValue("@FirstName", patient.FirstName);
                        insertCommand.Parameters.AddWithValue("@Date_Of_Birth", patient.DateOfBirth);
                        insertCommand.Parameters.AddWithValue("@SSN", patient.SocialSecurityNumber);
                        insertCommand.Parameters.AddWithValue("@Gender", patient.Gender);
                        insertCommand.Parameters.AddWithValue("@Street_Address", patient.StreetAddress);
                        insertCommand.Parameters.AddWithValue("@Phone", patient.Phone);
                        insertCommand.Parameters.AddWithValue("@ZipCode", patient.Zipcode);
                        insertCommand.ExecuteNonQuery();

                        string selectStatement = "SELECT IDENT_CURRENT('person')";
                        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                        personID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    }

                    using (SqlCommand insertCommand = new SqlCommand(insertPatientStatement, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@PersonalInformationID", personID);
                        insertCommand.ExecuteNonQuery();

                        string selectStatement = "SELECT IDENT_CURRENT('patient')";
                        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                        int patientID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return patientID;
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Helper method that populates personal info the patient object by Person data.
        /// </summary>
        /// <param name="person">Person object</param>
        /// <returns>Person object with populated info from the database.</returns>
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

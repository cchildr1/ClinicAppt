using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Clinic.Model;

namespace Clinic.DAL
{
    class AppointmentDAL
    {
        /// <summary>
        /// Returns a list of all appointments in the database.
        /// </summary>
        /// <returns>A list of all appointments.</returns>
        public List<Appointment> GetAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();
            string selectStatement = "Select id, scheduled_datetime, reason_for_visit, doctor_id, patient_id FROM appointment";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.Doctor = new Doctor();
                            appointment.Patient = new Patient();
                            appointment.AppointmentID = (int)reader["id"];
                            appointment.Scheduled_Date = (DateTime)reader["scheduled_datetime"];
                            appointment.Reason_For_Visit = reader["reason_for_visit"].ToString();
                            appointment.Doctor = GetDoctorByID((int)reader["doctor_id"]);
                            appointment.Patient = GetPatientByID((int)reader["patient_id"]);

                            appointments.Add(appointment);
                        }
                    }
                }
                connection.Close();
            }
            return appointments;
        }

        /// <summary>
        /// Returns appointents equal to the patient ID
        /// </summary>
        /// <param name="selectedRowPatientID"></param>
        /// <returns></returns>
        public List<Appointment> GetAppointmentsByPatientID(int selectedRowPatientID)
        {
            List<Appointment> appointments = new List<Appointment>();
            string selectStatement = "Select id, scheduled_datetime, reason_for_visit, doctor_id, patient_id FROM appointment WHERE patient_id = @id_clean";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
               
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@id_clean", selectedRowPatientID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.Doctor = new Doctor();
                            appointment.Patient = new Patient();
                            appointment.AppointmentID = (int)reader["id"];
                            appointment.Scheduled_Date = (DateTime)reader["scheduled_datetime"];
                            appointment.Reason_For_Visit = reader["reason_for_visit"].ToString();
                            appointment.Doctor = GetDoctorByID((int)reader["doctor_id"]);
                            appointment.Patient = GetPatientByID((int)reader["patient_id"]);

                            appointments.Add(appointment);
                        }
                    }
                }
                connection.Close();
            }
            return appointments;
        }

        /// <summary>
        /// Updates an Appointment record in the database.
        /// </summary>
        /// <param name="oldAppointment">The existing appointment record in the db</param>
        /// <param name="newAppointment">The new value or values for the appointment record in the db</param>
        /// <returns>true or false if the query returns any records</returns>
        public bool UpdateAppointment(Appointment oldAppointment, Appointment newAppointment)
        {
            string updateStatement = "UPDATE appointment SET " +
                "scheduled_datetime = @NewScheduled_Datetime, " +
                "reason_for_visit = @NewReasonForVisit, " +
                "doctor_id = @NewDoctorID, " +
                "patient_id = @NewPatientID " +
                "WHERE id = @OldID " +
                "AND scheduled_datetime = @OldScheduled_Datetime " +
                "AND reason_for_visit = @OldReasonForVisit " +
                "AND doctor_id = @OldDoctorID " +
                "AND patient_id = @OldPatientID;";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    // new item params
                    updateCommand.Parameters.AddWithValue("@NewScheduled_Datetime", newAppointment.Scheduled_Date);
                    updateCommand.Parameters.AddWithValue("@NewReasonForVisit", newAppointment.Reason_For_Visit);
                    updateCommand.Parameters.AddWithValue("@NewDoctorID", newAppointment.Doctor.DoctorId);
                    updateCommand.Parameters.AddWithValue("@NewPatientID", newAppointment.Patient.PatientID);

                    // old item params
                    updateCommand.Parameters.AddWithValue("@OldID", oldAppointment.AppointmentID);
                    updateCommand.Parameters.AddWithValue("@OldScheduled_Datetime", oldAppointment.Scheduled_Date);
                    updateCommand.Parameters.AddWithValue("@OldReasonForVisit", oldAppointment.Reason_For_Visit);
                    updateCommand.Parameters.AddWithValue("@OldDoctorID", oldAppointment.Doctor.DoctorId);
                    updateCommand.Parameters.AddWithValue("@OldPatientID", oldAppointment.Patient.PatientID);

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }


        public bool IsDoctorDoubleBooked(DateTime ScheduledDateTime, int DoctorID)
        {
            bool doubleBooked = false;
            SqlConnection connection = ClinicDBConnection.GetConnection();
            string sqlStatement = "SELECT COUNT(*) FROM appointment WHERE scheduled_datetime = @scheduledDateTime AND doctor_id = @doctor_id";
            SqlCommand command = new SqlCommand(sqlStatement, connection);
            command.Parameters.AddWithValue("@scheduledDateTime", @ScheduledDateTime);
            command.Parameters.AddWithValue("@doctor_id", @DoctorID);
            connection.Open();
            Int32 count = Convert.ToInt32(command.ExecuteScalar());

            if (count > 0)
            {
                doubleBooked = true;
            }

            connection.Close();
            return doubleBooked;
        }

        public void AddAppointment(Appointment addedAppointment)
        {
            SqlConnection connection = ClinicDBConnection.GetConnection();
            string insertAppointment = "INSERT appointment (scheduled_datetime, reason_for_visit, doctor_id, patient_id) " +
            "VALUES (@scheduled_datetime, @reason_for_visit, @doctor_id, @patient_id)";

            SqlCommand insertCommand = new SqlCommand(insertAppointment, connection);
            insertCommand.Parameters.AddWithValue("@scheduled_datetime", addedAppointment.Scheduled_Date);
            insertCommand.Parameters.AddWithValue("@reason_for_visit", addedAppointment.Reason_For_Visit);
            insertCommand.Parameters.AddWithValue("@doctor_id", addedAppointment.Doctor.DoctorId);
            insertCommand.Parameters.AddWithValue("@patient_id", addedAppointment.Patient.PatientID);
            insertCommand.Parameters.AddWithValue("@id", this.HelperAddAppointment(connection, insertCommand));


        }

        private int HelperAddAppointment(SqlConnection connection, SqlCommand insertCommand)
        {
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement = "SELECT IDENT_CURRENT('appointment') FROM  appointment";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int appointmentID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return appointmentID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        private Doctor GetDoctorByID(int doctorID)
        {
            return DoctorDAL.GetDoctorByID(doctorID);
        }

        private Patient GetPatientByID(int patientID)
        {
            return PatientDAL.GetPatientByID(patientID);
        }
    }
}

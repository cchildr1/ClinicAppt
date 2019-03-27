using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Clinic.Model;

namespace Clinic.DAL
{
    class AppointmentDAL
    {
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

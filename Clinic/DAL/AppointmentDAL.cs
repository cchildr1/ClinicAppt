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
                            appointment.Doctor.DoctorId = (int)reader["doctor_id"];
                            appointment.Patient.PatientID = (int)reader["patient_id"];

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
    }
}

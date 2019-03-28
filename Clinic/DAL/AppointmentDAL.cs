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



          
                        
           // appointment.AppointmentID = 5;
           // appointment.Doctor_ID = 6;
           // appointment.Patient_ID = 21;
           // appointment.Reason_For_Visit = "This is test code";
           // appointment.Scheduled_Date = new DateTime(2012, 12, 25, 10, 30, 50);
           // appointment.Scheduled_Time = new DateTime(1111, 12, 25, 10, 30, 50);
            
          //  appointments.Add(appointment);
           

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Model;

namespace Clinic.DAL
{
    class AppointmentDAL
    {
        public List<Appointment> GetAppointments()
        {
           
            List<Appointment> appointments = new List<Appointment>();
            string selectStatement = "Select * FROM appointment";

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
                            appointment.AppointmentID = (int)reader["id"];
                            appointment.Scheduled_Date = (DateTime)reader["scheduled_date"];
                         //   appointment.Scheduled_Time = (Time)reader["scheduled_time"];
                            appointment.Reason_For_Visit = reader["reason_for_visit"].ToString();
                            appointment.Doctor_ID = (int)reader["doctor_id"];
                            appointment.Patient_ID = (int)reader["patient_id"];

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

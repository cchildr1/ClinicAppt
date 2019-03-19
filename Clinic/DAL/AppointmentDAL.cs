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
                            appointment.Patient.PatientID = (int)reader["patient_id"];

                            appointments.Add(appointment);
                        }
                    }
                }
                connection.Close();
            }
            return appointments;
        }

        private Doctor GetDoctorByID(int doctorID)
        {
            Doctor doctor = new Doctor();
            doctor.City = "TestCity";
            doctor.DateOfBirth = DateTime.Now;
            doctor.DoctorId = doctorID;
            doctor.FirstName = "John";
            doctor.LastName = "Smith";
            doctor.PersonId = 21;
            doctor.Phone = "123456789";
            doctor.SocialSecurityNumber = "123456789";
            doctor.State = "GA";
            doctor.StreetAddress = "123 Greenway";
            doctor.Zipcode = "30180";
       
            return doctor;
        }
    }
}

using System;
using System.Collections.Generic;
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
            DateTime dateTime = new DateTime(2012, 12, 25, 10, 30, 50);
            List<Appointment> appointments = new List<Appointment>();
            Appointment appointment = new Appointment();

            appointment.Reason_For_Visit = "YAY it works";
            appointment.Patient_ID = 5;
            appointment.Doctor_ID = 21;


           /* appointment.AppointmentID = 5;
            appointment.Doctor_ID = 6;
            appointment.Patient_ID = 21;
            appointment.Reason_For_Visit = "This is test code";
            appointment.Scheduled_Date = new DateTime(2012, 12, 25, 10, 30, 50);
            appointment.Scheduled_Time = new DateTime(1111, 12, 25, 10, 30, 50);
            */
            appointments.Add(appointment);
            return appointments;

        }
    }
}

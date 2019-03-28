using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Model;
using Clinic.DAL;

namespace Clinic.Controller
{
    class AppointmentController
    {
        private AppointmentDAL appointmentDAL = new AppointmentDAL();

        public List<Appointment> GetAppointments()
        {
            return this.appointmentDAL.GetAppointments();
        }

        public void AddAppointment(Appointment addedAppointment)
        {
            this.appointmentDAL.AddAppointment(addedAppointment);
        }

        public bool IsDoctorDoubleBooked(DateTime scheduledDateTime, int doctorID)
        {
            return this.appointmentDAL.IsDoctorDoubleBooked(scheduledDateTime, doctorID);
        }

        public List<Appointment> GetAppointmentsByName()
        {
            return this.appointmentDAL.GetAppointments();
        }

        public List<Appointment> GetAppointmentsByID(int selectedRowPatientID)
        {
            return this.appointmentDAL.GetAppointmentsByID(selectedRowPatientID);
        }
    }
}

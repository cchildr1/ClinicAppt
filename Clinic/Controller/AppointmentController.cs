using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Model;
using Clinic.DAL;

namespace Clinic.Controller
{
    /// <summary>
    /// Appointment Controller Class insures proper access to the DAL
    /// </summary>
    class AppointmentController
    {
        private AppointmentDAL appointmentDAL = new AppointmentDAL();

        /// <summary>
        /// Returns list of all appointments
        /// </summary>
        /// <returns></returns>
        public List<Appointment> GetAppointments()
        {
            return this.appointmentDAL.GetAppointments();
        }

        /// <summary>
        /// Adds an appointent to the database
        /// </summary>
        /// <param name="addedAppointment"> is the added appointment</param>
        public void AddAppointment(Appointment addedAppointment)
        {
            this.appointmentDAL.AddAppointment(addedAppointment);
        }

        /// <summary>
        /// This method checks to see if a doctor is already scheduled at this time
        /// </summary>
        /// <param name="scheduledDateTime"></param>
        /// <param name="doctorID"></param>
        /// <returns></returns>
        public bool IsDoctorDoubleBooked(DateTime scheduledDateTime, int doctorID)
        {
            return this.appointmentDAL.IsDoctorDoubleBooked(scheduledDateTime, doctorID);
        }

        public List<Appointment> GetAppointmentsByName()
        {
            return this.appointmentDAL.GetAppointments();
        }

        public List<Appointment> GetAppointmentsByPatientID(int selectedRowPatientID)
        {
            return this.appointmentDAL.GetAppointmentsByPatientID(selectedRowPatientID);
        }
    }
}

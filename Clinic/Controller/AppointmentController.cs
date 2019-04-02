using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;

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
        /// Returns an appointment object equal to the accepted appointmentID Value
        /// </summary>
        /// <param name="appointmentID"></param>
        /// <returns></returns>
        public Appointment GetAppointmentByID(int appointmentID)
        {
            return this.appointmentDAL.GetAppointmentByID(appointmentID);
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
        /// <param name="scheduledDateTime">is the scheduledDateTime to check</param>
        /// <param name="doctorID">Is the Doctor checking for double booking</param>
        /// <returns>true if doctor is already booked</returns>
        public bool IsDoctorDoubleBooked(DateTime scheduledDateTime, int doctorID)
        {
            return this.appointmentDAL.IsDoctorDoubleBooked(scheduledDateTime, doctorID);
        }

        /// <summary>
        /// Gets Appointments by PatientID
        /// </summary>
        /// <param name="selectedRowPatientID">Accepted PatientID</param>
        /// <returns>All appointments with the accepted PatientID</returns>
        public List<Appointment> GetAppointmentsByPatientID(int selectedRowPatientID)
        {
            return this.appointmentDAL.GetAppointmentsByPatientID(selectedRowPatientID);
        }

       // public bool editAppointment(Appointment oldAppointment, Appointment editedAppointmnet)
       // {
        //    return this.appointmentDAL.      
     //  }
    }
}

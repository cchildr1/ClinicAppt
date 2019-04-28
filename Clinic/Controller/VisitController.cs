using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;

namespace Clinic.Controller
{
    /// <summary>
    /// Retrieves objects from DAL and returns to view for use
    /// </summary>
    public class VisitController
    {
        private readonly VisitDAL visitDAL = new VisitDAL();
        private List<Visit> visits;

        /// <summary>
        /// Initializes visits to everything in DB
        /// </summary>
        public VisitController()
        {
            this.visits = this.visitDAL.GetAllVisits();
        }

        /// <summary>
        /// Returns all visits as list
        /// </summary>
        /// <returns>List of all visits</returns>
        public List<Visit> GetAllVisits()
        {
            return this.visits;
        }

        /// <summary>
        /// Reloads the List<Visit> member variable
        /// </summary>
        /// <returns>The list of visits object</returns>
        public List<Visit> RefreshVisits()
        {
            this.visits = this.visitDAL.GetAllVisits();
            return this.visits;
        }

        /// <summary>
        /// Gets the visit by id number.
        /// </summary>
        /// <param name="id">Visit ID value</param>
        /// <returns>Visit object</returns>
        public Visit GetVisitByID(int id)
        {
            return this.visitDAL.GetVisitByID(id);
        }

        /// <summary>
        /// Searches the list and returns only the values that match
        /// </summary>
        /// <param name="doctorID">doctor id</param>
        /// <param name="nurseID">nurse id</param>
        /// <param name="patient">patient name, does not have to be exact only contains</param>
        /// <param name="appointmentStart">start date to search for appointment</param>
        /// <param name="appointmentEnd">end date to search for appointment date</param>
        /// <param name="visitStart">start date to search for visit date</param>
        /// <param name="visitEnd">end date to search for visit date</param>
        /// <returns></returns>
        public List<Visit> SearchVisits(int doctorID, int nurseID, string patient, 
            DateTime appointmentStart, DateTime appointmentEnd,
            DateTime visitStart, DateTime visitEnd)
        {
            List<Visit> visits = this.visits;
            if (doctorID != 0)
            {
                visits = this.SearchByDoctorID(doctorID, visits);
            }
            if (nurseID != 0)
            {
                visits = this.SearchByNurseID(nurseID, visits);
            }
            if (patient != "")
            {
                visits = this.SearchByPatient(patient, visits);
            }
            visits = this.SearchByAppointmentDate(appointmentStart, appointmentEnd, visits);
            visits = this.SearchByVisitDate(visitStart, visitEnd, visits);
            return visits;
            
        }

        /// <summary>
        /// Edits a visit in the database
        /// </summary>
        /// <param name="oldVisit">old visit</param>
        /// <param name="newVisit">new visit</param>
        /// <returns>true if successful, false otherwise.</returns>
        public bool EditVisit(Visit oldVisit, Visit newVisit)
        {
            return this.visitDAL.UpdateVisit(oldVisit, newVisit);
        }

        /// <summary>
        /// Adds a new visit to the DB for the visit object
        /// </summary>
        /// <param name="visit">visit object to add</param>
        /// <returns>int confirming if true or not</returns>
        public int AddVisit(Visit visit)
        {
            return this.visitDAL.AddNewVisit(visit);
        }

        /// <summary>
        /// REturns visit from DAL based on appointment id
        /// </summary>
        /// <param name="id">appointment id</param>
        /// <returns>Visit object</returns>
        public Visit GetVisitByAppointmentID(int id)
        {
            return this.visitDAL.GetVisitByAppointmentID(id);
        }

        private List<Visit> SearchByPatient(string patient, List<Visit> visits)
        {
            return visits.FindAll(V => V.Appointment.Patient.FullName.ToLower().Contains(patient.ToLower()));
        }

        private List<Visit> SearchByDoctorID(int doctorID, List<Visit> visits)
        {
            return visits.FindAll(V => V.Appointment.Doctor.DoctorId.Equals(doctorID));
        }

        private List<Visit> SearchByNurseID(int nurseID, List<Visit> visits)
        {
            return visits.FindAll(V => V.Nurse.NurseID.Equals(nurseID));
        }

        private List<Visit> SearchByAppointmentDate(DateTime appointmentStart, DateTime appointmentEnd, List<Visit> visits)
        {
            return visits.FindAll(V => (V.Appointment.Scheduled_Date.Date >= appointmentStart.Date && V.Appointment.Scheduled_Date.Date <= appointmentEnd.Date));
        }

        private List<Visit> SearchByVisitDate(DateTime visitStart, DateTime visitEnd, List<Visit> visits)
        {
            return visits.FindAll(V => V.DateTime.Date >= visitStart.Date && V.DateTime.Date <= visitEnd.Date);
        }

    }
}

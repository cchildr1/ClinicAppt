using System;

namespace Clinic.Model
{
    /// <summary>
    /// This is the appointment class it contains all the information needed for appointments
    /// </summary>
    public class Appointment
    {
        //Getters and setters for Appointment values
        public int AppointmentID { get; set; }
        public DateTime Scheduled_Date { get; set; }
        public string Reason_For_Visit { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        
    }
}

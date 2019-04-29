using System;

namespace Clinic.Model
{
    /// <summary>
    /// Represents a visit, contains the date and all biometric information
    /// </summary>
    public class Visit
    {
        public int VisitId { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Weight { get; set; }
        public int BpSystolic { get; set; }
        public int BpDiastolic { get; set; }
        public decimal BodyTemperature { get; set; }
        public int Pulse { get; set; }
        public string Symptoms { get; set; }
        public string Info { get; set; }
        public Nurse Nurse { get; set; }
        public Appointment Appointment { get; set; }
        public string InitialDiagnosis { get; set; }
        public string FinalDiagnosis { get; set; }
    }
}

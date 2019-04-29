namespace Clinic.Model
{
    /// <summary>
    /// A patient in the clinic.
    /// Represents a patient and contains the patient id, extends person
    /// </summary>
    public class Patient : Person
    {
        public int PatientID { get; set; }
        public int Status { get; set; }
    }
}

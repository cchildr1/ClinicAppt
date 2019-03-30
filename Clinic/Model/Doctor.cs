namespace Clinic.Model
{
    /// <summary>
    /// Represents a doctor containing their id and all person information, extends person
    /// </summary>
    public class Doctor : Person
    {
        //Getters and setters for Doctor value
        public int DoctorId { get; set; }
    }
}

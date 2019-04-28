namespace Clinic.Model
{
    /// <summary>
    /// Represents a doctor containing their id and all person information, extends person
    /// </summary>
    public class Doctor : Person
    {
        public int DoctorId { get; set; }
    }
}

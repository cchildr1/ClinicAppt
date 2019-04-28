namespace Clinic.Model
{
    /// <summary>
    /// Nurse
    /// Subclass of Employee
    /// </summary>
    public class Nurse : Employee
    {
        public int NurseID { get; set; }
        public int StatusID { get; set; }
    }
}

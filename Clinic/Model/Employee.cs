using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Text;

namespace Clinic.Model
{
    /// <summary>
    /// Represents an employee that can log into the system.
    /// Parent class of Nurse and admin
    /// </summary>
    public class Employee : Person
    {
        //Getters and setters for Employee values
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[] HashedPassword { get; set; }

        public byte[] GetPasswordHash()
        {
            byte[] data = Encoding.GetEncoding(1252).GetBytes(Password);
            var sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(data);
            return hash;
        }
    }
}

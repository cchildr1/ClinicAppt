using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}

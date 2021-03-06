﻿namespace Clinic.Model
{
    /// <summary>
    /// Represents an employee that can log into the system.
    /// Parent class of Nurse and admin
    /// </summary>
    public class Employee : Person
    {
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[] HashedPassword { get; set; }
    }
}
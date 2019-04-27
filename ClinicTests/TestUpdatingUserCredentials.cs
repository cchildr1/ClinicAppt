using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clinic.Model;
using Clinic.DAL;
using Clinic.Controller;

namespace ClinicTests
{
    [TestClass]
    public class TestUpdatingUserCredentials
    {
        [TestMethod]
        public void GetProperCreds()
        {
            Employee oldEmployee = new Employee
            {
                UserName = "CharlieStrong",
                Password = "password",
                EmployeeID = 118,
                PersonId = 147
            };
            Employee newEmployee = new Employee
            {
                UserName = "CharlieStrong",
                Password = "password1",
                EmployeeID = 118,
                PersonId = 147
            };
            EmployeeController employeeController = new EmployeeController();
            bool updated = employeeController.EditEmployeeInfo(newEmployee, oldEmployee);
            Assert.IsTrue(updated);
        }

        [TestMethod]
        public void GetImproperCreds()
        {
            Employee oldEmployee = new Employee
            {
                UserName = "CharlieStrong",
                Password = "gobbledeegook",
                EmployeeID = 118,
                PersonId = 147
            };
            Employee newEmployee = new Employee
            {
                UserName = "CharlieStrong",
                Password = "fhhfhffhfh",
                EmployeeID = 118,
                PersonId = 147
            };
            EmployeeController employeeController = new EmployeeController();
            bool updated = employeeController.EditEmployeeInfo(newEmployee, oldEmployee);
            Assert.IsFalse(updated);
        }
    }
}

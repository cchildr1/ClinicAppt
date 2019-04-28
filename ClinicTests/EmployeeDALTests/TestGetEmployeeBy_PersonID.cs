using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clinic.Controller;
using Clinic.Model;
using System.Diagnostics;

namespace ClinicTests.EmployeeDALTests
{
    [TestClass]
    public class TestGetEmployeeBy_PersonID
    {
        [TestMethod]
        public void TestComparingHashValue()
        {
            //create a new employee object that's already in the database.
            Employee inMemoryEmployee = new Employee
            {
                EmployeeID = 118,
                PersonId = 147,
                UserName = "CharlieStrong"
            };
            inMemoryEmployee.SetPasswordAsString("password1");

            //fetch the same employee from the database using the method to test.
            EmployeeController controller = new EmployeeController();
            Employee dbEmployee = controller.GetEmployeeBy_PersonID(147);

            //assert that usernames are the same.
            Assert.AreEqual(inMemoryEmployee.UserName, dbEmployee.UserName);
            Assert.AreEqual(inMemoryEmployee.Password, dbEmployee.Password);
        }
    }
}

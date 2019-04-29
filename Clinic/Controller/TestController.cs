using System.Collections.Generic;
using Clinic.Model;
using Clinic.DAL;

namespace Clinic.Controller
{
    /// <summary>
    /// Controller for the TestDAL
    /// </summary>
    public class TestController
    {
        /// <summary>
        /// Returns a list of all the test codes in the database.
        /// </summary>
        /// <returns>List of all test codes</returns>
        public List<Test> GetAllTestCodes()
        {
            return TestDAL.GetAllTestCodes();
        }
    }
}

using System.Collections.Generic;
using Clinic.Model;
using Clinic.DAL;

namespace Clinic.Controller
{
    public class TestController
    {
        public List<Test> GetAllTestCodes()
        {
            return TestDAL.GetAllTestCodes();
        }
    }
}

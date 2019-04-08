using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Model;
using Clinic.DAL;

namespace Clinic.Controller
{
    /// <summary>
    /// Provides 
    /// </summary>
    public class TestController
    {
       
        public List<Test> getAllTestCodes()
        {
            return TestDAL.getAllTestCodes();
        }

        public List<Test> getTestsForVisit(int visitID)
        {
            return TestDAL.getAllTestsForVisit(visitID);
        }
    }
}

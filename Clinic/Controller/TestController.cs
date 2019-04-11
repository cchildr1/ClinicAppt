using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

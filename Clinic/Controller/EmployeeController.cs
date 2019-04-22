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
    /// This is the employeeController class it will help edit/set/get employee datat
    /// </summary>
    public class EmployeeController
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();
        public bool EditEmployeeInfo(Employee editedEmployee)
        {
            return this.employeeDAL.EditEmployeeInfo();
        }
    }
}

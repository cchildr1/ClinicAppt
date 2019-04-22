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

        /// <summary>
        /// returns true if the employee is successfully updated
        /// </summary>
        /// <param name="editedEmployee"></param>
        /// <param name="old_employee"></param>
        /// <returns></returns>
        public bool EditEmployeeInfo(Employee editedEmployee, Employee old_employee)
        {
            return this.employeeDAL.EditEmployeeInfo(editedEmployee, old_employee);
        }

        /// <summary>
        /// This method returns the employee eqaul to the personID
        /// </summary>
        /// <param name="personID"></param>
        /// <returns></returns>
        public Employee GetEmployeeBy_PersonID(int personID)
        {
            return this.employeeDAL.GetEmployeeBy_PersonID(personID);
        }

        /// <summary>
        /// This method adds a employee to the database
        /// </summary>
        /// <param name="addedEmployee"></param>
        public void AddEmployeeInfo(Employee addedEmployee)
        {
            this.employeeDAL.AddEmployee(addedEmployee);
        }
    }
}

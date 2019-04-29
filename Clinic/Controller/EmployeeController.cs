using Clinic.Model;
using Clinic.DAL;

namespace Clinic.Controller
{
    /// <summary>
    /// This is the employeeController class. Helps edit/set/get employee datasets.
    /// </summary>
    public class EmployeeController
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();

        /// <summary>
        /// returns true if the employee is successfully updated
        /// </summary>
        /// <param name="editedEmployee">The new employee object</param>
        /// <param name="old_employee">The existing employee object to upate</param>
        /// <returns>Yes/No if was successful</returns>
        public bool EditEmployeeInfo(Employee editedEmployee, Employee old_employee)
        {
            return this.employeeDAL.EditEmployeeInfo(editedEmployee, old_employee);
        }

        /// <summary>
        /// This method returns the employee eqaul to the personID
        /// </summary>
        /// <param name="personID">PersonID value.</param>
        /// <returns>the coresponding Employee object</returns>
        public Employee GetEmployeeBy_PersonID(int personID)
        {
            return this.employeeDAL.GetEmployeeBy_PersonID(personID);
        }

        /// <summary>
        /// This method adds a employee to the database
        /// </summary>
        /// <param name="addedEmployee">The employee object to add</param>
        public void AddEmployeeInfo(Employee addedEmployee)
        {
            this.employeeDAL.AddEmployee(addedEmployee);
        }
    }
}

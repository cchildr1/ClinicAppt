using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;

namespace Clinic.Controller
{
    /// <summary>
    /// Interacts with DAL to get nurse objects
    /// </summary>
    public class NurseController
    {
        NurseDAL nurseDAL = new NurseDAL();
        /// <summary>
        /// Returns a list of all nurses
        /// </summary>
        /// <returns></returns>
        public List<Nurse> GetAllNurses()
        {
            return this.nurseDAL.GetAllNurses();
        }

        /// <summary>
        /// Returns a list of all nurses with a value equal to the accepted lastname
        /// </summary>
        /// <param name="lastname"></param>
        /// <returns></returns>
        public List<Nurse> GetNurseByLastName(string lastname)
        {
            return this.nurseDAL.GetAllNursesByLastname(lastname);
        }

        /// <summary>
        /// Returns a list of all nurses with full names equal to the accepted first and last names
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <returns></returns>
        public List<Nurse> GetNurseByFullName(string firstname, string lastname)
        {
            return this.nurseDAL.GetNurseByFullName(firstname, lastname);
        }

        /// <summary>
        /// Returns a list of all nurses with a value equal to the accepted firstname
        /// </summary>
        /// <param name="firstname"></param>
        /// <returns></returns>
        public List<Nurse> GetNurseByFirstName(string firstname)
        {
            return this.nurseDAL.GetAllNursesByFirstname(firstname);
        }


        /// <summary>
        /// This method returns true if the accepted SSN value is NOT present within the database
        /// </summary>
        /// <returns></returns>
        public bool IsSSN_Not_Duplicate(string ssn)
        {
            return this.nurseDAL.IsSSN_Not_Duplicate(ssn);
        }

        /// <summary>
        /// This method will enter the accepted Nurse value into the database
        /// </summary>
        /// <param name="nurse"></param>
        public void Addnurse(Nurse addedNurse)
        {
            this.nurseDAL.AddNurse(addedNurse);
        }

        /// <summary>
        /// Returns the nurse with an Id eqaul to the accepted value
        /// </summary>
        /// <param name="selectedNurseID"></param>
        /// <returns></returns>
        public Nurse GetNurseById(int selectedNurseID)
        {
            return NurseDAL.GetNurseByID(selectedNurseID);
        }
    }
}

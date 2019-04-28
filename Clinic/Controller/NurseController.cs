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
        /// <returns>List of Nurses.</returns>
        public List<Nurse> GetAllNurses()
        {
            return this.nurseDAL.GetAllNurses();
        }

        /// <summary>
        /// Returns a list of all nurses with a value equal to the accepted lastname
        /// </summary>
        /// <param name="lastname"></param>
        /// <returns>List of Nurses.</returns>
        public List<Nurse> GetNurseByLastName(string lastname)
        {
            return this.nurseDAL.GetAllNursesByLastname(lastname);
        }

        /// <summary>
        /// Returns a list of all nurses with full names equal to the accepted first and last names
        /// </summary>
        /// <param name="firstname">Nurse first name</param>
        /// <param name="lastname">Nurse last name</param>
        /// <returns>List of Nurses.</returns>
        public List<Nurse> GetNurseByFullName(string firstname, string lastname)
        {
            return this.nurseDAL.GetNurseByFullName(firstname, lastname);
        }

        /// <summary>
        /// Returns a list of all nurses with a value equal to the accepted firstname
        /// </summary>
        /// <param name="firstname">Nurse first name</param>
        /// <returns>List of Nurses.</returns>
        public List<Nurse> GetNurseByFirstName(string firstname)
        {
            return this.nurseDAL.GetAllNursesByFirstname(firstname);
        }


        /// <summary>
        /// This method returns true if the accepted SSN value is NOT present within the database
        /// </summary>
        /// <param name="ssn">Social Security Number</param>
        /// <returns>Yes/No if the SSN is a duplicate</returns>
        public bool IsSSN_Not_Duplicate(string ssn)
        {
            return this.nurseDAL.IsSSN_Not_Duplicate(ssn);
        }


        /// <summary>
        /// This method will enter the accepted Nurse value into the database.
        /// </summary>
        /// <param name="addedNurse">Nurse object to add</param>
        /// <returns>Nurse object</returns>
        public Nurse Addnurse(Nurse addedNurse)
        {
           return this.nurseDAL.AddNurse(addedNurse);
        }

        /// <summary>
        /// Returns the nurse with an Id eqaul to the accepted value
        /// </summary>
        /// <param name="selectedNurseID">Nurse ID number</param>
        /// <returns>Nurse object</returns>
        public Nurse GetNurseById(int selectedNurseID)
        {
            return NurseDAL.GetNurseByID(selectedNurseID);
        }

        ////
        /// <summary>
        /// This method updates the editedNurse to the nurse value 
        /// and insures that the old nurse was not edited by a different user in the interum
        /// </summary>
        /// <param name="nurse">new nurse values</param>
        /// <param name="editedNurse">old nurse value</param>
        public bool updateNurse(Nurse nurse, Nurse editedNurse)
        {
            return this.nurseDAL.UpdateNurse(nurse, editedNurse);
        }

        /// <summary>
        /// This method changes the status of the nurse to the accepted valuemember
        /// </summary>
        /// <param name="nurseID">NurseID</param>
        /// <param name="valueMember">Value Member</param>
        public void ChangeStatus(int nurseID, int valueMember)
        {
            this.nurseDAL.ChangeStatus(nurseID, valueMember);
        }
    }
}

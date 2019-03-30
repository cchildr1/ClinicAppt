using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;

namespace Clinic.Controller
{
    /// <summary>
    /// This is the PatientController class which guides the views which deal with patients
    /// </summary>
    class PatientController
    {
        PatientDAL patientDAL = new PatientDAL();
        /// <summary>
        /// Returns a list of all Patients
        /// </summary>
        /// <returns>a list of all Patients</returns>
        public List<Patient> GetAllPatients()
        {
            return this.patientDAL.GetAllPatients();
        }

        /// <summary>
        /// Returns Patient equal to paientID
        /// </summary>
        /// <param name="patientID">acceped PatientID</param>
        /// <returns>The patient equal to the accepted patientID</returns>
        public Patient GetPatientByID(int patientID)
        {
            return this.patientDAL.GetPatientByID(patientID);
        }

        /// <summary>
        /// Returns a list of patients equal to the accepted first/last names and Date of birth DOB
        /// if either first or last or both names are equal to "" there is error checking to return values from most complete to just the DOB
        /// </summary>
        /// <param name="firstname">accepted patients first name</param>
        /// <param name="lastname">accepted patients last name</param>
        /// <param name="dateOfBirth">accepted patients DOB</param>
        /// <returns>List of Patient's equal to the accepted values</returns>
        public List<Patient> PatientByFirst_Last_DOB(string firstname, string lastname, DateTime dateOfBirth)
        {
            if (firstname != "" && lastname != "")
            {
                return this.patientDAL.GetPatientByFirst_Last_DOB(firstname, lastname, dateOfBirth);
            }
            else if (firstname != "")
            {
                return this.patientDAL.GetPatientByFirstName_DOB(firstname, dateOfBirth);
            }
            else if (lastname != "")
            {
                return this.patientDAL.GetPatientByLastName_DOB(lastname, dateOfBirth);
            }
            else return this.patientDAL.GetAllPatients_DOB(dateOfBirth);
        }

        /// <summary>
        /// Returns a list of Patients equal to the first and or last names
        /// error checking goes both values to checking either one
        /// </summary>
        /// <param name="firstname">patient's firstname</param>
        /// <param name="lastname">patient's lastname</param>
        /// <returns>A list of patients equal to the entered values</returns>
        public List<Patient> PatientByWithoutDOB_Firstname_LastName(string firstname, string lastname)
        {
            if (firstname != "" && lastname != "")
            {
                return this.patientDAL.PatientByFirst_LastName(firstname, lastname);
            }
            else if (firstname != "")
            {
                return this.patientDAL.GetPatientByFirstName_Only(firstname);
            }
            else if (lastname != "")
            {
                return this.patientDAL.GetPatientByLastName_Only(lastname);
            }
            else return this.patientDAL.GetPatientByLastName_Only(lastname);
        }
    }
}

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

        /// <summary>
        /// This method allows users to edit existing patients
        /// </summary>
        /// <param name="oldPatient">Accepted old patient to insure patient has not been edited since being selected</param>
        /// <param name="editedPatient">What the old patient will be edited too</param>
        public bool EditPatient(Patient oldPatient, Patient editedPatient)
        {
            return patientDAL.UpdatePatient(oldPatient, editedPatient);
        }

        /// <summary>
        /// This method adds the accepted patient to the database
        /// </summary>
        /// <param name="addedPatient"></param>
        public void AddPatient(Patient addedPatient)
        {
            this.patientDAL.AddPatient(addedPatient);
        }


        /// <summary>
        /// This method returns true if the accepted SSN value is NOT present within the database
        /// </summary>
        /// <returns></returns>
        public bool IsSSN_Not_Duplicate(string ssn)
        {
            return this.patientDAL.IsSSN_Not_Duplicate(ssn);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Model;
using Clinic.DAL;

namespace Clinic.Controller
{
    class PatientController
    {
        public List<Patient> GetAllPatients()
        {
            return PatientDAL.GetAllPatients();
        }

        public Patient GetPatientByID(int patientID)
        {
            return PatientDAL.GetPatientByID(patientID);
        }

        public List<Patient> PatientByFirst_Last_DOB(string firstname, string lastname, DateTime dateOfBirth)
        {
            if (firstname != "" && lastname != "")
            {
                return PatientDAL.GetPatientByFirst_Last_DOB(firstname, lastname, dateOfBirth);
            }
            else if (firstname != "")
            {
                return PatientDAL.GetPatientByFirstName_DOB(firstname, dateOfBirth);
            }
            else if (lastname != "")
            {
                return PatientDAL.GetPatientByLastName_DOB(lastname, dateOfBirth);
            }
            else return PatientDAL.GetAllPatients_DOB(dateOfBirth);
        }

        public List<Patient> PatientByWithoutDOB_Firstname_LastName(string firstname, string lastname)
        {
            if (firstname != "" && lastname != "")
            {
                return PatientDAL.PatientByFirst_LastName(firstname, lastname);
            }
            else if (firstname != "")
            {
                return PatientDAL.GetPatientByFirstName_Only(firstname);
            }
            else if (lastname != "")
            {
                return PatientDAL.GetPatientByLastName_Only(lastname);
            }
            else return PatientDAL.GetPatientByLastName_Only(lastname);
        }
    }
}

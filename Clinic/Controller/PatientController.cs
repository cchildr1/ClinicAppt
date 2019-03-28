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
            return PatientDAL.GetPatientByFirst_Last_DOB(firstname, lastname, dateOfBirth);
        }
    }
}

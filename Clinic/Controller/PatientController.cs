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
    }
}

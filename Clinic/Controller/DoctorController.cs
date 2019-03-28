using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.DAL;
using Clinic.Model;

namespace Clinic.Controller
{
    class DoctorController
    {

        public List<Doctor> GetAllDoctors()
        {
            return DoctorDAL.GetAllDoctors();
        }

        public Doctor GetDoctorByID(int doctorID)
        {
            return DoctorDAL.GetDoctorByID(doctorID);
        }
    }
}

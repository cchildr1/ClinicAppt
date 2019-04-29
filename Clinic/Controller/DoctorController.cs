using Clinic.DAL;
using Clinic.Model;
using System.Collections.Generic;

namespace Clinic.Controller
{
    /// <summary>
    /// Controls the DoctorDAL.
    /// </summary>
    class DoctorController
    {

        /// <summary>
        /// Returns a list of All Doctors
        /// </summary>
        /// <returns>All Doctors</returns>
        public List<Doctor> GetAllDoctors()
        {
            return DoctorDAL.GetAllDoctors();
        }

        /// <summary>
        /// Returns Doctor equal to the accepted DoctorID
        /// </summary>
        /// <param name="doctorID">accepted Doctor ID</param>
        /// <returns>Doctor equal to accepted DoctorID</returns>
        public Doctor GetDoctorByID(int doctorID)
        {
            return DoctorDAL.GetDoctorByID(doctorID);
        }
    }
}

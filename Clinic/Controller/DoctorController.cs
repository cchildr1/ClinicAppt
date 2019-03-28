﻿using System;
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

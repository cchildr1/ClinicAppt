﻿using Clinic.DAL;
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
    }
}

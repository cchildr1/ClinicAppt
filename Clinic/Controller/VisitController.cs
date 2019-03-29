﻿using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Controller
{
    /// <summary>
    /// Retrieves objects from DAL and returns to view for use
    /// </summary>
    public class VisitController
    {
        private VisitDAL visitDAL = new VisitDAL();
        private List<Visit> visits;

        public VisitController()
        {
            this.visits = this.visitDAL.GetAllVisits();
        }

        public List<Visit> GetAllVisits()
        {
            return this.visits;
        }

        public List<Visit> SearchVisits(int doctorID)
        {
            List<Visit> visits = this.visits;
            if (doctorID != -1)
            {
                visits = this.SearchByDoctorID(doctorID, visits);
            }

            return visits;
            
        }

        private List<Visit> SearchByDoctorID(int doctorID, List<Visit> visits)
        {
            return visits.FindAll(V => V.Appointment.Doctor.DoctorId.Equals(doctorID));
        }
    }
}

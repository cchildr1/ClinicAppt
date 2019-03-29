using Clinic.DAL;
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

        public List<Visit> GetAllVisits()
        {
            return this.visitDAL.GetAllVisits();
        }
    }
}

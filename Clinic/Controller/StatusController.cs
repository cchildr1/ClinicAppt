using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Model;
using Clinic.DAL;

namespace Clinic.Controller
{
    /// <summary>
    /// This class gets all the status for the nurses 
    /// </summary>
    class StatusController
    {
        public StatusDAL statusDAL = new StatusDAL();

        //returns all possible status within the database
        public List<Status> GetAllStatusTypes()
        {
            return this.statusDAL.GetAllStatusTypes();
        }
    }
}

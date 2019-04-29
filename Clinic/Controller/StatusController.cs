using System.Collections.Generic;
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

        /// <summary>
        /// returns all possible status within the database
        /// </summary>
        /// <returns>List of all statuses</returns>
        public List<Status> GetAllStatusTypes()
        {
            return this.statusDAL.GetAllStatusTypes();
        }

        /// <summary>
        /// Returns the Status equal to the accepted Status ID
        /// </summary>
        /// <param name="statusID">Status ID value</param>
        /// <returns>Status object</returns>
        public Status GetStatusByID(int statusID)
        {
            return this.statusDAL.GetStatusByID(statusID);
        }
    }
}

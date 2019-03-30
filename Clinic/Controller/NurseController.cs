using Clinic.DAL;
using Clinic.Model;
using System.Collections.Generic;

namespace Clinic.Controller
{
    /// <summary>
    /// Interacts with DAL to get nurse objects
    /// </summary>
    public class NurseController
    {

        public List<Nurse> GetAllNurses()
        {
            return NurseDAL.GetAllNurses();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.DAL;
using Clinic.Model;

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

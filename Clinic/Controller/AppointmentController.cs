using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Model;
using Clinic.DAL;

namespace Clinic.Controller
{
    class AppointmentController
    {
        private AppointmentDAL appointmentDAL = new AppointmentDAL();

        public List<Appointment> GetAppointments()
        {
            return this.appointmentDAL.GetAppointments();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime Scheduled_Date { get; set; }
        public string Reason_For_Visit { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        
    }
}

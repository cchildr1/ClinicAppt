using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{
    class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime Scheduled_Date { get; set; }
        public string Reason_For_Visit { get; set; }
        public int Doctor_ID { get; set; }
        public int Patient_ID { get; set; }
        
    }
}

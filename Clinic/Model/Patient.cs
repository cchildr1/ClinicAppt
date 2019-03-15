using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{
    /// <summary>
    /// 
    /// Represents a patient and contains the patient id, extends person
    /// </summary>
    public class Patient : Person
    {
        public int PatientID { get; set; }
    }
}

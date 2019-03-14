using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{
    /// <summary>
    /// Represents person table with all information
    /// </summary>
    public abstract class Person
    {
        public int id { get; set; }
        public string firstName {get; set;}
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string socialSecurityNumber { get; set; }
        public string gender { get; set; }
        public string streetAddress { get; set; }
        public string phone { get; set; }
        public string zipcode { get; set; }

    }
}

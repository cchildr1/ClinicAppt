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
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Gender { get; set; }
        public string StreetAddress { get; set; }
        public string Phone { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

    }
}

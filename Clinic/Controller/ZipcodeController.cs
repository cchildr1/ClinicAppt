using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.DAL;

namespace Clinic.Controller
{
    /// <summary>
    /// This is the ZipcodeController it will return other values such as 
    /// </summary>
    class ZipcodeController
    {
        private ZipcodeDAL zipcodeDAL = new ZipcodeDAL();

        public bool IsValidZipCode(string zipcode)
        {
            return this.zipcodeDAL.IsValidZipcode(zipcode);
        }
    }
}

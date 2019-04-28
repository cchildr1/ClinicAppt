using Clinic.DAL;

namespace Clinic.Controller
{
    /// <summary>
    /// This is the ZipcodeController it will return other values such as 
    /// </summary>
    class ZipcodeController
    {
        private ZipcodeDAL zipcodeDAL = new ZipcodeDAL();

        /// <summary>
        /// This method insures that the accepted zipcode is a valid one
        /// must be one of the 42000 zipcodes in the USA
        /// </summary>
        /// <param name="zipcode"></param>
        /// <returns></returns>
        public bool IsValidZipCode(string zipcode)
        {
            return this.zipcodeDAL.IsValidZipcode(zipcode);
        }

        /// <summary>
        /// This method returns the state that contains the accepted Zipcode 
        /// </summary>
        /// <param name="zipcode"></param>
        /// <returns></returns>
        public string GetStateFromZipcode(string zipcode)
        {
            return this.zipcodeDAL.GetStateByZipcode(zipcode);
        }
        
        /// <summary>
        /// This method returns the city from the accepted Zipcode is assocated with
        /// </summary>
        /// <param name="zipcode"></param>
        /// <returns></returns>
        public string GetCityFromZipcode(string zipcode)
        {
            return this.zipcodeDAL.GetCityByZipcode(zipcode);
        }
    }
}

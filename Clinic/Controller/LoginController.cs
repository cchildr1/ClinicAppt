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
    /// Controller for login form
    /// </summary>
    public class LoginController
    {
        /// <summary>
        /// Returns employee if username and password matches entry in DB
        /// </summary>
        /// <param name="username">employee's username</param>
        /// <param name="password">employee's password</param>
        /// <returns>employee if username and password matches, null otherwise</returns>
        public Employee LoginEmployee(string username, string password)
        {
            return LoginDAL.LoginEmployee(username, password);
        }
    }
}

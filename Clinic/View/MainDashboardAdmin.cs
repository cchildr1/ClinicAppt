using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// This is the MainDashboardAdmin class - it will contain all the functionality for the Clinic's admin 
    /// </summary>
    public partial class MainDashboardAdmin : Form
    {
        /// <summary>
        /// Initializes all the aspects of the MainDashboardAdmin
        /// </summary>
        public MainDashboardAdmin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This sets the welcome lbl to welcome + the logged in username
        /// </summary>
        /// <param name="welcomeName"></param>
        public void SetLoggedInName(string welcomeName)
        {
            this.WelcomeLBL.Text = "Welcome " + welcomeName;
        }
    }
}

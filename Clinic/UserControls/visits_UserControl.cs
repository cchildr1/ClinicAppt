using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.Controller;
using Clinic.Model;

namespace Clinic.UserControls
{
    /// <summary>
    /// Displays initial visit information and allows user to add and edit a visit
    /// </summary>
    public partial class visits_UserControl : UserControl
    {
        private VisitController controller = new VisitController();
        private List<Visit> visits = new List<Visit>();
        /// <summary>
        /// Constructor
        /// </summary>
        public visits_UserControl()
        {
            InitializeComponent();
            this.visits = this.controller.GetAllVisits();
            this.visitDataGridView.DataSource = this.visits;
        }
    }
}

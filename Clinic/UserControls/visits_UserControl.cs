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
        private VisitController visitController = new VisitController();
        private DoctorController doctorController = new DoctorController();
        private List<Visit> visits = new List<Visit>();
        /// <summary>
        /// Constructor
        /// </summary>
        public visits_UserControl()
        {
            InitializeComponent();
            this.PopulateDoctorComboBox();
            this.PopulateDataGridView(this.visitController.GetAllVisits());
        }

        private void PopulateDataGridView(List<Visit> visits)
        {
            this.visitDataGridView.Rows.Clear();
            foreach (Visit visit in visits) {
                string[] row =
                {
                    visit.DateTime.ToString(),
                    visit.Appointment.Scheduled_Date.ToString(),
                    visit.Appointment.Patient.FullName,
                    visit.Appointment.Doctor.FullName,
                    visit.Nurse.FullName,
                    visit.Symptoms
                };
                this.visitDataGridView.Rows.Add(row);
            }
        }

        private void PopulateDoctorComboBox()
        {
            this.DoctorComboBox.DataSource = this.doctorController.GetAllDoctors();
            this.DoctorComboBox.ValueMember = "DoctorId";
            this.DoctorComboBox.DisplayMember = "FullName";
            this.DoctorComboBox.SelectedIndex = -1;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (this.DoctorComboBox.SelectedIndex == -1)
            {
                return;
            }
            this.PopulateDataGridView(this.visitController.SearchVisits((int)this.DoctorComboBox.SelectedValue));
        }
    }
}

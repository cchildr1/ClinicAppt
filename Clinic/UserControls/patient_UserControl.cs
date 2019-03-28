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
    public partial class patient_UserControl : UserControl
    {
        private bool DOB_ValueChanged = false;
        private PatientController patientController = new PatientController();
        public patient_UserControl()
        {
            InitializeComponent();
        }

        private void SearchAppointment_button_Click(object sender, EventArgs e)
        {
            this.patients_datagridview.DataSource = null;
            if (this.DOB_ValueChanged)
            {
                DateTime selected_DOB = this.DateOfBirth_datetimePicker.Value;
                this.patients_datagridview.DataSource = this.patientController.PatientByFirst_Last_DOB(this.firstname_textbox.Text, this.lastname_textbox.Text, selected_DOB.Date);
            }
            else 
            {
                this.patients_datagridview.DataSource = this.patientController.PatientByWithoutDOB_Firstname_LastName(this.firstname_textbox.Text, this.lastname_textbox.Text);
            }

        }

        private void DateOfBirth_datetimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.DOB_ValueChanged = true;
        }

        private void ResetDateOfBirth_Click(object sender, EventArgs e)
        {
            this.DateOfBirth_datetimePicker.Value = DateTime.Now;
            this.DOB_ValueChanged = false;
          
        }
    }
}

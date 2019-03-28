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
            if (this.firstname_textbox.Text != "" && this.lastname_textbox.Text != "" && this.DOB_ValueChanged)
            {
                this.patients_datagridview.DataSource = this.patientController.PatientByFirst_Last_DOB(this.firstname_textbox.Text, this.lastname_textbox.Text, this.DateOfBirth_datetimePicker.Value);
            }
        }

        private void DateOfBirth_datetimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.DOB_ValueChanged = true;
        }
    }
}

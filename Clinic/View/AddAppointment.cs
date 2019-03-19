using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.Controller;

namespace Clinic.View
{
    public partial class AddAppointment : Form
    {
        private DoctorController doctorController = new DoctorController();
        private PatientController patientController = new PatientController();
        public AddAppointment()
        {
            InitializeComponent();
            this.SetUpDoctor_ComboBox();
            this.SetUpPatient_ComboBox();
        }

        private void SetUpDoctor_ComboBox()
        {
            this.Doctor_ComboBox.DataSource = this.doctorController.GetAllDoctors();
            this.Doctor_ComboBox.DisplayMember = "FullName";
            this.Doctor_ComboBox.ValueMember = "DoctorID";
            this.Doctor_ComboBox.SelectedIndex = -1;
        }

        private void SetUpPatient_ComboBox()
        {
            this.Patient_ComboBox.DataSource = this.patientController.GetAllPatients();
            this.Patient_ComboBox.DisplayMember = "FullName";
            this.Patient_ComboBox.ValueMember = "PatientID";
            this.Patient_ComboBox.SelectedIndex = -1;
        }
   

        private void cancelAddAppointment_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

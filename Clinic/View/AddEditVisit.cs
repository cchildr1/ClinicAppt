using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.Model;
using Clinic.Controller;

namespace Clinic.View
{
    public partial class AddEditVisit : Form
    {
        private NurseController nurseController = new NurseController();
        private Form mainForm;
        private Visit oldVisit;
        public AddEditVisit(Visit visit)
        {
            InitializeComponent();
            this.oldVisit = visit;
            this.patientTextBox.Text = visit.Appointment.Patient.FullName;
            this.doctorTextBox.Text = visit.Appointment.Doctor.FullName;
            this.PopulateNurseComboBox();
            this.DTPVisitDate.Value = visit.DateTime.Date;
            this.DTPVisitTime.Value = visit.DateTime.ToLocalTime();
            this.bpDiastolicTextBox.Text = visit.BpDiastolic.ToString();
            this.bpSystolicTextBox.Text = visit.BpSystolic.ToString();
            this.weightTextBox.Text = visit.Weight.ToString();
            this.pulseTextBox.Text = visit.Pulse.ToString();
            this.symptomsTextBox.Text = visit.Symptoms;
            this.initialDiagnosisTextBox.Text = visit.InitialDiagnosis;
            this.finalDiagnosisTextBox.Text = visit.FinalDiagnosis;
        }

        private void PopulateNurseComboBox()
        {
            List<Nurse> nurses = this.nurseController.GetAllNurses();
            nurses.OrderBy(N => N.FullName).ToList();
            this.NurseComboBox.DataSource = nurses;
            this.NurseComboBox.ValueMember = "NurseID";
            this.NurseComboBox.DisplayMember = "FullName";
            this.NurseComboBox.SelectedValue = this.oldVisit.Nurse.NurseID;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            // code for updating goes here

            this.Dispose();
        }

        private Nurse GetNewNurse()
        {
            return null;
        }
    }
}

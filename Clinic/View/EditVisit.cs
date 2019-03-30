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
    /// <summary>
    /// Form for editing and creating a visit.
    /// </summary>
    public partial class EditVisit : Form
    {
        private NurseController nurseController;
        private VisitController visitController;
        private Visit oldVisit;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="visit">visit to add to form</param>
        public EditVisit(Visit visit)
        {
            InitializeComponent();
            this.nurseController = new NurseController();
            this.visitController = new VisitController();
            if (visit != null)
            {
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
                this.bodyTemperatureTextBox.Text = visit.BodyTemperature.ToString();
                this.infoTextBox.Text = visit.Info;
            }
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
            Visit newVisit = new Visit
            {
                DateTime = this.DTPVisitDate.Value.Date + this.DTPVisitTime.Value.TimeOfDay,
                Weight = decimal.Parse(weightTextBox.Text),
                BpSystolic = int.Parse(bpSystolicTextBox.Text),
                BpDiastolic = int.Parse(bpDiastolicTextBox.Text),
                BodyTemperature = decimal.Parse(bodyTemperatureTextBox.Text),
                Pulse = int.Parse(pulseTextBox.Text),
                Symptoms = symptomsTextBox.Text,
                Info = infoTextBox.Text,
                Nurse = new Nurse
                {
                    NurseID = (int)NurseComboBox.SelectedValue
                },
                Appointment = new Appointment
                {
                    AppointmentID = oldVisit.Appointment.AppointmentID
                },
                InitialDiagnosis = initialDiagnosisTextBox.Text,
                FinalDiagnosis = finalDiagnosisTextBox.Text
            };

            if (this.visitController.EditVisit(oldVisit, newVisit))
            {
                MessageBox.Show("Visit updated.");
            }
            else
            {
                MessageBox.Show("Update failed");
            }
            this.Dispose();
        }

    }
}

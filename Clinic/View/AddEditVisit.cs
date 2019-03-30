using Clinic.Controller;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// Form for editing and creating a visit.
    /// </summary>
    public partial class AddEditVisit : Form
    {
        private NurseController nurseController;
        private VisitController visitController;
        private Visit oldVisit;
        private bool update;
        private bool valid;

        /// <summary>
        /// Constructor for existing visit, populates form with pre-existing visit information
        /// </summary>
        /// <param name="visit">visit to add to form</param>
        public AddEditVisit(Visit visit)
        {
            InitializeComponent();
            this.nurseController = new NurseController();
            this.visitController = new VisitController();
            this.update = true;
            if (visit.VisitId == 0)
            {
                this.update = false;
                this.oldVisit = visit;
                this.patientTextBox.Text = visit.Appointment.Patient.FullName;
                this.doctorTextBox.Text = visit.Appointment.Doctor.FullName;
                this.PopulateNurseComboBox();
            }
            else
            {
                this.update = true;
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
            if (this.oldVisit.Nurse != null)
            {
                this.NurseComboBox.SelectedValue = this.oldVisit.Nurse.NurseID;
            } else
            {
                this.NurseComboBox.SelectedValue = -1;
            }
        }


        private void btOK_Click(object sender, EventArgs e)
        {
            this.valid = true;
            this.ColorReset();
            Visit newVisit = new Visit();
            
            newVisit.DateTime = this.DTPVisitDate.Value.Date + this.DTPVisitTime.Value.TimeOfDay;

            newVisit.Weight = this.ValidateDecimal(weightTextBox);
            newVisit.BpSystolic = this.ValidateInt(bpSystolicTextBox);
            newVisit.BpDiastolic = this.ValidateInt(bpDiastolicTextBox);
            newVisit.BodyTemperature = this.ValidateDecimal(bodyTemperatureTextBox);
            newVisit.Pulse = this.ValidateInt(pulseTextBox);
            newVisit.Symptoms = symptomsTextBox.Text;
            newVisit.Info = infoTextBox.Text;
            if (NurseComboBox.SelectedIndex == -1)
            {
                NurseComboBox.BackColor = Color.Red;
                this.valid = false;
            } else
            {
                newVisit.Nurse = new Nurse
                {
                    NurseID = (int)NurseComboBox.SelectedValue
                };
            }
            
            newVisit.Appointment = new Appointment
            {
                AppointmentID = oldVisit.Appointment.AppointmentID
            };
            newVisit.InitialDiagnosis = initialDiagnosisTextBox.Text;
            newVisit.FinalDiagnosis = finalDiagnosisTextBox.Text;
        
            if (this.update && valid)
            {
                if (this.visitController.EditVisit(oldVisit, newVisit))
                {
                    MessageBox.Show("Visit updated.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Update failed");
                    this.DialogResult = DialogResult.Cancel;
                }
            } else if (!this.update && valid)
            {
                if (this.visitController.AddVisit(newVisit) > 0)
                {
                    MessageBox.Show("Visit added");
                    this.DialogResult = DialogResult.OK;
                } else
                {
                    MessageBox.Show("Add failed");
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                return;
            }


            this.Dispose();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
        
        private decimal ValidateDecimal(TextBox textbox)
        {
            try
            {
                return decimal.Parse(textbox.Text);
            } catch (Exception ex)
            {
                textbox.BackColor = Color.Red;
                this.valid = false;
                return 0;
            }
        }

        private int ValidateInt(TextBox textbox)
        {
            try
            {
                return int.Parse(textbox.Text);
            } catch (Exception ex)
            {
                textbox.BackColor = Color.Red;
                this.valid = false;
                return 0;
            }
        }

        private void ColorReset()
        {
            weightTextBox.BackColor = SystemColors.Window;
            bpSystolicTextBox.BackColor = SystemColors.Window;
            bpDiastolicTextBox.BackColor = SystemColors.Window;
            bodyTemperatureTextBox.BackColor = SystemColors.Window;
            pulseTextBox.BackColor = SystemColors.Window;
            NurseComboBox.BackColor = SystemColors.Window;
        }
    }
}

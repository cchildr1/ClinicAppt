using Clinic.Controller;
using Clinic.DataSets;
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
        private TestController testController;
        private Visit oldVisit;
        private bool update;
        private bool valid;

        /// <summary>
        /// Constructor for existing visit, populates form with pre-existing visit information
        /// </summary>
        /// <param name="visit">visit to add to form</param>
        public AddEditVisit(Visit visit, Nurse loggedInNurse)
        {
            this.nurseController = new NurseController();
            this.visitController = new VisitController();
            this.testController = new TestController();
            this.update = true;
            InitializeComponent();
            if (visit.VisitId == 0)
            {
                this.update = false;
                this.oldVisit = visit;
                this.patientTextBox.Text = visit.Appointment.Patient.FullName;
                this.doctorTextBox.Text = visit.Appointment.Doctor.FullName;
                this.PopulateNurseComboBox();
                this.NurseComboBox.SelectedValue = loggedInNurse.NurseID;
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
            this.FillTestData(visit.VisitId);
            this.FillInsertTestComboBox();
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


        private void BtOK_Click(object sender, EventArgs e)
        {
            this.valid = true;
            this.ColorReset();
            Visit newVisit = new Visit();
            try
            {
                newVisit.DateTime = this.DTPVisitDate.Value.Date + this.DTPVisitTime.Value.TimeOfDay;
                if (weightTextBox.Text != "")
                {
                    newVisit.Weight = this.ValidateDecimal(weightTextBox);
                }
                if (bpSystolicTextBox.Text != "")
                {
                    newVisit.BpSystolic = this.ValidateInt(bpSystolicTextBox);
                }
                if (bpDiastolicTextBox.Text != "")
                {
                    newVisit.BpDiastolic = this.ValidateInt(bpDiastolicTextBox);
                }
                if (bodyTemperatureTextBox.Text != "")
                {
                    newVisit.BodyTemperature = this.ValidateDecimal(bodyTemperatureTextBox);
                }
                if (pulseTextBox.Text != "")
                {
                    newVisit.Pulse = this.ValidateInt(pulseTextBox);
                }

                newVisit.Symptoms = symptomsTextBox.Text;
                newVisit.Info = infoTextBox.Text;

                if (NurseComboBox.SelectedIndex == -1)
                {
                    NurseComboBox.BackColor = Color.Red;
                    this.valid = false;
                }
                else
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
                }
                else if (!this.update && valid)
                {
                    if (this.visitController.AddVisit(newVisit) > 0)
                    {
                        MessageBox.Show("Visit added");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DB Issue");
            }
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
        
        private decimal ValidateDecimal(TextBox textbox)
        {
            try
            {
                return decimal.Parse(textbox.Text);
            } catch (Exception)
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
            } catch (Exception)
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

        private void FillTestData(int visitID)
        {
            this.testTableAdapter.Fill(this.cS6232_g3DataSet.test, visitID);
        }

        private void FillInsertTestComboBox()
        {
            this.CBInsertTestCode.DisplayMember = "Code";
            foreach(Test test in this.testController.GetAllTestCodes())
            {
                this.CBInsertTestCode.Items.Add(test);
            }
        }

        private void BTInsertTest_Click(object sender, EventArgs e)
        {
            Test selectedTest = this.CBInsertTestCode.SelectedItem as Test;
            if (selectedTest != null)
            {
                CS6232_g3DataSet.testRow testRow = this.cS6232_g3DataSet.test.NewtestRow();
                testRow.test_code_id = selectedTest.TestCodeID;
                testRow.code = selectedTest.Code;
                testRow.date_performed = DateTime.Now.Date;
                testRow.visit_id = oldVisit.VisitId;
                this.cS6232_g3DataSet.test.AddtestRow(testRow);
            }           
        }

        private void BtClearChanges_Click(object sender, EventArgs e)
        {
            this.cS6232_g3DataSet.RejectChanges();
        }

        private void BtSubmitChanges_Click(object sender, EventArgs e)
        {
            
        }

        private void 

     }
}

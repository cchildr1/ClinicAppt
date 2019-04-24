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
        private List<int> rowsToDelete;

        /// <summary>
        /// Constructor for existing visit, populates form with pre-existing visit information
        /// </summary>
        /// <param name="visit">visit to add to form</param>
        public AddEditVisit(Visit visit, Nurse loggedInNurse)
        {
            this.nurseController = new NurseController();
            this.visitController = new VisitController();
            this.testController = new TestController();
            this.rowsToDelete = new List<int>();
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
            if (!(visit.FinalDiagnosis == null || visit.FinalDiagnosis == ""))
            {
                this.ToggleControlLock();
                MessageBox.Show("A final diagnosis has been entered. You cannot edit this visit.");
            }
            this.FillTestData(visit.VisitId);
            this.FillInsertTestComboBox();
            this.DeleteRowButton.Text = "Delete";
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
                this.ValidateRequiredFields();
                // CHECK FOR FINAL DIAGNOSIS AND OPEN TESTS HERE
                if (finalDiagnosisTextBox.Text != "")
                {
                    DialogResult result = MessageBox.Show("Once a final diagnosis is entered, you can no longer edit this visit. Confirm?", "Final Dignosis Closes Visit", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                if (this.update && this.valid)
                {
                    if (this.visitController.EditVisit(oldVisit, newVisit))
                    {
                        this.BtSubmitChanges_Click(sender, e);
                        MessageBox.Show("Visit updated.");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Update failed");
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
                else if (!this.update && this.valid)
                {
                    if (this.visitController.AddVisit(newVisit) > 0)
                    {
                        MessageBox.Show("Visit added");
                        this.BtSubmitChanges_Click(sender, e);
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
            this.ToggleControlLock();
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

        private void ValidateTextPresent(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                textbox.BackColor = Color.Red;
                this.valid = false;
            }
        }

        private void ValidateRequiredFields()
        {
            this.ValidateTextPresent(bpSystolicTextBox);
            this.ValidateTextPresent(bpDiastolicTextBox);
            this.ValidateTextPresent(pulseTextBox);
            this.ValidateTextPresent(weightTextBox);
            this.ValidateTextPresent(bodyTemperatureTextBox);
            this.ValidateTextPresent(symptomsTextBox);
            this.ValidateTextPresent(infoTextBox);
            this.ValidateTextPresent(initialDiagnosisTextBox);
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
            this.ProcessInsertChanges(this.cS6232_g3DataSet);
            this.ProcessUpdateChanges(this.cS6232_g3DataSet);
            this.ProcessDeleteChanges(this.cS6232_g3DataSet);
            this.cS6232_g3DataSet.AcceptChanges();
            MessageBox.Show("Tests updated.");
        }

        private void ProcessUpdateChanges(DataSet data)
        {
            DataTable table = data.Tables[0].GetChanges(DataRowState.Modified);
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    try
                    {
                        this.testTableAdapter.UpdateQuery((int)row["visit_id"],
                            this.validateDateString(row["date_performed"].ToString()),
                            this.validateDateString(row["date_available"].ToString()),
                            (int)row["test_code_id"],
                            this.validateAbnormalResult(row["abnormal_result"].ToString()), 
                            row["result"].ToString(),
                            (int)row["id"]);
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Entries not updated.");
                    }
                }
            }
        }

        private void ProcessInsertChanges(DataSet data)
        {
            DataTable table = data.Tables[0].GetChanges(DataRowState.Added);
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    try
                    {
                        this.testTableAdapter.InsertQuery((int)row["visit_id"],
                            this.validateDateString(row["date_performed"].ToString()),
                            this.validateDateString(row["date_available"].ToString()),
                            (int)row["test_code_id"],
                            this.validateAbnormalResult(row["abnormal_result"].ToString()),
                            row["result"].ToString());
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Entries not updated.");
                    }
                }
            }
        }
        
        private void ProcessDeleteChanges(DataSet data)
        {
            DataTable table = data.Tables[0].GetChanges(DataRowState.Deleted);
            if (table != null)
            {
                
                foreach (int id in this.rowsToDelete)
                {
                    try
                    {
                        this.testTableAdapter.DeleteQuery(id);
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Entries not updated.");
                    }
                }
                this.rowsToDelete.Clear();
            }
        }

        private byte? validateAbnormalResult(string value)
        {
            byte? abnormalResult;
            if (value == "1")
            {
                abnormalResult = 1;
            }
            else
            {
                abnormalResult = 0;
            }
            return abnormalResult;
        }

        private string validateDateString(String dateString)
        {
            String vString;
            if (dateString == "")
            {
                vString = null;
            }
            else
            {
                vString = Convert.ToDateTime(dateString).ToString("yyyy-MM-dd");
            }
            return vString;
        }

        private void testDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            
            if (senderGrid.Columns[e.ColumnIndex].ToString() == senderGrid.Columns["DeleteRowButton"].ToString() &&
                e.RowIndex >= 0)
            {
                DataRow row = this.cS6232_g3DataSet.Tables[0].Rows[e.RowIndex];
                if (row["result"].ToString() == "" && row["date_available"].ToString() == "")
                {
                    this.rowsToDelete.Add((int)row["id"]);
                    row.Delete();
                }
            }
        }

        private void ToggleControlLock()
        {
            this.bodyTemperatureTextBox.Enabled = !this.bodyTemperatureTextBox.Enabled;
            this.NurseComboBox.Enabled = !this.NurseComboBox.Enabled;
            this.DTPVisitDate.Enabled = !this.DTPVisitDate.Enabled;
            this.DTPVisitTime.Enabled = !this.DTPVisitTime.Enabled;
            this.bpSystolicTextBox.Enabled = !this.bpSystolicTextBox.Enabled;
            this.bpDiastolicTextBox.Enabled = !this.bpDiastolicTextBox.Enabled;
            this.pulseTextBox.Enabled = !this.pulseTextBox.Enabled;
            this.weightTextBox.Enabled = !this.weightTextBox.Enabled;
            this.symptomsTextBox.Enabled = !this.symptomsTextBox.Enabled;
            this.initialDiagnosisTextBox.Enabled = !this.initialDiagnosisTextBox.Enabled;
            this.infoTextBox.Enabled = !this.infoTextBox.Enabled;
            this.finalDiagnosisTextBox.Enabled = !this.finalDiagnosisTextBox.Enabled;
            this.CBInsertTestCode.Enabled = !this.CBInsertTestCode.Enabled;
            this.BTInsertTest.Enabled = !this.BTInsertTest.Enabled;
            this.BtSubmitChanges.Enabled = !this.BtSubmitChanges.Enabled;
            this.btOK.Enabled = !this.btOK.Enabled;
            this.testDataGridView.Enabled = !this.testDataGridView.Enabled;
        }

        private void CheckForOpenTests()
        {
            DataTable table = this.cS6232_g3DataSet.Tables[0];
            
        }
    }
}

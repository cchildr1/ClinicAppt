using Clinic.Controller;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Clinic.View;

namespace Clinic.UserControls
{
    /// <summary>
    /// Displays initial visit information and allows user to add and edit a visit
    /// </summary>
    public partial class visits_UserControl : UserControl
    {
        private VisitController visitController = new VisitController();
        private DoctorController doctorController = new DoctorController();
        private NurseController nurseController = new NurseController();
        private List<Visit> visits = new List<Visit>();
        /// <summary>
        /// Constructor
        /// </summary>
        public visits_UserControl()
        {
            InitializeComponent();
            this.visitDataGridView.CellContentClick += VisitDataGridView_CellContentClick;
            this.PopulateDoctorComboBox();
            this.PopulateNurseComboBox();
            this.PopulateDataGridView(this.visitController.GetAllVisits());
        }



        private void PopulateDataGridView(List<Visit> visits)
        {
            this.visitDataGridView.Rows.Clear();
            foreach (Visit visit in visits) {
                string[] row =
                {
                    visit.VisitId.ToString(),
                    visit.Appointment.Scheduled_Date.ToString(),
                    visit.DateTime.ToString(),
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
            List<Doctor> doctors = this.doctorController.GetAllDoctors();
            doctors.OrderBy(D => D.FullName).ToList();
            this.DoctorComboBox.DataSource = doctors;
            this.DoctorComboBox.ValueMember = "DoctorId";
            this.DoctorComboBox.DisplayMember = "FullName";
            this.DoctorComboBox.SelectedIndex = -1;
        }

        private void PopulateNurseComboBox()
        {
            List<Nurse> nurses = this.nurseController.GetAllNurses();
            nurses.OrderBy(N => N.FullName).ToList();
            this.NurseComboBox.DataSource = nurses;
            this.NurseComboBox.ValueMember = "NurseID";
            this.NurseComboBox.DisplayMember = "FullName";
            this.NurseComboBox.SelectedIndex = -1;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.ResetDataGridView();
            int doctorID = 0;
            int nurseID = 0;
            DateTime appointmentStart = DateTime.MinValue;
            DateTime appointmentEnd = DateTime.MaxValue;
            DateTime visitStart = DateTime.MinValue;
            DateTime visitEnd = DateTime.MaxValue;
            if (this.DoctorComboBox.SelectedValue != null)
            {
                doctorID = (int)this.DoctorComboBox.SelectedValue;
            }
            if (this.NurseComboBox.SelectedValue != null)
            {
                nurseID = (int)this.NurseComboBox.SelectedValue;
            }
            if (this.DTPAppointmentStart.Checked)
            {
                appointmentStart = this.DTPAppointmentStart.Value;
            }
            if (this.DTPAppointmentEnd.Checked)
            {
                appointmentEnd = this.DTPAppointmentEnd.Value;
            }
            if (this.DTPVisitStart.Checked)
            {
                visitStart = this.DTPVisitStart.Value;
            }
            if (this.DTPVisitEnd.Checked)
            {
                visitEnd = this.DTPVisitEnd.Value;
            }
            this.PopulateDataGridView(this.visitController.SearchVisits(
                    doctorID,
                    nurseID, 
                    this.TbPatient.Text,
                    appointmentStart,
                    appointmentEnd,
                    visitStart,
                    visitEnd
                ));
            
        }

        private void ResetDataGridView() {
            this.PopulateDataGridView(this.visitController.RefreshVisits());
        }
        private void Reset()
        {
            this.ResetDataGridView();
            this.DoctorComboBox.SelectedIndex = -1;
            this.NurseComboBox.SelectedIndex = -1;
            this.TbPatient.Text = "";
            this.DTPAppointmentEnd.Checked = false;
            this.DTPAppointmentStart.Checked = false;
            this.DTPVisitEnd.Checked = false;
            this.DTPVisitStart.Checked = false;
            this.DTPVisitStart.Checked = false;
            this.DTPVisitEnd.Checked = false;
        }

        private void BtReset_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void VisitDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                try {
                    int id = int.Parse(this.visitDataGridView.Rows[e.RowIndex].Cells["VisitID"].Value.ToString());
                    Visit oldVisit = this.visitController.GetVisitByID(id);
                    this.ParentForm.Enabled = false;
                    AddEditVisit addEditVisit = new AddEditVisit(oldVisit);
                    DialogResult result = addEditVisit.ShowDialog();
                    this.ParentForm.Enabled = true;
                    if (result == DialogResult.OK)
                    {
                        this.ResetDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}

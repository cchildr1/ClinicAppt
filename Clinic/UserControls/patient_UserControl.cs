using Clinic.Controller;
using Clinic.Model;
using Clinic.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Clinic.UserControls
{
    /// <summary>
    /// This class allows users to search patient's by first/last name and/or DOB
    /// All patients can be scene
    /// Selecting a patient allows for the appointment to be brought up
    /// </summary>
    public partial class patient_UserControl : UserControl
    {
        private bool DOB_ValueChanged = false;
        private bool dataGridView_Is_Patient = true;
        private int selectedPatientID = -1;
        private PatientController patientController = new PatientController();
        private AppointmentController appointmentController = new AppointmentController();
        private VisitController visitController = new VisitController();
        public patient_UserControl()
        {
            InitializeComponent();
        }

        private void SearchAppointment_button_Click(object sender, EventArgs e)
        {
            this.ResetDataGridView_button_Click(sender, e);
            if (this.DOB_ValueChanged)
            {
                DateTime selected_DOB = this.DateOfBirth_datetimePicker.Value;
                this.patients_datagridview.DataSource = this.patientController.PatientByFirst_Last_DOB(this.firstname_textbox.Text, this.lastname_textbox.Text, selected_DOB.Date);
                this.patients_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                this.patients_datagridview.DataSource = this.patientController.PatientByWithoutDOB_Firstname_LastName(this.firstname_textbox.Text, this.lastname_textbox.Text);
                this.patients_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            this.EditPatientGridView();
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

        private void patients_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].ToString() == this.patients_datagridview.Columns["AddEditVisit"].ToString())
            {
                try
                {
                    int id = int.Parse(this.patients_datagridview.Rows[e.RowIndex].Cells["AppointmentID"].Value.ToString());
                    Visit visit = this.visitController.GetVisitByAppointmentID(id);

                    this.ParentForm.Enabled = false;
                    MainDashboardNurse parent = (MainDashboardNurse)this.ParentForm;
                    AddEditVisit addEditVisit = new AddEditVisit(visit, parent.loggedInNurse);
                    DialogResult result = addEditVisit.ShowDialog();
                    this.ParentForm.Enabled = true;

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.GetType().ToString());
                }
            }
                if (this.dataGridView_Is_Patient)
            {   
                DataGridViewRow selectedRow = this.patients_datagridview.CurrentRow;
                this.selectedPatientID = (int)selectedRow.Cells["PatientID"].Value;
                this.patients_datagridview.DataSource = null;
                this.SetUpDataGridView_ForSelectedPatientAppointment();
                this.GetAppointmentData_ForSelectedPatient(this.selectedPatientID);
                this.dataGridView_Is_Patient = false;
              
            }
        }

        private void SetUpDataGridView_ForSelectedPatientAppointment()
        {
            this.patients_datagridview.ColumnCount = 5;
            this.patients_datagridview.ColumnHeadersVisible = true;
            this.patients_datagridview.Columns[0].Name = "AppointmentID";
            this.patients_datagridview.Columns[0].Visible = false;
            this.patients_datagridview.Columns[1].Name = "Date";
            this.patients_datagridview.Columns[2].Name = "Reason For Visit";
            this.patients_datagridview.Columns[3].Name = "Doctor";
            this.patients_datagridview.Columns[4].Name = "Patient";
            DataGridViewButtonColumn addEditColumn = new DataGridViewButtonColumn();
            addEditColumn.Name = "AddEditVisit";
            addEditColumn.Text = "Add/Edit Visit";
            addEditColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            addEditColumn.UseColumnTextForButtonValue = true;
            this.patients_datagridview.Columns.Add(addEditColumn);
            this.patients_datagridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.editSelectedPatient_Button.Visible = true;
            this.AddAppointment_BTN.Visible = true;
            
        }

        private void GetAppointmentData_ForSelectedPatient(int patientID)
        {
            this.patients_datagridview.DataSource = null;
            this.patients_datagridview.RowCount = 0;
            List<Appointment> appointments = new List<Appointment>();
            appointments = this.appointmentController.GetAppointmentsByPatientID(patientID);
           
            if (appointments.Count > 0)
            {
                Appointment appointment = new Appointment();

                for (int count = 0; count < appointments.Count; count++)
                {
                    appointment = appointments[count];
                    string[] rowAdded = new string[] {
                            appointment.AppointmentID.ToString(),
                            appointment.Scheduled_Date.ToString(),
                            appointment.Reason_For_Visit,
                            appointment.Doctor.FirstName + " " + appointment.Doctor.LastName,
                            appointment.Patient.FirstName + " " + appointment.Patient.LastName
                        };
                    this.patients_datagridview.Rows.Add(rowAdded);
                }
                this.searchPatients_LBL.Text = "Appointment(s) for " + appointment.Patient.FirstName + " " + appointment.Patient.LastName;
            }
           
        }

        private void ResetDataGridView_button_Click(object sender, EventArgs e)
        {
            this.patients_datagridview.DataSource = null;
            this.patients_datagridview.ColumnCount = 0;
            this.dataGridView_Is_Patient = true;
            this.editSelectedPatient_Button.Visible = false;
            this.AddAppointment_BTN.Visible = false;
            this.selectedPatientID = -1;
            this.searchPatients_LBL.Text = "Search Patients";
        }

        private void getAllPatients_Click(object sender, EventArgs e)
        {
            this.ResetDataGridView_button_Click(sender, e);
            this.patients_datagridview.DataSource = null;
            this.patients_datagridview.ColumnCount = 0;
            this.patients_datagridview.DataSource = this.patientController.GetAllPatients();
            this.editSelectedPatient_Button.Visible = false;
            this.EditPatientGridView();
        }

        private void AddPatient_button_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            DialogResult result = addPatient.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.getAllPatients_Click(sender, e);
            }
        }

        private void EditSelectedPatient_Button_Click(object sender, EventArgs e)
        {
            EditPatient editPatient = new EditPatient();
            editPatient.PopulateEditpatient_fields(this.patientController.GetPatientByID(this.selectedPatientID));
            DialogResult result = editPatient.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.GetAppointmentData_ForSelectedPatient(this.selectedPatientID);
            }
            
        }

        private void EditPatientGridView()
        {
            this.patients_datagridview.Columns["PatientID"].Visible = false;
            this.patients_datagridview.Columns["PersonID"].Visible = false;
            this.patients_datagridview.Columns["FullName"].Visible = false;
            this.patients_datagridview.Columns["Status"].Visible = false;
            this.patients_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.patients_datagridview.Columns["State"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void AddAppointment_BTN_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.SetPatientToAcceptedPatient(this.patientController.GetPatientByID(this.selectedPatientID));
            DialogResult result = addAppointment.ShowDialog();
            if (result == DialogResult.Yes)
            {
               this.GetAppointmentData_ForSelectedPatient(this.selectedPatientID);
            }
        }
    }
}

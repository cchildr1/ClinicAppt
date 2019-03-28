﻿using System;
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
        private bool dataGridView_Is_Patient = true;
        private PatientController patientController = new PatientController();
        private AppointmentController appointmentController = new AppointmentController();
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
                this.patients_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else 
            {
                this.patients_datagridview.DataSource = this.patientController.PatientByWithoutDOB_Firstname_LastName(this.firstname_textbox.Text, this.lastname_textbox.Text);
                this.patients_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void patients_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView_Is_Patient)
            {   
                DataGridViewRow selectedRow = this.patients_datagridview.CurrentRow;
                int selectedRowPatientID = (int)selectedRow.Cells["PatientID"].Value;
                this.patients_datagridview.DataSource = null;
                this.SetUpDataGridView_ForSelectedPatientAppointment();
                this.GetAppointmentData_ForSelectedPatient(selectedRowPatientID);
                this.dataGridView_Is_Patient = false;
            }
        }

        private void SetUpDataGridView_ForSelectedPatientAppointment()
        {
            this.patients_datagridview.ColumnCount = 5;
            this.patients_datagridview.ColumnHeadersVisible = true;
            this.patients_datagridview.Columns[0].Name = "AppointmentID";
            this.patients_datagridview.Columns[1].Name = "Date";
            this.patients_datagridview.Columns[2].Name = "Reason For Visit";
            this.patients_datagridview.Columns[3].Name = "Doctor";
            this.patients_datagridview.Columns[4].Name = "Patient";
        }

        public void GetAppointmentData_ForSelectedPatient(int patientID)
        {
            this.patients_datagridview.DataSource = null;
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
            }
        }

        private void ResetDataGridView_button_Click(object sender, EventArgs e)
        {
            this.patients_datagridview.DataSource = null;
            this.patients_datagridview.ColumnCount = 0;
            this.dataGridView_Is_Patient = true;
        }

        private void getAllPatients_Click(object sender, EventArgs e)
        {
            this.patients_datagridview.DataSource = null;
            this.patients_datagridview.DataSource = this.patientController.GetAllPatients();
        }
    }
}

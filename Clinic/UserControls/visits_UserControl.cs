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
                    visit.DateTime.ToString(),
                    visit.Appointment.Scheduled_Date.ToString(),
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
            this.Reset();
            this.PopulateDataGridView(this.visitController.SearchVisits(
                (int)this.DoctorComboBox.SelectedValue)
                );
            
        }

        private void Reset()
        {
            this.PopulateDataGridView(this.visitController.GetAllVisits());
            this.DoctorComboBox.SelectedIndex = -1;
            this.NurseComboBox.SelectedIndex = -1;
            this.TbPatient.Text = "";
            this.DTPAppointmentEnd.Checked = false;
            this.DTPAppointmentStart.Checked = false;
            this.DTPVisitEnd.Checked = false;
            this.DTPVisitStart.Checked = false;
        }

        private void BtReset_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
    }
}

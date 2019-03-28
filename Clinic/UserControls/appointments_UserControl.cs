﻿using System;
using Clinic.Controller;
using System.Collections.Generic;
using Clinic.Model;
using Clinic.View;
using System.Windows.Forms;

namespace Clinic.UserControls
{
    public partial class appointments_UserControl : System.Windows.Forms.UserControl
    {
        private AppointmentController appointmentController;

        public appointments_UserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.SetUpAppointment_DataGridView();
            this.GetAppointmentData();
        }

        /// <summary>
        /// Sets up the appointment_DataGridView to display all apppointment's date, reason for visit, Doctor's name and nurse name
        /// </summary>
        public void SetUpAppointment_DataGridView()
        {
            this.appointments_datagridview.ColumnCount = 4;
            this.appointments_datagridview.ColumnHeadersVisible = true;
            this.appointments_datagridview.Columns[0].Name = "Date";
            this.appointments_datagridview.Columns[1].Name ="Reason For Visit";
            this.appointments_datagridview.Columns[2].Name ="Doctor";
            this.appointments_datagridview.Columns[3].Name = "Patient";
        }

        /// <summary>
        /// Fills the DataGridView with all Appointments Date, reason for visit, Doctor's name and Patient's name
        /// </summary>
        public void GetAppointmentData()
        {
            this.appointments_datagridview.DataSource = null;
            List<Appointment> appointments = new List<Appointment>();
             appointments = this.appointmentController.GetAppointments();

                if (appointments.Count > 0)
                {
                    Appointment appointment = new Appointment();

                    for (int count =0; count< appointments.Count;  count++) {
                        appointment = appointments[count];
                        string[] rowAdded = new string[] {
                            appointment.Scheduled_Date.ToString(),
                            appointment.Reason_For_Visit,
                            appointment.Doctor.FirstName + " " + appointment.Doctor.LastName,
                            appointment.Patient.FirstName + " " + appointment.Patient.LastName
                        };
                        this.appointments_datagridview.Rows.Add(rowAdded);
                    }
                }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            this.appointments_datagridview.DataSource = null;
            this.appointments_datagridview.Rows.Clear();
            this.SetUpAppointment_DataGridView();
            this.GetAppointmentData();
        }

        private void Create_Appointments_Button_Click(object sender, EventArgs e)
        {          
            AddAppointment addAppointment = new AddAppointment();
            DialogResult result = addAppointment.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.Reset_Button_Click(sender, e);
            }
        }
    }
}

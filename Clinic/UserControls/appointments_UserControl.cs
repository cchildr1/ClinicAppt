using Clinic.Controller;
using Clinic.Model;
using Clinic.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.UserControls
{
    /// <summary>
    /// This class allows users to see all the appointments 
    /// </summary>
    public partial class appointments_UserControl : System.Windows.Forms.UserControl
    {
        private AppointmentController appointmentController;
        private VisitController VisitController;

        //Sets up the appointment_usercontrol insures that everything has been initialized
        public appointments_UserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.VisitController = new VisitController();
            this.SetUpAppointment_DataGridView();
            this.GetAppointmentData();
        }

        /// <summary>
        /// Sets up the appointment_DataGridView to display all apppointment's date, reason for visit, Doctor's name and nurse name
        /// </summary>
        public void SetUpAppointment_DataGridView()
        {
            this.appointments_datagridview.ColumnCount = 5;
            this.appointments_datagridview.ColumnHeadersVisible = true;
            this.appointments_datagridview.Columns[0].Name = "AppointmentID";
            this.appointments_datagridview.Columns[0].Visible = false;
            this.appointments_datagridview.Columns[1].Name = "Date";
            this.appointments_datagridview.Columns[2].Name ="Reason For Visit";
            this.appointments_datagridview.Columns[3].Name ="Doctor";
            this.appointments_datagridview.Columns[4].Name = "Patient";
            DataGridViewButtonColumn buttonColumnAppointment = new DataGridViewButtonColumn();
            buttonColumnAppointment.Name = "EditAppointment";
            buttonColumnAppointment.Text = "Edit Appointment";
            buttonColumnAppointment.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            buttonColumnAppointment.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn buttonColumnVisit = new DataGridViewButtonColumn();
            buttonColumnVisit.Name = "AddEditVisit";
            buttonColumnVisit.Text = "Add/Edit Visit";
            buttonColumnVisit.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            buttonColumnVisit.UseColumnTextForButtonValue = true;
            this.appointments_datagridview.Columns.Add(buttonColumnAppointment);
            this.appointments_datagridview.Columns.Add(buttonColumnVisit);
            this.appointments_datagridview.CellContentClick += Appointments_datagridview_CellContentClick;
            this.appointments_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.appointments_datagridview.Columns["Reason For Visit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Appointments_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].ToString() == this.appointments_datagridview.Columns["AddEditVisit"].ToString())
            {
                try
                {
                    int id = int.Parse(this.appointments_datagridview.Rows[e.RowIndex].Cells["AppointmentID"].Value.ToString());
                    Visit visit = this.VisitController.GetVisitByAppointmentID(id);
                    this.ParentForm.Enabled = false;
                    AddEditVisit addEditVisit = new AddEditVisit(visit);
                    DialogResult result = addEditVisit.ShowDialog();
                    this.ParentForm.Enabled = true;

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.GetType().ToString());
                }
            }
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
                            appointment.AppointmentID.ToString(),
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

        private void appointments_datagridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].ToString() == this.appointments_datagridview.Columns["EditAppointment"].ToString())
            {
                DataGridViewRow selectedAppointment = this.appointments_datagridview.CurrentRow;
                int appointmentID = int.Parse(this.appointments_datagridview.Rows[e.RowIndex].Cells["AppointmentID"].Value.ToString());
                Appointment appointment = this.appointmentController.GetAppointmentByID(appointmentID);
                EditAppointment editAppointment = new EditAppointment();
                editAppointment.PopulateEditAppointmentFields(appointment);
                if (!(appointment.Scheduled_Date < DateTime.Now))
                {
                    DialogResult result = editAppointment.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        this.Reset_Button_Click(sender, e);
                    }
                } else
                {
                    MessageBox.Show("This appointment has passed. Cannot Edit.");
                }
            }
        }
    }
}

using System;
using Clinic.Controller;
using System.Windows.Forms;
using Clinic.Model;

namespace Clinic.View
{
    public partial class EditAppointment : Form
    {
        private DoctorController doctorController = new DoctorController();
        private PatientController patientController = new PatientController();
        private AppointmentController appointmentController = new AppointmentController();
        private DateTime SelectedDateTime;
        public EditAppointment()
        {
            InitializeComponent();
            this.SetUpDoctor_ComboBox();
            this.SetUpPatient_ComboBox();
            this.SetUp_DateTimePicker();
        }

        private void SetUpDoctor_ComboBox()
        {
            this.Doctor_ComboBox.DataSource = this.doctorController.GetAllDoctors();
            this.Doctor_ComboBox.DisplayMember = "FullName";
            this.Doctor_ComboBox.ValueMember = "DoctorID";
            this.Doctor_ComboBox.SelectedIndex = -1;
        }

        private void SetUpPatient_ComboBox()
        {
            this.Patient_ComboBox.DataSource = this.patientController.GetAllPatients();
            this.Patient_ComboBox.DisplayMember = "FullName";
            this.Patient_ComboBox.ValueMember = "PatientID";
            this.Patient_ComboBox.SelectedIndex = -1;
        }

        private void SetUp_DateTimePicker()
        {
            this.appointment_time_selector.Format = DateTimePickerFormat.Custom;
            this.appointment_time_selector.CustomFormat = "MM/dd/yyyy";
            this.time_Appointment_DateTimePicker.CustomFormat = "HH:MM";
            this.time_Appointment_DateTimePicker.ShowUpDown = true;
            this.time_Appointment_DateTimePicker.Value = DateTime.Now.Date.AddHours(DateTime.Now.Hour);
            this.SelectedDateTime = this.appointment_time_selector.Value.Date + this.time_Appointment_DateTimePicker.Value.TimeOfDay;   
        }

        /// <summary>
        /// This method populates all the fields with the appropiate fields
        /// </summary>
        /// <param name="appointment"></param>
        public void PopulateEditAppointmentFields(Appointment appointment)
        {
           // this.appointment_time_selector.Format = DateTimePickerFormat.Custom;
           // this.appointment_time_selector.CustomFormat = "MM/dd/yyyy";
           // this.time_Appointment_DateTimePicker.CustomFormat = "HH:MM";
           // this.time_Appointment_DateTimePicker.ShowUpDown = true;
           // this.time_Appointment_DateTimePicker.Value = DateTime.Now.Date.AddHours(DateTime.Now.Hour);
            this.Doctor_ComboBox.Text = appointment.Doctor.FullName;
            this.Patient_ComboBox.Text = appointment.Patient.FullName;
            this.reasonForVisit_Textbox.Text = appointment.Reason_For_Visit;
            this.time_Appointment_DateTimePicker.Value = appointment.Scheduled_Date;
            this.appointment_time_selector.Value = appointment.Scheduled_Date;
        }

        private void editAppointment_button_Click(object sender, EventArgs e)
        {
           // this.appointmentController.editAppointment();
        }
    }
}

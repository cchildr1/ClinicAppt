using System;
using System.Windows.Forms;
using Clinic.Controller;
using Clinic.Model;

namespace Clinic.View
{
    public partial class AddAppointment : Form
    {
        private DoctorController doctorController = new DoctorController();
        private PatientController patientController = new PatientController();
        private AppointmentController appointmentController = new AppointmentController();
        public AddAppointment()
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
            this.appointment_time_selector.CustomFormat = "MM/dd/yyyy hh:mm";
        }
   

        private void cancelAddAppointment_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAppointment_button_Click(object sender, EventArgs e)
        {
            try
            {
                Appointment appointment = new Appointment();
                appointment.Scheduled_Date = this.appointment_time_selector.Value.Date + this.time_Appointment_DateTimePicker.Value.TimeOfDay;
                appointment.Reason_For_Visit = this.reasonForVisit_Textbox.Text;
                appointment.Patient = this.SelectedPatientByID((int)this.Patient_ComboBox.SelectedValue);
                appointment.Doctor = this.SelectedDoctorByID((int)this.Doctor_ComboBox.SelectedValue);

                this.appointmentController.AddAppointment(appointment);
                this.Close();
            }
            catch (Exception)
            {
                this.ErrorHelper();
            }
        }

        private Patient SelectedPatientByID(int patientID)
        {
            return this.patientController.GetPatientByID(patientID);
        }

        private Doctor SelectedDoctorByID(int doctorID)
        {
            return this.doctorController.GetDoctorByID(doctorID);
        }

        private void ErrorHelper()
        {

        }
    }
}

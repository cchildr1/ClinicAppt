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
        private Appointment oldAppointment;
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

        private bool ErrorHelper()
        {
            bool allFieldsFilled = true;
            if (this.reasonForVisit_Textbox.Text == "")
            {
                this.reasonForVisit_LBL.Text = "Required Please add Patient's Reason for Visit";
                this.reasonForVisit_LBL.ForeColor = System.Drawing.Color.Red;
                allFieldsFilled = false;
            }
            if (this.Doctor_ComboBox.SelectedIndex < 0)
            {
                this.doctor_label.Text = "You must select a Doctor";
                this.doctor_label.ForeColor = System.Drawing.Color.Red;
                allFieldsFilled = false;
            }
            if (this.Patient_ComboBox.SelectedIndex < 0)
            {
                this.patient_label.Text = "You must select a Patient";
                this.patient_label.ForeColor = System.Drawing.Color.Red;
                allFieldsFilled = false;
            }
            DateTime scheduledDateTime = this.appointment_time_selector.Value.Date + this.time_Appointment_DateTimePicker.Value.TimeOfDay;
            if (this.Doctor_ComboBox.SelectedIndex > -1)
            {
                if (this.CheckForDoctorDoubleBook(scheduledDateTime, (int)this.Doctor_ComboBox.SelectedValue))
                {
                    allFieldsFilled = false;
                    this.time_lbl.Text = this.Doctor_ComboBox.Text + " is unavaiable at this date/time";
                    this.time_lbl.ForeColor = System.Drawing.Color.Red;
                }
            }

            return allFieldsFilled;
        }

        private bool CheckForDoctorDoubleBook(DateTime scheduledDateTime, int doctorID)
        {
            return this.appointmentController.IsDoctorDoubleBooked(scheduledDateTime, doctorID);
        }

        /// <summary>
        /// This method populates all the fields with the appropiate fields
        /// </summary>
        /// <param name="appointment"></param>
        public void PopulateEditAppointmentFields(Appointment appointment)
        {
            this.oldAppointment = appointment;
            this.Doctor_ComboBox.Text = appointment.Doctor.FullName;
            this.Patient_ComboBox.Text = appointment.Patient.FullName;
            this.reasonForVisit_Textbox.Text = appointment.Reason_For_Visit;
            this.time_Appointment_DateTimePicker.Value = appointment.Scheduled_Date;
            this.appointment_time_selector.Value = appointment.Scheduled_Date;
        }

        private void editAppointment_button_Click(object sender, EventArgs e)
        {
            if (this.ErrorHelper())
            {
                Appointment editAppointment = new Appointment();
                editAppointment.Patient = this.patientController.GetPatientByID((int)this.Patient_ComboBox.SelectedValue);
                editAppointment.Doctor = this.doctorController.GetDoctorByID((int)this.Doctor_ComboBox.SelectedValue);
                editAppointment.Reason_For_Visit = this.reasonForVisit_Textbox.Text;
                editAppointment.Scheduled_Date = this.appointment_time_selector.Value.Date + this.time_Appointment_DateTimePicker.Value.TimeOfDay;

                if (this.appointmentController.EditAppointment(oldAppointment, editAppointment))
                {
                    MessageBox.Show("Patient updated.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Patient update failed");
                }
            }
        }
    }
}

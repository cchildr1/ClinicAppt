using Clinic.Controller;
using Clinic.Model;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// This class allows users to add appointments
    /// It is error checked against double booking of doctors, invalid/insufficent information
    /// </summary>
    public partial class AddAppointment : Form
    {
        private DoctorController doctorController = new DoctorController();
        private PatientController patientController = new PatientController();
        private AppointmentController appointmentController = new AppointmentController();
        private DateTime SelectedDateTime;
        private bool timeBusy;
        public AddAppointment()
        {
            InitializeComponent();
            this.SetUpDoctor_ComboBox();
            this.SetUpPatient_ComboBox();
            this.SetUp_DateTimePicker();
        }

        /// <summary>
        /// This method will set the PatientCombo box value to the accepted patient. It will not allow a change to another patient
        /// </summary>
        /// <param name="patient"></param>
        public void SetPatientToAcceptedPatient(Patient patient)
        {
            this.Patient_ComboBox.DataSource = null;
            this.Patient_ComboBox.Items.Add(patient);
            this.Patient_ComboBox.DisplayMember = "FullName";
            this.Patient_ComboBox.ValueMember = "PatientID";
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
            time_Appointment_DateTimePicker.ValueChanged += new EventHandler(Time_Appointment_ValueChanged);
        }


        private void Time_Appointment_ValueChanged(object sender, EventArgs e)
        {
            if (!timeBusy)
            {
                timeBusy = true;
                DateTime dt = time_Appointment_DateTimePicker.Value;
                if ((dt.Minute * 60 + dt.Second) % 300 != 0)
                {
                    TimeSpan diff = dt - this.SelectedDateTime;
                    if (diff.Ticks < 0) time_Appointment_DateTimePicker.Value = this.SelectedDateTime.AddMinutes(-15);
                    else time_Appointment_DateTimePicker.Value = this.SelectedDateTime.AddMinutes(15);
                }
                timeBusy = false;
            }
            this.SelectedDateTime = time_Appointment_DateTimePicker.Value;
        }

        private void cancelAddAppointment_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAppointment_button_Click(object sender, EventArgs e)
        {
            if (this.ErrorHelper())
            {
                try
                {
                    Appointment appointment = new Appointment();
                    appointment.Scheduled_Date = this.appointment_time_selector.Value.Date + this.time_Appointment_DateTimePicker.Value.TimeOfDay;
                    appointment.Reason_For_Visit = this.reasonForVisit_Textbox.Text;
                    appointment.Patient = this.SelectedPatientByID((int)this.Patient_ComboBox.SelectedValue);
                    appointment.Doctor = this.SelectedDoctorByID((int)this.Doctor_ComboBox.SelectedValue);

                    this.appointmentController.AddAppointment(appointment);
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                catch (Exception)
                {
                    this.ErrorHelper();
                }
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

        private void ResetErrorLabels_ComboBox_Click(object sender, EventArgs e)
        {
            this.doctor_label.Text = "Doctor";
            this.time_lbl.Text = "Time";
            this.time_lbl.ForeColor = System.Drawing.Color.Black;
            this.doctor_label.ForeColor = System.Drawing.Color.Black;
            this.patient_label.Text = "Patient";
            this.patient_label.ForeColor = System.Drawing.Color.Black;
            this.reasonForVisit_LBL.Text = "Reason for Visit";
            this.reasonForVisit_LBL.ForeColor = System.Drawing.Color.Black;

        }
    }
}

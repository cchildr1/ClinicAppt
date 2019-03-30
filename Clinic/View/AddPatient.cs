using System;
using System.Collections.Generic;
using Clinic.Model;
using Clinic.Controller;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Clinic.View
{
    /// <summary>
    /// This class will allow users to add patient's to the database
    /// </summary>
    public partial class AddPatient : Form
    {
        private string errorMessage = "";
        private bool selected_DOB = false;
        /// <summary>
        /// Initializes the class and all the prerequsit functions
        /// </summary>
        public AddPatient()
        {
            InitializeComponent();
            this.SetUpGender_ComboBox();
        }

        private void SetUpGender_ComboBox()
        {
            this.gender_ComboBox.Items.Add("Male");
            this.gender_ComboBox.Items.Add("Female");
            this.gender_ComboBox.Items.Add("Other");
            this.gender_ComboBox.Items.Add("I choose not to disclose");
            this.gender_ComboBox.SelectedIndex = -1;
        }

        private void addPatientDialog_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            if (!this.ErrorCheck())
            {
                try
                {
                    ZipcodeController zipcodeController = new ZipcodeController();
                    patient.FirstName = this.firstname_textbox.Text;
                    patient.LastName = this.lastname_textbox.Text;
                    patient.Phone = this.phoneNumber_textbox.Text;
                    patient.SocialSecurityNumber = this.ssn_textbox.Text;
                    patient.Zipcode = this.zipcode_textbox.Text;
                    patient.State = zipcodeController.GetStateFromZipcode(patient.Zipcode);
                    patient.City = zipcodeController.GetCityFromZipcode(patient.Zipcode);
                    patient.DateOfBirth = this.dateOfBirth_DateTimePicker.Value;
                    patient.Gender = (string)this.gender_ComboBox.SelectedValue;
                    patient.StreetAddress = this.streetAddress_textbox.Text;
                    PatientController patientController = new PatientController();
                    patientController.AddPatient(patient);
                }
                catch (Exception)
                {
                    this.ErrorCheck();
                }
            }

        }

        private bool ErrorCheck()
        {
            bool errors = false;
            this.errorMessage = "";
            if (this.firstname_textbox.Text == "")
            {
                errors = true;
                this.errorMessage = "Must Include a first name \n";
                this.firstname_label.ForeColor = System.Drawing.Color.Red;
            }

            if (this.lastname_textbox.Text == "")
            {
                errors = true;
                this.errorMessage += "Must Include a last name \n";
                this.lastname_lbl.ForeColor = System.Drawing.Color.Red;
            }

            if (!this.selected_DOB)
            {
                errors = true;
                this.errorMessage += "Must select a date of birth\n";
                this.dateOfBirth_LBL.ForeColor = System.Drawing.Color.Red;
            }

            if (!this.IsValidSSN(this.ssn_textbox.Text))
            {
                errors = true;
                this.errorMessage += "Must have valid 9# SSN \n";
                this.SSN_Label.ForeColor = System.Drawing.Color.Red;
            }

            if (this.gender_ComboBox.SelectedIndex < 0)
            {
                errors = true;
                this.errorMessage += "Must make a gender selection \n";
                this.gender_LBL.ForeColor = System.Drawing.Color.Red;
            }

            if (this.streetAddress_textbox.Text == "")
            {
                errors = true;
                this.errorMessage += "Must enter a street address \n";
                this.streetAddress_LBL.ForeColor = System.Drawing.Color.Red;
            }

            if (!this.IsPhoneNumber(this.phoneNumber_textbox.Text))
            {
                errors = true;
                this.errorMessage += "Must enter a valid phone number ###-###-####\n";
                this.phone_number_LBL.ForeColor = System.Drawing.Color.Red;
            }

            if (!this.ValidZipcode(this.zipcode_textbox.Text))
            {
                errors = true;
                this.errorMessage += "Zipcode must be a valid 5 digit entry \n";
                this.zipcode_lbl.ForeColor = System.Drawing.Color.Red;
            }

            this.errorMessage_lbl.Text = this.errorMessage;
            this.errorMessage_lbl.ForeColor = System.Drawing.Color.Red;
            return errors;
        }

        private bool IsPhoneNumber(string number)
        {
            return Regex.IsMatch(number, @"^(\+0?1\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$");
        }

        private bool ValidZipcode(string zipcode)
        {
            ZipcodeController zipcodeController = new ZipcodeController();
            return zipcodeController.IsValidZipCode(zipcode);
        }

        private bool IsValidSSN(string ssn)
        {
            return Regex.IsMatch(ssn, @"^(?:\d{9}|\d{3}-\d{2}-\d{4})$");
        }


        private void Reset_ErrorMessages()
        {
            this.errorMessage = "";
            this.errorMessage_lbl.Text = this.errorMessage;
            this.firstname_label.ForeColor = System.Drawing.Color.Black;
            this.lastname_lbl.ForeColor = System.Drawing.Color.Black;
            this.gender_LBL.ForeColor = System.Drawing.Color.Black;
            this.streetAddress_LBL.ForeColor = System.Drawing.Color.Black;
            this.phone_number_LBL.ForeColor = System.Drawing.Color.Black;
            this.zipcode_lbl.ForeColor = System.Drawing.Color.Black;
            this.SSN_Label.ForeColor = System.Drawing.Color.Black;
            this.dateOfBirth_LBL.ForeColor = System.Drawing.Color.Black;

        }

        private void Reset_Patient_ErrorMessages(object sender, EventArgs e)
        {
            this.Reset_ErrorMessages();
        }

        private void dateOfBirth_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.selected_DOB = true;
            this.Reset_Patient_ErrorMessages(sender, e);
        }

        private void Reset_Button_Clicked(object sender, EventArgs e)
        {
            this.firstname_textbox.Text = "";
            this.ssn_textbox.Text = "";
            this.lastname_textbox.Text = "";
            this.gender_ComboBox.SelectedIndex = -1;
            this.streetAddress_textbox.Text = "";
            this.phoneNumber_textbox.Text = "";
            this.zipcode_textbox.Text = "";
            this.dateOfBirth_DateTimePicker.Value = DateTime.Now;
            this.selected_DOB = false;
        }

    }
}

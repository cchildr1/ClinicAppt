using Clinic.Model;
using Clinic.Controller;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Clinic.View
{
    /// <summary>
    /// This is the edit patient class it will allow users to edit patients
    /// </summary>
    public partial class EditPatient : Form
    {
        Patient oldPatient = new Patient();
        PatientController patientController = new PatientController();
        string errorMessage = "";
        bool noValueChanged;
        public EditPatient(
            )
        {
            InitializeComponent();
            this.SetUpGender_ComboBox();
        }

        private void SetUpGender_ComboBox()
        {
            this.gender_ComboBox.Items.Add("Male");
            this.gender_ComboBox.Items.Add("Female");
            this.gender_ComboBox.Items.Add("Other");
            this.gender_ComboBox.Items.Add("Rather not say");
            this.gender_ComboBox.SelectedIndex = -1;
        }


        /// <summary>
        /// This method accepts a Patient object and populates all the fields with the values of the accepted patient object
        /// </summary>
        /// <param name="patient">acepted Pateient object</param>
        public void PopulateEditpatient_fields(Patient patient) {
            this.oldPatient = patient;
            this.firstname_textbox.Text = this.oldPatient.FirstName;
            this.lastname_textbox.Text = this.oldPatient.LastName;
            this.dateOfBirth_DateTimePicker.Value = patient.DateOfBirth;
            this.ssn_textbox.Text = patient.SocialSecurityNumber;
            this.gender_ComboBox.Text = patient.Gender;
            this.gender_ComboBox.Enabled = false;
            this.streetAddress_textbox.Text = patient.StreetAddress;
            this.phoneNumber_textbox.Text = patient.Phone;
            this.zipcode_textbox.Text = patient.Zipcode;
            this.noValueChanged = true;
        }

        private void editPatient_button_Click(object sender, System.EventArgs e)
        {
            if (!ErrorCheck())
            {
                Patient editedPatient = new Patient();
                ZipcodeController zipcodeController = new ZipcodeController();
                editedPatient.FirstName = this.firstname_textbox.Text;
                editedPatient.LastName = this.lastname_textbox.Text;
                editedPatient.DateOfBirth = this.dateOfBirth_DateTimePicker.Value;
                editedPatient.SocialSecurityNumber = this.ssn_textbox.Text;
                editedPatient.Gender = this.gender_ComboBox.Text;
                editedPatient.StreetAddress = this.streetAddress_textbox.Text;
                editedPatient.Zipcode = this.zipcode_textbox.Text;
                editedPatient.City = zipcodeController.GetCityFromZipcode(editedPatient.Zipcode);
                editedPatient.State = zipcodeController.GetStateFromZipcode(editedPatient.Zipcode);
                editedPatient.Phone = this.phoneNumber_textbox.Text;

                if (this.patientController.EditPatient(this.oldPatient, editedPatient))
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

        private void Reset_button_Click(object sender, System.EventArgs e)
        {
            this.PopulateEditpatient_fields(this.oldPatient);
            this.ValueOfPatientChanged(sender, e);
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
                 
            if (!this.IsValidSSN(this.ssn_textbox.Text))
            {
                errors = true;
                this.errorMessage += "Must have valid 9# SSN - Only numbers allowed\n";
                this.SSN_Label.ForeColor = System.Drawing.Color.Red;
            }

            if (this.noValueChanged)
            {
                errors = true;
                this.errorMessage += "You must change a value to edit the Patient otherwise select the Cancel button\n";
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
                this.errorMessage += "Must enter a valid 10 or 11 digit phone number- Only numbers allowed\n";
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
            return Regex.IsMatch(number, @"^\d{10,11}$");
        }

        private bool ValidZipcode(string zipcode)
        {
            ZipcodeController zipcodeController = new ZipcodeController();
            return zipcodeController.IsValidZipCode(zipcode);
        }

        private bool IsValidSSN(string ssn)
        {
            if (ssn != "")
            {
                return Regex.IsMatch(ssn, @"^\d{9}$");
            }
            return true;
        }

        private void ValueOfPatientChanged(object sender, System.EventArgs e)
        {
            this.noValueChanged = false;
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
    }
}

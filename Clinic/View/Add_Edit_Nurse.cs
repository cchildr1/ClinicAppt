using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Clinic.Controller;
using Clinic.Model;


namespace Clinic.View
{
    /// <summary>
    /// This class allows administrators to add nurses to the database.
    /// </summary>
    public partial class Add_Edit_Nurse : Form
    {
        NurseController nurseController = new NurseController();
        private bool isEditingNurse = false;
        private Nurse editedNurse;
        private string errorMessage = "";
        private bool selected_DOB = false;
        private bool ssn_numberChanged = false;
        /// <summary>
        /// This is the constuctor it initalizes the AddNurse dialog
        /// </summary>
        public Add_Edit_Nurse()
        {
            InitializeComponent();
            this.SetUpGender_ComboBox();
        }


        /// <summary>
        /// Calling this method sets up the view to edit the accepted Nurse value
        /// </summary>
        /// <param name="editedNurse"></param>
        public void SetUp_ForEditNurse(Nurse editedNurse)
        {
            this.editedNurse = editedNurse;
            this.isEditingNurse = true;
            this.add_editNurse_button.Text = "Edit Nurse";
            this.firstname_textbox.Text = editedNurse.FirstName;
            this.lastname_textbox.Text = editedNurse.LastName;
            this.phoneNumber_textbox.Text = editedNurse.Phone;
            this.ssn_textbox.Text = editedNurse.SocialSecurityNumber;
            this.streetAddress_textbox.Text = editedNurse.StreetAddress;
            this.zipcode_textbox.Text = editedNurse.Zipcode;
            this.gender_ComboBox.Text = editedNurse.Gender;
            this.gender_ComboBox.Enabled = false;
            this.selected_DOB = true;
            this.ssn_numberChanged = false;
        }



        private void SetUpGender_ComboBox()
        {
            this.gender_ComboBox.Items.Add("Male");
            this.gender_ComboBox.Items.Add("Female");
            this.gender_ComboBox.Items.Add("Other");
            this.gender_ComboBox.Items.Add("Rather not say");
            this.gender_ComboBox.SelectedIndex = -1;
        }


        private void reset_button_Click(object sender, EventArgs e)
        {
            if (!isEditingNurse)
            {
                this.firstname_textbox.Text = "";
                this.lastname_textbox.Text = "";
                this.phoneNumber_textbox.Text = "";
                this.ssn_textbox.Text = "";
                this.streetAddress_textbox.Text = "";
                this.zipcode_textbox.Text = "";
            }
            else {
                this.SetUp_ForEditNurse(this.editedNurse);
            }

            this.Reset_ErrorMessage(sender, e);
        }

        private void Reset_ErrorMessage(object sender, EventArgs e)
        {
            this.errorMessage = "";
            this.errorMessage_lbl.Text = this.errorMessage;
            this.firstname_label.ForeColor = System.Drawing.Color.Black;
            this.lastname_lbl.ForeColor = System.Drawing.Color.Black;
            this.dateOfBirth_LBL.ForeColor = System.Drawing.Color.Black;
            this.SSN_Label.ForeColor = System.Drawing.Color.Black;
            this.gender_LBL.ForeColor = System.Drawing.Color.Black;
            this.phone_number_LBL.ForeColor = System.Drawing.Color.Black;
            this.streetAddress_LBL.ForeColor = System.Drawing.Color.Black;
            this.zipcode_lbl.ForeColor = System.Drawing.Color.Black;
        }

        private void dateOfBirth_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.selected_DOB = true;
            this.Reset_ErrorMessage(sender , e);
        }

        private void ssn_valueChanged(object sender, EventArgs e)
        {
            this.ssn_numberChanged = true;
            this.Reset_ErrorMessage(sender, e);
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

            if (!this.IsValidSSN(this.ssn_textbox.Text) && this.ssn_numberChanged)
            {
                errors = true;
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
                if (Regex.IsMatch(ssn, @"^\d{9}$"))
                {
                    bool duplicateSSN = this.nurseController.IsSSN_Not_Duplicate(ssn);
                    if (!duplicateSSN && this.ssn_numberChanged)
                    {
                        this.errorMessage += "Invalid SSN - SSN already present within the database\n";
                        this.SSN_Label.ForeColor = System.Drawing.Color.Red;
                    }
                    return duplicateSSN;
                }
                else
                {
                    this.errorMessage += "Must have valid 9# SSN - Only numbers allowed\n";
                    this.SSN_Label.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
            }
            return true;
        }

        private void addNurseDialog_Click(object sender, EventArgs e)
        {
            ZipcodeController zipcodeController = new ZipcodeController();
            Nurse nurse = new Nurse();
                if (!this.ErrorCheck())
                {
                    try
                    {
                        nurse.FirstName = this.firstname_textbox.Text;
                        nurse.LastName = this.lastname_textbox.Text;
                        nurse.Phone = this.phoneNumber_textbox.Text;
                        nurse.SocialSecurityNumber = this.ssn_textbox.Text;
                        nurse.Zipcode = this.zipcode_textbox.Text;
                        nurse.State = zipcodeController.GetStateFromZipcode(nurse.Zipcode);
                        nurse.City = zipcodeController.GetCityFromZipcode(nurse.Zipcode);
                        nurse.DateOfBirth = this.dateOfBirth_DateTimePicker.Value;
                        nurse.Gender = this.gender_ComboBox.Text;
                        nurse.StreetAddress = this.streetAddress_textbox.Text;
                    if (this.isEditingNurse)
                    {
                        if (this.nurseController.updateNurse(nurse, this.editedNurse))
                        {
                            MessageBox.Show("Nurse updated.");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Nurse update failed");
                        }            
                    }
                    else
                    {
                        this.nurseController.Addnurse(nurse);
                    }
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    catch (Exception)
                    {
                        this.ErrorCheck();
                    }
                }
            
        }
    }
}

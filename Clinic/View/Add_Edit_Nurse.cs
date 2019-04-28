using System;
using System.Collections.Generic;
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
        StatusController statusController = new StatusController();
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
            this.SetUpStatus_ComboBox();
            this.creditentals_button.Visible = false;
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
            this.nurseStatus_comboBox.Text = this.statusController.GetStatusByID(editedNurse.StatusID).StatusDescription;
            this.gender_ComboBox.Enabled = false;
            this.selected_DOB = true;
            this.ssn_numberChanged = false;
            this.creditentals_button.Visible = true;
        }



        private void SetUpGender_ComboBox()
        {
            this.gender_ComboBox.Items.Add("Male");
            this.gender_ComboBox.Items.Add("Female");
            this.gender_ComboBox.Items.Add("Other");
            this.gender_ComboBox.Items.Add("Rather not say");
            this.gender_ComboBox.SelectedIndex = -1;
        }

        private void SetUpStatus_ComboBox()
        {
            List<Status> statuses = statusController.GetAllStatusTypes();
            this.nurseStatus_comboBox.DataSource = statuses;
            this.nurseStatus_comboBox.DisplayMember = "StatusDescription";
            this.nurseStatus_comboBox.ValueMember = "StatusID";
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
                else if(this.ssn_numberChanged)
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
            int nurseStatus;

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
                    nurse.StatusID = (int)this.nurseStatus_comboBox.SelectedValue;
                    nurseStatus = nurse.StatusID;
                    if (this.isEditingNurse)
                    {
                        if (this.nurseController.updateNurse(nurse, this.editedNurse))
                        {
                            this.nurseController.ChangeStatus(this.editedNurse.NurseID, nurseStatus);
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
                        Nurse addedNurse = this.nurseController.Addnurse(nurse);
                        this.nurseController.ChangeStatus(nurse.NurseID, nurseStatus);
                        this.Add_employee_info(addedNurse);                           
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

        private void creditentals_button_Click(object sender, EventArgs e)
        {
            AddEdit_Employee edit_Employee = new AddEdit_Employee();
            if (this.editedNurse.UserName != null)
            {
                edit_Employee.SetUpFormToEditEmployee(this.editedNurse);
            }

            DialogResult result = edit_Employee.ShowDialog();
            if (result == DialogResult.Yes)
            {
                Employee employee = edit_Employee.ReturnedEmployee;
                this.editedNurse.EmployeeID = employee.EmployeeID;
                this.editedNurse.UserName = employee.UserName;
                this.editedNurse.Password = employee.Password;
                this.editedNurse.PersonId = employee.PersonId;
                this.Refresh(); 
                this.SetUp_ForEditNurse(this.editedNurse);
            }
        }

        private void Add_employee_info(Employee employee)
        {
            AddEdit_Employee add_Employee = new AddEdit_Employee();
            add_Employee.SetUpFormFor_New_Employee(employee);
            DialogResult result = add_Employee.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using Clinic.Model;
using Clinic.Controller;


namespace Clinic.View
{
    /// <summary>
    /// This class allows Admin to edit nurse username and password
    /// </summary>
    public partial class AddEdit_Employee : Form
    {
        //This employee will be returned to the Add_Edit_Nurse page to insure that 
        public Employee ReturnedEmployee { get; set; }

        bool isEditingEmployee = false;
        Employee editedEmployee;
        Employee addedEmployee;
        EmployeeController employeeController = new EmployeeController();
        public AddEdit_Employee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This form is called to EDIT a employee and the admin can to see/change values
        /// </summary>
        public void SetUpFormToEditEmployee(Nurse employee)
        {
            this.username_textbox.Text = employee.UserName;
            this.editedEmployee = this.employeeController.GetEmployeeBy_PersonID(employee.PersonId);
            this.isEditingEmployee = true;
        }

        public void SetUpFormFor_New_Employee(Employee employee)
        {
            this.addedEmployee = employee;
        }

        private void Edit_info_button_Click(object sender, EventArgs e)
        {
            if (!this.ErrorsPresentCheck()) {
                if (this.isEditingEmployee)
                {
                    if (this.employeeController.EditEmployeeInfo(this.SetUpdated_employee(), this.editedEmployee))
                    {
                        MessageBox.Show("Employee updated.");
                        this.ReturnedEmployee = this.SetUpdated_employee();
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        MessageBox.Show("Employee update failed " + this.editedEmployee.EmployeeID.ToString() + " personal-> " + 
                            this.editedEmployee.PersonId.ToString() + " username " + this.editedEmployee.UserName.ToString());
                    }
                }
                else
                {
                    this.addedEmployee.UserName = this.username_textbox.Text;
                    this.addedEmployee.Password = this.passwordMasked_textbox.Text;
                    this.employeeController.AddEmployeeInfo(this.addedEmployee);
                }

            }
        }

        private bool ErrorsPresentCheck()
        {
            bool errorsPresent = false;

            if (this.username_textbox.Text == "" || this.passwordMasked_confirmation_textbox.Text == "" || this.passwordMasked_textbox.Text == "")
            {
                errorsPresent = true;
                this.errorMessage_lbl.Text = "Must fill all values";
                this.errorMessage_lbl.Visible = true;
                this.errorMessage_lbl.ForeColor = Color.Red;
            }
            else if (this.passwordMasked_confirmation_textbox.Text != this.passwordMasked_textbox.Text)
            {
                errorsPresent = true;
                this.errorMessage_lbl.Text = "Password and password confirmation are not equal";
                this.errorMessage_lbl.Visible = true;
                this.errorMessage_lbl.ForeColor = Color.Red;
            }
            
            return errorsPresent;
        }

        private Employee SetUpdated_employee()
        {
            Employee updatedEmployee = new Employee
            {
                EmployeeID = this.editedEmployee.EmployeeID,
                PersonId = this.editedEmployee.PersonId,
                UserName = this.username_textbox.Text,
                Password = this.passwordMasked_textbox.Text
            };
            return updatedEmployee;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            
            if (this.isEditingEmployee)
            {
                this.username_textbox.Text = this.editedEmployee.UserName;
            }
            else
            {
                this.username_textbox.Text = "";

            }
            this.passwordMasked_confirmation_textbox.Text = "";
            this.passwordMasked_textbox.Text = "";
            this.ResetErrorMessage(sender,e);
        }

        private void ResetErrorMessage(object sender, EventArgs e)
        {
            this.errorMessage_lbl.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.Model;
using Clinic.Controller;
using Clinic.View;



namespace Clinic.View
{
    /// <summary>
    /// This class allows Admin to edit nurse username and password
    /// </summary>
    public partial class AddEdit_Employee : Form
    {

        bool isEditingEmployee = false;
        Employee editedEmployee;
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
            this.editedEmployee = employee;
            this.editedEmployee.EmployeeID = this.employeeController.GetEmployeeIDBy_PersonID(employee.PersonId);
            this.isEditingEmployee = true;
            //this.password_textbox.Text = pass;// editedEmployee.Password;
        }

        public void SetUpFormFor_New_Employee(Employee employee)
        {
            this.editedEmployee = employee;
        }

        private void Edit_info_button_Click(object sender, EventArgs e)
        {
            if (!this.ErrorsPresentCheck() && this.isEditingEmployee)
            {
                if (this.employeeController.EditEmployeeInfo(this.SetUpdated_employee(), this.editedEmployee))
                {
                   MessageBox.Show("Employee updated.");
                   this.DialogResult = DialogResult.OK;
                }
                else
                {
                   MessageBox.Show("Employee update failed " + this.editedEmployee.EmployeeID.ToString() + " personal-> " +this.editedEmployee.PersonId.ToString() + " username " + this.editedEmployee.UserName.ToString());                    
                }
            }
        }

        private bool ErrorsPresentCheck()
        {
            bool errorsPresent = false;

            if (this.username_textbox.Text == "" || this.password_conformation_textbox.Text == "" || this.password_textbox.Text == "")
            {
                errorsPresent = true;
                this.errorMessage_lbl.Text = "Must fill all values";
                this.errorMessage_lbl.Visible = true;
                this.errorMessage_lbl.ForeColor = Color.Red;
            }
            
            return errorsPresent;
        }

        private Employee SetUpdated_employee()
        {
            Employee updatedEmployee = new Employee();
            updatedEmployee.EmployeeID = this.editedEmployee.EmployeeID;
            updatedEmployee.PersonId = this.editedEmployee.PersonId;
            updatedEmployee.UserName = this.username_textbox.Text;
            updatedEmployee.Password = this.password_textbox.Text;
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
            this.password_conformation_textbox.Text = "";
            this.password_textbox.Text = "";
            this.ResetErrorMessage(sender,e);
        }

        private void ResetErrorMessage(object sender, EventArgs e)
        {
            this.errorMessage_lbl.Visible = false;
        }
    }
}

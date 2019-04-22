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
        public AddEdit_Employee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This form is called when a nurse is edited to allow the admin to see/change values
        /// </summary>
        public void SetUpFormToEditEmployee(Nurse editedEmployee)
        {
            this.username_textbox.Text = editedEmployee.UserName;
            this.editedEmployee = editedEmployee;
            this.isEditingEmployee = true;
            //this.password_textbox.Text = pass;// editedEmployee.Password;
        }

        private void Edit_info_button_Click(object sender, EventArgs e)
        {
            if (!this.ErrorsPresentCheck())
            { }
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

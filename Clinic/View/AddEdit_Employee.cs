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
        public AddEdit_Employee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This form is called when a nurse is edited to allow the admin to see/change values
        /// </summary>
        public void SetUpFormToEditEmployee(Employee editedEmployee)
        {
            this.username_textbox.Text = editedEmployee.UserName;
            this.password_textbox.Text = editedEmployee.Password;
        }

        private void Edit_info_button_Click(object sender, EventArgs e)
        {

        }
    }
}

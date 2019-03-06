using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.Controller;
using Clinic.Model;

namespace Clinic
{
    public partial class LoginForm : Form
    {
        private LoginController controller;
        public LoginForm()
        {
            InitializeComponent();
            this.controller = new LoginController();
        }

        private void Bt_Clear_Click(object sender, EventArgs e)
        {
            userNameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void Bt_Login_Click(object sender, EventArgs e)
        {
            Employee employee = this.controller.LoginEmployee(userNameTextBox.Text, passwordTextBox.Text);
            if (employee == null)
            {
                MessageBox.Show("Invalid username/password");
            } else
            {
                MessageBox.Show("Successful Login\n" + employee.UserName + "\n" + employee.Password);
            }

        }
    }
}

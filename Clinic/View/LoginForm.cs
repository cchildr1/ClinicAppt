using Clinic.Controller;
using Clinic.Model;
using System;
using System.Windows.Forms;

namespace Clinic
{
    /// <summary>
    /// Initial login form which creates either a nurse or admin object and passes it to the mainform
    /// if the username and password matches.
    /// </summary>
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
            passwordMaskedTextBox.Clear();
            errorLabel.Text = "";
        }

        private void Bt_Login_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = this.controller.LoginEmployee(userNameTextBox.Text, passwordMaskedTextBox.Text);
                if (employee == null)
                {
                    errorLabel.Text = "Invalid username/password.";
                }
                else
                {
                    if (employee.GetType().ToString() == "Clinic.Model.Nurse")
                    {
                        MessageBox.Show("Welcome Nurse " + employee.FirstName + " " + employee.LastName);
                        errorLabel.Text = "";
                    }
                    else if (employee.GetType().ToString() == "Clinic.Model.Admin")
                    {
                        MessageBox.Show("Welcome Administrator " + employee.FirstName + " " + employee.LastName);
                        errorLabel.Text = "";
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("There is an error with the database.\n" + ex.Message.ToString(), "Error!");
            }

        }
    }
}

﻿using Clinic.Controller;
using Clinic.Model;
using Clinic.View;
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
            Employee employee = this.controller.LoginEmployee(userNameTextBox.Text, passwordMaskedTextBox.Text);
            if (employee == null)
            {
                errorLabel.Text = "Invalid username/password.";
            }
            else
            {
                if (employee.GetType().ToString() == "Clinic.Model.Nurse")
                {
                    this.Hide();
                    Nurse loggedInNurse = (Nurse)employee;
                    MainDashboardNurse mainDashboardNurse = new MainDashboardNurse(loggedInNurse);
                    
                    DialogResult result = mainDashboardNurse.ShowDialog();

                    if (result == DialogResult.Cancel)
                    {
                        this.Bt_Clear_Click(sender, e);
                        this.Show();
                    }
                }
                else if (employee.GetType().ToString() == "Clinic.Model.Admin")
                {
                    this.Hide();

                    MainDashboardAdmin mainDashboardAdmin = new MainDashboardAdmin();
                    mainDashboardAdmin.SetLoggedInName(employee.FirstName + " " + employee.LastName);
                    DialogResult result = mainDashboardAdmin.ShowDialog();

                    if (result == DialogResult.Cancel)
                    {
                        this.Bt_Clear_Click(sender, e);
                        this.Show();
                    }
                }
            }
        }
    }
}

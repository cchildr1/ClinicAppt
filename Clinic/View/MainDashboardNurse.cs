﻿using Clinic.UserControls;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// This class is the main location for all tabpages and usercontrols for the Clinic application
    /// </summary>
    public partial class MainDashboardNurse : Form
    {
        private bool loggingOut;

        /// <summary>
        /// This is the MainDashboard class it will have secitons for everything the nurses need
        /// </summary>
        public MainDashboardNurse()
        {
            InitializeComponent();
            this.SetUpUserControls();
            this.loggingOut = false;
        }

        private void SetUpUserControls()
        {
            this.appointments_tabPage = new TabPage();
            appointments_UserControl appointments_UC = new appointments_UserControl();
            appointments_UC.Dock = DockStyle.Fill;
            this.appointments_tabPage.Controls.Add(appointments_UC);

           
        }

        /// <summary>
        /// Sets the logged name for the Nurse
        /// </summary>
        /// <param name="name">name of the logged name</param>
        public void setLoggedInName(string name)
        {
            this.WelcomeLBL.Text = "Welcome " + name;
        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            this.loggingOut = true;
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

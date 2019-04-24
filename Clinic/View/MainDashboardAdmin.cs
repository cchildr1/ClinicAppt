﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.View
{
    /// <summary>
    /// This is the MainDashboardAdmin class - it will contain all the functionality for the Clinic's admin 
    /// </summary>
    public partial class MainDashboardAdmin : Form
    {
        /// <summary>
        /// Initializes all the aspects of the MainDashboardAdmin
        /// </summary>
        public MainDashboardAdmin()
        {
            InitializeComponent();
        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// This sets the welcome lbl to welcome + the logged in username
        /// </summary>
        /// <param name="welcomeName"></param>
        public void SetLoggedInName(string welcomeName)
        {
            this.WelcomeLBL.Text = "Welcome " + welcomeName;
        }

        private void MainDashboardAdmin_Load(object sender, EventArgs e)
        {
            this.sp_mostPerformedTestDuringDatesTableAdapter.Fill(this.reportData.sp_mostPerformedTestDuringDates, (DateTime)SqlDateTime.MinValue, (DateTime)SqlDateTime.MaxValue);
            this.reportViewer1.RefreshReport();
        }

        private void btGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = (DateTime)SqlDateTime.MinValue;
            DateTime endDate = (DateTime)SqlDateTime.MaxValue;
            if (this.DTPStartDate.Checked)
            {
                startDate = this.DTPStartDate.Value;
            }
            if (this.DTPEndDate.Checked)
            {
                endDate = this.DTPEndDate.Value;
            }
            this.sp_mostPerformedTestDuringDatesTableAdapter.Fill(this.reportData.sp_mostPerformedTestDuringDates, startDate, endDate);
            this.reportViewer1.RefreshReport();
        }
    }
}

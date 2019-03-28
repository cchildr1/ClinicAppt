using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.UserControls;

namespace Clinic.View
{
    public partial class MainDashboardNurse : Form
    {
        private bool loggingOut;
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

        public void setLoggedInName(string name)
        {
            this.WelcomeLBL.Text = "Welcome " + name;
        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            this.loggingOut = true;
            this.DialogResult = DialogResult.Cancel;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!loggingOut)
            {
                Environment.Exit(0);
            }
        }
    }
}

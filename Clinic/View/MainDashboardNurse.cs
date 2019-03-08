using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.View
{
    public partial class MainDashboardNurse : Form
    {
        private bool loggingOut;
        public MainDashboardNurse()
        {
            InitializeComponent();
            this.loggingOut = false;
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

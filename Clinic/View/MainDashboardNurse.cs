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
        public MainDashboardNurse()
        {
            InitializeComponent();
        }

        public void setLoggedInName(string name)
        {
            this.WelcomeLBL.Text = "Welcome " + name;
        }
    }
}

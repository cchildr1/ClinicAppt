using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.Controller;
using Clinic.Model;

namespace Clinic.UserControls
{
    public partial class admin_NurseControl_userControl : UserControl
    {
        private NurseController nurseController = new NurseController();
        public admin_NurseControl_userControl()
        {
            InitializeComponent();
            this.PopulateNurseDataGridView();
        }

        private void searchNurse_TableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_Nurse_Click(object sender, EventArgs e)
        {

        }

        private void PopulateNurseDataGridView()
        {
            this.nurse_DataGridView.DataSource = nurseController.GetAllNurses();
            this.nurse_DataGridView.Columns["NurseID"].Visible = false;
            this.nurse_DataGridView.Columns["EmployeeID"].Visible = false;
            this.nurse_DataGridView.Columns["Username"].Visible = false;
            this.nurse_DataGridView.Columns["Password"].Visible = false;
            this.nurse_DataGridView.Columns["PersonID"].Visible = false;
            this.nurse_DataGridView.Columns["State"].Visible = false;
            this.nurse_DataGridView.Columns["City"].Visible = false;
            this.nurse_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

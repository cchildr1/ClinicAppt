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


        private void search_Nurse_Click(object sender, EventArgs e)
        {
            if (this.firstName_textbox.Text != "" && this.lastName_textbox.Text != "")
            {
                this.nurse_DataGridView.DataSource = null;
                this.nurse_DataGridView.DataSource = this.nurseController.GetNurseByFullName(this.firstName_textbox.Text, this.lastName_textbox.Text);
                this.PopulateNurseDataGridView_Helper();
            }
            else if (this.firstName_textbox.Text != "")
            {
                this.nurse_DataGridView.DataSource = null;
                this.nurse_DataGridView.DataSource = this.nurseController.GetNurseByFirstName(this.firstName_textbox.Text);
                this.PopulateNurseDataGridView_Helper();
            }
            else if (this.lastName_textbox.Text != "")
            {
                this.nurse_DataGridView.DataSource = null;
                this.nurse_DataGridView.DataSource = this.nurseController.GetNurseByLastName(this.lastName_textbox.Text);
                this.PopulateNurseDataGridView_Helper();
            }
            else
            {
                this.searchDescription_lbl.Text = "You must enter a name to search the nurses";
                this.searchDescription_lbl.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void PopulateNurseDataGridView_Helper()
        {
            this.nurse_DataGridView.Columns["NurseID"].Visible = false;
            this.nurse_DataGridView.Columns["EmployeeID"].Visible = false;
            this.nurse_DataGridView.Columns["Username"].Visible = false;
            this.nurse_DataGridView.Columns["Password"].Visible = false;
            this.nurse_DataGridView.Columns["PersonID"].Visible = false;
            this.nurse_DataGridView.Columns["State"].Visible = false;
            this.nurse_DataGridView.Columns["City"].Visible = false;
            this.nurse_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PopulateNurseDataGridView()
        {
            this.nurse_DataGridView.DataSource = nurseController.GetAllNurses();
            this.PopulateNurseDataGridView_Helper();
        }

        private void ResetNurseLabels_toDefault(object sender, EventArgs e)
        {
            this.searchDescription_lbl.Text = "Double Click a nurse to see details";
            this.searchDescription_lbl.ForeColor = System.Drawing.Color.Black;
        }

    }
}

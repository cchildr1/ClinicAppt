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
using Clinic.View;
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

   

        private void PopulateNurseDataGridView()
        {
            this.nurse_DataGridView.DataSource = nurseController.GetAllNurses();
            this.PopulateNurseDataGridView_Helper();
        }
     private void PopulateNurseDataGridView_Helper()
        {
            int length = this.nurse_DataGridView.RowCount;
            this.nurse_DataGridView.Columns["NurseID"].Visible = false;
            this.nurse_DataGridView.Columns["EmployeeID"].Visible = false;
            this.nurse_DataGridView.Columns["Username"].Visible = false;
            this.nurse_DataGridView.Columns["Password"].Visible = false;
            this.nurse_DataGridView.Columns["PersonID"].Visible = false;
            this.nurse_DataGridView.Columns["State"].Visible = false;
            this.nurse_DataGridView.Columns["City"].Visible = false;
            this.SetNurseActiveValuesToReadable(length);
            this.nurse_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetNurseActiveValuesToReadable(int length)
        {   
        }

        private void ResetNurseLabels_toDefault(object sender, EventArgs e)
        {
            this.searchDescription_lbl.Text = "Double Click a nurse to see details";
            this.searchDescription_lbl.ForeColor = System.Drawing.Color.Black;
        }

        private void ResetAdmin_Nurse_btn_Click(object sender, EventArgs e)
        {
            this.ResetNurseLabels_toDefault(sender, e);
            this.PopulateNurseDataGridView();
            this.firstName_textbox.Text = "";
            this.lastName_textbox.Text = "";
        }

        private void addNurse_button_Click(object sender, EventArgs e)
        {
            Add_Edit_Nurse addNurse = new Add_Edit_Nurse();
            DialogResult result = addNurse.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.ResetAdmin_Nurse_btn_Click(sender, e);
            }
        }

        private void nurse_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = this.nurse_DataGridView.CurrentRow;
            int selectedNurseID = (int) selectedRow.Cells["NurseID"].Value;
            Add_Edit_Nurse editNurse = new Add_Edit_Nurse();
            editNurse.SetUp_ForEditNurse(this.nurseController.GetNurseById(selectedNurseID));
            DialogResult result = editNurse.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.ResetAdmin_Nurse_btn_Click(sender, e);
            }
        }
    }
}

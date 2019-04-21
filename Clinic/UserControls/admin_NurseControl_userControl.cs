using System;
using System.Collections.Generic;
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
                this.PopulateNurse_FullName_dataGridView(this.firstName_textbox.Text, this.lastName_textbox.Text);
            }
            else if (this.firstName_textbox.Text != "")
            {
                this.PopulateNurse_FirstName_dataGridView(this.firstName_textbox.Text); 
            }
            else if (this.lastName_textbox.Text != "")
            {
                this.PopulateNurse_LastName_dataGridView(this.lastName_textbox.Text);
            }
            else
            {
                this.searchDescription_lbl.Text = "You must enter a name to search the nurses";
                this.searchDescription_lbl.ForeColor = System.Drawing.Color.Red;
            }
        }

   

        private void PopulateNurseDataGridView_Helper()
        {
            this.nurse_DataGridView.DataSource = null;
            this.nurse_DataGridView.ColumnCount = 0;
            this.nurse_DataGridView.ColumnCount = 10;
            this.nurse_DataGridView.ColumnHeadersVisible = true;
            this.nurse_DataGridView.Columns[0].Name = "First name";
            this.nurse_DataGridView.Columns[1].Name = "Last name";
            this.nurse_DataGridView.Columns[2].Name = "Date of birth";
            this.nurse_DataGridView.Columns[3].Name = "Social Securty";
            this.nurse_DataGridView.Columns[4].Name = "Gender";
            this.nurse_DataGridView.Columns[5].Name = "Address";
            this.nurse_DataGridView.Columns[6].Name = "Phone";
            this.nurse_DataGridView.Columns[7].Name = "Zipcode";
            this.nurse_DataGridView.Columns[8].Name = "Active";
            this.nurse_DataGridView.Columns[9].Name = "NurseID";
            this.nurse_DataGridView.Columns[9].Visible = false;
            this.nurse_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

         private void PopulateNurseDataGridView()
         {
            this.PopulateNurseDataGridView_Helper();
            List<Nurse> nurses = new List<Nurse>();
            nurses = nurseController.GetAllNurses();

            if (nurses.Count > 0) {
                Nurse nurse = new Nurse();
                for (int count = 0; count < nurses.Count; count++) {
                    nurse = nurses[count];
                    string[] rowAdded = this.AddRowHelper(nurse);
                    this.nurse_DataGridView.Rows.Add(rowAdded);
                }
            }
        }

        private void PopulateNurse_LastName_dataGridView(string lastName)
        {
            this.PopulateNurseDataGridView_Helper();
            List<Nurse> nurses = new List<Nurse>();
            nurses = nurseController.GetNurseByLastName(lastName);

            if (nurses.Count > 0)
            {
                Nurse nurse = new Nurse();
                for (int count = 0; count < nurses.Count; count++)
                {
                    nurse = nurses[count];
                    string[] rowAdded = this.AddRowHelper(nurse);
                    this.nurse_DataGridView.Rows.Add(rowAdded);
                }
            }
        }

        private void PopulateNurse_FirstName_dataGridView(string firstName)
        {
            this.PopulateNurseDataGridView_Helper();
            List<Nurse> nurses = new List<Nurse>();
            nurses = nurseController.GetNurseByFirstName(firstName);

            if (nurses.Count > 0)
            {
                Nurse nurse = new Nurse();
                for (int count = 0; count < nurses.Count; count++)
                {
                    nurse = nurses[count];
                    string[] rowAdded = this.AddRowHelper(nurse);
                    this.nurse_DataGridView.Rows.Add(rowAdded);
                }
            }
        }

        private void PopulateNurse_FullName_dataGridView(string firstname, string lastname)
        {
            this.PopulateNurseDataGridView_Helper();
            List<Nurse> nurses = new List<Nurse>();
            nurses = nurseController.GetNurseByFullName(firstname, lastname);

            if (nurses.Count > 0)
            {
                Nurse nurse = new Nurse();
                for (int count = 0; count < nurses.Count; count++)
                {
                    nurse = nurses[count];
                    string[] rowAdded = this.AddRowHelper(nurse);
                    this.nurse_DataGridView.Rows.Add(rowAdded);
                }
            }
        }


        private string[] AddRowHelper(Nurse nurse)
        {
            string[] rowAdded = new string[] {
                        nurse.FirstName,
                        nurse.LastName,
                        nurse.DateOfBirth.ToShortDateString(),
                        nurse.SocialSecurityNumber.ToString(),
                        nurse.Gender,
                        nurse.StreetAddress,
                        nurse.Phone,
                        nurse.Zipcode,
                        this.GetStatusDescription(nurse.StatusID),
                        nurse.NurseID.ToString()
                    };
            return rowAdded;
        }

        private string GetStatusDescription(int statusID)
        {
            StatusController statusController = new StatusController();
            Status status = statusController.GetStatusByID(statusID);
            return status.StatusDescription;

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
            int selectedNurseID = int.Parse(selectedRow.Cells["NurseID"].Value.ToString());
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

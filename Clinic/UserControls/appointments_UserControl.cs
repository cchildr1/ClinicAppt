using System;
using Clinic.Controller;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.UserControls
{
    public partial class appointments_UserControl : System.Windows.Forms.UserControl
    {
        private readonly AppointmentController appointmentController;

        public appointments_UserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.GetAppointmentData();
        }

        private void PatientName_TextBox_Click(object sender, EventArgs e)
        {
            if (this.PatientName_TextBox.Text == "patient name")
                {
                    this.PatientName_TextBox.Text = "";
                }          
        }

        public void GetAppointmentData()
        {
            appointmentBindingSource.DataSource = null;
            appointmentBindingSource.DataSource = this.appointmentController.GetAppointments();
            appointmentDataGridView.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
            appointmentDataGridView.Columns[2].DefaultCellStyle.Format = "hh:mm tt";
        }
        private void FilterAppointment_button_Click(object sender, EventArgs e)
        {
           
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            this.GetAppointmentData();
        }
    }
}

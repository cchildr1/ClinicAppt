using Clinic.Model;
using System.Windows.Forms;

namespace Clinic.View
{
    public partial class EditPatient : Form
    {
        Patient oldPatient = new Patient();
        public EditPatient()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method accepts a Patient object and populates all the fields with the values of the accepted patient object
        /// </summary>
        /// <param name="patient"></param>
        public void PopulateEditpatient_fields(Patient patient) {
            this.oldPatient = patient;
            this.firstname_textbox.Text = patient.FirstName;
            this.lastname_textbox.Text = patient.LastName;
            this.dateOfBirth_DateTimePicker.Value = patient.DateOfBirth;
            this.ssn_textbox.Text = patient.SocialSecurityNumber;
            this.gender_ComboBox.Text = patient.Gender;
            this.streetAddress_textbox.Text = patient.StreetAddress;
            this.phoneNumber_textbox.Text = patient.Phone;
            this.zipcode_textbox.Text = patient.Zipcode;
        }


    }
}

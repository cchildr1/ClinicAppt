namespace Clinic.UserControls
{
    partial class patient_UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ResetDataGridView_button = new System.Windows.Forms.Button();
            this.getAllPatients = new System.Windows.Forms.Button();
            this.addPatient_button = new System.Windows.Forms.Button();
            this.editSelectedPatient_Button = new System.Windows.Forms.Button();
            this.patients_datagridview = new System.Windows.Forms.DataGridView();
            this.doubleClickInstructions_LBL = new System.Windows.Forms.Label();
            this.dateOfBirth_LBL = new System.Windows.Forms.Label();
            this.lastname_LBL = new System.Windows.Forms.Label();
            this.firstname_lbl = new System.Windows.Forms.Label();
            this.lastname_textbox = new System.Windows.Forms.TextBox();
            this.firstname_textbox = new System.Windows.Forms.TextBox();
            this.searchAppointment_button = new System.Windows.Forms.Button();
            this.searchPatients_LBL = new System.Windows.Forms.Label();
            this.resetDateOfBirth = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DateOfBirth_datetimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddAppointment_BTN = new System.Windows.Forms.Button();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.patients_datagridview)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetDataGridView_button
            // 
            this.ResetDataGridView_button.Location = new System.Drawing.Point(649, 374);
            this.ResetDataGridView_button.Name = "ResetDataGridView_button";
            this.ResetDataGridView_button.Size = new System.Drawing.Size(75, 23);
            this.ResetDataGridView_button.TabIndex = 0;
            this.ResetDataGridView_button.Text = "Reset Field";
            this.ResetDataGridView_button.UseVisualStyleBackColor = true;
            this.ResetDataGridView_button.Click += new System.EventHandler(this.ResetDataGridView_button_Click);
            // 
            // getAllPatients
            // 
            this.getAllPatients.Location = new System.Drawing.Point(252, 374);
            this.getAllPatients.Name = "getAllPatients";
            this.getAllPatients.Size = new System.Drawing.Size(128, 23);
            this.getAllPatients.TabIndex = 1;
            this.getAllPatients.Text = "Get All Active Patients";
            this.getAllPatients.UseVisualStyleBackColor = true;
            this.getAllPatients.Click += new System.EventHandler(this.getAllPatients_Click);
            // 
            // addPatient_button
            // 
            this.addPatient_button.Location = new System.Drawing.Point(3, 374);
            this.addPatient_button.Name = "addPatient_button";
            this.addPatient_button.Size = new System.Drawing.Size(75, 23);
            this.addPatient_button.TabIndex = 2;
            this.addPatient_button.Text = "Add Patient";
            this.addPatient_button.UseVisualStyleBackColor = true;
            this.addPatient_button.Click += new System.EventHandler(this.AddPatient_button_Click);
            // 
            // editSelectedPatient_Button
            // 
            this.editSelectedPatient_Button.Location = new System.Drawing.Point(386, 374);
            this.editSelectedPatient_Button.Name = "editSelectedPatient_Button";
            this.editSelectedPatient_Button.Size = new System.Drawing.Size(75, 23);
            this.editSelectedPatient_Button.TabIndex = 3;
            this.editSelectedPatient_Button.Text = "Edit Patient";
            this.editSelectedPatient_Button.UseVisualStyleBackColor = true;
            this.editSelectedPatient_Button.Visible = false;
            this.editSelectedPatient_Button.Click += new System.EventHandler(this.EditSelectedPatient_Button_Click);
            // 
            // patients_datagridview
            // 
            this.patients_datagridview.AllowUserToAddRows = false;
            this.patients_datagridview.AllowUserToDeleteRows = false;
            this.patients_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patients_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.patients_datagridview, 5);
            this.patients_datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patients_datagridview.Location = new System.Drawing.Point(3, 62);
            this.patients_datagridview.MultiSelect = false;
            this.patients_datagridview.Name = "patients_datagridview";
            this.patients_datagridview.ReadOnly = true;
            this.patients_datagridview.Size = new System.Drawing.Size(844, 306);
            this.patients_datagridview.TabIndex = 3;
            this.patients_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patients_datagridview_CellContentClick);
            // 
            // doubleClickInstructions_LBL
            // 
            this.doubleClickInstructions_LBL.AutoSize = true;
            this.doubleClickInstructions_LBL.Location = new System.Drawing.Point(3, 30);
            this.doubleClickInstructions_LBL.Name = "doubleClickInstructions_LBL";
            this.doubleClickInstructions_LBL.Size = new System.Drawing.Size(243, 13);
            this.doubleClickInstructions_LBL.TabIndex = 8;
            this.doubleClickInstructions_LBL.Text = "Double Click any patient to see their appointments";
            // 
            // dateOfBirth_LBL
            // 
            this.dateOfBirth_LBL.AutoSize = true;
            this.dateOfBirth_LBL.Location = new System.Drawing.Point(486, 30);
            this.dateOfBirth_LBL.Name = "dateOfBirth_LBL";
            this.dateOfBirth_LBL.Size = new System.Drawing.Size(68, 13);
            this.dateOfBirth_LBL.TabIndex = 5;
            this.dateOfBirth_LBL.Text = "Date Of Birth";
            // 
            // lastname_LBL
            // 
            this.lastname_LBL.AutoSize = true;
            this.lastname_LBL.Location = new System.Drawing.Point(386, 30);
            this.lastname_LBL.Name = "lastname_LBL";
            this.lastname_LBL.Size = new System.Drawing.Size(56, 13);
            this.lastname_LBL.TabIndex = 1;
            this.lastname_LBL.Text = "Last name";
            // 
            // firstname_lbl
            // 
            this.firstname_lbl.AutoSize = true;
            this.firstname_lbl.Location = new System.Drawing.Point(252, 30);
            this.firstname_lbl.Name = "firstname_lbl";
            this.firstname_lbl.Size = new System.Drawing.Size(55, 13);
            this.firstname_lbl.TabIndex = 0;
            this.firstname_lbl.Text = "First name";
            // 
            // lastname_textbox
            // 
            this.lastname_textbox.Location = new System.Drawing.Point(386, 3);
            this.lastname_textbox.Name = "lastname_textbox";
            this.lastname_textbox.Size = new System.Drawing.Size(94, 20);
            this.lastname_textbox.TabIndex = 1;
            // 
            // firstname_textbox
            // 
            this.firstname_textbox.Location = new System.Drawing.Point(252, 3);
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.Size = new System.Drawing.Size(94, 20);
            this.firstname_textbox.TabIndex = 0;
            // 
            // searchAppointment_button
            // 
            this.searchAppointment_button.Location = new System.Drawing.Point(649, 3);
            this.searchAppointment_button.Name = "searchAppointment_button";
            this.searchAppointment_button.Size = new System.Drawing.Size(75, 23);
            this.searchAppointment_button.TabIndex = 3;
            this.searchAppointment_button.Text = "Search";
            this.searchAppointment_button.UseVisualStyleBackColor = true;
            this.searchAppointment_button.Click += new System.EventHandler(this.SearchAppointment_button_Click);
            // 
            // searchPatients_LBL
            // 
            this.searchPatients_LBL.AutoSize = true;
            this.searchPatients_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatients_LBL.Location = new System.Drawing.Point(3, 0);
            this.searchPatients_LBL.Name = "searchPatients_LBL";
            this.searchPatients_LBL.Padding = new System.Windows.Forms.Padding(5);
            this.searchPatients_LBL.Size = new System.Drawing.Size(132, 30);
            this.searchPatients_LBL.TabIndex = 0;
            this.searchPatients_LBL.Text = "Search Patients";
            // 
            // resetDateOfBirth
            // 
            this.resetDateOfBirth.Location = new System.Drawing.Point(649, 33);
            this.resetDateOfBirth.Name = "resetDateOfBirth";
            this.resetDateOfBirth.Size = new System.Drawing.Size(75, 23);
            this.resetDateOfBirth.TabIndex = 0;
            this.resetDateOfBirth.Text = "Reset Date";
            this.resetDateOfBirth.UseVisualStyleBackColor = true;
            this.resetDateOfBirth.Click += new System.EventHandler(this.ResetDateOfBirth_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ResetDataGridView_button, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.resetDateOfBirth, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.patients_datagridview, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.addPatient_button, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.DateOfBirth_datetimePicker, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.doubleClickInstructions_LBL, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.searchAppointment_button, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lastname_LBL, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.firstname_lbl, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lastname_textbox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.firstname_textbox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchPatients_LBL, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateOfBirth_LBL, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.AddAppointment_BTN, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.getAllPatients, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.editSelectedPatient_Button, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(850, 400);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // DateOfBirth_datetimePicker
            // 
            this.DateOfBirth_datetimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateOfBirth_datetimePicker.Location = new System.Drawing.Point(488, 5);
            this.DateOfBirth_datetimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.DateOfBirth_datetimePicker.Name = "DateOfBirth_datetimePicker";
            this.DateOfBirth_datetimePicker.Size = new System.Drawing.Size(153, 20);
            this.DateOfBirth_datetimePicker.TabIndex = 6;
            this.DateOfBirth_datetimePicker.ValueChanged += new System.EventHandler(this.DateOfBirth_datetimePicker_ValueChanged);
            // 
            // AddAppointment_BTN
            // 
            this.AddAppointment_BTN.Location = new System.Drawing.Point(486, 374);
            this.AddAppointment_BTN.Name = "AddAppointment_BTN";
            this.AddAppointment_BTN.Size = new System.Drawing.Size(107, 23);
            this.AddAppointment_BTN.TabIndex = 9;
            this.AddAppointment_BTN.Text = "Add Appointment";
            this.AddAppointment_BTN.UseVisualStyleBackColor = true;
            this.AddAppointment_BTN.Visible = false;
            this.AddAppointment_BTN.Click += new System.EventHandler(this.AddAppointment_BTN_Click);
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(Clinic.Model.Appointment);
            // 
            // patient_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "patient_UserControl";
            this.Size = new System.Drawing.Size(850, 400);
            ((System.ComponentModel.ISupportInitialize)(this.patients_datagridview)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.DataGridView patients_datagridview;
        private System.Windows.Forms.Button ResetDataGridView_button;
        private System.Windows.Forms.Button getAllPatients;
        private System.Windows.Forms.Button addPatient_button;
        private System.Windows.Forms.Button editSelectedPatient_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button resetDateOfBirth;
        private System.Windows.Forms.DateTimePicker DateOfBirth_datetimePicker;
        private System.Windows.Forms.Label doubleClickInstructions_LBL;
        private System.Windows.Forms.Button searchAppointment_button;
        private System.Windows.Forms.Label lastname_LBL;
        private System.Windows.Forms.Label firstname_lbl;
        private System.Windows.Forms.TextBox lastname_textbox;
        private System.Windows.Forms.TextBox firstname_textbox;
        private System.Windows.Forms.Label searchPatients_LBL;
        private System.Windows.Forms.Label dateOfBirth_LBL;
        private System.Windows.Forms.Button AddAppointment_BTN;
    }
}

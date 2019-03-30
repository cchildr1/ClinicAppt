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
            this.searchPatients_LBL = new System.Windows.Forms.Label();
            this.bottomRow_Appointments_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResetDataGridView_button = new System.Windows.Forms.Button();
            this.getAllPatients = new System.Windows.Forms.Button();
            this.addPatient_button = new System.Windows.Forms.Button();
            this.baseAppointment_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.topRow_Appointment_tableLOP = new System.Windows.Forms.TableLayoutPanel();
            this.resetDateOfBirth = new System.Windows.Forms.Button();
            this.DateOfBirth_datetimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchAppointment_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.firstname_textbox = new System.Windows.Forms.TextBox();
            this.lastname_textbox = new System.Windows.Forms.TextBox();
            this.patientnameLBL_TLP = new System.Windows.Forms.TableLayoutPanel();
            this.firstname_lbl = new System.Windows.Forms.Label();
            this.lastname_LBL = new System.Windows.Forms.Label();
            this.dateOfBirth_LBL = new System.Windows.Forms.Label();
            this.patients_datagridview = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editSelectedPatient_Button = new System.Windows.Forms.Button();
            this.bottomRow_Appointments_TableLayoutPanel.SuspendLayout();
            this.baseAppointment_TableLayoutPanel.SuspendLayout();
            this.topRow_Appointment_tableLOP.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.patientnameLBL_TLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patients_datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // bottomRow_Appointments_TableLayoutPanel
            // 
            this.bottomRow_Appointments_TableLayoutPanel.ColumnCount = 3;
            this.bottomRow_Appointments_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bottomRow_Appointments_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bottomRow_Appointments_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.bottomRow_Appointments_TableLayoutPanel.Controls.Add(this.getAllPatients, 1, 0);
            this.bottomRow_Appointments_TableLayoutPanel.Controls.Add(this.addPatient_button, 0, 0);
            this.bottomRow_Appointments_TableLayoutPanel.Controls.Add(this.editSelectedPatient_Button, 2, 0);
            this.bottomRow_Appointments_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRow_Appointments_TableLayoutPanel.Location = new System.Drawing.Point(3, 357);
            this.bottomRow_Appointments_TableLayoutPanel.Name = "bottomRow_Appointments_TableLayoutPanel";
            this.bottomRow_Appointments_TableLayoutPanel.RowCount = 1;
            this.bottomRow_Appointments_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomRow_Appointments_TableLayoutPanel.Size = new System.Drawing.Size(844, 40);
            this.bottomRow_Appointments_TableLayoutPanel.TabIndex = 2;
            // 
            // ResetDataGridView_button
            // 
            this.ResetDataGridView_button.Location = new System.Drawing.Point(3, 37);
            this.ResetDataGridView_button.Name = "ResetDataGridView_button";
            this.ResetDataGridView_button.Size = new System.Drawing.Size(75, 23);
            this.ResetDataGridView_button.TabIndex = 0;
            this.ResetDataGridView_button.Text = "Reset Field";
            this.ResetDataGridView_button.UseVisualStyleBackColor = true;
            this.ResetDataGridView_button.Click += new System.EventHandler(this.ResetDataGridView_button_Click);
            // 
            // getAllPatients
            // 
            this.getAllPatients.Location = new System.Drawing.Point(171, 3);
            this.getAllPatients.Name = "getAllPatients";
            this.getAllPatients.Size = new System.Drawing.Size(91, 23);
            this.getAllPatients.TabIndex = 1;
            this.getAllPatients.Text = "Get All Patients";
            this.getAllPatients.UseVisualStyleBackColor = true;
            this.getAllPatients.Click += new System.EventHandler(this.getAllPatients_Click);
            // 
            // addPatient_button
            // 
            this.addPatient_button.Location = new System.Drawing.Point(3, 3);
            this.addPatient_button.Name = "addPatient_button";
            this.addPatient_button.Size = new System.Drawing.Size(75, 23);
            this.addPatient_button.TabIndex = 2;
            this.addPatient_button.Text = "Add Patient";
            this.addPatient_button.UseVisualStyleBackColor = true;
            this.addPatient_button.Click += new System.EventHandler(this.AddPatient_button_Click);
            // 
            // baseAppointment_TableLayoutPanel
            // 
            this.baseAppointment_TableLayoutPanel.ColumnCount = 1;
            this.baseAppointment_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.baseAppointment_TableLayoutPanel.Controls.Add(this.topRow_Appointment_tableLOP, 0, 0);
            this.baseAppointment_TableLayoutPanel.Controls.Add(this.bottomRow_Appointments_TableLayoutPanel, 0, 2);
            this.baseAppointment_TableLayoutPanel.Controls.Add(this.patients_datagridview, 0, 1);
            this.baseAppointment_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseAppointment_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.baseAppointment_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.baseAppointment_TableLayoutPanel.Name = "baseAppointment_TableLayoutPanel";
            this.baseAppointment_TableLayoutPanel.RowCount = 3;
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.62147F));
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.37853F));
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.baseAppointment_TableLayoutPanel.Size = new System.Drawing.Size(850, 400);
            this.baseAppointment_TableLayoutPanel.TabIndex = 1;
            // 
            // topRow_Appointment_tableLOP
            // 
            this.topRow_Appointment_tableLOP.ColumnCount = 4;
            this.topRow_Appointment_tableLOP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topRow_Appointment_tableLOP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topRow_Appointment_tableLOP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topRow_Appointment_tableLOP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topRow_Appointment_tableLOP.Controls.Add(this.ResetDataGridView_button, 0, 1);
            this.topRow_Appointment_tableLOP.Controls.Add(this.resetDateOfBirth, 3, 1);
            this.topRow_Appointment_tableLOP.Controls.Add(this.searchPatients_LBL, 0, 0);
            this.topRow_Appointment_tableLOP.Controls.Add(this.DateOfBirth_datetimePicker, 2, 0);
            this.topRow_Appointment_tableLOP.Controls.Add(this.searchAppointment_button, 3, 0);
            this.topRow_Appointment_tableLOP.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.topRow_Appointment_tableLOP.Controls.Add(this.patientnameLBL_TLP, 1, 1);
            this.topRow_Appointment_tableLOP.Controls.Add(this.dateOfBirth_LBL, 2, 1);
            this.topRow_Appointment_tableLOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRow_Appointment_tableLOP.Location = new System.Drawing.Point(5, 5);
            this.topRow_Appointment_tableLOP.Margin = new System.Windows.Forms.Padding(5);
            this.topRow_Appointment_tableLOP.Name = "topRow_Appointment_tableLOP";
            this.topRow_Appointment_tableLOP.RowCount = 2;
            this.topRow_Appointment_tableLOP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topRow_Appointment_tableLOP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.topRow_Appointment_tableLOP.Size = new System.Drawing.Size(840, 63);
            this.topRow_Appointment_tableLOP.TabIndex = 0;
            // 
            // resetDateOfBirth
            // 
            this.resetDateOfBirth.Location = new System.Drawing.Point(633, 37);
            this.resetDateOfBirth.Name = "resetDateOfBirth";
            this.resetDateOfBirth.Size = new System.Drawing.Size(75, 23);
            this.resetDateOfBirth.TabIndex = 0;
            this.resetDateOfBirth.Text = "Reset Date";
            this.resetDateOfBirth.UseVisualStyleBackColor = true;
            this.resetDateOfBirth.Click += new System.EventHandler(this.ResetDateOfBirth_Click);
            // 
            // DateOfBirth_datetimePicker
            // 
            this.DateOfBirth_datetimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateOfBirth_datetimePicker.Location = new System.Drawing.Point(425, 5);
            this.DateOfBirth_datetimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.DateOfBirth_datetimePicker.Name = "DateOfBirth_datetimePicker";
            this.DateOfBirth_datetimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirth_datetimePicker.TabIndex = 2;
            this.DateOfBirth_datetimePicker.ValueChanged += new System.EventHandler(this.DateOfBirth_datetimePicker_ValueChanged);
            // 
            // searchAppointment_button
            // 
            this.searchAppointment_button.Location = new System.Drawing.Point(633, 3);
            this.searchAppointment_button.Name = "searchAppointment_button";
            this.searchAppointment_button.Size = new System.Drawing.Size(75, 23);
            this.searchAppointment_button.TabIndex = 3;
            this.searchAppointment_button.Text = "Search";
            this.searchAppointment_button.UseVisualStyleBackColor = true;
            this.searchAppointment_button.Click += new System.EventHandler(this.SearchAppointment_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.firstname_textbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lastname_textbox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(213, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 28);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // firstname_textbox
            // 
            this.firstname_textbox.Location = new System.Drawing.Point(3, 3);
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.Size = new System.Drawing.Size(94, 20);
            this.firstname_textbox.TabIndex = 0;
            // 
            // lastname_textbox
            // 
            this.lastname_textbox.Location = new System.Drawing.Point(103, 3);
            this.lastname_textbox.Name = "lastname_textbox";
            this.lastname_textbox.Size = new System.Drawing.Size(94, 20);
            this.lastname_textbox.TabIndex = 1;
            // 
            // patientnameLBL_TLP
            // 
            this.patientnameLBL_TLP.ColumnCount = 2;
            this.patientnameLBL_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.patientnameLBL_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.patientnameLBL_TLP.Controls.Add(this.firstname_lbl, 0, 0);
            this.patientnameLBL_TLP.Controls.Add(this.lastname_LBL, 1, 0);
            this.patientnameLBL_TLP.Location = new System.Drawing.Point(213, 37);
            this.patientnameLBL_TLP.Name = "patientnameLBL_TLP";
            this.patientnameLBL_TLP.RowCount = 1;
            this.patientnameLBL_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.patientnameLBL_TLP.Size = new System.Drawing.Size(200, 14);
            this.patientnameLBL_TLP.TabIndex = 7;
            // 
            // firstname_lbl
            // 
            this.firstname_lbl.AutoSize = true;
            this.firstname_lbl.Location = new System.Drawing.Point(3, 0);
            this.firstname_lbl.Name = "firstname_lbl";
            this.firstname_lbl.Size = new System.Drawing.Size(55, 13);
            this.firstname_lbl.TabIndex = 0;
            this.firstname_lbl.Text = "First name";
            // 
            // lastname_LBL
            // 
            this.lastname_LBL.AutoSize = true;
            this.lastname_LBL.Location = new System.Drawing.Point(103, 0);
            this.lastname_LBL.Name = "lastname_LBL";
            this.lastname_LBL.Size = new System.Drawing.Size(56, 13);
            this.lastname_LBL.TabIndex = 1;
            this.lastname_LBL.Text = "Last name";
            // 
            // dateOfBirth_LBL
            // 
            this.dateOfBirth_LBL.AutoSize = true;
            this.dateOfBirth_LBL.Location = new System.Drawing.Point(423, 34);
            this.dateOfBirth_LBL.Name = "dateOfBirth_LBL";
            this.dateOfBirth_LBL.Size = new System.Drawing.Size(68, 13);
            this.dateOfBirth_LBL.TabIndex = 5;
            this.dateOfBirth_LBL.Text = "Date Of Birth";
            // 
            // patients_datagridview
            // 
            this.patients_datagridview.AllowUserToAddRows = false;
            this.patients_datagridview.AllowUserToDeleteRows = false;
            this.patients_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patients_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patients_datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patients_datagridview.Location = new System.Drawing.Point(3, 76);
            this.patients_datagridview.MultiSelect = false;
            this.patients_datagridview.Name = "patients_datagridview";
            this.patients_datagridview.ReadOnly = true;
            this.patients_datagridview.Size = new System.Drawing.Size(844, 275);
            this.patients_datagridview.TabIndex = 3;
            this.patients_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patients_datagridview_CellContentClick);
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(Clinic.Model.Appointment);
            // 
            // editSelectedPatient_Button
            // 
            this.editSelectedPatient_Button.Location = new System.Drawing.Point(339, 3);
            this.editSelectedPatient_Button.Name = "editSelectedPatient_Button";
            this.editSelectedPatient_Button.Size = new System.Drawing.Size(75, 23);
            this.editSelectedPatient_Button.TabIndex = 3;
            this.editSelectedPatient_Button.Text = "Edit Patient";
            this.editSelectedPatient_Button.UseVisualStyleBackColor = true;
            this.editSelectedPatient_Button.Visible = false;
            this.editSelectedPatient_Button.Click += new System.EventHandler(this.editSelectedPatient_Button_Click);
            // 
            // patient_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.baseAppointment_TableLayoutPanel);
            this.Name = "patient_UserControl";
            this.Size = new System.Drawing.Size(850, 400);
            this.bottomRow_Appointments_TableLayoutPanel.ResumeLayout(false);
            this.baseAppointment_TableLayoutPanel.ResumeLayout(false);
            this.topRow_Appointment_tableLOP.ResumeLayout(false);
            this.topRow_Appointment_tableLOP.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.patientnameLBL_TLP.ResumeLayout(false);
            this.patientnameLBL_TLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patients_datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.Label searchPatients_LBL;
        private System.Windows.Forms.TableLayoutPanel bottomRow_Appointments_TableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel baseAppointment_TableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel topRow_Appointment_tableLOP;
        private System.Windows.Forms.DateTimePicker DateOfBirth_datetimePicker;
        private System.Windows.Forms.Button searchAppointment_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox firstname_textbox;
        private System.Windows.Forms.TextBox lastname_textbox;
        private System.Windows.Forms.TableLayoutPanel patientnameLBL_TLP;
        private System.Windows.Forms.Label firstname_lbl;
        private System.Windows.Forms.Label lastname_LBL;
        private System.Windows.Forms.Label dateOfBirth_LBL;
        private System.Windows.Forms.DataGridView patients_datagridview;
        private System.Windows.Forms.Button resetDateOfBirth;
        private System.Windows.Forms.Button ResetDataGridView_button;
        private System.Windows.Forms.Button getAllPatients;
        private System.Windows.Forms.Button addPatient_button;
        private System.Windows.Forms.Button editSelectedPatient_Button;
    }
}

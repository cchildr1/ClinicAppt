namespace Clinic.UserControls
{
    partial class visits_UserControl
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
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label fullNameLabel1;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NurseComboBox = new System.Windows.Forms.ComboBox();
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.visitDataGridView = new System.Windows.Forms.DataGridView();
            this.VisitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symptoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPatient = new System.Windows.Forms.TextBox();
            this.DTPAppointmentStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BtReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPVisitEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DTPVisitStart = new System.Windows.Forms.DateTimePicker();
            this.DTPAppointmentEnd = new System.Windows.Forms.DateTimePicker();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            fullNameLabel = new System.Windows.Forms.Label();
            fullNameLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            fullNameLabel.Location = new System.Drawing.Point(3, 20);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(120, 27);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "Doctor:";
            fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullNameLabel1
            // 
            fullNameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            fullNameLabel1.AutoSize = true;
            fullNameLabel1.Location = new System.Drawing.Point(550, 20);
            fullNameLabel1.Name = "fullNameLabel1";
            fullNameLabel1.Size = new System.Drawing.Size(117, 27);
            fullNameLabel1.TabIndex = 5;
            fullNameLabel1.Text = "Nurse:";
            fullNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(fullNameLabel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NurseComboBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(fullNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DoctorComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.visitDataGridView, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnSearch, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TbPatient, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DTPAppointmentStart, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtReset, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.DTPVisitEnd, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.DTPVisitStart, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DTPAppointmentEnd, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 492);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NurseComboBox
            // 
            this.NurseComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NurseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Nurse.FullName", true));
            this.NurseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NurseComboBox.FormattingEnabled = true;
            this.NurseComboBox.Location = new System.Drawing.Point(673, 23);
            this.NurseComboBox.Name = "NurseComboBox";
            this.NurseComboBox.Size = new System.Drawing.Size(415, 21);
            this.NurseComboBox.TabIndex = 6;
            // 
            // DoctorComboBox
            // 
            this.DoctorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Appointment.Doctor.FullName", true));
            this.DoctorComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoctorComboBox.FormattingEnabled = true;
            this.DoctorComboBox.Location = new System.Drawing.Point(129, 23);
            this.DoctorComboBox.Name = "DoctorComboBox";
            this.DoctorComboBox.Size = new System.Drawing.Size(415, 21);
            this.DoctorComboBox.TabIndex = 3;
            // 
            // visitDataGridView
            // 
            this.visitDataGridView.AllowUserToAddRows = false;
            this.visitDataGridView.AllowUserToDeleteRows = false;
            this.visitDataGridView.AllowUserToOrderColumns = true;
            this.visitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VisitID,
            this.AppointmentDate,
            this.VisitDate,
            this.PatientName,
            this.DoctorName,
            this.NurseName,
            this.Symptoms,
            this.EditButton});
            this.tableLayoutPanel1.SetColumnSpan(this.visitDataGridView, 4);
            this.visitDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitDataGridView.Location = new System.Drawing.Point(3, 151);
            this.visitDataGridView.Name = "visitDataGridView";
            this.visitDataGridView.ReadOnly = true;
            this.visitDataGridView.Size = new System.Drawing.Size(1085, 309);
            this.visitDataGridView.TabIndex = 0;
            // 
            // VisitID
            // 
            this.VisitID.HeaderText = "Visit ID";
            this.VisitID.Name = "VisitID";
            this.VisitID.ReadOnly = true;
            this.VisitID.Visible = false;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AppointmentDate.HeaderText = "Appointment Date";
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.ReadOnly = true;
            this.AppointmentDate.Width = 107;
            // 
            // VisitDate
            // 
            this.VisitDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VisitDate.HeaderText = "Visit Date";
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.ReadOnly = true;
            this.VisitDate.Width = 71;
            // 
            // PatientName
            // 
            this.PatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Width = 88;
            // 
            // DoctorName
            // 
            this.DoctorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DoctorName.HeaderText = "Doctor Name";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            this.DoctorName.Width = 87;
            // 
            // NurseName
            // 
            this.NurseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NurseName.HeaderText = "Nurse Name";
            this.NurseName.Name = "NurseName";
            this.NurseName.ReadOnly = true;
            this.NurseName.Width = 84;
            // 
            // Symptoms
            // 
            this.Symptoms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Symptoms.HeaderText = "Symptoms";
            this.Symptoms.Name = "Symptoms";
            this.Symptoms.ReadOnly = true;
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EditButton.HeaderText = "Edit";
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditButton.Text = "Edit";
            this.EditButton.Width = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Visits";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(673, 122);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(115, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patient:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbPatient
            // 
            this.TbPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPatient.Location = new System.Drawing.Point(129, 50);
            this.TbPatient.Name = "TbPatient";
            this.TbPatient.Size = new System.Drawing.Size(415, 20);
            this.TbPatient.TabIndex = 8;
            // 
            // DTPAppointmentStart
            // 
            this.DTPAppointmentStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPAppointmentStart.Checked = false;
            this.DTPAppointmentStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPAppointmentStart.Location = new System.Drawing.Point(129, 76);
            this.DTPAppointmentStart.Name = "DTPAppointmentStart";
            this.DTPAppointmentStart.ShowCheckBox = true;
            this.DTPAppointmentStart.Size = new System.Drawing.Size(415, 20);
            this.DTPAppointmentStart.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Appointment Start Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtReset
            // 
            this.BtReset.Location = new System.Drawing.Point(673, 466);
            this.BtReset.Name = "BtReset";
            this.BtReset.Size = new System.Drawing.Size(75, 23);
            this.BtReset.TabIndex = 13;
            this.BtReset.Text = "Reset";
            this.BtReset.UseVisualStyleBackColor = true;
            this.BtReset.Click += new System.EventHandler(this.BtReset_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Visit End Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTPVisitEnd
            // 
            this.DTPVisitEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPVisitEnd.Checked = false;
            this.DTPVisitEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPVisitEnd.Location = new System.Drawing.Point(673, 102);
            this.DTPVisitEnd.Name = "DTPVisitEnd";
            this.DTPVisitEnd.ShowCheckBox = true;
            this.DTPVisitEnd.Size = new System.Drawing.Size(415, 20);
            this.DTPVisitEnd.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Appointment End Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Visit Start Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTPVisitStart
            // 
            this.DTPVisitStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPVisitStart.Checked = false;
            this.DTPVisitStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPVisitStart.Location = new System.Drawing.Point(129, 102);
            this.DTPVisitStart.Name = "DTPVisitStart";
            this.DTPVisitStart.ShowCheckBox = true;
            this.DTPVisitStart.Size = new System.Drawing.Size(415, 20);
            this.DTPVisitStart.TabIndex = 16;
            // 
            // DTPAppointmentEnd
            // 
            this.DTPAppointmentEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPAppointmentEnd.Checked = false;
            this.DTPAppointmentEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPAppointmentEnd.Location = new System.Drawing.Point(673, 76);
            this.DTPAppointmentEnd.Name = "DTPAppointmentEnd";
            this.DTPAppointmentEnd.ShowCheckBox = true;
            this.DTPAppointmentEnd.Size = new System.Drawing.Size(415, 20);
            this.DTPAppointmentEnd.TabIndex = 17;
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(Clinic.Model.Visit);
            // 
            // visits_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "visits_UserControl";
            this.Size = new System.Drawing.Size(1091, 492);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.BindingSource visitBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView visitDataGridView;
        private System.Windows.Forms.ComboBox DoctorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ComboBox NurseComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbPatient;
        private System.Windows.Forms.DateTimePicker DTPAppointmentStart;
        private System.Windows.Forms.DateTimePicker DTPVisitEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTPVisitStart;
        private System.Windows.Forms.DateTimePicker DTPAppointmentEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symptoms;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
    }
}

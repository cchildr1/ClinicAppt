namespace Clinic.View
{
    partial class AddEditVisit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fullNameLabel1;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label dateTimeLabel;
            System.Windows.Forms.Label dateTimeLabel1;
            System.Windows.Forms.Label bpSystolicLabel;
            System.Windows.Forms.Label bpDiastolicLabel;
            System.Windows.Forms.Label pulseLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label initialDiagnosisLabel;
            System.Windows.Forms.Label finalDiagnosisLabel;
            System.Windows.Forms.Label fullNameLabel2;
            this.patientTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.finalDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.initialDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.bpDiastolicTextBox = new System.Windows.Forms.TextBox();
            this.bpSystolicTextBox = new System.Windows.Forms.TextBox();
            this.DTPVisitTime = new System.Windows.Forms.DateTimePicker();
            this.DTPVisitDate = new System.Windows.Forms.DateTimePicker();
            this.NurseComboBox = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            fullNameLabel1 = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            dateTimeLabel = new System.Windows.Forms.Label();
            dateTimeLabel1 = new System.Windows.Forms.Label();
            bpSystolicLabel = new System.Windows.Forms.Label();
            bpDiastolicLabel = new System.Windows.Forms.Label();
            pulseLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            initialDiagnosisLabel = new System.Windows.Forms.Label();
            finalDiagnosisLabel = new System.Windows.Forms.Label();
            fullNameLabel2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel1
            // 
            fullNameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            fullNameLabel1.AutoSize = true;
            fullNameLabel1.Location = new System.Drawing.Point(3, 0);
            fullNameLabel1.Name = "fullNameLabel1";
            fullNameLabel1.Size = new System.Drawing.Size(83, 26);
            fullNameLabel1.TabIndex = 2;
            fullNameLabel1.Text = "Patient:";
            fullNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullNameLabel
            // 
            fullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(3, 26);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(83, 27);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Nurse:";
            fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Location = new System.Drawing.Point(3, 53);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new System.Drawing.Size(83, 26);
            dateTimeLabel.TabIndex = 4;
            dateTimeLabel.Text = "Visit Date:";
            dateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel1
            // 
            dateTimeLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dateTimeLabel1.AutoSize = true;
            dateTimeLabel1.Location = new System.Drawing.Point(298, 53);
            dateTimeLabel1.Name = "dateTimeLabel1";
            dateTimeLabel1.Size = new System.Drawing.Size(75, 26);
            dateTimeLabel1.TabIndex = 6;
            dateTimeLabel1.Text = "Visit Time:";
            dateTimeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bpSystolicLabel
            // 
            bpSystolicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            bpSystolicLabel.AutoSize = true;
            bpSystolicLabel.Location = new System.Drawing.Point(3, 79);
            bpSystolicLabel.Name = "bpSystolicLabel";
            bpSystolicLabel.Size = new System.Drawing.Size(83, 26);
            bpSystolicLabel.TabIndex = 8;
            bpSystolicLabel.Text = "Systolic:";
            bpSystolicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bpDiastolicLabel
            // 
            bpDiastolicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            bpDiastolicLabel.AutoSize = true;
            bpDiastolicLabel.Location = new System.Drawing.Point(298, 79);
            bpDiastolicLabel.Name = "bpDiastolicLabel";
            bpDiastolicLabel.Size = new System.Drawing.Size(75, 26);
            bpDiastolicLabel.TabIndex = 10;
            bpDiastolicLabel.Text = "Diastolic:";
            bpDiastolicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pulseLabel
            // 
            pulseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new System.Drawing.Point(3, 105);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new System.Drawing.Size(83, 26);
            pulseLabel.TabIndex = 12;
            pulseLabel.Text = "Pulse:";
            pulseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightLabel
            // 
            weightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(298, 105);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(75, 26);
            weightLabel.TabIndex = 14;
            weightLabel.Text = "Weight:";
            weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // symptomsLabel
            // 
            symptomsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(3, 131);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(83, 98);
            symptomsLabel.TabIndex = 16;
            symptomsLabel.Text = "Symptoms:";
            symptomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // initialDiagnosisLabel
            // 
            initialDiagnosisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            initialDiagnosisLabel.AutoSize = true;
            initialDiagnosisLabel.Location = new System.Drawing.Point(3, 229);
            initialDiagnosisLabel.Name = "initialDiagnosisLabel";
            initialDiagnosisLabel.Size = new System.Drawing.Size(83, 98);
            initialDiagnosisLabel.TabIndex = 18;
            initialDiagnosisLabel.Text = "Initial Diagnosis:";
            // 
            // finalDiagnosisLabel
            // 
            finalDiagnosisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            finalDiagnosisLabel.AutoSize = true;
            finalDiagnosisLabel.Location = new System.Drawing.Point(3, 327);
            finalDiagnosisLabel.Name = "finalDiagnosisLabel";
            finalDiagnosisLabel.Size = new System.Drawing.Size(83, 98);
            finalDiagnosisLabel.TabIndex = 20;
            finalDiagnosisLabel.Text = "Final Diagnosis:";
            // 
            // fullNameLabel2
            // 
            fullNameLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            fullNameLabel2.AutoSize = true;
            fullNameLabel2.Location = new System.Drawing.Point(298, 26);
            fullNameLabel2.Name = "fullNameLabel2";
            fullNameLabel2.Size = new System.Drawing.Size(75, 27);
            fullNameLabel2.TabIndex = 22;
            fullNameLabel2.Text = "Doctor:";
            fullNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patientTextBox
            // 
            this.patientTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Appointment.Patient.FullName", true));
            this.patientTextBox.Location = new System.Drawing.Point(92, 3);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.ReadOnly = true;
            this.patientTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientTextBox.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(fullNameLabel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.doctorTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(finalDiagnosisLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.finalDiagnosisTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(initialDiagnosisLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.initialDiagnosisTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(symptomsLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.symptomsTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(weightLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.weightTextBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(pulseLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pulseTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(bpDiastolicLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bpDiastolicTextBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(bpSystolicLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bpSystolicTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(dateTimeLabel1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.DTPVisitTime, 3, 2);
            this.tableLayoutPanel1.Controls.Add(dateTimeLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DTPVisitDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(fullNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NurseComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.patientTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(fullNameLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btOK, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.btCancel, 3, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 456);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Appointment.Doctor.FullName", true));
            this.doctorTextBox.Location = new System.Drawing.Point(379, 29);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.ReadOnly = true;
            this.doctorTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctorTextBox.TabIndex = 23;
            // 
            // finalDiagnosisTextBox
            // 
            this.finalDiagnosisTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.finalDiagnosisTextBox, 3);
            this.finalDiagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "FinalDiagnosis", true));
            this.finalDiagnosisTextBox.Location = new System.Drawing.Point(92, 330);
            this.finalDiagnosisTextBox.Multiline = true;
            this.finalDiagnosisTextBox.Name = "finalDiagnosisTextBox";
            this.finalDiagnosisTextBox.Size = new System.Drawing.Size(498, 92);
            this.finalDiagnosisTextBox.TabIndex = 21;
            // 
            // initialDiagnosisTextBox
            // 
            this.initialDiagnosisTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.initialDiagnosisTextBox, 3);
            this.initialDiagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "InitialDiagnosis", true));
            this.initialDiagnosisTextBox.Location = new System.Drawing.Point(92, 232);
            this.initialDiagnosisTextBox.Multiline = true;
            this.initialDiagnosisTextBox.Name = "initialDiagnosisTextBox";
            this.initialDiagnosisTextBox.Size = new System.Drawing.Size(498, 92);
            this.initialDiagnosisTextBox.TabIndex = 19;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.symptomsTextBox, 3);
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.symptomsTextBox.Location = new System.Drawing.Point(92, 134);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(498, 92);
            this.symptomsTextBox.TabIndex = 17;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(379, 108);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 15;
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Pulse", true));
            this.pulseTextBox.Location = new System.Drawing.Point(92, 108);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(100, 20);
            this.pulseTextBox.TabIndex = 13;
            // 
            // bpDiastolicTextBox
            // 
            this.bpDiastolicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "BpDiastolic", true));
            this.bpDiastolicTextBox.Location = new System.Drawing.Point(379, 82);
            this.bpDiastolicTextBox.Name = "bpDiastolicTextBox";
            this.bpDiastolicTextBox.Size = new System.Drawing.Size(100, 20);
            this.bpDiastolicTextBox.TabIndex = 11;
            // 
            // bpSystolicTextBox
            // 
            this.bpSystolicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "BpSystolic", true));
            this.bpSystolicTextBox.Location = new System.Drawing.Point(92, 82);
            this.bpSystolicTextBox.Name = "bpSystolicTextBox";
            this.bpSystolicTextBox.Size = new System.Drawing.Size(100, 20);
            this.bpSystolicTextBox.TabIndex = 9;
            // 
            // DTPVisitTime
            // 
            this.DTPVisitTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.visitBindingSource, "DateTime", true));
            this.DTPVisitTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPVisitTime.Location = new System.Drawing.Point(379, 56);
            this.DTPVisitTime.Name = "DTPVisitTime";
            this.DTPVisitTime.Size = new System.Drawing.Size(200, 20);
            this.DTPVisitTime.TabIndex = 7;
            // 
            // DTPVisitDate
            // 
            this.DTPVisitDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.visitBindingSource, "DateTime", true));
            this.DTPVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPVisitDate.Location = new System.Drawing.Point(92, 56);
            this.DTPVisitDate.Name = "DTPVisitDate";
            this.DTPVisitDate.Size = new System.Drawing.Size(200, 20);
            this.DTPVisitDate.TabIndex = 5;
            // 
            // NurseComboBox
            // 
            this.NurseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Nurse.FullName", true));
            this.NurseComboBox.FormattingEnabled = true;
            this.NurseComboBox.Location = new System.Drawing.Point(92, 29);
            this.NurseComboBox.Name = "NurseComboBox";
            this.NurseComboBox.Size = new System.Drawing.Size(121, 21);
            this.NurseComboBox.TabIndex = 4;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(298, 428);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 24;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(379, 428);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 25;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(Clinic.Model.Visit);
            // 
            // AddEditVisit
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(593, 456);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditVisit";
            this.Text = "AddEditVisit";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource visitBindingSource;
        private System.Windows.Forms.TextBox patientTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox NurseComboBox;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox pulseTextBox;
        private System.Windows.Forms.TextBox bpDiastolicTextBox;
        private System.Windows.Forms.TextBox bpSystolicTextBox;
        private System.Windows.Forms.DateTimePicker DTPVisitTime;
        private System.Windows.Forms.DateTimePicker DTPVisitDate;
        private System.Windows.Forms.TextBox doctorTextBox;
        private System.Windows.Forms.TextBox finalDiagnosisTextBox;
        private System.Windows.Forms.TextBox initialDiagnosisTextBox;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}
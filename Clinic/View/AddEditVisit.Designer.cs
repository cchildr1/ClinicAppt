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
            System.Windows.Forms.Label nurseLabel;
            System.Windows.Forms.Label visitDateLabel;
            System.Windows.Forms.Label visitTimeLabel;
            System.Windows.Forms.Label bpSystolicLabel;
            System.Windows.Forms.Label bpDiastolicLabel;
            System.Windows.Forms.Label pulseLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label initialDiagnosisLabel;
            System.Windows.Forms.Label finalDiagnosisLabel;
            System.Windows.Forms.Label fullNameLabel2;
            System.Windows.Forms.Label bodyTemperatureLabel;
            System.Windows.Forms.Label infoLabel;
            this.patientTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.bodyTemperatureTextBox = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtClearTest = new System.Windows.Forms.Button();
            this.BtSubmitTest = new System.Windows.Forms.Button();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTestCodeComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fullNameLabel1 = new System.Windows.Forms.Label();
            nurseLabel = new System.Windows.Forms.Label();
            visitDateLabel = new System.Windows.Forms.Label();
            visitTimeLabel = new System.Windows.Forms.Label();
            bpSystolicLabel = new System.Windows.Forms.Label();
            bpDiastolicLabel = new System.Windows.Forms.Label();
            pulseLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            initialDiagnosisLabel = new System.Windows.Forms.Label();
            finalDiagnosisLabel = new System.Windows.Forms.Label();
            fullNameLabel2 = new System.Windows.Forms.Label();
            bodyTemperatureLabel = new System.Windows.Forms.Label();
            infoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).BeginInit();
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
            // nurseLabel
            // 
            nurseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            nurseLabel.AutoSize = true;
            nurseLabel.Location = new System.Drawing.Point(3, 26);
            nurseLabel.Name = "nurseLabel";
            nurseLabel.Size = new System.Drawing.Size(83, 27);
            nurseLabel.TabIndex = 3;
            nurseLabel.Text = "Nurse:";
            nurseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visitDateLabel
            // 
            visitDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            visitDateLabel.AutoSize = true;
            visitDateLabel.Location = new System.Drawing.Point(3, 53);
            visitDateLabel.Name = "visitDateLabel";
            visitDateLabel.Size = new System.Drawing.Size(83, 26);
            visitDateLabel.TabIndex = 4;
            visitDateLabel.Text = "Visit Date:";
            visitDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visitTimeLabel
            // 
            visitTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            visitTimeLabel.AutoSize = true;
            visitTimeLabel.Location = new System.Drawing.Point(298, 53);
            visitTimeLabel.Name = "visitTimeLabel";
            visitTimeLabel.Size = new System.Drawing.Size(75, 26);
            visitTimeLabel.TabIndex = 6;
            visitTimeLabel.Text = "Visit Time:";
            visitTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            symptomsLabel.Location = new System.Drawing.Point(3, 157);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(83, 39);
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
            initialDiagnosisLabel.Location = new System.Drawing.Point(3, 235);
            initialDiagnosisLabel.Name = "initialDiagnosisLabel";
            initialDiagnosisLabel.Size = new System.Drawing.Size(83, 39);
            initialDiagnosisLabel.TabIndex = 18;
            initialDiagnosisLabel.Text = "Initial Diagnosis:";
            initialDiagnosisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finalDiagnosisLabel
            // 
            finalDiagnosisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            finalDiagnosisLabel.AutoSize = true;
            finalDiagnosisLabel.Location = new System.Drawing.Point(3, 274);
            finalDiagnosisLabel.Name = "finalDiagnosisLabel";
            finalDiagnosisLabel.Size = new System.Drawing.Size(83, 39);
            finalDiagnosisLabel.TabIndex = 20;
            finalDiagnosisLabel.Text = "Final Diagnosis:";
            finalDiagnosisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // bodyTemperatureLabel
            // 
            bodyTemperatureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            bodyTemperatureLabel.AutoSize = true;
            bodyTemperatureLabel.Location = new System.Drawing.Point(3, 131);
            bodyTemperatureLabel.Name = "bodyTemperatureLabel";
            bodyTemperatureLabel.Size = new System.Drawing.Size(83, 26);
            bodyTemperatureLabel.TabIndex = 26;
            bodyTemperatureLabel.Text = "Temperature:";
            bodyTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            infoLabel.AutoSize = true;
            infoLabel.Location = new System.Drawing.Point(3, 196);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new System.Drawing.Size(83, 39);
            infoLabel.TabIndex = 28;
            infoLabel.Text = "Info:";
            infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.patientTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.testDataGridView, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.infoTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(bodyTemperatureLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.bodyTemperatureTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(fullNameLabel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.doctorTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(finalDiagnosisLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.finalDiagnosisTextBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(initialDiagnosisLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.initialDiagnosisTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(symptomsLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.symptomsTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(weightLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.weightTextBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(pulseLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pulseTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(bpDiastolicLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bpDiastolicTextBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(bpSystolicLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bpSystolicTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(visitTimeLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.DTPVisitTime, 3, 2);
            this.tableLayoutPanel1.Controls.Add(visitDateLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DTPVisitDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(nurseLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NurseComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.patientTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(fullNameLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btOK, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.btCancel, 3, 10);
            this.tableLayoutPanel1.Controls.Add(infoLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 3, 13);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1083, 549);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.infoTextBox, 3);
            this.infoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Info", true));
            this.infoTextBox.Location = new System.Drawing.Point(92, 199);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(988, 33);
            this.infoTextBox.TabIndex = 12;
            // 
            // bodyTemperatureTextBox
            // 
            this.bodyTemperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "BodyTemperature", true));
            this.bodyTemperatureTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyTemperatureTextBox.Location = new System.Drawing.Point(92, 134);
            this.bodyTemperatureTextBox.Name = "bodyTemperatureTextBox";
            this.bodyTemperatureTextBox.Size = new System.Drawing.Size(200, 20);
            this.bodyTemperatureTextBox.TabIndex = 10;
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Appointment.Doctor.FullName", true));
            this.doctorTextBox.Location = new System.Drawing.Point(379, 29);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.ReadOnly = true;
            this.doctorTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctorTextBox.TabIndex = 3;
            // 
            // finalDiagnosisTextBox
            // 
            this.finalDiagnosisTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.finalDiagnosisTextBox, 3);
            this.finalDiagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "FinalDiagnosis", true));
            this.finalDiagnosisTextBox.Location = new System.Drawing.Point(92, 277);
            this.finalDiagnosisTextBox.Multiline = true;
            this.finalDiagnosisTextBox.Name = "finalDiagnosisTextBox";
            this.finalDiagnosisTextBox.Size = new System.Drawing.Size(988, 33);
            this.finalDiagnosisTextBox.TabIndex = 14;
            // 
            // initialDiagnosisTextBox
            // 
            this.initialDiagnosisTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.initialDiagnosisTextBox, 3);
            this.initialDiagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "InitialDiagnosis", true));
            this.initialDiagnosisTextBox.Location = new System.Drawing.Point(92, 238);
            this.initialDiagnosisTextBox.Multiline = true;
            this.initialDiagnosisTextBox.Name = "initialDiagnosisTextBox";
            this.initialDiagnosisTextBox.Size = new System.Drawing.Size(988, 33);
            this.initialDiagnosisTextBox.TabIndex = 13;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.symptomsTextBox, 3);
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.symptomsTextBox.Location = new System.Drawing.Point(92, 160);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(988, 33);
            this.symptomsTextBox.TabIndex = 11;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(379, 108);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 8;
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Pulse", true));
            this.pulseTextBox.Location = new System.Drawing.Point(92, 108);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(100, 20);
            this.pulseTextBox.TabIndex = 8;
            // 
            // bpDiastolicTextBox
            // 
            this.bpDiastolicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "BpDiastolic", true));
            this.bpDiastolicTextBox.Location = new System.Drawing.Point(379, 82);
            this.bpDiastolicTextBox.Name = "bpDiastolicTextBox";
            this.bpDiastolicTextBox.Size = new System.Drawing.Size(100, 20);
            this.bpDiastolicTextBox.TabIndex = 7;
            // 
            // bpSystolicTextBox
            // 
            this.bpSystolicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "BpSystolic", true));
            this.bpSystolicTextBox.Location = new System.Drawing.Point(92, 82);
            this.bpSystolicTextBox.Name = "bpSystolicTextBox";
            this.bpSystolicTextBox.Size = new System.Drawing.Size(100, 20);
            this.bpSystolicTextBox.TabIndex = 6;
            // 
            // DTPVisitTime
            // 
            this.DTPVisitTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.visitBindingSource, "DateTime", true));
            this.DTPVisitTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPVisitTime.Location = new System.Drawing.Point(379, 56);
            this.DTPVisitTime.Name = "DTPVisitTime";
            this.DTPVisitTime.Size = new System.Drawing.Size(200, 20);
            this.DTPVisitTime.TabIndex = 5;
            // 
            // DTPVisitDate
            // 
            this.DTPVisitDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.visitBindingSource, "DateTime", true));
            this.DTPVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPVisitDate.Location = new System.Drawing.Point(92, 56);
            this.DTPVisitDate.Name = "DTPVisitDate";
            this.DTPVisitDate.Size = new System.Drawing.Size(200, 20);
            this.DTPVisitDate.TabIndex = 4;
            // 
            // NurseComboBox
            // 
            this.NurseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Nurse.FullName", true));
            this.NurseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NurseComboBox.FormattingEnabled = true;
            this.NurseComboBox.Location = new System.Drawing.Point(92, 29);
            this.NurseComboBox.Name = "NurseComboBox";
            this.NurseComboBox.Size = new System.Drawing.Size(121, 21);
            this.NurseComboBox.TabIndex = 2;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(298, 316);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 15;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(379, 316);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 16;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tests";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtClearTest);
            this.flowLayoutPanel1.Controls.Add(this.BtSubmitTest);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(379, 517);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(701, 29);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // BtClearTest
            // 
            this.BtClearTest.Location = new System.Drawing.Point(3, 3);
            this.BtClearTest.Name = "BtClearTest";
            this.BtClearTest.Size = new System.Drawing.Size(109, 23);
            this.BtClearTest.TabIndex = 32;
            this.BtClearTest.Text = "Clear Test Changes";
            this.BtClearTest.UseVisualStyleBackColor = true;
            this.BtClearTest.Click += new System.EventHandler(this.BtClearTest_Click);
            // 
            // BtSubmitTest
            // 
            this.BtSubmitTest.Location = new System.Drawing.Point(118, 3);
            this.BtSubmitTest.Name = "BtSubmitTest";
            this.BtSubmitTest.Size = new System.Drawing.Size(117, 23);
            this.BtSubmitTest.TabIndex = 33;
            this.BtSubmitTest.Text = "Submit Test Changes";
            this.BtSubmitTest.UseVisualStyleBackColor = true;
            this.BtSubmitTest.Click += new System.EventHandler(this.BtSubmitTest_Click);
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(Clinic.Model.Visit);
            // 
            // testBindingSource1
            // 
            this.testBindingSource1.DataSource = typeof(Clinic.Model.Test);
            // 
            // testDataGridView
            // 
            this.testDataGridView.AutoGenerateColumns = false;
            this.testDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTestCodeComboBox,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.tableLayoutPanel1.SetColumnSpan(this.testDataGridView, 4);
            this.testDataGridView.DataSource = this.testBindingSource1;
            this.testDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testDataGridView.Location = new System.Drawing.Point(3, 358);
            this.testDataGridView.Name = "testDataGridView";
            this.testDataGridView.Size = new System.Drawing.Size(1077, 153);
            this.testDataGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TestID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TestID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VisitID";
            this.dataGridViewTextBoxColumn2.HeaderText = "VisitID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTestCodeComboBox
            // 
            this.dataGridViewTestCodeComboBox.DataPropertyName = "Code";
            this.dataGridViewTestCodeComboBox.HeaderText = "Test Code";
            this.dataGridViewTestCodeComboBox.Name = "dataGridViewTestCodeComboBox";
            this.dataGridViewTestCodeComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTestCodeComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DatePerformed";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date Performed";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateAvailable";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date Available";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "AbnormalResult";
            this.dataGridViewCheckBoxColumn1.HeaderText = "AbnormalResult";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Result";
            this.dataGridViewTextBoxColumn5.HeaderText = "Result";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // AddEditVisit
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(1083, 549);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Visit";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox bodyTemperatureTextBox;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource testBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtClearTest;
        private System.Windows.Forms.Button BtSubmitTest;
        private System.Windows.Forms.DataGridView testDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTestCodeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource testBindingSource1;
    }
}
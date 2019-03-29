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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitDataGridView = new System.Windows.Forms.DataGridView();
            this.VisitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symptoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            fullNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            fullNameLabel.Location = new System.Drawing.Point(3, 20);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(102, 27);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "Doctor:";
            fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(fullNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DoctorComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.visitDataGridView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnSearch, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1074, 492);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DoctorComboBox
            // 
            this.DoctorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Appointment.Doctor.FullName", true));
            this.DoctorComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorComboBox.FormattingEnabled = true;
            this.DoctorComboBox.Location = new System.Drawing.Point(111, 23);
            this.DoctorComboBox.Name = "DoctorComboBox";
            this.DoctorComboBox.Size = new System.Drawing.Size(477, 21);
            this.DoctorComboBox.TabIndex = 3;
            this.DoctorComboBox.Text = "Doctor";
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(Clinic.Model.Visit);
            // 
            // visitDataGridView
            // 
            this.visitDataGridView.AllowUserToAddRows = false;
            this.visitDataGridView.AllowUserToDeleteRows = false;
            this.visitDataGridView.AllowUserToOrderColumns = true;
            this.visitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VisitDate,
            this.AppointmentDate,
            this.PatientName,
            this.DoctorName,
            this.NurseName,
            this.Symptoms});
            this.tableLayoutPanel1.SetColumnSpan(this.visitDataGridView, 3);
            this.visitDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitDataGridView.Location = new System.Drawing.Point(3, 79);
            this.visitDataGridView.Name = "visitDataGridView";
            this.visitDataGridView.ReadOnly = true;
            this.visitDataGridView.Size = new System.Drawing.Size(1068, 390);
            this.visitDataGridView.TabIndex = 0;
            // 
            // VisitDate
            // 
            this.VisitDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VisitDate.HeaderText = "Visit Date";
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.ReadOnly = true;
            this.VisitDate.Width = 71;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AppointmentDate.HeaderText = "Appointment Date";
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.ReadOnly = true;
            this.AppointmentDate.Width = 107;
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
            this.BtnSearch.Location = new System.Drawing.Point(594, 50);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // visits_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "visits_UserControl";
            this.Size = new System.Drawing.Size(1074, 492);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource visitBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView visitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symptoms;
        private System.Windows.Forms.ComboBox DoctorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSearch;
    }
}

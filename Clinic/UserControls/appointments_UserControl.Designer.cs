namespace Clinic.UserControls
{
    partial class appointments_UserControl
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
            this.baseAppointment_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.topRow_Appointment_tableLOP = new System.Windows.Forms.TableLayoutPanel();
            this.filterAppointments_LBL = new System.Windows.Forms.Label();
            this.PatientName_TextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.filterAppointment_button = new System.Windows.Forms.Button();
            this.appointment_DataGridView = new System.Windows.Forms.DataGridView();
            this.bottomRow_Appointments_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.create_Appointments_Button = new System.Windows.Forms.Button();
            this.edit_appointments_Button = new System.Windows.Forms.Button();
            this.reset_Button = new System.Windows.Forms.Button();
            this.baseAppointment_TableLayoutPanel.SuspendLayout();
            this.topRow_Appointment_tableLOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_DataGridView)).BeginInit();
            this.bottomRow_Appointments_TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseAppointment_TableLayoutPanel
            // 
            this.baseAppointment_TableLayoutPanel.ColumnCount = 1;
            this.baseAppointment_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.baseAppointment_TableLayoutPanel.Controls.Add(this.topRow_Appointment_tableLOP, 0, 0);
            this.baseAppointment_TableLayoutPanel.Controls.Add(this.appointment_DataGridView, 0, 1);
            this.baseAppointment_TableLayoutPanel.Controls.Add(this.bottomRow_Appointments_TableLayoutPanel, 0, 2);
            this.baseAppointment_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseAppointment_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.baseAppointment_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.baseAppointment_TableLayoutPanel.Name = "baseAppointment_TableLayoutPanel";
            this.baseAppointment_TableLayoutPanel.RowCount = 3;
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2058F));
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.7942F));
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.baseAppointment_TableLayoutPanel.Size = new System.Drawing.Size(850, 400);
            this.baseAppointment_TableLayoutPanel.TabIndex = 0;
            // 
            // topRow_Appointment_tableLOP
            // 
            this.topRow_Appointment_tableLOP.ColumnCount = 4;
            this.topRow_Appointment_tableLOP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topRow_Appointment_tableLOP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topRow_Appointment_tableLOP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topRow_Appointment_tableLOP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topRow_Appointment_tableLOP.Controls.Add(this.filterAppointments_LBL, 0, 0);
            this.topRow_Appointment_tableLOP.Controls.Add(this.PatientName_TextBox, 1, 0);
            this.topRow_Appointment_tableLOP.Controls.Add(this.dateTimePicker2, 2, 0);
            this.topRow_Appointment_tableLOP.Controls.Add(this.filterAppointment_button, 3, 0);
            this.topRow_Appointment_tableLOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRow_Appointment_tableLOP.Location = new System.Drawing.Point(5, 5);
            this.topRow_Appointment_tableLOP.Margin = new System.Windows.Forms.Padding(5);
            this.topRow_Appointment_tableLOP.Name = "topRow_Appointment_tableLOP";
            this.topRow_Appointment_tableLOP.RowCount = 1;
            this.topRow_Appointment_tableLOP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topRow_Appointment_tableLOP.Size = new System.Drawing.Size(840, 54);
            this.topRow_Appointment_tableLOP.TabIndex = 0;
            // 
            // filterAppointments_LBL
            // 
            this.filterAppointments_LBL.AutoSize = true;
            this.filterAppointments_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterAppointments_LBL.Location = new System.Drawing.Point(3, 0);
            this.filterAppointments_LBL.Name = "filterAppointments_LBL";
            this.filterAppointments_LBL.Padding = new System.Windows.Forms.Padding(5);
            this.filterAppointments_LBL.Size = new System.Drawing.Size(157, 30);
            this.filterAppointments_LBL.TabIndex = 0;
            this.filterAppointments_LBL.Text = "Filter Appointments";
            // 
            // PatientName_TextBox
            // 
            this.PatientName_TextBox.AllowDrop = true;
            this.PatientName_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientName_TextBox.Location = new System.Drawing.Point(215, 5);
            this.PatientName_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PatientName_TextBox.Name = "PatientName_TextBox";
            this.PatientName_TextBox.Size = new System.Drawing.Size(200, 20);
            this.PatientName_TextBox.TabIndex = 1;
            this.PatientName_TextBox.Text = "patient name";
            this.PatientName_TextBox.Click += new System.EventHandler(this.PatientName_TextBox_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Location = new System.Drawing.Point(425, 5);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // filterAppointment_button
            // 
            this.filterAppointment_button.Location = new System.Drawing.Point(633, 3);
            this.filterAppointment_button.Name = "filterAppointment_button";
            this.filterAppointment_button.Size = new System.Drawing.Size(75, 23);
            this.filterAppointment_button.TabIndex = 3;
            this.filterAppointment_button.Text = "filter";
            this.filterAppointment_button.UseVisualStyleBackColor = true;
            this.filterAppointment_button.Click += new System.EventHandler(this.FilterAppointment_button_Click);
            // 
            // appointment_DataGridView
            // 
            this.appointment_DataGridView.AllowUserToAddRows = false;
            this.appointment_DataGridView.AllowUserToDeleteRows = false;
            this.appointment_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointment_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointment_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointment_DataGridView.Location = new System.Drawing.Point(10, 74);
            this.appointment_DataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.appointment_DataGridView.Name = "appointment_DataGridView";
            this.appointment_DataGridView.ReadOnly = true;
            this.appointment_DataGridView.Size = new System.Drawing.Size(830, 270);
            this.appointment_DataGridView.TabIndex = 1;
            // 
            // bottomRow_Appointments_TableLayoutPanel
            // 
            this.bottomRow_Appointments_TableLayoutPanel.ColumnCount = 3;
            this.bottomRow_Appointments_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bottomRow_Appointments_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bottomRow_Appointments_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.bottomRow_Appointments_TableLayoutPanel.Controls.Add(this.create_Appointments_Button, 0, 0);
            this.bottomRow_Appointments_TableLayoutPanel.Controls.Add(this.edit_appointments_Button, 1, 0);
            this.bottomRow_Appointments_TableLayoutPanel.Controls.Add(this.reset_Button, 2, 0);
            this.bottomRow_Appointments_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRow_Appointments_TableLayoutPanel.Location = new System.Drawing.Point(3, 357);
            this.bottomRow_Appointments_TableLayoutPanel.Name = "bottomRow_Appointments_TableLayoutPanel";
            this.bottomRow_Appointments_TableLayoutPanel.RowCount = 1;
            this.bottomRow_Appointments_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomRow_Appointments_TableLayoutPanel.Size = new System.Drawing.Size(844, 40);
            this.bottomRow_Appointments_TableLayoutPanel.TabIndex = 2;
            // 
            // create_Appointments_Button
            // 
            this.create_Appointments_Button.Location = new System.Drawing.Point(3, 3);
            this.create_Appointments_Button.Name = "create_Appointments_Button";
            this.create_Appointments_Button.Size = new System.Drawing.Size(116, 23);
            this.create_Appointments_Button.TabIndex = 0;
            this.create_Appointments_Button.Text = "Create Appointment";
            this.create_Appointments_Button.UseVisualStyleBackColor = true;
            // 
            // edit_appointments_Button
            // 
            this.edit_appointments_Button.Location = new System.Drawing.Point(171, 3);
            this.edit_appointments_Button.Name = "edit_appointments_Button";
            this.edit_appointments_Button.Size = new System.Drawing.Size(107, 23);
            this.edit_appointments_Button.TabIndex = 1;
            this.edit_appointments_Button.Text = "Edit Appointment";
            this.edit_appointments_Button.UseVisualStyleBackColor = true;
            // 
            // reset_Button
            // 
            this.reset_Button.Location = new System.Drawing.Point(721, 3);
            this.reset_Button.Margin = new System.Windows.Forms.Padding(385, 3, 3, 3);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(112, 23);
            this.reset_Button.TabIndex = 2;
            this.reset_Button.Text = "Reset Appointments";
            this.reset_Button.UseVisualStyleBackColor = true;
            this.reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // appointments_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.baseAppointment_TableLayoutPanel);
            this.Name = "appointments_UserControl";
            this.Size = new System.Drawing.Size(850, 400);
            this.baseAppointment_TableLayoutPanel.ResumeLayout(false);
            this.topRow_Appointment_tableLOP.ResumeLayout(false);
            this.topRow_Appointment_tableLOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_DataGridView)).EndInit();
            this.bottomRow_Appointments_TableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel baseAppointment_TableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel topRow_Appointment_tableLOP;
        private System.Windows.Forms.Label filterAppointments_LBL;
        private System.Windows.Forms.TextBox PatientName_TextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button filterAppointment_button;
        private System.Windows.Forms.DataGridView appointment_DataGridView;
        private System.Windows.Forms.TableLayoutPanel bottomRow_Appointments_TableLayoutPanel;
        private System.Windows.Forms.Button create_Appointments_Button;
        private System.Windows.Forms.Button edit_appointments_Button;
        private System.Windows.Forms.Button reset_Button;
    }
}

namespace Clinic.View
{
    partial class AddAppointment
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
            this.background_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addAppointment_button = new System.Windows.Forms.Button();
            this.reasonForVisit_Textbox = new System.Windows.Forms.TextBox();
            this.appointment_time_selector = new System.Windows.Forms.DateTimePicker();
            this.Patient_ComboBox = new System.Windows.Forms.ComboBox();
            this.Doctor_ComboBox = new System.Windows.Forms.ComboBox();
            this.doctor_label = new System.Windows.Forms.Label();
            this.patient_label = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.reasonForVisit_LBL = new System.Windows.Forms.Label();
            this.cancelAddAppointment_button = new System.Windows.Forms.Button();
            this.background_TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // background_TableLayoutPanel
            // 
            this.background_TableLayoutPanel.ColumnCount = 2;
            this.background_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.46667F));
            this.background_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.53333F));
            this.background_TableLayoutPanel.Controls.Add(this.cancelAddAppointment_button, 1, 4);
            this.background_TableLayoutPanel.Controls.Add(this.Doctor_ComboBox, 1, 0);
            this.background_TableLayoutPanel.Controls.Add(this.reasonForVisit_Textbox, 1, 3);
            this.background_TableLayoutPanel.Controls.Add(this.appointment_time_selector, 1, 2);
            this.background_TableLayoutPanel.Controls.Add(this.Patient_ComboBox, 1, 1);
            this.background_TableLayoutPanel.Controls.Add(this.doctor_label, 0, 0);
            this.background_TableLayoutPanel.Controls.Add(this.patient_label, 0, 1);
            this.background_TableLayoutPanel.Controls.Add(this.date_lbl, 0, 2);
            this.background_TableLayoutPanel.Controls.Add(this.reasonForVisit_LBL, 0, 3);
            this.background_TableLayoutPanel.Controls.Add(this.addAppointment_button, 0, 4);
            this.background_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.background_TableLayoutPanel.Name = "background_TableLayoutPanel";
            this.background_TableLayoutPanel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.background_TableLayoutPanel.RowCount = 5;
            this.background_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.background_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.background_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.background_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.background_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.background_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.background_TableLayoutPanel.Size = new System.Drawing.Size(395, 450);
            this.background_TableLayoutPanel.TabIndex = 0;
            // 
            // addAppointment_button
            // 
            this.addAppointment_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addAppointment_button.Location = new System.Drawing.Point(13, 419);
            this.addAppointment_button.Name = "addAppointment_button";
            this.addAppointment_button.Size = new System.Drawing.Size(97, 23);
            this.addAppointment_button.TabIndex = 0;
            this.addAppointment_button.Text = "Add Appointment";
            this.addAppointment_button.UseVisualStyleBackColor = true;
            // 
            // reasonForVisit_Textbox
            // 
            this.reasonForVisit_Textbox.Location = new System.Drawing.Point(116, 183);
            this.reasonForVisit_Textbox.Multiline = true;
            this.reasonForVisit_Textbox.Name = "reasonForVisit_Textbox";
            this.reasonForVisit_Textbox.Size = new System.Drawing.Size(266, 199);
            this.reasonForVisit_Textbox.TabIndex = 3;
            // 
            // appointment_time_selector
            // 
            this.appointment_time_selector.Location = new System.Drawing.Point(116, 108);
            this.appointment_time_selector.Name = "appointment_time_selector";
            this.appointment_time_selector.Size = new System.Drawing.Size(200, 20);
            this.appointment_time_selector.TabIndex = 2;
            // 
            // Patient_ComboBox
            // 
            this.Patient_ComboBox.FormattingEnabled = true;
            this.Patient_ComboBox.Location = new System.Drawing.Point(116, 58);
            this.Patient_ComboBox.Name = "Patient_ComboBox";
            this.Patient_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Patient_ComboBox.TabIndex = 1;
            // 
            // Doctor_ComboBox
            // 
            this.Doctor_ComboBox.FormattingEnabled = true;
            this.Doctor_ComboBox.Location = new System.Drawing.Point(116, 8);
            this.Doctor_ComboBox.Name = "Doctor_ComboBox";
            this.Doctor_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Doctor_ComboBox.TabIndex = 0;
            // 
            // doctor_label
            // 
            this.doctor_label.AutoSize = true;
            this.doctor_label.Location = new System.Drawing.Point(13, 5);
            this.doctor_label.Name = "doctor_label";
            this.doctor_label.Size = new System.Drawing.Size(39, 13);
            this.doctor_label.TabIndex = 5;
            this.doctor_label.Text = "Doctor";
            // 
            // patient_label
            // 
            this.patient_label.AutoSize = true;
            this.patient_label.Location = new System.Drawing.Point(13, 55);
            this.patient_label.Name = "patient_label";
            this.patient_label.Size = new System.Drawing.Size(40, 13);
            this.patient_label.TabIndex = 6;
            this.patient_label.Text = "Patient";
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(13, 105);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(30, 13);
            this.date_lbl.TabIndex = 7;
            this.date_lbl.Text = "Date";
            // 
            // reasonForVisit_LBL
            // 
            this.reasonForVisit_LBL.AutoSize = true;
            this.reasonForVisit_LBL.Location = new System.Drawing.Point(13, 180);
            this.reasonForVisit_LBL.Name = "reasonForVisit_LBL";
            this.reasonForVisit_LBL.Size = new System.Drawing.Size(84, 13);
            this.reasonForVisit_LBL.TabIndex = 8;
            this.reasonForVisit_LBL.Text = "Reason For Visit";
            // 
            // cancelAddAppointment_button
            // 
            this.cancelAddAppointment_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelAddAppointment_button.Location = new System.Drawing.Point(211, 419);
            this.cancelAddAppointment_button.Name = "cancelAddAppointment_button";
            this.cancelAddAppointment_button.Size = new System.Drawing.Size(75, 23);
            this.cancelAddAppointment_button.TabIndex = 9;
            this.cancelAddAppointment_button.Text = "Cancel";
            this.cancelAddAppointment_button.UseVisualStyleBackColor = true;
            this.cancelAddAppointment_button.Click += new System.EventHandler(this.cancelAddAppointment_button_Click);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.background_TableLayoutPanel);
            this.Name = "AddAppointment";
            this.Text = "Add Appointment";
            this.background_TableLayoutPanel.ResumeLayout(false);
            this.background_TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel background_TableLayoutPanel;
        private System.Windows.Forms.Button cancelAddAppointment_button;
        private System.Windows.Forms.ComboBox Doctor_ComboBox;
        private System.Windows.Forms.TextBox reasonForVisit_Textbox;
        private System.Windows.Forms.DateTimePicker appointment_time_selector;
        private System.Windows.Forms.ComboBox Patient_ComboBox;
        private System.Windows.Forms.Label doctor_label;
        private System.Windows.Forms.Label patient_label;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label reasonForVisit_LBL;
        private System.Windows.Forms.Button addAppointment_button;
    }
}
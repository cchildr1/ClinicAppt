namespace Clinic.View
{
    partial class EditPatient
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
            this.reset_button = new System.Windows.Forms.Button();
            this.firstname_label = new System.Windows.Forms.Label();
            this.lastname_lbl = new System.Windows.Forms.Label();
            this.dateOfBirth_LBL = new System.Windows.Forms.Label();
            this.SSN_Label = new System.Windows.Forms.Label();
            this.gender_LBL = new System.Windows.Forms.Label();
            this.streetAddress_LBL = new System.Windows.Forms.Label();
            this.phone_number_LBL = new System.Windows.Forms.Label();
            this.gender_ComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfBirth_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneNumber_textbox = new System.Windows.Forms.TextBox();
            this.zipcode_textbox = new System.Windows.Forms.TextBox();
            this.ssn_textbox = new System.Windows.Forms.TextBox();
            this.lastname_textbox = new System.Windows.Forms.TextBox();
            this.firstname_textbox = new System.Windows.Forms.TextBox();
            this.streetAddress_textbox = new System.Windows.Forms.TextBox();
            this.editPatient_button = new System.Windows.Forms.Button();
            this.errorMessage_lbl = new System.Windows.Forms.Label();
            this.cancel_reset_buttons_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cancel_button = new System.Windows.Forms.Button();
            this.AddPatientBase_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.zipcode_lbl = new System.Windows.Forms.Label();
            this.MakePatientInactive_button = new System.Windows.Forms.Button();
            this.cancel_reset_buttons_tableLayoutPanel.SuspendLayout();
            this.AddPatientBase_TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(3, 3);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 22);
            this.reset_button.TabIndex = 12;
            this.reset_button.Text = "Reset Patient";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // firstname_label
            // 
            this.firstname_label.AutoSize = true;
            this.firstname_label.Location = new System.Drawing.Point(5, 5);
            this.firstname_label.Margin = new System.Windows.Forms.Padding(5);
            this.firstname_label.Name = "firstname_label";
            this.firstname_label.Size = new System.Drawing.Size(78, 13);
            this.firstname_label.TabIndex = 0;
            this.firstname_label.Text = "Edit First Name";
            // 
            // lastname_lbl
            // 
            this.lastname_lbl.AutoSize = true;
            this.lastname_lbl.Location = new System.Drawing.Point(5, 35);
            this.lastname_lbl.Margin = new System.Windows.Forms.Padding(5);
            this.lastname_lbl.Name = "lastname_lbl";
            this.lastname_lbl.Size = new System.Drawing.Size(79, 13);
            this.lastname_lbl.TabIndex = 1;
            this.lastname_lbl.Text = "Edit Last Name";
            // 
            // dateOfBirth_LBL
            // 
            this.dateOfBirth_LBL.AutoSize = true;
            this.dateOfBirth_LBL.Location = new System.Drawing.Point(5, 61);
            this.dateOfBirth_LBL.Margin = new System.Windows.Forms.Padding(5);
            this.dateOfBirth_LBL.Name = "dateOfBirth_LBL";
            this.dateOfBirth_LBL.Size = new System.Drawing.Size(89, 13);
            this.dateOfBirth_LBL.TabIndex = 2;
            this.dateOfBirth_LBL.Text = "Edit Date Of Birth";
            // 
            // SSN_Label
            // 
            this.SSN_Label.AutoSize = true;
            this.SSN_Label.Location = new System.Drawing.Point(5, 87);
            this.SSN_Label.Margin = new System.Windows.Forms.Padding(5);
            this.SSN_Label.Name = "SSN_Label";
            this.SSN_Label.Size = new System.Drawing.Size(50, 13);
            this.SSN_Label.TabIndex = 3;
            this.SSN_Label.Text = "Edit SSN";
            // 
            // gender_LBL
            // 
            this.gender_LBL.AutoSize = true;
            this.gender_LBL.Location = new System.Drawing.Point(5, 119);
            this.gender_LBL.Margin = new System.Windows.Forms.Padding(5);
            this.gender_LBL.Name = "gender_LBL";
            this.gender_LBL.Size = new System.Drawing.Size(63, 13);
            this.gender_LBL.TabIndex = 4;
            this.gender_LBL.Text = "Edit Gender";
            // 
            // streetAddress_LBL
            // 
            this.streetAddress_LBL.AutoSize = true;
            this.streetAddress_LBL.Location = new System.Drawing.Point(5, 154);
            this.streetAddress_LBL.Margin = new System.Windows.Forms.Padding(5);
            this.streetAddress_LBL.Name = "streetAddress_LBL";
            this.streetAddress_LBL.Size = new System.Drawing.Size(97, 13);
            this.streetAddress_LBL.TabIndex = 5;
            this.streetAddress_LBL.Text = "Edit Street Address";
            // 
            // phone_number_LBL
            // 
            this.phone_number_LBL.AutoSize = true;
            this.phone_number_LBL.Location = new System.Drawing.Point(5, 298);
            this.phone_number_LBL.Margin = new System.Windows.Forms.Padding(5);
            this.phone_number_LBL.Name = "phone_number_LBL";
            this.phone_number_LBL.Size = new System.Drawing.Size(59, 13);
            this.phone_number_LBL.TabIndex = 6;
            this.phone_number_LBL.Text = "Edit Phone";
            // 
            // gender_ComboBox
            // 
            this.gender_ComboBox.FormattingEnabled = true;
            this.gender_ComboBox.Location = new System.Drawing.Point(200, 117);
            this.gender_ComboBox.Name = "gender_ComboBox";
            this.gender_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.gender_ComboBox.TabIndex = 5;
            this.gender_ComboBox.SelectedIndexChanged += new System.EventHandler(this.ValueOfPatientChanged);
            // 
            // dateOfBirth_DateTimePicker
            // 
            this.dateOfBirth_DateTimePicker.AllowDrop = true;
            this.dateOfBirth_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirth_DateTimePicker.Location = new System.Drawing.Point(200, 59);
            this.dateOfBirth_DateTimePicker.Name = "dateOfBirth_DateTimePicker";
            this.dateOfBirth_DateTimePicker.Size = new System.Drawing.Size(192, 20);
            this.dateOfBirth_DateTimePicker.TabIndex = 9;
            this.dateOfBirth_DateTimePicker.ValueChanged += new System.EventHandler(this.ValueOfPatientChanged);
            // 
            // phoneNumber_textbox
            // 
            this.phoneNumber_textbox.Location = new System.Drawing.Point(200, 296);
            this.phoneNumber_textbox.MaxLength = 15;
            this.phoneNumber_textbox.Name = "phoneNumber_textbox";
            this.phoneNumber_textbox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumber_textbox.TabIndex = 7;
            this.phoneNumber_textbox.TextChanged += new System.EventHandler(this.ValueOfPatientChanged);
            // 
            // zipcode_textbox
            // 
            this.zipcode_textbox.Location = new System.Drawing.Point(200, 330);
            this.zipcode_textbox.Name = "zipcode_textbox";
            this.zipcode_textbox.Size = new System.Drawing.Size(100, 20);
            this.zipcode_textbox.TabIndex = 8;
            this.zipcode_textbox.Validated += new System.EventHandler(this.ValueOfPatientChanged);
            // 
            // ssn_textbox
            // 
            this.ssn_textbox.Location = new System.Drawing.Point(200, 85);
            this.ssn_textbox.Name = "ssn_textbox";
            this.ssn_textbox.Size = new System.Drawing.Size(100, 20);
            this.ssn_textbox.TabIndex = 4;
            this.ssn_textbox.TextChanged += new System.EventHandler(this.ValueOfPatientChanged);
            // 
            // lastname_textbox
            // 
            this.lastname_textbox.Location = new System.Drawing.Point(200, 33);
            this.lastname_textbox.Name = "lastname_textbox";
            this.lastname_textbox.Size = new System.Drawing.Size(100, 20);
            this.lastname_textbox.TabIndex = 2;
            this.lastname_textbox.TextChanged += new System.EventHandler(this.ValueOfPatientChanged);
            // 
            // firstname_textbox
            // 
            this.firstname_textbox.Location = new System.Drawing.Point(200, 3);
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.Size = new System.Drawing.Size(100, 20);
            this.firstname_textbox.TabIndex = 1;
            this.firstname_textbox.TextChanged += new System.EventHandler(this.ValueOfPatientChanged);
            // 
            // streetAddress_textbox
            // 
            this.streetAddress_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streetAddress_textbox.Location = new System.Drawing.Point(200, 152);
            this.streetAddress_textbox.Multiline = true;
            this.streetAddress_textbox.Name = "streetAddress_textbox";
            this.streetAddress_textbox.Size = new System.Drawing.Size(192, 138);
            this.streetAddress_textbox.TabIndex = 6;
            this.streetAddress_textbox.TextChanged += new System.EventHandler(this.ValueOfPatientChanged);
            // 
            // editPatient_button
            // 
            this.editPatient_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.editPatient_button.Location = new System.Drawing.Point(3, 611);
            this.editPatient_button.Name = "editPatient_button";
            this.editPatient_button.Size = new System.Drawing.Size(75, 23);
            this.editPatient_button.TabIndex = 10;
            this.editPatient_button.Text = "Edit Patient";
            this.editPatient_button.UseVisualStyleBackColor = true;
            this.editPatient_button.Click += new System.EventHandler(this.editPatient_button_Click);
            // 
            // errorMessage_lbl
            // 
            this.errorMessage_lbl.AutoSize = true;
            this.AddPatientBase_TableLayoutPanel.SetColumnSpan(this.errorMessage_lbl, 2);
            this.errorMessage_lbl.Location = new System.Drawing.Point(3, 399);
            this.errorMessage_lbl.Name = "errorMessage_lbl";
            this.errorMessage_lbl.Size = new System.Drawing.Size(0, 13);
            this.errorMessage_lbl.TabIndex = 12;
            // 
            // cancel_reset_buttons_tableLayoutPanel
            // 
            this.cancel_reset_buttons_tableLayoutPanel.ColumnCount = 2;
            this.cancel_reset_buttons_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cancel_reset_buttons_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cancel_reset_buttons_tableLayoutPanel.Controls.Add(this.cancel_button, 1, 0);
            this.cancel_reset_buttons_tableLayoutPanel.Controls.Add(this.reset_button, 0, 0);
            this.cancel_reset_buttons_tableLayoutPanel.Location = new System.Drawing.Point(200, 611);
            this.cancel_reset_buttons_tableLayoutPanel.Name = "cancel_reset_buttons_tableLayoutPanel";
            this.cancel_reset_buttons_tableLayoutPanel.RowCount = 1;
            this.cancel_reset_buttons_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cancel_reset_buttons_tableLayoutPanel.Size = new System.Drawing.Size(192, 28);
            this.cancel_reset_buttons_tableLayoutPanel.TabIndex = 13;
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(99, 3);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 22);
            this.cancel_button.TabIndex = 11;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // AddPatientBase_TableLayoutPanel
            // 
            this.AddPatientBase_TableLayoutPanel.ColumnCount = 2;
            this.AddPatientBase_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddPatientBase_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.firstname_label, 0, 0);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.dateOfBirth_LBL, 0, 2);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.SSN_Label, 0, 3);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.gender_LBL, 0, 4);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.streetAddress_LBL, 0, 5);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.phone_number_LBL, 0, 6);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.zipcode_lbl, 0, 7);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.gender_ComboBox, 1, 4);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.dateOfBirth_DateTimePicker, 1, 2);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.phoneNumber_textbox, 1, 6);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.zipcode_textbox, 1, 7);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.ssn_textbox, 1, 3);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.lastname_textbox, 1, 1);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.firstname_textbox, 1, 0);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.streetAddress_textbox, 1, 5);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.lastname_lbl, 0, 1);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.editPatient_button, 0, 11);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.cancel_reset_buttons_tableLayoutPanel, 1, 11);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.errorMessage_lbl, 0, 10);
            this.AddPatientBase_TableLayoutPanel.Controls.Add(this.MakePatientInactive_button, 0, 9);
            this.AddPatientBase_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPatientBase_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AddPatientBase_TableLayoutPanel.Name = "AddPatientBase_TableLayoutPanel";
            this.AddPatientBase_TableLayoutPanel.RowCount = 12;
            this.AddPatientBase_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.29493F));
            this.AddPatientBase_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.373272F));
            this.AddPatientBase_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.AddPatientBase_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.791209F));
            this.AddPatientBase_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.615385F));
            this.AddPatientBase_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.56044F));
            this.AddPatientBase_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.366391F));
            this.AddPatientBase_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.988981F));
            this.AddPatientBase_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.203857F));
            this.AddPatientBase_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.AddPatientBase_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.AddPatientBase_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.AddPatientBase_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AddPatientBase_TableLayoutPanel.Size = new System.Drawing.Size(395, 642);
            this.AddPatientBase_TableLayoutPanel.TabIndex = 1;
            // 
            // zipcode_lbl
            // 
            this.zipcode_lbl.AutoSize = true;
            this.zipcode_lbl.Location = new System.Drawing.Point(5, 332);
            this.zipcode_lbl.Margin = new System.Windows.Forms.Padding(5);
            this.zipcode_lbl.Name = "zipcode_lbl";
            this.zipcode_lbl.Size = new System.Drawing.Size(67, 13);
            this.zipcode_lbl.TabIndex = 7;
            this.zipcode_lbl.Text = "Edit Zipcode";
            // 
            // MakePatientInactive_button
            // 
            this.MakePatientInactive_button.Location = new System.Drawing.Point(3, 367);
            this.MakePatientInactive_button.Name = "MakePatientInactive_button";
            this.MakePatientInactive_button.Size = new System.Drawing.Size(99, 23);
            this.MakePatientInactive_button.TabIndex = 14;
            this.MakePatientInactive_button.Text = "Deactive Patient";
            this.MakePatientInactive_button.UseVisualStyleBackColor = true;
            this.MakePatientInactive_button.Click += new System.EventHandler(this.MakePatientInactive_button_Click);
            // 
            // EditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 642);
            this.Controls.Add(this.AddPatientBase_TableLayoutPanel);
            this.Name = "EditPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditPatient";
            this.cancel_reset_buttons_tableLayoutPanel.ResumeLayout(false);
            this.AddPatientBase_TableLayoutPanel.ResumeLayout(false);
            this.AddPatientBase_TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label firstname_label;
        private System.Windows.Forms.Label lastname_lbl;
        private System.Windows.Forms.Label dateOfBirth_LBL;
        private System.Windows.Forms.Label SSN_Label;
        private System.Windows.Forms.Label gender_LBL;
        private System.Windows.Forms.Label streetAddress_LBL;
        private System.Windows.Forms.Label phone_number_LBL;
        private System.Windows.Forms.ComboBox gender_ComboBox;
        private System.Windows.Forms.DateTimePicker dateOfBirth_DateTimePicker;
        private System.Windows.Forms.TextBox phoneNumber_textbox;
        private System.Windows.Forms.TextBox zipcode_textbox;
        private System.Windows.Forms.TextBox ssn_textbox;
        private System.Windows.Forms.TextBox lastname_textbox;
        private System.Windows.Forms.TextBox firstname_textbox;
        private System.Windows.Forms.TextBox streetAddress_textbox;
        private System.Windows.Forms.Button editPatient_button;
        private System.Windows.Forms.Label errorMessage_lbl;
        private System.Windows.Forms.TableLayoutPanel AddPatientBase_TableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel cancel_reset_buttons_tableLayoutPanel;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label zipcode_lbl;
        private System.Windows.Forms.Button MakePatientInactive_button;
    }
}
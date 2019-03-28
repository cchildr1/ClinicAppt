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
            this.components = new System.ComponentModel.Container();
            this.baseAppointment_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.topRow_Appointment_tableLOP = new System.Windows.Forms.TableLayoutPanel();
            this.filterAppointments_LBL = new System.Windows.Forms.Label();
            this.bottomRow_Appointments_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.create_Appointments_Button = new System.Windows.Forms.Button();
            this.reset_Button = new System.Windows.Forms.Button();
            this.appointments_datagridview = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseAppointment_TableLayoutPanel.SuspendLayout();
            this.topRow_Appointment_tableLOP.SuspendLayout();
            this.bottomRow_Appointments_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baseAppointment_TableLayoutPanel
            // 
            this.baseAppointment_TableLayoutPanel.ColumnCount = 1;
            this.baseAppointment_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.baseAppointment_TableLayoutPanel.Controls.Add(this.topRow_Appointment_tableLOP, 0, 0);
            this.baseAppointment_TableLayoutPanel.Controls.Add(this.bottomRow_Appointments_TableLayoutPanel, 0, 2);
            this.baseAppointment_TableLayoutPanel.Controls.Add(this.appointments_datagridview, 0, 1);
            this.baseAppointment_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseAppointment_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.baseAppointment_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.baseAppointment_TableLayoutPanel.Name = "baseAppointment_TableLayoutPanel";
            this.baseAppointment_TableLayoutPanel.RowCount = 3;
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2058F));
            this.baseAppointment_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.7942F));
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
            this.topRow_Appointment_tableLOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRow_Appointment_tableLOP.Location = new System.Drawing.Point(5, 5);
            this.topRow_Appointment_tableLOP.Margin = new System.Windows.Forms.Padding(5);
            this.topRow_Appointment_tableLOP.Name = "topRow_Appointment_tableLOP";
            this.topRow_Appointment_tableLOP.RowCount = 2;
            this.topRow_Appointment_tableLOP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topRow_Appointment_tableLOP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.filterAppointments_LBL.Size = new System.Drawing.Size(118, 30);
            this.filterAppointments_LBL.TabIndex = 0;
            this.filterAppointments_LBL.Text = "Appointments";
            // 
            // bottomRow_Appointments_TableLayoutPanel
            // 
            this.bottomRow_Appointments_TableLayoutPanel.ColumnCount = 3;
            this.bottomRow_Appointments_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bottomRow_Appointments_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bottomRow_Appointments_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.bottomRow_Appointments_TableLayoutPanel.Controls.Add(this.create_Appointments_Button, 0, 0);
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
            this.create_Appointments_Button.Click += new System.EventHandler(this.Create_Appointments_Button_Click);
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
            // appointments_datagridview
            // 
            this.appointments_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointments_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointments_datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointments_datagridview.Location = new System.Drawing.Point(3, 67);
            this.appointments_datagridview.Name = "appointments_datagridview";
            this.appointments_datagridview.Size = new System.Drawing.Size(844, 284);
            this.appointments_datagridview.TabIndex = 3;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(Clinic.Model.Appointment);
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
            this.bottomRow_Appointments_TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointments_datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.TableLayoutPanel baseAppointment_TableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel topRow_Appointment_tableLOP;
        private System.Windows.Forms.Label filterAppointments_LBL;
        private System.Windows.Forms.TableLayoutPanel bottomRow_Appointments_TableLayoutPanel;
        private System.Windows.Forms.Button create_Appointments_Button;
        private System.Windows.Forms.Button reset_Button;
        private System.Windows.Forms.DataGridView appointments_datagridview;
    }
}

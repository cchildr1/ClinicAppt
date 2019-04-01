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
            this.filterAppointments_LBL = new System.Windows.Forms.Label();
            this.create_Appointments_Button = new System.Windows.Forms.Button();
            this.appointments_datagridview = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // create_Appointments_Button
            // 
            this.create_Appointments_Button.Location = new System.Drawing.Point(3, 374);
            this.create_Appointments_Button.Name = "create_Appointments_Button";
            this.create_Appointments_Button.Size = new System.Drawing.Size(116, 23);
            this.create_Appointments_Button.TabIndex = 0;
            this.create_Appointments_Button.Text = "Create Appointment";
            this.create_Appointments_Button.UseVisualStyleBackColor = true;
            this.create_Appointments_Button.Click += new System.EventHandler(this.Create_Appointments_Button_Click);
            // 
            // appointments_datagridview
            // 
            this.appointments_datagridview.AllowUserToAddRows = false;
            this.appointments_datagridview.AllowUserToDeleteRows = false;
            this.appointments_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointments_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.appointments_datagridview, 4);
            this.appointments_datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointments_datagridview.Location = new System.Drawing.Point(3, 33);
            this.appointments_datagridview.Name = "appointments_datagridview";
            this.appointments_datagridview.ReadOnly = true;
            this.appointments_datagridview.Size = new System.Drawing.Size(844, 335);
            this.appointments_datagridview.TabIndex = 3;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(Clinic.Model.Appointment);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.create_Appointments_Button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.filterAppointments_LBL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.appointments_datagridview, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 400);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // appointments_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "appointments_UserControl";
            this.Size = new System.Drawing.Size(850, 400);
            ((System.ComponentModel.ISupportInitialize)(this.appointments_datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.Label filterAppointments_LBL;
        private System.Windows.Forms.Button create_Appointments_Button;
        private System.Windows.Forms.DataGridView appointments_datagridview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

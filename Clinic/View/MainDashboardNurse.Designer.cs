namespace Clinic.View
{
    partial class MainDashboardNurse
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
            this.mainDashBoardNurse_TabControl = new System.Windows.Forms.TabControl();
            this.appointments_tabPage = new System.Windows.Forms.TabPage();
            this.appointments_UserControl1 = new Clinic.UserControls.appointments_UserControl();
            this.patients_tabpage = new System.Windows.Forms.TabPage();
            this.patient_UserControl1 = new Clinic.UserControls.patient_UserControl();
            this.visitTab = new System.Windows.Forms.TabPage();
            this.visits_UserControl1 = new Clinic.UserControls.visits_UserControl();
            this.WelcomeLBL = new System.Windows.Forms.Label();
            this.LogOut_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainDashBoardNurse_TabControl.SuspendLayout();
            this.appointments_tabPage.SuspendLayout();
            this.patients_tabpage.SuspendLayout();
            this.visitTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDashBoardNurse_TabControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.mainDashBoardNurse_TabControl, 2);
            this.mainDashBoardNurse_TabControl.Controls.Add(this.patients_tabpage);
            this.mainDashBoardNurse_TabControl.Controls.Add(this.appointments_tabPage);
            this.mainDashBoardNurse_TabControl.Controls.Add(this.visitTab);
            this.mainDashBoardNurse_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDashBoardNurse_TabControl.Location = new System.Drawing.Point(3, 32);
            this.mainDashBoardNurse_TabControl.Name = "mainDashBoardNurse_TabControl";
            this.mainDashBoardNurse_TabControl.SelectedIndex = 0;
            this.mainDashBoardNurse_TabControl.Size = new System.Drawing.Size(1132, 543);
            this.mainDashBoardNurse_TabControl.TabIndex = 3;
            // 
            // appointments_tabPage
            // 
            this.appointments_tabPage.Controls.Add(this.appointments_UserControl1);
            this.appointments_tabPage.Location = new System.Drawing.Point(4, 22);
            this.appointments_tabPage.Name = "appointments_tabPage";
            this.appointments_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.appointments_tabPage.Size = new System.Drawing.Size(1124, 517);
            this.appointments_tabPage.TabIndex = 0;
            this.appointments_tabPage.Text = "Appointments";
            this.appointments_tabPage.UseVisualStyleBackColor = true;
            // 
            // appointments_UserControl1
            // 
            this.appointments_UserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointments_UserControl1.Location = new System.Drawing.Point(3, 3);
            this.appointments_UserControl1.Name = "appointments_UserControl1";
            this.appointments_UserControl1.Size = new System.Drawing.Size(1118, 511);
            this.appointments_UserControl1.TabIndex = 0;
            // 
            // patients_tabpage
            // 
            this.patients_tabpage.Controls.Add(this.patient_UserControl1);
            this.patients_tabpage.Location = new System.Drawing.Point(4, 22);
            this.patients_tabpage.Name = "patients_tabpage";
            this.patients_tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.patients_tabpage.Size = new System.Drawing.Size(1124, 517);
            this.patients_tabpage.TabIndex = 1;
            this.patients_tabpage.Text = "Patients";
            this.patients_tabpage.UseVisualStyleBackColor = true;
            // 
            // patient_UserControl1
            // 
            this.patient_UserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patient_UserControl1.Location = new System.Drawing.Point(3, 3);
            this.patient_UserControl1.Name = "patient_UserControl1";
            this.patient_UserControl1.Size = new System.Drawing.Size(1118, 511);
            this.patient_UserControl1.TabIndex = 0;
            // 
            // visitTab
            // 
            this.visitTab.Controls.Add(this.visits_UserControl1);
            this.visitTab.Location = new System.Drawing.Point(4, 22);
            this.visitTab.Name = "visitTab";
            this.visitTab.Padding = new System.Windows.Forms.Padding(3);
            this.visitTab.Size = new System.Drawing.Size(1124, 517);
            this.visitTab.TabIndex = 2;
            this.visitTab.Text = "Visits";
            this.visitTab.UseVisualStyleBackColor = true;
            // 
            // visits_UserControl1
            // 
            this.visits_UserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visits_UserControl1.Location = new System.Drawing.Point(3, 3);
            this.visits_UserControl1.Name = "visits_UserControl1";
            this.visits_UserControl1.Size = new System.Drawing.Size(1118, 511);
            this.visits_UserControl1.TabIndex = 0;
            // 
            // WelcomeLBL
            // 
            this.WelcomeLBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WelcomeLBL.AutoSize = true;
            this.WelcomeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLBL.Location = new System.Drawing.Point(3, 0);
            this.WelcomeLBL.Name = "WelcomeLBL";
            this.WelcomeLBL.Size = new System.Drawing.Size(75, 29);
            this.WelcomeLBL.TabIndex = 1;
            this.WelcomeLBL.Text = "Welcome";
            this.WelcomeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOut_Button.Location = new System.Drawing.Point(1013, 3);
            this.LogOut_Button.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.Size = new System.Drawing.Size(75, 23);
            this.LogOut_Button.TabIndex = 4;
            this.LogOut_Button.Text = "Log Out";
            this.LogOut_Button.UseVisualStyleBackColor = true;
            this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mainDashBoardNurse_TabControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LogOut_Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WelcomeLBL, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1138, 578);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // MainDashboardNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainDashboardNurse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic";
            this.mainDashBoardNurse_TabControl.ResumeLayout(false);
            this.appointments_tabPage.ResumeLayout(false);
            this.patients_tabpage.ResumeLayout(false);
            this.visitTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainDashBoardNurse_TabControl;
        private System.Windows.Forms.TabPage appointments_tabPage;
        private System.Windows.Forms.TabPage patients_tabpage;
        private System.Windows.Forms.Label WelcomeLBL;
        private System.Windows.Forms.Button LogOut_Button;
        private UserControls.appointments_UserControl appointments_UserControl1;
        private UserControls.patient_UserControl patient_UserControl1;
        private System.Windows.Forms.TabPage visitTab;
        private UserControls.visits_UserControl visits_UserControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
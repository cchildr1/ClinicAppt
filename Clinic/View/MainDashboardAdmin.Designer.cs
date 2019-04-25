namespace Clinic.View
{
    partial class MainDashboardAdmin
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportData = new Clinic.Reports.ReportData();
            this.mainDashBoardNurse_TabControl = new System.Windows.Forms.TabControl();
            this.nurse_tabpage = new System.Windows.Forms.TabPage();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.btGenerateReport = new System.Windows.Forms.Button();
            this.WelcomeLBL = new System.Windows.Forms.Label();
            this.LogOut_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sp_mostPerformedTestDuringDatesTableAdapter = new Clinic.Reports.ReportDataTableAdapters.sp_mostPerformedTestDuringDatesTableAdapter();
            this.admin_NurseControl_userControl1 = new Clinic.UserControls.admin_NurseControl_userControl();
            this.sp_mostPerformedTestDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportData)).BeginInit();
            this.mainDashBoardNurse_TabControl.SuspendLayout();
            this.nurse_tabpage.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_mostPerformedTestDuringDatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportData
            // 
            this.reportData.DataSetName = "ReportData";
            this.reportData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainDashBoardNurse_TabControl
            // 
            this.mainDashBoardNurse_TabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.tableLayoutPanel1.SetColumnSpan(this.mainDashBoardNurse_TabControl, 2);
            this.mainDashBoardNurse_TabControl.Controls.Add(this.nurse_tabpage);
            this.mainDashBoardNurse_TabControl.Controls.Add(this.tabPageReport);
            this.mainDashBoardNurse_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDashBoardNurse_TabControl.Location = new System.Drawing.Point(3, 32);
            this.mainDashBoardNurse_TabControl.Name = "mainDashBoardNurse_TabControl";
            this.mainDashBoardNurse_TabControl.SelectedIndex = 0;
            this.mainDashBoardNurse_TabControl.Size = new System.Drawing.Size(1061, 415);
            this.mainDashBoardNurse_TabControl.TabIndex = 3;
            // 
            // nurse_tabpage
            // 
            this.nurse_tabpage.Controls.Add(this.admin_NurseControl_userControl1);
            this.nurse_tabpage.Location = new System.Drawing.Point(4, 22);
            this.nurse_tabpage.Name = "nurse_tabpage";
            this.nurse_tabpage.Size = new System.Drawing.Size(1053, 389);
            this.nurse_tabpage.TabIndex = 0;
            this.nurse_tabpage.Text = "Nurses";
            this.nurse_tabpage.UseVisualStyleBackColor = true;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.tableLayoutPanel2);
            this.tabPageReport.Location = new System.Drawing.Point(4, 22);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(1053, 389);
            this.tabPageReport.TabIndex = 1;
            this.tabPageReport.Text = "Reports";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.DTPStartDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.reportViewer1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.DTPEndDate, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btGenerateReport, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1047, 383);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DTPStartDate
            // 
            this.DTPStartDate.Checked = false;
            this.DTPStartDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTPStartDate.Location = new System.Drawing.Point(235, 3);
            this.DTPStartDate.Name = "DTPStartDate";
            this.DTPStartDate.ShowCheckBox = true;
            this.DTPStartDate.Size = new System.Drawing.Size(200, 20);
            this.DTPStartDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reportViewer1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.reportViewer1, 4);
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 12;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_mostPerformedTestDuringDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Clinic.Reports.report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1041, 322);
            this.reportViewer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(467, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DTPEndDate
            // 
            this.DTPEndDate.Checked = false;
            this.DTPEndDate.Location = new System.Drawing.Point(699, 3);
            this.DTPEndDate.Name = "DTPEndDate";
            this.DTPEndDate.ShowCheckBox = true;
            this.DTPEndDate.Size = new System.Drawing.Size(200, 20);
            this.DTPEndDate.TabIndex = 3;
            // 
            // btGenerateReport
            // 
            this.btGenerateReport.Location = new System.Drawing.Point(699, 29);
            this.btGenerateReport.Name = "btGenerateReport";
            this.btGenerateReport.Size = new System.Drawing.Size(75, 23);
            this.btGenerateReport.TabIndex = 4;
            this.btGenerateReport.Text = "Generate";
            this.btGenerateReport.UseVisualStyleBackColor = true;
            this.btGenerateReport.Click += new System.EventHandler(this.btGenerateReport_Click);
            // 
            // WelcomeLBL
            // 
            this.WelcomeLBL.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
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
            this.LogOut_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.LogOut_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOut_Button.Location = new System.Drawing.Point(942, 3);
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
            this.tableLayoutPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 450);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // sp_mostPerformedTestDuringDatesTableAdapter
            // 
            this.sp_mostPerformedTestDuringDatesTableAdapter.ClearBeforeFill = true;
            // 
            // admin_NurseControl_userControl1
            // 
            this.admin_NurseControl_userControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_NurseControl_userControl1.Location = new System.Drawing.Point(0, 0);
            this.admin_NurseControl_userControl1.Name = "admin_NurseControl_userControl1";
            this.admin_NurseControl_userControl1.Size = new System.Drawing.Size(1053, 389);
            this.admin_NurseControl_userControl1.TabIndex = 0;
            // 
            // sp_mostPerformedTestDuringDatesBindingSource
            // 
            this.sp_mostPerformedTestDuringDatesBindingSource.DataMember = "sp_mostPerformedTestDuringDates";
            this.sp_mostPerformedTestDuringDatesBindingSource.DataSource = this.reportData;
            // 
            // MainDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainDashboardAdmin";
            this.Text = "MainDashboardAdmin";
            this.Load += new System.EventHandler(this.MainDashboardAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportData)).EndInit();
            this.mainDashBoardNurse_TabControl.ResumeLayout(false);
            this.nurse_tabpage.ResumeLayout(false);
            this.tabPageReport.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_mostPerformedTestDuringDatesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainDashBoardNurse_TabControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button LogOut_Button;
        private System.Windows.Forms.Label WelcomeLBL;
        private System.Windows.Forms.TabPage nurse_tabpage;
        private UserControls.admin_NurseControl_userControl admin_NurseControl_userControl1;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reports.ReportData reportData;
        private System.Windows.Forms.DateTimePicker DTPStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPEndDate;
        private System.Windows.Forms.Button btGenerateReport;
        private Reports.ReportDataTableAdapters.sp_mostPerformedTestDuringDatesTableAdapter sp_mostPerformedTestDuringDatesTableAdapter;
        private System.Windows.Forms.BindingSource sp_mostPerformedTestDuringDatesBindingSource;
    }
}
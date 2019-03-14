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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WelcomeLBL = new System.Windows.Forms.Label();
            this.LogOut_Button = new System.Windows.Forms.Button();
            this.appointments_UserControl1 = new Clinic.UserControls.appointments_UserControl();
            this.mainDashBoardNurse_TabControl.SuspendLayout();
            this.appointments_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDashBoardNurse_TabControl
            // 
            this.mainDashBoardNurse_TabControl.Controls.Add(this.appointments_tabPage);
            this.mainDashBoardNurse_TabControl.Controls.Add(this.tabPage2);
            this.mainDashBoardNurse_TabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainDashBoardNurse_TabControl.Location = new System.Drawing.Point(0, 51);
            this.mainDashBoardNurse_TabControl.Name = "mainDashBoardNurse_TabControl";
            this.mainDashBoardNurse_TabControl.SelectedIndex = 0;
            this.mainDashBoardNurse_TabControl.Size = new System.Drawing.Size(984, 410);
            this.mainDashBoardNurse_TabControl.TabIndex = 0;
            // 
            // appointments_tabPage
            // 
            this.appointments_tabPage.Controls.Add(this.appointments_UserControl1);
            this.appointments_tabPage.Location = new System.Drawing.Point(4, 22);
            this.appointments_tabPage.Name = "appointments_tabPage";
            this.appointments_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.appointments_tabPage.Size = new System.Drawing.Size(976, 384);
            this.appointments_tabPage.TabIndex = 0;
            this.appointments_tabPage.Text = "Appointments";
            this.appointments_tabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WelcomeLBL
            // 
            this.WelcomeLBL.AutoSize = true;
            this.WelcomeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLBL.Location = new System.Drawing.Point(12, 9);
            this.WelcomeLBL.Name = "WelcomeLBL";
            this.WelcomeLBL.Size = new System.Drawing.Size(75, 20);
            this.WelcomeLBL.TabIndex = 1;
            this.WelcomeLBL.Text = "Welcome";
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.Location = new System.Drawing.Point(897, 6);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.Size = new System.Drawing.Size(75, 23);
            this.LogOut_Button.TabIndex = 2;
            this.LogOut_Button.Text = "Log Out";
            this.LogOut_Button.UseVisualStyleBackColor = true;
            this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click);
            // 
            // appointments_UserControl1
            // 
            this.appointments_UserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointments_UserControl1.Location = new System.Drawing.Point(3, 3);
            this.appointments_UserControl1.Name = "appointments_UserControl1";
            this.appointments_UserControl1.Size = new System.Drawing.Size(970, 378);
            this.appointments_UserControl1.TabIndex = 0;
            // 
            // MainDashboardNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.LogOut_Button);
            this.Controls.Add(this.WelcomeLBL);
            this.Controls.Add(this.mainDashBoardNurse_TabControl);
            this.Name = "MainDashboardNurse";
            this.Text = "Clinic";
            this.mainDashBoardNurse_TabControl.ResumeLayout(false);
            this.appointments_tabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainDashBoardNurse_TabControl;
        private System.Windows.Forms.TabPage appointments_tabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label WelcomeLBL;
        private System.Windows.Forms.Button LogOut_Button;
        private UserControls.appointments_UserControl appointments_UserControl1;
    }
}
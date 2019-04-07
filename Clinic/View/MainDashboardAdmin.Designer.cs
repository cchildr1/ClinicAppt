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
            this.mainDashBoardNurse_TabControl = new System.Windows.Forms.TabControl();
            this.WelcomeLBL = new System.Windows.Forms.Label();
            this.LogOut_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nurse_tabpage = new System.Windows.Forms.TabPage();
            this.mainDashBoardNurse_TabControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDashBoardNurse_TabControl
            // 
            this.mainDashBoardNurse_TabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.tableLayoutPanel1.SetColumnSpan(this.mainDashBoardNurse_TabControl, 2);
            this.mainDashBoardNurse_TabControl.Controls.Add(this.nurse_tabpage);
            this.mainDashBoardNurse_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDashBoardNurse_TabControl.Location = new System.Drawing.Point(3, 32);
            this.mainDashBoardNurse_TabControl.Name = "mainDashBoardNurse_TabControl";
            this.mainDashBoardNurse_TabControl.SelectedIndex = 0;
            this.mainDashBoardNurse_TabControl.Size = new System.Drawing.Size(1061, 415);
            this.mainDashBoardNurse_TabControl.TabIndex = 3;
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
            // nurse_tabpage
            // 
            this.nurse_tabpage.Location = new System.Drawing.Point(4, 22);
            this.nurse_tabpage.Name = "nurse_tabpage";
            this.nurse_tabpage.Size = new System.Drawing.Size(1053, 389);
            this.nurse_tabpage.TabIndex = 0;
            this.nurse_tabpage.Text = "Nurses";
            this.nurse_tabpage.UseVisualStyleBackColor = true;
            // 
            // MainDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainDashboardAdmin";
            this.Text = "MainDashboardAdmin";
            this.mainDashBoardNurse_TabControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainDashBoardNurse_TabControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button LogOut_Button;
        private System.Windows.Forms.Label WelcomeLBL;
        private System.Windows.Forms.TabPage nurse_tabpage;
    }
}
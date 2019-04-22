namespace Clinic.View
{
    partial class AddEdit_Employee
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
            this.addEdit_employee_BASE_tablelayoutpanel = new System.Windows.Forms.TableLayoutPanel();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.password_Confirmation_LBL = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.password_conformation_textbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Edit_info_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.errorMessage_lbl = new System.Windows.Forms.Label();
            this.addEdit_employee_BASE_tablelayoutpanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEdit_employee_BASE_tablelayoutpanel
            // 
            this.addEdit_employee_BASE_tablelayoutpanel.ColumnCount = 2;
            this.addEdit_employee_BASE_tablelayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addEdit_employee_BASE_tablelayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addEdit_employee_BASE_tablelayoutpanel.Controls.Add(this.password_conformation_textbox, 1, 2);
            this.addEdit_employee_BASE_tablelayoutpanel.Controls.Add(this.password_textbox, 1, 1);
            this.addEdit_employee_BASE_tablelayoutpanel.Controls.Add(this.username_lbl, 0, 0);
            this.addEdit_employee_BASE_tablelayoutpanel.Controls.Add(this.password, 0, 1);
            this.addEdit_employee_BASE_tablelayoutpanel.Controls.Add(this.password_Confirmation_LBL, 0, 2);
            this.addEdit_employee_BASE_tablelayoutpanel.Controls.Add(this.username_textbox, 1, 0);
            this.addEdit_employee_BASE_tablelayoutpanel.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.addEdit_employee_BASE_tablelayoutpanel.Controls.Add(this.cancel_button, 1, 4);
            this.addEdit_employee_BASE_tablelayoutpanel.Controls.Add(this.errorMessage_lbl, 0, 3);
            this.addEdit_employee_BASE_tablelayoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEdit_employee_BASE_tablelayoutpanel.Location = new System.Drawing.Point(0, 0);
            this.addEdit_employee_BASE_tablelayoutpanel.Name = "addEdit_employee_BASE_tablelayoutpanel";
            this.addEdit_employee_BASE_tablelayoutpanel.RowCount = 5;
            this.addEdit_employee_BASE_tablelayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.addEdit_employee_BASE_tablelayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.addEdit_employee_BASE_tablelayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.addEdit_employee_BASE_tablelayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.89418F));
            this.addEdit_employee_BASE_tablelayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.58201F));
            this.addEdit_employee_BASE_tablelayoutpanel.Size = new System.Drawing.Size(314, 378);
            this.addEdit_employee_BASE_tablelayoutpanel.TabIndex = 0;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(3, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Padding = new System.Windows.Forms.Padding(5);
            this.username_lbl.Size = new System.Drawing.Size(65, 23);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(3, 75);
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(5);
            this.password.Size = new System.Drawing.Size(63, 23);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // password_Confirmation_LBL
            // 
            this.password_Confirmation_LBL.AutoSize = true;
            this.password_Confirmation_LBL.Location = new System.Drawing.Point(3, 150);
            this.password_Confirmation_LBL.Name = "password_Confirmation_LBL";
            this.password_Confirmation_LBL.Padding = new System.Windows.Forms.Padding(5);
            this.password_Confirmation_LBL.Size = new System.Drawing.Size(124, 23);
            this.password_Confirmation_LBL.TabIndex = 2;
            this.password_Confirmation_LBL.Text = "Password Confirmation";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(162, 5);
            this.username_textbox.Margin = new System.Windows.Forms.Padding(5);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(133, 20);
            this.username_textbox.TabIndex = 3;
            this.username_textbox.Click += new System.EventHandler(this.ResetErrorMessage);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(162, 80);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(5);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(133, 20);
            this.password_textbox.TabIndex = 4;
            this.password_textbox.Click += new System.EventHandler(this.ResetErrorMessage);
            // 
            // password_conformation_textbox
            // 
            this.password_conformation_textbox.Location = new System.Drawing.Point(162, 155);
            this.password_conformation_textbox.Margin = new System.Windows.Forms.Padding(5);
            this.password_conformation_textbox.Name = "password_conformation_textbox";
            this.password_conformation_textbox.Size = new System.Drawing.Size(133, 20);
            this.password_conformation_textbox.TabIndex = 5;
            this.password_conformation_textbox.Click += new System.EventHandler(this.ResetErrorMessage);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Edit_info_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reset_button, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 340);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(151, 35);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Edit_info_button
            // 
            this.Edit_info_button.Location = new System.Drawing.Point(3, 3);
            this.Edit_info_button.Name = "Edit_info_button";
            this.Edit_info_button.Size = new System.Drawing.Size(69, 23);
            this.Edit_info_button.TabIndex = 0;
            this.Edit_info_button.Text = "Edit";
            this.Edit_info_button.UseVisualStyleBackColor = true;
            this.Edit_info_button.Click += new System.EventHandler(this.Edit_info_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(78, 3);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(70, 23);
            this.reset_button.TabIndex = 1;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(160, 340);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 7;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseCompatibleTextRendering = true;
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // errorMessage_lbl
            // 
            this.errorMessage_lbl.AutoSize = true;
            this.errorMessage_lbl.Location = new System.Drawing.Point(3, 225);
            this.errorMessage_lbl.Name = "errorMessage_lbl";
            this.errorMessage_lbl.Size = new System.Drawing.Size(0, 13);
            this.errorMessage_lbl.TabIndex = 8;
            // 
            // AddEdit_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 378);
            this.Controls.Add(this.addEdit_employee_BASE_tablelayoutpanel);
            this.Name = "AddEdit_Employee";
            this.Text = "Edit Employee Info";
            this.addEdit_employee_BASE_tablelayoutpanel.ResumeLayout(false);
            this.addEdit_employee_BASE_tablelayoutpanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel addEdit_employee_BASE_tablelayoutpanel;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label password_Confirmation_LBL;
        private System.Windows.Forms.TextBox password_conformation_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Edit_info_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label errorMessage_lbl;
    }
}
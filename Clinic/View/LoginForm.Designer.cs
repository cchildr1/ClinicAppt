namespace Clinic
{
    partial class LoginForm
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
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel1;
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.passwordMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            userNameLabel.Location = new System.Drawing.Point(4, 0);
            userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(112, 36);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "User Name:";
            userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel1
            // 
            passwordLabel1.AutoSize = true;
            passwordLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            passwordLabel1.Location = new System.Drawing.Point(4, 36);
            passwordLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel1.Name = "passwordLabel1";
            passwordLabel1.Size = new System.Drawing.Size(112, 36);
            passwordLabel1.TabIndex = 0;
            passwordLabel1.Text = "Password:";
            passwordLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(4, 123);
            this.bt_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(112, 35);
            this.bt_Login.TabIndex = 3;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.Bt_Login_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(124, 123);
            this.bt_Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(112, 35);
            this.bt_Clear.TabIndex = 4;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.Bt_Clear_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "UserName", true));
            this.userNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameTextBox.Location = new System.Drawing.Point(124, 5);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(293, 26);
            this.userNameTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(passwordLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordMaskedTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(userNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.userNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_Clear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_Login, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.errorLabel, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 207);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // passwordMaskedTextBox
            // 
            this.passwordMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.passwordMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Password", true));
            this.passwordMaskedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordMaskedTextBox.Location = new System.Drawing.Point(124, 41);
            this.passwordMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordMaskedTextBox.Name = "passwordMaskedTextBox";
            this.passwordMaskedTextBox.Size = new System.Drawing.Size(293, 26);
            this.passwordMaskedTextBox.TabIndex = 2;
            this.passwordMaskedTextBox.UseSystemPasswordChar = true;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.errorLabel, 2);
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(4, 72);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(413, 46);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Clinic.Model.Employee);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 207);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic - Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox passwordMaskedTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Label errorLabel;
    }
}


namespace Clinic.UserControls
{
    partial class admin_NurseControl_userControl
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
            this.nurse_baseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nurse_DataGridView = new System.Windows.Forms.DataGridView();
            this.searchNurse_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchNurse_LBL = new System.Windows.Forms.Label();
            this.searchDescription_lbl = new System.Windows.Forms.Label();
            this.firstName_LBL = new System.Windows.Forms.Label();
            this.lastName_lbl = new System.Windows.Forms.Label();
            this.firstName_textbox = new System.Windows.Forms.TextBox();
            this.lastName_textbox = new System.Windows.Forms.TextBox();
            this.search_Nurse = new System.Windows.Forms.Button();
            this.nurse_baseTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nurse_DataGridView)).BeginInit();
            this.searchNurse_TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nurse_baseTableLayoutPanel
            // 
            this.nurse_baseTableLayoutPanel.ColumnCount = 3;
            this.nurse_baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.494565F));
            this.nurse_baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.50543F));
            this.nurse_baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.nurse_baseTableLayoutPanel.Controls.Add(this.nurse_DataGridView, 1, 1);
            this.nurse_baseTableLayoutPanel.Controls.Add(this.searchNurse_TableLayoutPanel, 1, 0);
            this.nurse_baseTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nurse_baseTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.nurse_baseTableLayoutPanel.Name = "nurse_baseTableLayoutPanel";
            this.nurse_baseTableLayoutPanel.RowCount = 3;
            this.nurse_baseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.79699F));
            this.nurse_baseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.20301F));
            this.nurse_baseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.nurse_baseTableLayoutPanel.Size = new System.Drawing.Size(776, 477);
            this.nurse_baseTableLayoutPanel.TabIndex = 0;
            // 
            // nurse_DataGridView
            // 
            this.nurse_DataGridView.AllowUserToAddRows = false;
            this.nurse_DataGridView.AllowUserToDeleteRows = false;
            this.nurse_DataGridView.AllowUserToOrderColumns = true;
            this.nurse_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nurse_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nurse_DataGridView.Location = new System.Drawing.Point(14, 78);
            this.nurse_DataGridView.Name = "nurse_DataGridView";
            this.nurse_DataGridView.ReadOnly = true;
            this.nurse_DataGridView.Size = new System.Drawing.Size(719, 318);
            this.nurse_DataGridView.TabIndex = 0;
            // 
            // searchNurse_TableLayoutPanel
            // 
            this.searchNurse_TableLayoutPanel.ColumnCount = 5;
            this.searchNurse_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.84284F));
            this.searchNurse_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.21975F));
            this.searchNurse_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.1669F));
            this.searchNurse_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.60362F));
            this.searchNurse_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.searchNurse_TableLayoutPanel.Controls.Add(this.searchNurse_LBL, 0, 0);
            this.searchNurse_TableLayoutPanel.Controls.Add(this.searchDescription_lbl, 0, 1);
            this.searchNurse_TableLayoutPanel.Controls.Add(this.firstName_LBL, 1, 1);
            this.searchNurse_TableLayoutPanel.Controls.Add(this.lastName_lbl, 2, 1);
            this.searchNurse_TableLayoutPanel.Controls.Add(this.firstName_textbox, 1, 0);
            this.searchNurse_TableLayoutPanel.Controls.Add(this.lastName_textbox, 2, 0);
            this.searchNurse_TableLayoutPanel.Controls.Add(this.search_Nurse, 3, 0);
            this.searchNurse_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchNurse_TableLayoutPanel.Location = new System.Drawing.Point(14, 3);
            this.searchNurse_TableLayoutPanel.Name = "searchNurse_TableLayoutPanel";
            this.searchNurse_TableLayoutPanel.RowCount = 2;
            this.searchNurse_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchNurse_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchNurse_TableLayoutPanel.Size = new System.Drawing.Size(719, 69);
            this.searchNurse_TableLayoutPanel.TabIndex = 1;
            this.searchNurse_TableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchNurse_TableLayoutPanel_Paint);
            // 
            // searchNurse_LBL
            // 
            this.searchNurse_LBL.AutoSize = true;
            this.searchNurse_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNurse_LBL.Location = new System.Drawing.Point(3, 0);
            this.searchNurse_LBL.Name = "searchNurse_LBL";
            this.searchNurse_LBL.Size = new System.Drawing.Size(138, 24);
            this.searchNurse_LBL.TabIndex = 0;
            this.searchNurse_LBL.Text = "Search Nurse";
            // 
            // searchDescription_lbl
            // 
            this.searchDescription_lbl.AutoSize = true;
            this.searchDescription_lbl.Location = new System.Drawing.Point(3, 34);
            this.searchDescription_lbl.Name = "searchDescription_lbl";
            this.searchDescription_lbl.Size = new System.Drawing.Size(172, 13);
            this.searchDescription_lbl.TabIndex = 1;
            this.searchDescription_lbl.Text = "Double Click a Nurse to see details";
            // 
            // firstName_LBL
            // 
            this.firstName_LBL.AutoSize = true;
            this.firstName_LBL.Location = new System.Drawing.Point(196, 34);
            this.firstName_LBL.Name = "firstName_LBL";
            this.firstName_LBL.Size = new System.Drawing.Size(55, 13);
            this.firstName_LBL.TabIndex = 3;
            this.firstName_LBL.Text = "First name";
            // 
            // lastName_lbl
            // 
            this.lastName_lbl.AutoSize = true;
            this.lastName_lbl.Location = new System.Drawing.Point(327, 34);
            this.lastName_lbl.Name = "lastName_lbl";
            this.lastName_lbl.Size = new System.Drawing.Size(56, 13);
            this.lastName_lbl.TabIndex = 4;
            this.lastName_lbl.Text = "Last name";
            // 
            // firstName_textbox
            // 
            this.firstName_textbox.Location = new System.Drawing.Point(196, 3);
            this.firstName_textbox.Name = "firstName_textbox";
            this.firstName_textbox.Size = new System.Drawing.Size(100, 20);
            this.firstName_textbox.TabIndex = 5;
            // 
            // lastName_textbox
            // 
            this.lastName_textbox.Location = new System.Drawing.Point(327, 3);
            this.lastName_textbox.Name = "lastName_textbox";
            this.lastName_textbox.Size = new System.Drawing.Size(100, 20);
            this.lastName_textbox.TabIndex = 6;
            // 
            // search_Nurse
            // 
            this.search_Nurse.Location = new System.Drawing.Point(472, 3);
            this.search_Nurse.Name = "search_Nurse";
            this.search_Nurse.Size = new System.Drawing.Size(75, 23);
            this.search_Nurse.TabIndex = 7;
            this.search_Nurse.Text = "Search";
            this.search_Nurse.UseVisualStyleBackColor = true;
            this.search_Nurse.Click += new System.EventHandler(this.search_Nurse_Click);
            // 
            // admin_NurseControl_userControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nurse_baseTableLayoutPanel);
            this.Name = "admin_NurseControl_userControl";
            this.Size = new System.Drawing.Size(776, 477);
            this.nurse_baseTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nurse_DataGridView)).EndInit();
            this.searchNurse_TableLayoutPanel.ResumeLayout(false);
            this.searchNurse_TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel nurse_baseTableLayoutPanel;
        private System.Windows.Forms.DataGridView nurse_DataGridView;
        private System.Windows.Forms.TableLayoutPanel searchNurse_TableLayoutPanel;
        private System.Windows.Forms.Label searchNurse_LBL;
        private System.Windows.Forms.Label searchDescription_lbl;
        private System.Windows.Forms.Label firstName_LBL;
        private System.Windows.Forms.Label lastName_lbl;
        private System.Windows.Forms.TextBox firstName_textbox;
        private System.Windows.Forms.TextBox lastName_textbox;
        private System.Windows.Forms.Button search_Nurse;
    }
}

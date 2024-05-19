namespace DentalAppointmentandInformationSystem
{
    partial class StaffList
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fullName = new System.Windows.Forms.Label();
            this.employeeNum = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.Label();
            this.staffRole = new System.Windows.Forms.Label();
            this.contactNum = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 386F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel2.Controls.Add(this.fullName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.employeeNum, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ageLbl, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.birthDate, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.staffRole, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.contactNum, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.passwordLbl, 6, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1322, 91);
            this.tableLayoutPanel2.TabIndex = 89;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.editStaff_Click);
            // 
            // fullName
            // 
            this.fullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullName.AutoSize = true;
            this.fullName.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.fullName.Location = new System.Drawing.Point(291, 33);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(104, 24);
            this.fullName.TabIndex = 80;
            this.fullName.Text = "Full Name";
            this.fullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fullName.Click += new System.EventHandler(this.editStaff_Click);
            // 
            // employeeNum
            // 
            this.employeeNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeNum.AutoSize = true;
            this.employeeNum.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.employeeNum.Location = new System.Drawing.Point(3, 33);
            this.employeeNum.Name = "employeeNum";
            this.employeeNum.Size = new System.Drawing.Size(144, 24);
            this.employeeNum.TabIndex = 77;
            this.employeeNum.Text = "Employee No.";
            this.employeeNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.employeeNum.Click += new System.EventHandler(this.editStaff_Click);
            // 
            // ageLbl
            // 
            this.ageLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ageLbl.AutoSize = true;
            this.ageLbl.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.ageLbl.Location = new System.Drawing.Point(550, 33);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(49, 24);
            this.ageLbl.TabIndex = 78;
            this.ageLbl.Text = "Age";
            this.ageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ageLbl.Click += new System.EventHandler(this.editStaff_Click);
            // 
            // birthDate
            // 
            this.birthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDate.AutoSize = true;
            this.birthDate.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.birthDate.Location = new System.Drawing.Point(646, 33);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(101, 24);
            this.birthDate.TabIndex = 79;
            this.birthDate.Text = "Birthdate";
            this.birthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.birthDate.Click += new System.EventHandler(this.editStaff_Click);
            // 
            // staffRole
            // 
            this.staffRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffRole.AutoSize = true;
            this.staffRole.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.staffRole.Location = new System.Drawing.Point(818, 33);
            this.staffRole.Name = "staffRole";
            this.staffRole.Size = new System.Drawing.Size(105, 24);
            this.staffRole.TabIndex = 81;
            this.staffRole.Text = "Staff Role";
            this.staffRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.staffRole.Click += new System.EventHandler(this.editStaff_Click);
            // 
            // contactNum
            // 
            this.contactNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactNum.AutoSize = true;
            this.contactNum.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.contactNum.Location = new System.Drawing.Point(1007, 33);
            this.contactNum.Name = "contactNum";
            this.contactNum.Size = new System.Drawing.Size(88, 24);
            this.contactNum.TabIndex = 82;
            this.contactNum.Text = "Contact";
            this.contactNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.contactNum.Click += new System.EventHandler(this.editStaff_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.passwordLbl.Location = new System.Drawing.Point(1178, 33);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(106, 24);
            this.passwordLbl.TabIndex = 83;
            this.passwordLbl.Text = "Password";
            this.passwordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordLbl.Click += new System.EventHandler(this.editStaff_Click);
            // 
            // StaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "StaffList";
            this.Size = new System.Drawing.Size(1322, 90);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label employeeNum;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label birthDate;
        private System.Windows.Forms.Label staffRole;
        private System.Windows.Forms.Label contactNum;
        private System.Windows.Forms.Label passwordLbl;
    }
}
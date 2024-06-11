namespace DentalAppointmentandInformationSystem
{
    partial class AppointmentArchived
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.appntmntState = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.appntmntIDLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteAppntmnt = new System.Windows.Forms.Button();
            this.editAppntmnt = new System.Windows.Forms.Button();
            this.stffLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.srvcLbl = new System.Windows.Forms.Label();
            this.ptntLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.appntmntState);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.appntmntIDLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.stffLbl);
            this.panel1.Controls.Add(this.timeLbl);
            this.panel1.Controls.Add(this.srvcLbl);
            this.panel1.Controls.Add(this.ptntLbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 306);
            this.panel1.TabIndex = 15;
            // 
            // appntmntState
            // 
            this.appntmntState.DisplayMember = "Pending";
            this.appntmntState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appntmntState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.appntmntState.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.appntmntState.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.appntmntState.FormattingEnabled = true;
            this.appntmntState.Items.AddRange(new object[] {
            "Pending",
            "Ongoing",
            "Completed",
            "Cancelled",
            "No Show"});
            this.appntmntState.Location = new System.Drawing.Point(831, 229);
            this.appntmntState.Name = "appntmntState";
            this.appntmntState.Size = new System.Drawing.Size(188, 29);
            this.appntmntState.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(753, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Status:";
            // 
            // appntmntIDLbl
            // 
            this.appntmntIDLbl.AutoSize = true;
            this.appntmntIDLbl.Font = new System.Drawing.Font("Inter Medium", 8F, System.Drawing.FontStyle.Bold);
            this.appntmntIDLbl.Location = new System.Drawing.Point(998, 9);
            this.appntmntIDLbl.Name = "appntmntIDLbl";
            this.appntmntIDLbl.Size = new System.Drawing.Size(55, 19);
            this.appntmntIDLbl.TabIndex = 13;
            this.appntmntIDLbl.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "notes";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(-12, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(16, 297);
            this.panel6.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(1059, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 297);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(3, -16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1058, 22);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(3, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1058, 149);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteAppntmnt);
            this.panel2.Controls.Add(this.editAppntmnt);
            this.panel2.Location = new System.Drawing.Point(756, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 155);
            this.panel2.TabIndex = 7;
            // 
            // deleteAppntmnt
            // 
            this.deleteAppntmnt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAppntmnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.deleteAppntmnt.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAppntmnt.ForeColor = System.Drawing.Color.White;
            this.deleteAppntmnt.Location = new System.Drawing.Point(25, 83);
            this.deleteAppntmnt.Name = "deleteAppntmnt";
            this.deleteAppntmnt.Size = new System.Drawing.Size(219, 49);
            this.deleteAppntmnt.TabIndex = 2;
            this.deleteAppntmnt.Text = "Delete";
            this.deleteAppntmnt.UseVisualStyleBackColor = false;
            this.deleteAppntmnt.Click += new System.EventHandler(this.deleteAppntmnt_Click);
            // 
            // editAppntmnt
            // 
            this.editAppntmnt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editAppntmnt.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAppntmnt.Location = new System.Drawing.Point(25, 23);
            this.editAppntmnt.Name = "editAppntmnt";
            this.editAppntmnt.Size = new System.Drawing.Size(219, 46);
            this.editAppntmnt.TabIndex = 1;
            this.editAppntmnt.Text = "Restore";
            this.editAppntmnt.UseVisualStyleBackColor = true;
            this.editAppntmnt.Click += new System.EventHandler(this.restoreAppntmnt_Click);
            // 
            // stffLbl
            // 
            this.stffLbl.AutoSize = true;
            this.stffLbl.Font = new System.Drawing.Font("Inter Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stffLbl.Location = new System.Drawing.Point(45, 181);
            this.stffLbl.Name = "stffLbl";
            this.stffLbl.Size = new System.Drawing.Size(61, 21);
            this.stffLbl.TabIndex = 6;
            this.stffLbl.Text = "label5";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Inter Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(45, 136);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(62, 21);
            this.timeLbl.TabIndex = 5;
            this.timeLbl.Text = "label4";
            // 
            // srvcLbl
            // 
            this.srvcLbl.AutoSize = true;
            this.srvcLbl.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.srvcLbl.Location = new System.Drawing.Point(45, 93);
            this.srvcLbl.Name = "srvcLbl";
            this.srvcLbl.Size = new System.Drawing.Size(62, 21);
            this.srvcLbl.TabIndex = 4;
            this.srvcLbl.Text = "label3";
            // 
            // ptntLbl
            // 
            this.ptntLbl.AutoSize = true;
            this.ptntLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptntLbl.Location = new System.Drawing.Point(44, 33);
            this.ptntLbl.Name = "ptntLbl";
            this.ptntLbl.Size = new System.Drawing.Size(85, 29);
            this.ptntLbl.TabIndex = 3;
            this.ptntLbl.Text = "label2";
            this.ptntLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AppointmentArchived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AppointmentArchived";
            this.Size = new System.Drawing.Size(1064, 303);
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteAppntmnt;
        private System.Windows.Forms.Button editAppntmnt;
        private System.Windows.Forms.Label stffLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label srvcLbl;
        private System.Windows.Forms.Label ptntLbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label appntmntIDLbl;
        private System.Windows.Forms.ComboBox appntmntState;
        private System.Windows.Forms.Label label2;
    }
}
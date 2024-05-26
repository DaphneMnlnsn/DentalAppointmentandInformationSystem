namespace DentalAppointmentandInformationSystem
{
    partial class PatientsList
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
            this.patientName = new System.Windows.Forms.Label();
            this.patientId = new System.Windows.Forms.Label();
            this.patientAge = new System.Windows.Forms.Label();
            this.patientGender = new System.Windows.Forms.Label();
            this.patientContact = new System.Windows.Forms.Label();
            this.patientLastVisit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 580F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel2.Controls.Add(this.patientName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.patientId, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.patientAge, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.patientGender, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.patientContact, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.patientLastVisit, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1322, 85);
            this.tableLayoutPanel2.TabIndex = 92;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.patientDetails_Click);
            // 
            // patientName
            // 
            this.patientName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientName.AutoSize = true;
            this.patientName.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.patientName.Location = new System.Drawing.Point(354, 30);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(104, 24);
            this.patientName.TabIndex = 80;
            this.patientName.Text = "Full Name";
            this.patientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patientName.Click += new System.EventHandler(this.patientDetails_Click);
            // 
            // patientId
            // 
            this.patientId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientId.AutoSize = true;
            this.patientId.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.patientId.Location = new System.Drawing.Point(6, 30);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(104, 24);
            this.patientId.TabIndex = 77;
            this.patientId.Text = "Patient ID";
            this.patientId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patientId.Click += new System.EventHandler(this.patientDetails_Click);
            // 
            // patientAge
            // 
            this.patientAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientAge.AutoSize = true;
            this.patientAge.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.patientAge.Location = new System.Drawing.Point(717, 30);
            this.patientAge.Name = "patientAge";
            this.patientAge.Size = new System.Drawing.Size(49, 24);
            this.patientAge.TabIndex = 78;
            this.patientAge.Text = "Age";
            this.patientAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patientAge.Click += new System.EventHandler(this.patientDetails_Click);
            // 
            // patientGender
            // 
            this.patientGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientGender.AutoSize = true;
            this.patientGender.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.patientGender.Location = new System.Drawing.Point(829, 30);
            this.patientGender.Name = "patientGender";
            this.patientGender.Size = new System.Drawing.Size(82, 24);
            this.patientGender.TabIndex = 79;
            this.patientGender.Text = "Gender";
            this.patientGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patientGender.Click += new System.EventHandler(this.patientDetails_Click);
            // 
            // patientContact
            // 
            this.patientContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientContact.AutoSize = true;
            this.patientContact.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.patientContact.Location = new System.Drawing.Point(1189, 30);
            this.patientContact.Name = "patientContact";
            this.patientContact.Size = new System.Drawing.Size(88, 24);
            this.patientContact.TabIndex = 82;
            this.patientContact.Text = "Contact";
            this.patientContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patientContact.Click += new System.EventHandler(this.patientDetails_Click);
            // 
            // patientLastVisit
            // 
            this.patientLastVisit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientLastVisit.AutoSize = true;
            this.patientLastVisit.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.patientLastVisit.Location = new System.Drawing.Point(999, 30);
            this.patientLastVisit.Name = "patientLastVisit";
            this.patientLastVisit.Size = new System.Drawing.Size(99, 24);
            this.patientLastVisit.TabIndex = 83;
            this.patientLastVisit.Text = "Last Visit";
            this.patientLastVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patientLastVisit.Click += new System.EventHandler(this.patientDetails_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-5, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 74);
            this.panel1.TabIndex = 93;
            // 
            // PatientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "PatientsList";
            this.Size = new System.Drawing.Size(1322, 90);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label patientName;
        private System.Windows.Forms.Label patientId;
        private System.Windows.Forms.Label patientAge;
        private System.Windows.Forms.Label patientGender;
        private System.Windows.Forms.Label patientContact;
        private System.Windows.Forms.Label patientLastVisit;
        private System.Windows.Forms.Panel panel1;
    }
}

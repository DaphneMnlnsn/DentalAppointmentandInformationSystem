namespace DentalAppointmentandInformationSystem
{
    partial class PatientDetails
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dshbrdLbl = new System.Windows.Forms.Label();
            this.editPatientBtn = new System.Windows.Forms.Button();
            this.servicesBtn = new System.Windows.Forms.PictureBox();
            this.staffBtn = new System.Windows.Forms.PictureBox();
            this.patientBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.doctorPic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.servicesBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.staffBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.patientBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(162, 823);
            this.tableLayoutPanel1.TabIndex = 72;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.doctorPic);
            this.panel2.Controls.Add(this.dshbrdLbl);
            this.panel2.Controls.Add(this.editPatientBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1537, 97);
            this.panel2.TabIndex = 71;
            // 
            // dshbrdLbl
            // 
            this.dshbrdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dshbrdLbl.AutoSize = true;
            this.dshbrdLbl.Font = new System.Drawing.Font("Metrophobic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshbrdLbl.Location = new System.Drawing.Point(193, 22);
            this.dshbrdLbl.Name = "dshbrdLbl";
            this.dshbrdLbl.Size = new System.Drawing.Size(302, 50);
            this.dshbrdLbl.TabIndex = 5;
            this.dshbrdLbl.Text = "Patient Overview";
            this.dshbrdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editPatientBtn
            // 
            this.editPatientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.editPatientBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.editPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPatientBtn.Font = new System.Drawing.Font("Inter Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPatientBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.editPatientBtn.Location = new System.Drawing.Point(1163, 26);
            this.editPatientBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editPatientBtn.Name = "editPatientBtn";
            this.editPatientBtn.Size = new System.Drawing.Size(224, 48);
            this.editPatientBtn.TabIndex = 1;
            this.editPatientBtn.Text = "Edit Patient";
            this.editPatientBtn.UseVisualStyleBackColor = false;
            this.editPatientBtn.Click += new System.EventHandler(this.editPatientBtn_Click);
            // 
            // servicesBtn
            // 
            this.servicesBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.servicesBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.services;
            this.servicesBtn.Location = new System.Drawing.Point(48, 441);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(66, 65);
            this.servicesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.servicesBtn.TabIndex = 2;
            this.servicesBtn.TabStop = false;
            // 
            // staffBtn
            // 
            this.staffBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.staffs;
            this.staffBtn.Location = new System.Drawing.Point(48, 297);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(66, 74);
            this.staffBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffBtn.TabIndex = 0;
            this.staffBtn.TabStop = false;
            // 
            // patientBtn
            // 
            this.patientBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.calendar;
            this.patientBtn.Location = new System.Drawing.Point(48, 165);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(66, 61);
            this.patientBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patientBtn.TabIndex = 1;
            this.patientBtn.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(56, 585);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.person_icon;
            this.pictureBox5.Location = new System.Drawing.Point(38, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(84, 77);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // doctorPic
            // 
            this.doctorPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doctorPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.profile_icon;
            this.doctorPic.Location = new System.Drawing.Point(1435, 12);
            this.doctorPic.Name = "doctorPic";
            this.doctorPic.Size = new System.Drawing.Size(77, 69);
            this.doctorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doctorPic.TabIndex = 7;
            this.doctorPic.TabStop = false;
            // 
            // PatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 920);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1559, 976);
            this.Name = "PatientDetails";
            this.Text = "PatientDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientDetails_FormClosing);
            this.Load += new System.EventHandler(this.PatientDetails_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox servicesBtn;
        private System.Windows.Forms.PictureBox staffBtn;
        private System.Windows.Forms.PictureBox patientBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox doctorPic;
        private System.Windows.Forms.Label dshbrdLbl;
        private System.Windows.Forms.Button editPatientBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
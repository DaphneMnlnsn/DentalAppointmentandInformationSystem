namespace DentalAppointmentandInformationSystem
{
    partial class Staff
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
            this.dshbrdLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.staffContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employee_no = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.servicesBtn = new System.Windows.Forms.PictureBox();
            this.patientBtn = new System.Windows.Forms.PictureBox();
            this.clndrBtn = new System.Windows.Forms.PictureBox();
            this.dshbrdBtn = new System.Windows.Forms.PictureBox();
            this.doctorPic = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clndrBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshbrdBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            this.dshbrdLbl.Size = new System.Drawing.Size(213, 50);
            this.dshbrdLbl.TabIndex = 5;
            this.dshbrdLbl.Text = "List of Staff";
            this.dshbrdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.btnAddStaff);
            this.panel1.Controls.Add(this.doctorPic);
            this.panel1.Controls.Add(this.dshbrdLbl);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1537, 97);
            this.panel1.TabIndex = 6;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddStaff.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddStaff.Location = new System.Drawing.Point(1162, 26);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(224, 48);
            this.btnAddStaff.TabIndex = 8;
            this.btnAddStaff.Text = "+ Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.servicesBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.patientBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.clndrBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dshbrdBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(162, 823);
            this.tableLayoutPanel1.TabIndex = 71;
            // 
            // staffContainer
            // 
            this.staffContainer.AutoScroll = true;
            this.staffContainer.Location = new System.Drawing.Point(190, 246);
            this.staffContainer.Name = "staffContainer";
            this.staffContainer.Size = new System.Drawing.Size(1322, 607);
            this.staffContainer.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1162, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 31);
            this.label6.TabIndex = 83;
            this.label6.Text = "Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(993, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 31);
            this.label5.TabIndex = 82;
            this.label5.Text = "Contact";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(802, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 31);
            this.label4.TabIndex = 81;
            this.label4.Text = "Staff Role";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(636, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 79;
            this.label3.Text = "Birthdate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(549, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 31);
            this.label2.TabIndex = 78;
            this.label2.Text = "Age";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employee_no
            // 
            this.employee_no.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employee_no.AutoSize = true;
            this.employee_no.Font = new System.Drawing.Font("Inter SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.employee_no.Location = new System.Drawing.Point(10, 14);
            this.employee_no.Name = "employee_no";
            this.employee_no.Size = new System.Drawing.Size(135, 62);
            this.employee_no.TabIndex = 77;
            this.employee_no.Text = "Employee No.";
            this.employee_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(279, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 80;
            this.label1.Text = "Full Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 383F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.employee_no, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(190, 157);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1322, 90);
            this.tableLayoutPanel2.TabIndex = 88;
            // 
            // servicesBtn
            // 
            this.servicesBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.servicesBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.services;
            this.servicesBtn.Location = new System.Drawing.Point(48, 594);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(66, 65);
            this.servicesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.servicesBtn.TabIndex = 2;
            this.servicesBtn.TabStop = false;
            this.servicesBtn.Click += new System.EventHandler(this.servicesBtn_Click);
            // 
            // patientBtn
            // 
            this.patientBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.patients;
            this.patientBtn.Location = new System.Drawing.Point(48, 443);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(66, 70);
            this.patientBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patientBtn.TabIndex = 1;
            this.patientBtn.TabStop = false;
            this.patientBtn.Click += new System.EventHandler(this.patientBtn_Click);
            // 
            // clndrBtn
            // 
            this.clndrBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clndrBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.calendar;
            this.clndrBtn.Location = new System.Drawing.Point(48, 295);
            this.clndrBtn.Name = "clndrBtn";
            this.clndrBtn.Size = new System.Drawing.Size(66, 61);
            this.clndrBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clndrBtn.TabIndex = 0;
            this.clndrBtn.TabStop = false;
            this.clndrBtn.Click += new System.EventHandler(this.clndrBtn_Click);
            // 
            // dshbrdBtn
            // 
            this.dshbrdBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dshbrdBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.dashboard;
            this.dshbrdBtn.Location = new System.Drawing.Point(53, 154);
            this.dshbrdBtn.Name = "dshbrdBtn";
            this.dshbrdBtn.Size = new System.Drawing.Size(56, 55);
            this.dshbrdBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dshbrdBtn.TabIndex = 3;
            this.dshbrdBtn.TabStop = false;
            this.dshbrdBtn.Click += new System.EventHandler(this.dshbrdBtn_Click);
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
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.staffs;
            this.pictureBox4.Location = new System.Drawing.Point(38, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(84, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1537, 920);
            this.Controls.Add(this.staffContainer);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1559, 976);
            this.Name = "Staff";
            this.Text = "Staff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Staff_FormClosing);
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clndrBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshbrdBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label dshbrdLbl;
        private System.Windows.Forms.PictureBox doctorPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox patientBtn;
        private System.Windows.Forms.PictureBox clndrBtn;
        private System.Windows.Forms.PictureBox servicesBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel staffContainer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label employee_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.PictureBox dshbrdBtn;
    }
}
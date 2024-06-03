namespace DentalAppointmentandInformationSystem
{
    partial class FileArchives
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.servicesBtn = new System.Windows.Forms.PictureBox();
            this.staffBtn = new System.Windows.Forms.PictureBox();
            this.patientBtn = new System.Windows.Forms.PictureBox();
            this.dshbrdBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.doctorPic = new System.Windows.Forms.PictureBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.attachmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshbrdBtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.servicesBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.staffBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.patientBtn, 0, 2);
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
            this.tableLayoutPanel1.TabIndex = 72;
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
            this.toolTip1.SetToolTip(this.servicesBtn, "Archived Services");
            this.servicesBtn.Click += new System.EventHandler(this.servicesBtn_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.staffs;
            this.staffBtn.Location = new System.Drawing.Point(48, 441);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(66, 74);
            this.staffBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffBtn.TabIndex = 0;
            this.staffBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.staffBtn, "Archived Staff");
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // patientBtn
            // 
            this.patientBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.calendar;
            this.patientBtn.Location = new System.Drawing.Point(48, 296);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(66, 59);
            this.patientBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patientBtn.TabIndex = 1;
            this.patientBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.patientBtn, "Archived Appointments");
            this.patientBtn.Click += new System.EventHandler(this.clndrBtn_Click);
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
            this.toolTip1.SetToolTip(this.dshbrdBtn, "Dashboard");
            this.dshbrdBtn.Click += new System.EventHandler(this.dshbrdBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.doctorPic);
            this.panel2.Controls.Add(this.titleLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1537, 97);
            this.panel2.TabIndex = 71;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.newBin;
            this.pictureBox5.Location = new System.Drawing.Point(30, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(108, 94);
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
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Metrophobic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(193, 22);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(252, 50);
            this.titleLbl.TabIndex = 5;
            this.titleLbl.Text = "Archived Files";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attachmentContainer
            // 
            this.attachmentContainer.AutoScroll = true;
            this.attachmentContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attachmentContainer.Location = new System.Drawing.Point(190, 198);
            this.attachmentContainer.Name = "attachmentContainer";
            this.attachmentContainer.Size = new System.Drawing.Size(1322, 691);
            this.attachmentContainer.TabIndex = 92;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTxtBox.Font = new System.Drawing.Font("Inter Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(1062, 128);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(448, 32);
            this.searchTxtBox.TabIndex = 94;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.Window;
            this.searchBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.search;
            this.searchBtn.Location = new System.Drawing.Point(1474, 129);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(33, 28);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchBtn.TabIndex = 95;
            this.searchBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.searchBtn, "Search");
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.back;
            this.backBtn.Location = new System.Drawing.Point(202, 117);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(56, 55);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backBtn.TabIndex = 4;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // FileArchives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 920);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.attachmentContainer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1559, 976);
            this.Name = "FileArchives";
            this.Text = "File Archives";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileArchives_FormClosing);
            this.Load += new System.EventHandler(this.FileArchives_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshbrdBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox servicesBtn;
        private System.Windows.Forms.PictureBox staffBtn;
        private System.Windows.Forms.PictureBox patientBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox doctorPic;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.FlowLayoutPanel attachmentContainer;
        private System.Windows.Forms.PictureBox dshbrdBtn;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
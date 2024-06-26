﻿namespace DentalAppointmentandInformationSystem
{
    partial class ServiceArchives
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
            this.staffBtn = new System.Windows.Forms.PictureBox();
            this.ptntsBtn = new System.Windows.Forms.PictureBox();
            this.clndrBtn = new System.Windows.Forms.PictureBox();
            this.dshbrdbtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dshbrdLbl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.doctorPic = new System.Windows.Forms.PictureBox();
            this.servicesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.emptyLbl = new System.Windows.Forms.Label();
            this.emptyPic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptntsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clndrBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshbrdbtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPic)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.staffBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ptntsBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.clndrBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dshbrdbtn, 0, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(162, 814);
            this.tableLayoutPanel1.TabIndex = 74;
            // 
            // staffBtn
            // 
            this.staffBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.staffs;
            this.staffBtn.Location = new System.Drawing.Point(48, 582);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(66, 71);
            this.staffBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffBtn.TabIndex = 2;
            this.staffBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.staffBtn, "Archived Staff");
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // ptntsBtn
            // 
            this.ptntsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptntsBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.patients;
            this.ptntsBtn.Location = new System.Drawing.Point(48, 432);
            this.ptntsBtn.Name = "ptntsBtn";
            this.ptntsBtn.Size = new System.Drawing.Size(66, 74);
            this.ptntsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptntsBtn.TabIndex = 0;
            this.ptntsBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.ptntsBtn, "Archived Patients");
            this.ptntsBtn.Click += new System.EventHandler(this.ptntsBtn_Click);
            // 
            // clndrBtn
            // 
            this.clndrBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clndrBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.calendar;
            this.clndrBtn.Location = new System.Drawing.Point(48, 287);
            this.clndrBtn.Name = "clndrBtn";
            this.clndrBtn.Size = new System.Drawing.Size(66, 58);
            this.clndrBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clndrBtn.TabIndex = 1;
            this.clndrBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.clndrBtn, "Archived Appointments");
            this.clndrBtn.Click += new System.EventHandler(this.clndrBtn_Click);
            // 
            // dshbrdbtn
            // 
            this.dshbrdbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dshbrdbtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.dashboard;
            this.dshbrdbtn.Location = new System.Drawing.Point(53, 145);
            this.dshbrdbtn.Name = "dshbrdbtn";
            this.dshbrdbtn.Size = new System.Drawing.Size(56, 55);
            this.dshbrdbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dshbrdbtn.TabIndex = 3;
            this.dshbrdbtn.TabStop = false;
            this.toolTip1.SetToolTip(this.dshbrdbtn, "Dashboard");
            this.dshbrdbtn.Click += new System.EventHandler(this.dshbrdbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.dshbrdLbl);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.doctorPic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1534, 97);
            this.panel2.TabIndex = 73;
            // 
            // dshbrdLbl
            // 
            this.dshbrdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dshbrdLbl.AutoSize = true;
            this.dshbrdLbl.Font = new System.Drawing.Font("Metrophobic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshbrdLbl.Location = new System.Drawing.Point(194, 27);
            this.dshbrdLbl.Name = "dshbrdLbl";
            this.dshbrdLbl.Size = new System.Drawing.Size(313, 50);
            this.dshbrdLbl.TabIndex = 9;
            this.dshbrdLbl.Text = "Archived Services";
            this.dshbrdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.newBin;
            this.pictureBox5.Location = new System.Drawing.Point(36, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(84, 78);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // doctorPic
            // 
            this.doctorPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doctorPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.profile_icon;
            this.doctorPic.Location = new System.Drawing.Point(1434, 12);
            this.doctorPic.Name = "doctorPic";
            this.doctorPic.Size = new System.Drawing.Size(76, 69);
            this.doctorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doctorPic.TabIndex = 7;
            this.doctorPic.TabStop = false;
            // 
            // servicesContainer
            // 
            this.servicesContainer.AutoScroll = true;
            this.servicesContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.servicesContainer.Location = new System.Drawing.Point(276, 282);
            this.servicesContainer.Name = "servicesContainer";
            this.servicesContainer.Size = new System.Drawing.Size(1150, 593);
            this.servicesContainer.TabIndex = 86;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTxtBox.Font = new System.Drawing.Font("Inter Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(974, 128);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(448, 32);
            this.searchTxtBox.TabIndex = 93;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.Window;
            this.searchBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.search;
            this.searchBtn.Location = new System.Drawing.Point(1386, 129);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(33, 28);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchBtn.TabIndex = 94;
            this.searchBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.searchBtn, "Search");
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.back;
            this.backBtn.Location = new System.Drawing.Point(276, 119);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(56, 55);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backBtn.TabIndex = 95;
            this.backBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.backBtn, "Back to Services List");
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // emptyLbl
            // 
            this.emptyLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emptyLbl.AutoSize = true;
            this.emptyLbl.Font = new System.Drawing.Font("Metrophobic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLbl.Location = new System.Drawing.Point(766, 583);
            this.emptyLbl.Name = "emptyLbl";
            this.emptyLbl.Size = new System.Drawing.Size(142, 45);
            this.emptyLbl.TabIndex = 101;
            this.emptyLbl.Text = "No Data";
            this.emptyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emptyLbl.Visible = false;
            // 
            // emptyPic
            // 
            this.emptyPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emptyPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.empty;
            this.emptyPic.Location = new System.Drawing.Point(760, 439);
            this.emptyPic.Name = "emptyPic";
            this.emptyPic.Size = new System.Drawing.Size(153, 141);
            this.emptyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emptyPic.TabIndex = 100;
            this.emptyPic.TabStop = false;
            this.emptyPic.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 464F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(276, 193);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1150, 90);
            this.tableLayoutPanel3.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(600, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 79;
            this.label4.Text = "Service Price";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(256, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 29);
            this.label5.TabIndex = 78;
            this.label5.Text = "Service Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(5, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 58);
            this.label6.TabIndex = 77;
            this.label6.Text = "Service ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(797, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 58);
            this.label7.TabIndex = 80;
            this.label7.Text = "Service Duration (hour)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceArchives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 911);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.emptyLbl);
            this.Controls.Add(this.emptyPic);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.servicesContainer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1556, 967);
            this.Name = "ServiceArchives";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Services_FormClosing);
            this.Load += new System.EventHandler(this.Services_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptntsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clndrBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshbrdbtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPic)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox staffBtn;
        private System.Windows.Forms.PictureBox ptntsBtn;
        private System.Windows.Forms.PictureBox clndrBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox doctorPic;
        private System.Windows.Forms.FlowLayoutPanel servicesContainer;
        private System.Windows.Forms.PictureBox dshbrdbtn;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Label dshbrdLbl;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label emptyLbl;
        private System.Windows.Forms.PictureBox emptyPic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
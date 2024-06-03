namespace DentalAppointmentandInformationSystem
{
    partial class Services
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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.doctorPic = new System.Windows.Forms.PictureBox();
            this.dshbrdLbl = new System.Windows.Forms.Label();
            this.addServiceBtn = new System.Windows.Forms.Button();
            this.servicesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.binBtn = new System.Windows.Forms.Panel();
            this.binPic = new System.Windows.Forms.PictureBox();
            this.binLbl = new System.Windows.Forms.Label();
            this.editService1 = new DentalAppointmentandInformationSystem.EditService();
            this.addService1 = new DentalAppointmentandInformationSystem.AddService();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptntsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clndrBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshbrdbtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.binBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
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
            this.toolTip1.SetToolTip(this.staffBtn, "List of Staff");
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
            this.toolTip1.SetToolTip(this.ptntsBtn, "List of Patients");
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
            this.toolTip1.SetToolTip(this.clndrBtn, "Appointment Calendar");
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
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.doctorPic);
            this.panel2.Controls.Add(this.dshbrdLbl);
            this.panel2.Controls.Add(this.addServiceBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1534, 97);
            this.panel2.TabIndex = 73;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.services;
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
            // dshbrdLbl
            // 
            this.dshbrdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dshbrdLbl.AutoSize = true;
            this.dshbrdLbl.Font = new System.Drawing.Font("Metrophobic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshbrdLbl.Location = new System.Drawing.Point(194, 27);
            this.dshbrdLbl.Name = "dshbrdLbl";
            this.dshbrdLbl.Size = new System.Drawing.Size(290, 50);
            this.dshbrdLbl.TabIndex = 5;
            this.dshbrdLbl.Text = "Services Offered";
            this.dshbrdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addServiceBtn
            // 
            this.addServiceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addServiceBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addServiceBtn.Font = new System.Drawing.Font("Inter Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServiceBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addServiceBtn.Location = new System.Drawing.Point(1162, 26);
            this.addServiceBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addServiceBtn.Name = "addServiceBtn";
            this.addServiceBtn.Size = new System.Drawing.Size(224, 48);
            this.addServiceBtn.TabIndex = 1;
            this.addServiceBtn.Text = "+ Add Service";
            this.addServiceBtn.UseVisualStyleBackColor = false;
            this.addServiceBtn.Click += new System.EventHandler(this.addServiceBtn_Click);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 62);
            this.label1.TabIndex = 77;
            this.label1.Text = "Service ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(290, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 31);
            this.label2.TabIndex = 78;
            this.label2.Text = "Service Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(697, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 31);
            this.label3.TabIndex = 79;
            this.label3.Text = "Service Price";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 513F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(276, 193);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1150, 90);
            this.tableLayoutPanel2.TabIndex = 84;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTxtBox.Font = new System.Drawing.Font("Inter Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(786, 128);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(448, 32);
            this.searchTxtBox.TabIndex = 93;
            // 
            // binBtn
            // 
            this.binBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.binBtn.Controls.Add(this.binPic);
            this.binBtn.Controls.Add(this.binLbl);
            this.binBtn.Location = new System.Drawing.Point(1252, 128);
            this.binBtn.Name = "binBtn";
            this.binBtn.Size = new System.Drawing.Size(169, 32);
            this.binBtn.TabIndex = 97;
            this.binBtn.Click += new System.EventHandler(this.binBtn_Click);
            // 
            // binPic
            // 
            this.binPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.newBin;
            this.binPic.Location = new System.Drawing.Point(112, -1);
            this.binPic.Name = "binPic";
            this.binPic.Size = new System.Drawing.Size(42, 32);
            this.binPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.binPic.TabIndex = 1;
            this.binPic.TabStop = false;
            this.toolTip1.SetToolTip(this.binPic, "Trash Bin");
            this.binPic.Click += new System.EventHandler(this.binBtn_Click);
            // 
            // binLbl
            // 
            this.binLbl.AutoSize = true;
            this.binLbl.Font = new System.Drawing.Font("Inter Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binLbl.Location = new System.Drawing.Point(13, 4);
            this.binLbl.Name = "binLbl";
            this.binLbl.Size = new System.Drawing.Size(99, 24);
            this.binLbl.TabIndex = 0;
            this.binLbl.Text = "Trash Bin";
            this.binLbl.Click += new System.EventHandler(this.binBtn_Click);
            // 
            // editService1
            // 
            this.editService1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editService1.Location = new System.Drawing.Point(351, 302);
            this.editService1.Name = "editService1";
            this.editService1.Size = new System.Drawing.Size(998, 298);
            this.editService1.TabIndex = 87;
            // 
            // addService1
            // 
            this.addService1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addService1.Location = new System.Drawing.Point(351, 302);
            this.addService1.Name = "addService1";
            this.addService1.Size = new System.Drawing.Size(998, 298);
            this.addService1.TabIndex = 9;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.Window;
            this.searchBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.search;
            this.searchBtn.Location = new System.Drawing.Point(1198, 129);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(33, 28);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchBtn.TabIndex = 94;
            this.searchBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.searchBtn, "Search");
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 911);
            this.Controls.Add(this.binBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.editService1);
            this.Controls.Add(this.addService1);
            this.Controls.Add(this.servicesContainer);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1556, 967);
            this.Name = "Services";
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.binBtn.ResumeLayout(false);
            this.binBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
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
        private System.Windows.Forms.Label dshbrdLbl;
        private System.Windows.Forms.Button addServiceBtn;
        private System.Windows.Forms.FlowLayoutPanel servicesContainer;
        private AddService addService1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private EditService editService1;
        private System.Windows.Forms.PictureBox dshbrdbtn;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Panel binBtn;
        private System.Windows.Forms.PictureBox binPic;
        private System.Windows.Forms.Label binLbl;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
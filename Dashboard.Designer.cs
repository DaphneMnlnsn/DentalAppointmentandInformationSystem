using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DentalAppointmentandInformationSystem
{
    partial class Dashboard
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.wlcmLbl = new System.Windows.Forms.Label();
            this.dshbrdLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.clndrLbl = new System.Windows.Forms.Label();
            this.monthLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logoutBtn = new System.Windows.Forms.Label();
            this.logoutPic = new System.Windows.Forms.PictureBox();
            this.servicesBtn = new System.Windows.Forms.Label();
            this.staffBtn = new System.Windows.Forms.Label();
            this.staffPic = new System.Windows.Forms.PictureBox();
            this.ptntBtn = new System.Windows.Forms.Label();
            this.patientPic = new System.Windows.Forms.PictureBox();
            this.apptclndrBtn = new System.Windows.Forms.Label();
            this.clndrPic = new System.Windows.Forms.PictureBox();
            this.doctorPic = new System.Windows.Forms.PictureBox();
            this.emNameTxtBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dshboardBtn = new System.Windows.Forms.Label();
            this.dshbrdPic = new System.Windows.Forms.PictureBox();
            this.srvcsPic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clndrPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshbrdPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srvcsPic)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.12463F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.87537F));
            this.tableLayoutPanel2.Controls.Add(this.wlcmLbl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dshbrdLbl, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(447, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1003, 71);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // wlcmLbl
            // 
            this.wlcmLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wlcmLbl.AutoSize = true;
            this.wlcmLbl.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlcmLbl.Location = new System.Drawing.Point(692, 0);
            this.wlcmLbl.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.wlcmLbl.Name = "wlcmLbl";
            this.wlcmLbl.Size = new System.Drawing.Size(291, 71);
            this.wlcmLbl.TabIndex = 1;
            this.wlcmLbl.Text = "Welcome, [name]!";
            this.wlcmLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dshbrdLbl
            // 
            this.dshbrdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dshbrdLbl.AutoSize = true;
            this.dshbrdLbl.Font = new System.Drawing.Font("Metrophobic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshbrdLbl.Location = new System.Drawing.Point(3, 0);
            this.dshbrdLbl.Name = "dshbrdLbl";
            this.dshbrdLbl.Size = new System.Drawing.Size(246, 71);
            this.dshbrdLbl.TabIndex = 0;
            this.dshbrdLbl.Text = "Dashboard";
            this.dshbrdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(447, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 731);
            this.panel1.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.clndrLbl, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.monthLbl, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1003, 70);
            this.tableLayoutPanel3.TabIndex = 26;
            // 
            // clndrLbl
            // 
            this.clndrLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clndrLbl.AutoSize = true;
            this.clndrLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.clndrLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clndrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(167)))));
            this.clndrLbl.Location = new System.Drawing.Point(20, 0);
            this.clndrLbl.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.clndrLbl.Name = "clndrLbl";
            this.clndrLbl.Size = new System.Drawing.Size(120, 70);
            this.clndrLbl.TabIndex = 15;
            this.clndrLbl.Text = "Calendar";
            this.clndrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthLbl
            // 
            this.monthLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthLbl.AutoSize = true;
            this.monthLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.monthLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(167)))));
            this.monthLbl.Location = new System.Drawing.Point(859, 0);
            this.monthLbl.Margin = new System.Windows.Forms.Padding(3, 0, 24, 0);
            this.monthLbl.Name = "monthLbl";
            this.monthLbl.Size = new System.Drawing.Size(120, 70);
            this.monthLbl.TabIndex = 16;
            this.monthLbl.Text = "Calendar";
            this.monthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(963, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "_________________________________________________________________________________" +
    "_________________________";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1003, 593);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(896, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Sat";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(760, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "Fri";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(608, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Thu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(461, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Wed";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(327, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tue";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(179, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mon";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sun";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(999, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "_________________________________________________________________________________" +
    "_____________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.logoutBtn, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.logoutPic, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.servicesBtn, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.staffBtn, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.staffPic, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ptntBtn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.patientPic, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.apptclndrBtn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.clndrPic, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.doctorPic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.emNameTxtBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dshboardBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dshbrdPic, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.srvcsPic, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 920);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.AutoSize = true;
            this.logoutBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(132, 791);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(210, 99);
            this.logoutBtn.TabIndex = 14;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // logoutPic
            // 
            this.logoutPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.logout;
            this.logoutPic.Location = new System.Drawing.Point(54, 818);
            this.logoutPic.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.logoutPic.Name = "logoutPic";
            this.logoutPic.Size = new System.Drawing.Size(43, 44);
            this.logoutPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutPic.TabIndex = 13;
            this.logoutPic.TabStop = false;
            // 
            // servicesBtn
            // 
            this.servicesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesBtn.AutoSize = true;
            this.servicesBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesBtn.Location = new System.Drawing.Point(132, 692);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(210, 99);
            this.servicesBtn.TabIndex = 12;
            this.servicesBtn.Text = "List of Services";
            this.servicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicesBtn.Click += new System.EventHandler(this.servicesBtn_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffBtn.AutoSize = true;
            this.staffBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.Location = new System.Drawing.Point(132, 593);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(210, 99);
            this.staffBtn.TabIndex = 11;
            this.staffBtn.Text = "List of Staff";
            this.staffBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // staffPic
            // 
            this.staffPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.staffs;
            this.staffPic.Location = new System.Drawing.Point(48, 612);
            this.staffPic.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.staffPic.Name = "staffPic";
            this.staffPic.Size = new System.Drawing.Size(55, 61);
            this.staffPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffPic.TabIndex = 9;
            this.staffPic.TabStop = false;
            this.staffPic.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // ptntBtn
            // 
            this.ptntBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptntBtn.AutoSize = true;
            this.ptntBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptntBtn.Location = new System.Drawing.Point(132, 494);
            this.ptntBtn.Name = "ptntBtn";
            this.ptntBtn.Size = new System.Drawing.Size(210, 99);
            this.ptntBtn.TabIndex = 8;
            this.ptntBtn.Text = "List of Patients";
            this.ptntBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ptntBtn.Click += new System.EventHandler(this.ptntBtn_Click);
            // 
            // patientPic
            // 
            this.patientPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.patients;
            this.patientPic.Location = new System.Drawing.Point(47, 513);
            this.patientPic.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.patientPic.Name = "patientPic";
            this.patientPic.Size = new System.Drawing.Size(57, 60);
            this.patientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patientPic.TabIndex = 7;
            this.patientPic.TabStop = false;
            this.patientPic.Click += new System.EventHandler(this.ptntBtn_Click);
            // 
            // apptclndrBtn
            // 
            this.apptclndrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apptclndrBtn.AutoSize = true;
            this.apptclndrBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptclndrBtn.Location = new System.Drawing.Point(132, 395);
            this.apptclndrBtn.Name = "apptclndrBtn";
            this.apptclndrBtn.Size = new System.Drawing.Size(210, 99);
            this.apptclndrBtn.TabIndex = 6;
            this.apptclndrBtn.Text = "Appointment\r\nCalendar";
            this.apptclndrBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apptclndrBtn.Click += new System.EventHandler(this.apptclndrBtn_Click);
            // 
            // clndrPic
            // 
            this.clndrPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clndrPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.calendar;
            this.clndrPic.Location = new System.Drawing.Point(50, 421);
            this.clndrPic.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.clndrPic.Name = "clndrPic";
            this.clndrPic.Size = new System.Drawing.Size(50, 46);
            this.clndrPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clndrPic.TabIndex = 5;
            this.clndrPic.TabStop = false;
            this.clndrPic.Click += new System.EventHandler(this.apptclndrBtn_Click);
            // 
            // doctorPic
            // 
            this.doctorPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.doctorPic, 2);
            this.doctorPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.profile_icon;
            this.doctorPic.Location = new System.Drawing.Point(96, 18);
            this.doctorPic.Name = "doctorPic";
            this.doctorPic.Size = new System.Drawing.Size(153, 141);
            this.doctorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doctorPic.TabIndex = 0;
            this.doctorPic.TabStop = false;
            // 
            // emNameTxtBox
            // 
            this.emNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emNameTxtBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.emNameTxtBox, 2);
            this.emNameTxtBox.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold);
            this.emNameTxtBox.Location = new System.Drawing.Point(3, 178);
            this.emNameTxtBox.Name = "emNameTxtBox";
            this.emNameTxtBox.Size = new System.Drawing.Size(339, 64);
            this.emNameTxtBox.TabIndex = 1;
            this.emNameTxtBox.Text = "label1";
            this.emNameTxtBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "______________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dshboardBtn
            // 
            this.dshboardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dshboardBtn.AutoSize = true;
            this.dshboardBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshboardBtn.Location = new System.Drawing.Point(132, 296);
            this.dshboardBtn.Name = "dshboardBtn";
            this.dshboardBtn.Size = new System.Drawing.Size(210, 99);
            this.dshboardBtn.TabIndex = 3;
            this.dshboardBtn.Text = "Dashboard";
            this.dshboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dshbrdPic
            // 
            this.dshbrdPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dshbrdPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.dashboard;
            this.dshbrdPic.Location = new System.Drawing.Point(52, 321);
            this.dshbrdPic.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.dshbrdPic.Name = "dshbrdPic";
            this.dshbrdPic.Size = new System.Drawing.Size(46, 48);
            this.dshbrdPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dshbrdPic.TabIndex = 4;
            this.dshbrdPic.TabStop = false;
            // 
            // srvcsPic
            // 
            this.srvcsPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.srvcsPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.services;
            this.srvcsPic.Location = new System.Drawing.Point(49, 715);
            this.srvcsPic.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.srvcsPic.Name = "srvcsPic";
            this.srvcsPic.Size = new System.Drawing.Size(53, 53);
            this.srvcsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.srvcsPic.TabIndex = 10;
            this.srvcsPic.TabStop = false;
            this.srvcsPic.Click += new System.EventHandler(this.servicesBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1537, 920);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1559, 976);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clndrPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshbrdPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srvcsPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Label wlcmLbl;
        private Label dshbrdLbl;
        private Panel panel1;
        private Label clndrLbl;
        private Label label2;
        private Label monthLbl;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label logoutBtn;
        private PictureBox logoutPic;
        private Label servicesBtn;
        private Label staffBtn;
        private PictureBox staffPic;
        private Label ptntBtn;
        private PictureBox patientPic;
        private Label apptclndrBtn;
        private PictureBox clndrPic;
        private PictureBox doctorPic;
        private Label emNameTxtBox;
        private Label label1;
        private Label dshboardBtn;
        private PictureBox dshbrdPic;
        private PictureBox srvcsPic;
    }
}
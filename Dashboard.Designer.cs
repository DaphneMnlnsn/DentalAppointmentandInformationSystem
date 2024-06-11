using System.Windows.Forms;

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
            this.dshbrdLbl = new System.Windows.Forms.Label();
            this.wlcmLbl = new System.Windows.Forms.Label();
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
            this.servicesBtn = new System.Windows.Forms.Label();
            this.staffBtn = new System.Windows.Forms.Label();
            this.ptntBtn = new System.Windows.Forms.Label();
            this.apptclndrBtn = new System.Windows.Forms.Label();
            this.emNameTxtBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dshboardBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.actlog = new System.Windows.Forms.Label();
            this.activitylog = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.activityPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.noNotifLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.notifContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.noNotifPic = new System.Windows.Forms.PictureBox();
            this.noNotifs = new System.Windows.Forms.PictureBox();
            this.logoutPic = new System.Windows.Forms.PictureBox();
            this.staffPic = new System.Windows.Forms.PictureBox();
            this.patientPic = new System.Windows.Forms.PictureBox();
            this.clndrPic = new System.Windows.Forms.PictureBox();
            this.doctorPic = new System.Windows.Forms.PictureBox();
            this.dshbrdPic = new System.Windows.Forms.PictureBox();
            this.srvcsPic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.notifContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noNotifPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noNotifs)).BeginInit();
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
            this.tableLayoutPanel2.Controls.Add(this.dshbrdLbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.wlcmLbl, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(396, 37);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(742, 71);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // dshbrdLbl
            // 
            this.dshbrdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dshbrdLbl.AutoSize = true;
            this.dshbrdLbl.Font = new System.Drawing.Font("Metrophobic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshbrdLbl.Location = new System.Drawing.Point(3, 0);
            this.dshbrdLbl.Name = "dshbrdLbl";
            this.dshbrdLbl.Size = new System.Drawing.Size(180, 71);
            this.dshbrdLbl.TabIndex = 0;
            this.dshbrdLbl.Text = "Dashboard";
            this.dshbrdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wlcmLbl
            // 
            this.wlcmLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wlcmLbl.AutoSize = true;
            this.wlcmLbl.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlcmLbl.Location = new System.Drawing.Point(430, 0);
            this.wlcmLbl.Margin = new System.Windows.Forms.Padding(3, 0, 21, 0);
            this.wlcmLbl.Name = "wlcmLbl";
            this.wlcmLbl.Size = new System.Drawing.Size(291, 71);
            this.wlcmLbl.TabIndex = 1;
            this.wlcmLbl.Text = "Welcome, [name]!";
            this.wlcmLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel1.Location = new System.Drawing.Point(396, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 752);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(740, 71);
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
            this.clndrLbl.Location = new System.Drawing.Point(21, 0);
            this.clndrLbl.Margin = new System.Windows.Forms.Padding(21, 0, 3, 0);
            this.clndrLbl.Name = "clndrLbl";
            this.clndrLbl.Size = new System.Drawing.Size(120, 71);
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
            this.monthLbl.Location = new System.Drawing.Point(596, 0);
            this.monthLbl.Margin = new System.Windows.Forms.Padding(3, 0, 24, 0);
            this.monthLbl.Name = "monthLbl";
            this.monthLbl.Size = new System.Drawing.Size(120, 71);
            this.monthLbl.TabIndex = 16;
            this.monthLbl.Text = "Calendar";
            this.monthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(738, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "_________________________________________________________________________________" +
    "";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 156);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 594);
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
            this.label9.Location = new System.Drawing.Point(634, 88);
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
            this.label8.Location = new System.Drawing.Point(549, 88);
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
            this.label7.Location = new System.Drawing.Point(446, 88);
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
            this.label6.Location = new System.Drawing.Point(338, 88);
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
            this.label5.Location = new System.Drawing.Point(240, 88);
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
            this.label4.Location = new System.Drawing.Point(137, 88);
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
            this.label3.Location = new System.Drawing.Point(35, 88);
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
            this.label2.Size = new System.Drawing.Size(693, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "____________________________________________________________________________";
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 912);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.AutoSize = true;
            this.logoutBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(132, 783);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(210, 98);
            this.logoutBtn.TabIndex = 14;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // servicesBtn
            // 
            this.servicesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesBtn.AutoSize = true;
            this.servicesBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesBtn.Location = new System.Drawing.Point(132, 685);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(210, 98);
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
            this.staffBtn.Location = new System.Drawing.Point(132, 587);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(210, 98);
            this.staffBtn.TabIndex = 11;
            this.staffBtn.Text = "List of Staff";
            this.staffBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // ptntBtn
            // 
            this.ptntBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptntBtn.AutoSize = true;
            this.ptntBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptntBtn.Location = new System.Drawing.Point(132, 489);
            this.ptntBtn.Name = "ptntBtn";
            this.ptntBtn.Size = new System.Drawing.Size(210, 98);
            this.ptntBtn.TabIndex = 8;
            this.ptntBtn.Text = "List of Patients";
            this.ptntBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ptntBtn.Click += new System.EventHandler(this.ptntBtn_Click);
            // 
            // apptclndrBtn
            // 
            this.apptclndrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apptclndrBtn.AutoSize = true;
            this.apptclndrBtn.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptclndrBtn.Location = new System.Drawing.Point(132, 391);
            this.apptclndrBtn.Name = "apptclndrBtn";
            this.apptclndrBtn.Size = new System.Drawing.Size(210, 98);
            this.apptclndrBtn.TabIndex = 6;
            this.apptclndrBtn.Text = "Appointment\r\nCalendar";
            this.apptclndrBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apptclndrBtn.Click += new System.EventHandler(this.apptclndrBtn_Click);
            // 
            // emNameTxtBox
            // 
            this.emNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emNameTxtBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.emNameTxtBox, 2);
            this.emNameTxtBox.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold);
            this.emNameTxtBox.Location = new System.Drawing.Point(3, 177);
            this.emNameTxtBox.Name = "emNameTxtBox";
            this.emNameTxtBox.Size = new System.Drawing.Size(339, 63);
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
            this.label1.Location = new System.Drawing.Point(3, 240);
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
            this.dshboardBtn.Location = new System.Drawing.Point(132, 293);
            this.dshboardBtn.Name = "dshboardBtn";
            this.dshboardBtn.Size = new System.Drawing.Size(210, 98);
            this.dshboardBtn.TabIndex = 3;
            this.dshboardBtn.Text = "Dashboard";
            this.dshboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.actlog);
            this.panel2.Controls.Add(this.activitylog);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.activityPanel);
            this.panel2.Location = new System.Drawing.Point(1155, 449);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 440);
            this.panel2.TabIndex = 16;
            // 
            // actlog
            // 
            this.actlog.AutoSize = true;
            this.actlog.Font = new System.Drawing.Font("Inter Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actlog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(167)))));
            this.actlog.Location = new System.Drawing.Point(10, 23);
            this.actlog.Name = "actlog";
            this.actlog.Size = new System.Drawing.Size(135, 26);
            this.actlog.TabIndex = 28;
            this.actlog.Text = "Activity Log";
            // 
            // activitylog
            // 
            this.activitylog.AutoSize = true;
            this.activitylog.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activitylog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(167)))));
            this.activitylog.Location = new System.Drawing.Point(6, 14);
            this.activitylog.Name = "activitylog";
            this.activitylog.Size = new System.Drawing.Size(0, 29);
            this.activitylog.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Location = new System.Drawing.Point(10, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(342, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "_____________________________________";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // activityPanel
            // 
            this.activityPanel.AutoScroll = true;
            this.activityPanel.Location = new System.Drawing.Point(8, 65);
            this.activityPanel.Name = "activityPanel";
            this.activityPanel.Size = new System.Drawing.Size(346, 372);
            this.activityPanel.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel3.Controls.Add(this.noNotifLbl);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.notifContainer);
            this.panel3.Location = new System.Drawing.Point(1155, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 388);
            this.panel3.TabIndex = 17;
            // 
            // noNotifLbl
            // 
            this.noNotifLbl.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noNotifLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.noNotifLbl.Location = new System.Drawing.Point(64, 246);
            this.noNotifLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noNotifLbl.Name = "noNotifLbl";
            this.noNotifLbl.Size = new System.Drawing.Size(238, 54);
            this.noNotifLbl.TabIndex = 29;
            this.noNotifLbl.Text = "There are no \r\nupcoming appointments";
            this.noNotifLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Inter Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(167)))));
            this.label11.Location = new System.Drawing.Point(10, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 26);
            this.label11.TabIndex = 28;
            this.label11.Text = "Upcoming Appointments";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(167)))));
            this.label14.Location = new System.Drawing.Point(6, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 29);
            this.label14.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.Location = new System.Drawing.Point(10, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(342, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "_____________________________________";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // notifContainer
            // 
            this.notifContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notifContainer.AutoScroll = true;
            this.notifContainer.Controls.Add(this.noNotifPic);
            this.notifContainer.Controls.Add(this.noNotifs);
            this.notifContainer.Location = new System.Drawing.Point(8, 55);
            this.notifContainer.Name = "notifContainer";
            this.notifContainer.Size = new System.Drawing.Size(346, 329);
            this.notifContainer.TabIndex = 27;
            // 
            // noNotifPic
            // 
            this.noNotifPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.notifs;
            this.noNotifPic.Location = new System.Drawing.Point(4, 5);
            this.noNotifPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noNotifPic.Name = "noNotifPic";
            this.noNotifPic.Size = new System.Drawing.Size(340, 323);
            this.noNotifPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noNotifPic.TabIndex = 1;
            this.noNotifPic.TabStop = false;
            // 
            // noNotifs
            // 
            this.noNotifs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noNotifs.Location = new System.Drawing.Point(4, 338);
            this.noNotifs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noNotifs.Name = "noNotifs";
            this.noNotifs.Size = new System.Drawing.Size(255, 0);
            this.noNotifs.TabIndex = 0;
            this.noNotifs.TabStop = false;
            // 
            // logoutPic
            // 
            this.logoutPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.logout;
            this.logoutPic.Location = new System.Drawing.Point(54, 810);
            this.logoutPic.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.logoutPic.Name = "logoutPic";
            this.logoutPic.Size = new System.Drawing.Size(42, 43);
            this.logoutPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutPic.TabIndex = 13;
            this.logoutPic.TabStop = false;
            // 
            // staffPic
            // 
            this.staffPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.staffs;
            this.staffPic.Location = new System.Drawing.Point(47, 605);
            this.staffPic.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.staffPic.Name = "staffPic";
            this.staffPic.Size = new System.Drawing.Size(56, 62);
            this.staffPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffPic.TabIndex = 9;
            this.staffPic.TabStop = false;
            this.staffPic.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // patientPic
            // 
            this.patientPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.patients;
            this.patientPic.Location = new System.Drawing.Point(46, 508);
            this.patientPic.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.patientPic.Name = "patientPic";
            this.patientPic.Size = new System.Drawing.Size(57, 60);
            this.patientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patientPic.TabIndex = 7;
            this.patientPic.TabStop = false;
            this.patientPic.Click += new System.EventHandler(this.ptntBtn_Click);
            // 
            // clndrPic
            // 
            this.clndrPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clndrPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.calendar;
            this.clndrPic.Location = new System.Drawing.Point(50, 417);
            this.clndrPic.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
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
            this.doctorPic.Location = new System.Drawing.Point(96, 17);
            this.doctorPic.Name = "doctorPic";
            this.doctorPic.Size = new System.Drawing.Size(153, 142);
            this.doctorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doctorPic.TabIndex = 0;
            this.doctorPic.TabStop = false;
            // 
            // dshbrdPic
            // 
            this.dshbrdPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dshbrdPic.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.dashboard;
            this.dshbrdPic.Location = new System.Drawing.Point(52, 318);
            this.dshbrdPic.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
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
            this.srvcsPic.Location = new System.Drawing.Point(49, 708);
            this.srvcsPic.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.srvcsPic.Name = "srvcsPic";
            this.srvcsPic.Size = new System.Drawing.Size(52, 52);
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
            this.ClientSize = new System.Drawing.Size(1534, 912);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1556, 968);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.notifContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noNotifPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noNotifs)).EndInit();
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
        private Panel panel2;
        private Label activitylog;
        private FlowLayoutPanel activityPanel;
        private Label label12;
        private Label actlog;
        private Panel panel3;
        private Label label11;
        private FlowLayoutPanel notifContainer;
        private Label label13;
        private Label label14;
        private PictureBox noNotifs;
        private Label noNotifLbl;
        private PictureBox noNotifPic;
    }
}
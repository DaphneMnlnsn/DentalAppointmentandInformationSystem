namespace DentalAppointmentandInformationSystem
{
    partial class ServicesListArchived
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.restoreBtn = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.servicePrice = new System.Windows.Forms.Label();
            this.serviceName = new System.Windows.Forms.Label();
            this.serviceID = new System.Windows.Forms.Label();
            this.srvcDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-10, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 74);
            this.panel1.TabIndex = 95;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.delete;
            this.pictureBox1.Location = new System.Drawing.Point(1086, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Delete");
            // 
            // restoreBtn
            // 
            this.restoreBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.restoreBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.restore;
            this.restoreBtn.Location = new System.Drawing.Point(1010, 9);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(50, 45);
            this.restoreBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restoreBtn.TabIndex = 83;
            this.restoreBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.restoreBtn, "Restore");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.Controls.Add(this.servicePrice, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.serviceName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.serviceID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.srvcDuration, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.restoreBtn, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 64);
            this.tableLayoutPanel1.TabIndex = 96;
            // 
            // servicePrice
            // 
            this.servicePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.servicePrice.AutoSize = true;
            this.servicePrice.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.servicePrice.Location = new System.Drawing.Point(616, 20);
            this.servicePrice.Name = "servicePrice";
            this.servicePrice.Size = new System.Drawing.Size(139, 24);
            this.servicePrice.TabIndex = 79;
            this.servicePrice.Text = "Service Price";
            // 
            // serviceName
            // 
            this.serviceName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serviceName.AutoSize = true;
            this.serviceName.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.serviceName.Location = new System.Drawing.Point(267, 20);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(145, 24);
            this.serviceName.TabIndex = 78;
            this.serviceName.Text = "Service Name";
            // 
            // serviceID
            // 
            this.serviceID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serviceID.AutoSize = true;
            this.serviceID.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.serviceID.Location = new System.Drawing.Point(8, 8);
            this.serviceID.Name = "serviceID";
            this.serviceID.Size = new System.Drawing.Size(84, 48);
            this.serviceID.TabIndex = 77;
            this.serviceID.Text = "Service ID";
            this.serviceID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srvcDuration
            // 
            this.srvcDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.srvcDuration.AutoSize = true;
            this.srvcDuration.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.srvcDuration.Location = new System.Drawing.Point(809, 8);
            this.srvcDuration.Name = "srvcDuration";
            this.srvcDuration.Size = new System.Drawing.Size(171, 48);
            this.srvcDuration.TabIndex = 82;
            this.srvcDuration.Text = "Service Duration (hour)";
            this.srvcDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServicesListArchived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServicesListArchived";
            this.Size = new System.Drawing.Size(1150, 69);
            this.Load += new System.EventHandler(this.ServicesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label servicePrice;
        private System.Windows.Forms.Label serviceName;
        private System.Windows.Forms.Label serviceID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label srvcDuration;
        private System.Windows.Forms.PictureBox restoreBtn;
    }
}
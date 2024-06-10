namespace DentalAppointmentandInformationSystem
{
    partial class ServicesList
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.servicePrice = new System.Windows.Forms.Label();
            this.serviceName = new System.Windows.Forms.Label();
            this.serviceID = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.srvcDuration = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.Controls.Add(this.servicePrice, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.serviceName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.serviceID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteBtn, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.editBtn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.srvcDuration, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1150, 64);
            this.tableLayoutPanel2.TabIndex = 85;
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
            // editBtn
            // 
            this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.edit;
            this.editBtn.Location = new System.Drawing.Point(1010, 9);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(50, 45);
            this.editBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editBtn.TabIndex = 80;
            this.editBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.editBtn, "Edit");
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.delete;
            this.deleteBtn.Location = new System.Drawing.Point(1086, 9);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(50, 45);
            this.deleteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteBtn.TabIndex = 81;
            this.deleteBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.deleteBtn, "Delete");
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-10, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 74);
            this.panel1.TabIndex = 95;
            // 
            // srvcDuration
            // 
            this.srvcDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.srvcDuration.AutoSize = true;
            this.srvcDuration.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.srvcDuration.Location = new System.Drawing.Point(807, 8);
            this.srvcDuration.Name = "srvcDuration";
            this.srvcDuration.Size = new System.Drawing.Size(176, 48);
            this.srvcDuration.TabIndex = 82;
            this.srvcDuration.Text = "Service Duration (hour)";
            this.srvcDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServicesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServicesList";
            this.Size = new System.Drawing.Size(1150, 69);
            this.Load += new System.EventHandler(this.ServicesList_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label servicePrice;
        private System.Windows.Forms.Label serviceName;
        private System.Windows.Forms.Label serviceID;
        private System.Windows.Forms.PictureBox editBtn;
        private System.Windows.Forms.PictureBox deleteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label srvcDuration;
    }
}
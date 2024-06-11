namespace DentalAppointmentandInformationSystem
{
    partial class DashboardDaysNotBlank
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
            this.dayLbl = new System.Windows.Forms.Label();
            this.eventLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayLbl
            // 
            this.dayLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dayLbl.AutoSize = true;
            this.dayLbl.Font = new System.Drawing.Font("Inter Medium", 10F, System.Drawing.FontStyle.Bold);
            this.dayLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.dayLbl.Location = new System.Drawing.Point(3, 0);
            this.dayLbl.Name = "dayLbl";
            this.dayLbl.Size = new System.Drawing.Size(83, 24);
            this.dayLbl.TabIndex = 1;
            this.dayLbl.Text = "day no.";
            this.dayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dayLbl.Click += new System.EventHandler(this.DashboardDaysNotBlank_Click);
            // 
            // eventLbl
            // 
            this.eventLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eventLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.eventLbl.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.eventLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))));
            this.eventLbl.Location = new System.Drawing.Point(0, 40);
            this.eventLbl.Margin = new System.Windows.Forms.Padding(0);
            this.eventLbl.Name = "eventLbl";
            this.eventLbl.Size = new System.Drawing.Size(89, 36);
            this.eventLbl.TabIndex = 2;
            this.eventLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eventLbl.Click += new System.EventHandler(this.DashboardDaysNotBlank_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dayLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.eventLbl, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.89189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.10811F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(89, 96);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.DashboardDaysNotBlank_Click);
            // 
            // DashboardDaysNotBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardDaysNotBlank";
            this.Size = new System.Drawing.Size(95, 96);
            this.Load += new System.EventHandler(this.DashboardDaysNotBlank_Load);
            this.Click += new System.EventHandler(this.DashboardDaysNotBlank_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dayLbl;
        private System.Windows.Forms.Label eventLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
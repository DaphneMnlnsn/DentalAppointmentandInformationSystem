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
            this.dayLbl.Font = new System.Drawing.Font("Inter Medium", 11F, System.Drawing.FontStyle.Bold);
            this.dayLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.dayLbl.Location = new System.Drawing.Point(3, 0);
            this.dayLbl.Name = "dayLbl";
            this.dayLbl.Size = new System.Drawing.Size(125, 25);
            this.dayLbl.TabIndex = 1;
            this.dayLbl.Text = "day no.";
            this.dayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventLbl
            // 
            this.eventLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventLbl.AutoSize = true;
            this.eventLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.eventLbl.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.eventLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))));
            this.eventLbl.Location = new System.Drawing.Point(3, 25);
            this.eventLbl.Name = "eventLbl";
            this.eventLbl.Size = new System.Drawing.Size(125, 63);
            this.eventLbl.TabIndex = 2;
            this.eventLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dayLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.eventLbl, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.40909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.59091F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(131, 88);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // DashboardDaysNotBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DashboardDaysNotBlank";
            this.Size = new System.Drawing.Size(137, 94);
            this.Load += new System.EventHandler(this.DashboardDaysNotBlank_Load);
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
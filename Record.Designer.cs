namespace DentalAppointmentandInformationSystem
{
    partial class Record
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.records_status = new System.Windows.Forms.Label();
            this.records_price = new System.Windows.Forms.Label();
            this.records_tooth = new System.Windows.Forms.Label();
            this.records_date = new System.Windows.Forms.Label();
            this.records_treat = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.Controls.Add(this.records_treat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.records_status, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.records_price, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.records_tooth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.records_date, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1319, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.Record_Click);
            // 
            // records_status
            // 
            this.records_status.AutoSize = true;
            this.records_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.records_status.Font = new System.Drawing.Font("Inter Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.records_status.Location = new System.Drawing.Point(1155, 0);
            this.records_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.records_status.Name = "records_status";
            this.records_status.Size = new System.Drawing.Size(160, 43);
            this.records_status.TabIndex = 3;
            this.records_status.Text = "status";
            this.records_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.records_status.Click += new System.EventHandler(this.Record_Click);
            // 
            // records_price
            // 
            this.records_price.AutoSize = true;
            this.records_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.records_price.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.records_price.Location = new System.Drawing.Point(861, 0);
            this.records_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.records_price.Name = "records_price";
            this.records_price.Size = new System.Drawing.Size(286, 43);
            this.records_price.TabIndex = 2;
            this.records_price.Text = "price";
            this.records_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.records_price.Click += new System.EventHandler(this.Record_Click);
            // 
            // records_tooth
            // 
            this.records_tooth.AutoSize = true;
            this.records_tooth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.records_tooth.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.records_tooth.Location = new System.Drawing.Point(642, 0);
            this.records_tooth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.records_tooth.Name = "records_tooth";
            this.records_tooth.Size = new System.Drawing.Size(211, 43);
            this.records_tooth.TabIndex = 1;
            this.records_tooth.Text = "tooth #";
            this.records_tooth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.records_tooth.Click += new System.EventHandler(this.Record_Click);
            // 
            // records_date
            // 
            this.records_date.AutoSize = true;
            this.records_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.records_date.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.records_date.Location = new System.Drawing.Point(4, 0);
            this.records_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.records_date.Name = "records_date";
            this.records_date.Size = new System.Drawing.Size(225, 43);
            this.records_date.TabIndex = 0;
            this.records_date.Text = "date";
            this.records_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.records_date.Click += new System.EventHandler(this.Record_Click);
            // 
            // records_treat
            // 
            this.records_treat.AutoSize = true;
            this.records_treat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.records_treat.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.records_treat.Location = new System.Drawing.Point(237, 0);
            this.records_treat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.records_treat.Name = "records_treat";
            this.records_treat.Size = new System.Drawing.Size(397, 43);
            this.records_treat.TabIndex = 4;
            this.records_treat.Text = "treatment";
            this.records_treat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Record";
            this.Size = new System.Drawing.Size(1319, 45);
            this.Click += new System.EventHandler(this.Record_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label records_status;
        private System.Windows.Forms.Label records_price;
        private System.Windows.Forms.Label records_tooth;
        private System.Windows.Forms.Label records_date;
        private System.Windows.Forms.Label records_treat;
    }
}
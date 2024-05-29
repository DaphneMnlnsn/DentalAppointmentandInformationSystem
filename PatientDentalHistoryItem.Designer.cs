namespace DentalAppointmentandInformationSystem
{
    partial class PatientDentalHistoryItem
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dentistName = new System.Windows.Forms.Label();
            this.treatmentName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.00278F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 583F));
            this.tableLayoutPanel3.Controls.Add(this.dentistName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.treatmentName, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1150, 48);
            this.tableLayoutPanel3.TabIndex = 95;
            // 
            // dentistName
            // 
            this.dentistName.AutoSize = true;
            this.dentistName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dentistName.Font = new System.Drawing.Font("Inter", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dentistName.ForeColor = System.Drawing.Color.Black;
            this.dentistName.Location = new System.Drawing.Point(571, 0);
            this.dentistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dentistName.Name = "dentistName";
            this.dentistName.Size = new System.Drawing.Size(575, 48);
            this.dentistName.TabIndex = 3;
            this.dentistName.Text = "DENTIST";
            this.dentistName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dentistName.Click += new System.EventHandler(this.PatientDentalHistoryItem_Click);
            // 
            // treatmentName
            // 
            this.treatmentName.AutoSize = true;
            this.treatmentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treatmentName.Font = new System.Drawing.Font("Inter", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentName.ForeColor = System.Drawing.Color.Black;
            this.treatmentName.Location = new System.Drawing.Point(4, 0);
            this.treatmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.treatmentName.Name = "treatmentName";
            this.treatmentName.Size = new System.Drawing.Size(559, 48);
            this.treatmentName.TabIndex = 1;
            this.treatmentName.Text = "TREATMENT";
            this.treatmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.treatmentName.Click += new System.EventHandler(this.PatientDentalHistoryItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 74);
            this.panel1.TabIndex = 96;
            // 
            // PatientDentalHistoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PatientDentalHistoryItem";
            this.Size = new System.Drawing.Size(1153, 55);
            this.Click += new System.EventHandler(this.PatientDentalHistoryItem_Click);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label dentistName;
        private System.Windows.Forms.Label treatmentName;
        private System.Windows.Forms.Panel panel1;
    }
}
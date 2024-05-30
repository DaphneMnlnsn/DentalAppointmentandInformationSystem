namespace DentalAppointmentandInformationSystem
{
    partial class PatientDetailsAttachment
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
            this.displayFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayFile
            // 
            this.displayFile.AutoSize = true;
            this.displayFile.BackColor = System.Drawing.Color.Gainsboro;
            this.displayFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.displayFile.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayFile.Location = new System.Drawing.Point(4, 5);
            this.displayFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayFile.Name = "displayFile";
            this.displayFile.Size = new System.Drawing.Size(148, 21);
            this.displayFile.TabIndex = 97;
            this.displayFile.Text = "<file goes here>";
            this.displayFile.Click += new System.EventHandler(this.displayFile_Click);
            // 
            // PatientDetailsAttachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.displayFile);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PatientDetailsAttachment";
            this.Size = new System.Drawing.Size(250, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayFile;
    }
}
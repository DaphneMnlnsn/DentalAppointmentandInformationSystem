﻿namespace DentalAppointmentandInformationSystem
{
    partial class UserControlDaysArchived
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
            this.lbldays = new System.Windows.Forms.Label();
            this.lblsched = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldays
            // 
            this.lbldays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.Location = new System.Drawing.Point(68, 17);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(36, 25);
            this.lbldays.TabIndex = 0;
            this.lbldays.Text = "00";
            this.lbldays.Click += new System.EventHandler(this.UserControlDays_Click);
            // 
            // lblsched
            // 
            this.lblsched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsched.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsched.Location = new System.Drawing.Point(0, 51);
            this.lblsched.Name = "lblsched";
            this.lblsched.Size = new System.Drawing.Size(165, 51);
            this.lblsched.TabIndex = 1;
            this.lblsched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblsched.Click += new System.EventHandler(this.UserControlDays_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblsched);
            this.Controls.Add(this.lbldays);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(165, 102);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblsched;
    }
}
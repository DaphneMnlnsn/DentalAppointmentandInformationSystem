namespace DentalAppointmentandInformationSystem
{
    partial class activityLog
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
            this.actText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // actText
            // 
            this.actText.AutoSize = true;
            this.actText.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actText.Location = new System.Drawing.Point(15, 11);
            this.actText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actText.MaximumSize = new System.Drawing.Size(367, 0);
            this.actText.Name = "actText";
            this.actText.Size = new System.Drawing.Size(72, 21);
            this.actText.TabIndex = 0;
            this.actText.Text = "activity";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(167)))));
            this.panel1.Location = new System.Drawing.Point(-4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 52);
            this.panel1.TabIndex = 1;
            // 
            // activityLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actText);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(374, 0);
            this.MinimumSize = new System.Drawing.Size(374, 60);
            this.Name = "activityLog";
            this.Size = new System.Drawing.Size(374, 60);
            this.Load += new System.EventHandler(this.activityLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label actText;
        private System.Windows.Forms.Panel panel1;
    }
}
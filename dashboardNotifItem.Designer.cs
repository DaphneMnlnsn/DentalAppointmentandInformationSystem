namespace DentalAppointmentandInformationSystem
{
    partial class dashboardNotifItem
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
            this.notifText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // notifText
            // 
            this.notifText.AutoSize = true;
            this.notifText.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifText.Location = new System.Drawing.Point(15, 11);
            this.notifText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notifText.MaximumSize = new System.Drawing.Size(300, 0);
            this.notifText.Name = "notifText";
            this.notifText.Size = new System.Drawing.Size(107, 21);
            this.notifText.TabIndex = 0;
            this.notifText.Text = "notification";
            this.notifText.Click += new System.EventHandler(this.notifText_Click);
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
            // dashboardNotifItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notifText);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(374, 0);
            this.MinimumSize = new System.Drawing.Size(374, 60);
            this.Name = "dashboardNotifItem";
            this.Size = new System.Drawing.Size(374, 60);
            this.Load += new System.EventHandler(this.dashboardNotifItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notifText;
        private System.Windows.Forms.Panel panel1;
    }
}
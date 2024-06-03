namespace DentalAppointmentandInformationSystem
{
    partial class PatientDetailsAttachmentArchived
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
            this.displayFile = new System.Windows.Forms.Label();
            this.deleteFile = new System.Windows.Forms.Label();
            this.restoreBtn = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // displayFile
            // 
            this.displayFile.AutoSize = true;
            this.displayFile.BackColor = System.Drawing.Color.Gainsboro;
            this.displayFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.displayFile.Font = new System.Drawing.Font("Inter", 11F);
            this.displayFile.Location = new System.Drawing.Point(4, 17);
            this.displayFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayFile.Name = "displayFile";
            this.displayFile.Size = new System.Drawing.Size(183, 26);
            this.displayFile.TabIndex = 97;
            this.displayFile.Text = "<file goes here>";
            this.displayFile.Click += new System.EventHandler(this.displayFile_Click);
            // 
            // deleteFile
            // 
            this.deleteFile.AutoSize = true;
            this.deleteFile.BackColor = System.Drawing.Color.Gainsboro;
            this.deleteFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteFile.Font = new System.Drawing.Font("Metrophobic", 16F);
            this.deleteFile.Location = new System.Drawing.Point(314, 0);
            this.deleteFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(36, 45);
            this.deleteFile.TabIndex = 98;
            this.deleteFile.Text = "x";
            this.deleteFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.deleteFile, "Delete File Permanently");
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.restoreBtn.Image = global::DentalAppointmentandInformationSystem.Properties.Resources.restore;
            this.restoreBtn.Location = new System.Drawing.Point(269, 8);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(44, 44);
            this.restoreBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restoreBtn.TabIndex = 99;
            this.restoreBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.restoreBtn, "Restore File");
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // PatientDetailsAttachmentArchived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.deleteFile);
            this.Controls.Add(this.displayFile);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PatientDetailsAttachmentArchived";
            this.Size = new System.Drawing.Size(350, 65);
            this.Click += new System.EventHandler(this.displayFile_Click);
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayFile;
        private System.Windows.Forms.Label deleteFile;
        private System.Windows.Forms.PictureBox restoreBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
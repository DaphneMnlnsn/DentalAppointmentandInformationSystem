﻿namespace DentalAppointmentandInformationSystem
{
    partial class EditService
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.srvcNameTxtBox = new System.Windows.Forms.TextBox();
            this.srvcPriceTxtBox = new System.Windows.Forms.TextBox();
            this.saveSrvcBtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.srvcDuration = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.srvcNameTxtBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.srvcPriceTxtBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.saveSrvcBtn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cancelbtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.srvcDuration, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.86555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.13445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(999, 339);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(428, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 78;
            this.label1.Text = "Edit Service";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "SERVICE NAME *";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 21);
            this.label2.TabIndex = 80;
            this.label2.Text = "SERVICE MINIMUM PRICE*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // srvcNameTxtBox
            // 
            this.srvcNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srvcNameTxtBox.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srvcNameTxtBox.Location = new System.Drawing.Point(40, 119);
            this.srvcNameTxtBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.srvcNameTxtBox.MaxLength = 50;
            this.srvcNameTxtBox.Name = "srvcNameTxtBox";
            this.srvcNameTxtBox.Size = new System.Drawing.Size(430, 32);
            this.srvcNameTxtBox.TabIndex = 81;
            // 
            // srvcPriceTxtBox
            // 
            this.srvcPriceTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srvcPriceTxtBox.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srvcPriceTxtBox.Location = new System.Drawing.Point(529, 119);
            this.srvcPriceTxtBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.srvcPriceTxtBox.Name = "srvcPriceTxtBox";
            this.srvcPriceTxtBox.Size = new System.Drawing.Size(430, 32);
            this.srvcPriceTxtBox.TabIndex = 82;
            // 
            // saveSrvcBtn
            // 
            this.saveSrvcBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveSrvcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.saveSrvcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSrvcBtn.Font = new System.Drawing.Font("Inter", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSrvcBtn.ForeColor = System.Drawing.Color.White;
            this.saveSrvcBtn.Location = new System.Drawing.Point(154, 259);
            this.saveSrvcBtn.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.saveSrvcBtn.Name = "saveSrvcBtn";
            this.saveSrvcBtn.Size = new System.Drawing.Size(221, 49);
            this.saveSrvcBtn.TabIndex = 83;
            this.saveSrvcBtn.Text = "Save";
            this.saveSrvcBtn.UseVisualStyleBackColor = false;
            this.saveSrvcBtn.Click += new System.EventHandler(this.saveSrvcBtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelbtn.BackColor = System.Drawing.Color.Gray;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Inter", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(643, 259);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(221, 49);
            this.cancelbtn.TabIndex = 86;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(471, 21);
            this.label4.TabIndex = 87;
            this.label4.Text = "SERVICE DURATION (hours) *";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // srvcDuration
            // 
            this.srvcDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srvcDuration.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srvcDuration.Location = new System.Drawing.Point(40, 195);
            this.srvcDuration.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.srvcDuration.MaxLength = 50;
            this.srvcDuration.Name = "srvcDuration";
            this.srvcDuration.Size = new System.Drawing.Size(430, 32);
            this.srvcDuration.TabIndex = 88;
            // 
            // EditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditService";
            this.Size = new System.Drawing.Size(998, 342);
            this.Load += new System.EventHandler(this.EditService_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button saveSrvcBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox srvcNameTxtBox;
        private System.Windows.Forms.TextBox srvcPriceTxtBox;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox srvcDuration;
    }
}

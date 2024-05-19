namespace DentalAppointmentandInformationSystem
{
    partial class AddService
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
            this.saveStaffBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.srvcNameTxtBox = new System.Windows.Forms.TextBox();
            this.srvcPriceTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.saveStaffBtn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cancelBtn, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // saveStaffBtn
            // 
            this.saveStaffBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveStaffBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.saveStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveStaffBtn.Font = new System.Drawing.Font("Inter", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveStaffBtn.ForeColor = System.Drawing.Color.White;
            this.saveStaffBtn.Location = new System.Drawing.Point(154, 221);
            this.saveStaffBtn.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.saveStaffBtn.Name = "saveStaffBtn";
            this.saveStaffBtn.Size = new System.Drawing.Size(221, 49);
            this.saveStaffBtn.TabIndex = 83;
            this.saveStaffBtn.Text = "Save";
            this.saveStaffBtn.UseVisualStyleBackColor = false;
            this.saveStaffBtn.Click += new System.EventHandler(this.saveServiceBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(427, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 78;
            this.label1.Text = "Add Service";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 21);
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
            this.label2.Location = new System.Drawing.Point(525, 104);
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
            this.srvcNameTxtBox.Location = new System.Drawing.Point(40, 128);
            this.srvcNameTxtBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.srvcNameTxtBox.Name = "srvcNameTxtBox";
            this.srvcNameTxtBox.Size = new System.Drawing.Size(430, 32);
            this.srvcNameTxtBox.TabIndex = 81;
            // 
            // srvcPriceTxtBox
            // 
            this.srvcPriceTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srvcPriceTxtBox.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srvcPriceTxtBox.Location = new System.Drawing.Point(530, 128);
            this.srvcPriceTxtBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.srvcPriceTxtBox.Name = "srvcPriceTxtBox";
            this.srvcPriceTxtBox.Size = new System.Drawing.Size(430, 32);
            this.srvcPriceTxtBox.TabIndex = 82;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelBtn.BackColor = System.Drawing.Color.Gray;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Inter", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(644, 221);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(221, 49);
            this.cancelBtn.TabIndex = 85;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddService";
            this.Size = new System.Drawing.Size(998, 298);
            this.Load += new System.EventHandler(this.AddService_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox srvcNameTxtBox;
        private System.Windows.Forms.TextBox srvcPriceTxtBox;
        private System.Windows.Forms.Button saveStaffBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}

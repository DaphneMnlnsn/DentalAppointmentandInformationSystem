﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalAppointmentandInformationSystem
{
    public partial class PatientDetailsAttachment : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;
        string attachmentSelected;
        public PatientDetailsAttachment()
        {
            InitializeComponent();
            constring = v.getConnection;
        }
        public void setAttachment(string attachmentID, string file)
        {
            this.attachmentSelected = attachmentID;
            displayFile.Text = file;
        }

        private void displayFile_Click(object sender, EventArgs e)
        {
            v.getsetattachmentSelected = attachmentSelected;
            AttachmentDisplay fileWindow = new AttachmentDisplay();
            fileWindow.Show();
            fileWindow.DisplayAttachedFile(v.getsetattachmentSelected);
        }

        private void deleteFile_Click(object sender, EventArgs e)
        {
            v.getsetattachmentSelected = attachmentSelected;
            constring.Open();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this service?\nThis will be moved to the Trash Bin/Archives!", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("UPDATE [File] SET status = 0 WHERE file_id = '" + v.getsetattachmentSelected + "'", constring);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("File successfully deleted!");
                    constring.Close();
                    PatientDetails pd = new PatientDetails();
                    pd.Show();
                }
            }
            constring.Close();
        }
    }
}
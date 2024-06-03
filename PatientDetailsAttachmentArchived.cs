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
    public partial class PatientDetailsAttachmentArchived : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;
        string attachmentSelected;
        public PatientDetailsAttachmentArchived()
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
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    reader1.Close();
                    v.getsetattachmentSelected = attachmentSelected;
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this file permanently?\nYou will not be able to retrieve this!", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlCommand cmdd = new SqlCommand("DELETE FROM [File] WHERE file_id = '" + v.getsetattachmentSelected + "'", constring);
                        if (cmdd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("File permanently deleted!");
                            constring.Close();
                            this.ParentForm.Hide();
                            FileArchives pd = new FileArchives();
                            pd.Show();
                        }
                    }
                    constring.Close();
                }
                else
                {
                    MessageBox.Show("You do not have the authorization to delete patient files!");
                    constring.Close();
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    reader1.Close();
                    v.getsetattachmentSelected = attachmentSelected;
                    DialogResult dialogResult = MessageBox.Show("Restore this patient file?", "Confirm Restore", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query2 = "UPDATE [File] SET status = 1 WHERE file_id ='" + v.getsetattachmentSelected + "';";
                        SqlCommand cmd2 = new SqlCommand(query2, constring);
                        cmd2.CommandText = query2;
                        if (cmd2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("File successfully restored!");
                            constring.Close();
                            this.ParentForm.Hide();
                            FileArchives ptd = new FileArchives();
                            ptd.Show();
                        }
                    }
                    constring.Close();
                }
                else
                {
                    MessageBox.Show("You do not have the authorization to restore patient files!");
                    constring.Close();
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            
        }
    }
}
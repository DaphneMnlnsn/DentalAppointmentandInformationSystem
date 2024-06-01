using System;
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
            v.getsetattachmentSelected = attachmentSelected;
            constring.Open();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this service permanently?\nYou will not be able to retrieve this!", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [File] WHERE file_id = '" + v.getsetattachmentSelected + "'", constring);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("File permanently deleted!");
                    constring.Close();
                    FileArchives pd = new FileArchives();
                    pd.Show();
                }
            }
            constring.Close();
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            v.getsetattachmentSelected = attachmentSelected;
            constring.Open();
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
                    FileArchives ptd = new FileArchives();
                    ptd.Show();
                    this.ParentForm.Hide();
                }
            }
            constring.Close();
        }
    }
}
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
            //Displaying file
            v.getsetattachmentSelected = attachmentSelected;
            AttachmentDisplay fileWindow = new AttachmentDisplay();
            fileWindow.Show();
            fileWindow.DisplayAttachedFile(v.getsetattachmentSelected);
        }

        private void deleteFile_Click(object sender, EventArgs e)
        {
            //Deleting file
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
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this file?\nThis will be moved to the Trash Bin/Archives!", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlCommand cmdd = new SqlCommand("UPDATE [File] SET status = 0 WHERE file_id = '" + v.getsetattachmentSelected + "'", constring);
                        if (cmdd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("File successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string queryAct = "INSERT INTO Activity_Log VALUES('" + v.getsetloggedIn + "','" + DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")) + "','archived a file of patient "
                                + v.getsetpatientSelected + "')";

                            SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                            cmdAct.CommandText = queryAct;
                            cmdAct.ExecuteNonQuery();
                            constring.Close();
                            this.ParentForm.Hide();
                            PatientDetails pd = new PatientDetails();
                            pd.Show();
                        }
                    }
                    constring.Close();
                }
                else
                {
                    MessageBox.Show("You do not have authorization to open this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
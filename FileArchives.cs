using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalAppointmentandInformationSystem
{
    public partial class FileArchives : Form
    {
        Variables v = new Variables();
        SqlConnection constring;

        public FileArchives()
        {
            InitializeComponent();
            constring = v.getConnection;
        }
        private void FileArchives_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FileArchives_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            displayPatient();
        }

        private void displayPatient()
        {
            constring.Open();
            string sql = "SELECT * FROM [File] WHERE status = 0 AND patient_id = " + v.getsetpatientSelected;
            DataTable files = new DataTable("files");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(files);
            if (files.Rows.Count <= 0)
            {
                emptyPic.Visible = true;
                emptyLbl.Visible = true;
            }
            else
            {
                emptyPic.Visible = false;
                emptyLbl.Visible = false;
            }
            foreach (DataRow row in files.Rows)
            {
                 PatientDetailsAttachmentArchived pda = new PatientDetailsAttachmentArchived();
                 pda.setAttachment(row["file_id"].ToString(), row["file_name"].ToString());
                 attachmentContainer.Controls.Add(pda);
            }
            constring.Close();
        }

        private void clndrBtn_Click(object sender, EventArgs e)
        {
            CalendarArchives clndr = new CalendarArchives();
            clndr.Show();
            this.Hide();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    constring.Close();
                    StaffArchives stf = new StaffArchives();
                    stf.Show();
                    this.Hide();
                }
                else
                {
                    constring.Close();
                    MessageBox.Show("You do not have authorization to open this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }

        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            ServiceArchives srvcs = new ServiceArchives();
            srvcs.Show();
            this.Hide();
        }

        private void dshbrdBtn_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            PatientDetails ptnt = new PatientDetails();
            ptnt.Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            constring.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [File]] WHERE (file_id LIKE @FileID OR file_name LIKE @FileName"
                + " OR file_path LIKE @FilePath) AND status = 0 AND patient_id = " + v.getsetpatientSelected, constring))
            {
                cmd.Parameters.AddWithValue("FileID", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("FileName", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("FilePath", string.Format("%{0}%", searchTxtBox.Text));

                string sql = "SELECT * FROM [File] WHERE status = 0 AND patient_id = " + v.getsetpatientSelected;
                DataTable files = new DataTable("files");
                SqlDataAdapter da = new SqlDataAdapter(sql, constring);
                da.Fill(files);
                attachmentContainer.Controls.Clear();
                if (files.Rows.Count <= 0)
                {
                    emptyPic.Visible = true;
                    emptyLbl.Visible = true;
                }
                else
                {
                    emptyPic.Visible = false;
                    emptyLbl.Visible = false;
                }
                foreach (DataRow row in files.Rows)
                {
                    PatientDetailsAttachmentArchived pda = new PatientDetailsAttachmentArchived();
                    pda.setAttachment(row["file_id"].ToString(), row["file_name"].ToString());
                    attachmentContainer.Controls.Add(pda);
                }
                constring.Close();
            }
        }
    }
}
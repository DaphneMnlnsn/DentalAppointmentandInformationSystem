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
    public partial class Patients : Form
    {
        Variables v = new Variables();
        SqlConnection constring;

        public Patients()
        {
            InitializeComponent();
            constring = v.getConnection;
        }
        private void Patients_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            displayPatient();
        }

        private void displayPatient()
        {
            constring.Open();
            string sql = "SELECT * FROM Patient WHERE status = 1";
            DataTable patients = new DataTable("patients");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(patients);
            if (patients.Rows.Count <= 0)
            {
                emptyPic.Visible = true;
                emptyLbl.Visible = true;
            }
            else
            {
                emptyPic.Visible = false;
                emptyLbl.Visible = false;
            }
            foreach (DataRow row in patients.Rows)
            {
                PatientsList patient = new PatientsList();
                string patient_fullname = "";
                if (row["patient_mname"].ToString().Equals(null) || row["patient_mname"].ToString().Equals(""))
                {
                    patient_fullname = row["patient_fname"].ToString() + " " + row["patient_lname"].ToString();
                }
                else
                {
                    patient_fullname = row["patient_fname"].ToString() + " " + row["patient_mname"].ToString() + " " + row["patient_lname"].ToString();

                }
                string lastVisit = "";
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 appointment_date FROM Appointment WHERE patient_id = '" + row["patient_id"].ToString() + "' ORDER BY appointment_id DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                        lastVisit += (DateTime.Parse(reader1["appointment_date"].ToString()).ToString("MM/dd/yyyy")).ToString();
                }
                reader1.Close();
                patient.setPatientInfo(row["patient_id"].ToString(), patient_fullname, row["patient_age"].ToString(),
                    row["patient_gender"].ToString(), lastVisit, row["patient_cnum"].ToString());
                staffContainer.Controls.Add(patient);
            }
            constring.Close();
        }

        private void clndrBtn_Click(object sender, EventArgs e)
        {
            Calendar clndr = new Calendar();
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
                    Staff stf = new Staff();
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
            Services srvcs = new Services();
            srvcs.Show();
            this.Hide();
        }

        private void dshbrdBtn_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            this.Hide();
        }

        private void binBtn_Click(object sender, EventArgs e)
        {
            PatientArchives patientArch = new PatientArchives();
            patientArch.Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            constring.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Patient WHERE (patient_id LIKE @PatientID OR patient_fname LIKE @FirstName"
                + " OR patient_mname LIKE @MiddleName OR patient_lname LIKE @LastName OR patient_age LIKE @Age OR patient_gender LIKE @Gender OR" 
                + " patient_cnum LIKE @Contact OR patient_bdate LIKE @Birthdate OR patient_email LIKE @Email OR patient_address LIKE @Address" 
                + " OR patient_cperson LIKE @ContactPerson OR patient_cpernum LIKE @ContactPersonNum) AND status = 1", constring))
            {
                cmd.Parameters.AddWithValue("PatientID", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("FirstName", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("MiddleName", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("LastName", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("Age", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("Gender", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("Contact", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("Birthdate", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("Email", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("Address", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("ContactPerson", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("ContactPersonNum", string.Format("%{0}%", searchTxtBox.Text));

                DataTable patients = new DataTable("patients");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(patients);
                staffContainer.Controls.Clear();
                if (patients.Rows.Count <= 0)
                {
                    emptyPic.Visible = true;
                    emptyLbl.Visible = true;
                }
                else
                {
                    emptyPic.Visible = false;
                    emptyLbl.Visible = false;
                }
                foreach (DataRow row in patients.Rows)
                {
                    PatientsList patient = new PatientsList();
                    string patient_fullname = "";
                    if (row["patient_mname"].ToString().Equals(null) || row["patient_mname"].ToString().Equals(""))
                    {
                        patient_fullname = row["patient_fname"].ToString() + " " + row["patient_lname"].ToString();
                    }
                    else
                    {
                        patient_fullname = row["patient_fname"].ToString() + " " + row["patient_mname"].ToString() + " " + row["patient_lname"].ToString();

                    }
                    string lastVisit = "";
                    SqlCommand cmdd = new SqlCommand("SELECT TOP 1 appointment_date FROM Appointment WHERE patient_id = '" + row["patient_id"].ToString() + "' ORDER BY appointment_id DESC", constring);
                    SqlDataReader reader1;
                    reader1 = cmdd.ExecuteReader();
                    if (reader1.Read())
                    {
                        lastVisit += (DateTime.Parse(reader1["appointment_date"].ToString()).ToString("MM/dd/yyyy")).ToString();
                    }
                    reader1.Close();
                    patient.setPatientInfo(row["patient_id"].ToString(), patient_fullname, row["patient_age"].ToString(),
                        row["patient_gender"].ToString(), lastVisit, row["patient_cnum"].ToString());
                    staffContainer.Controls.Add(patient);
                }
                constring.Close();
            }
        }
    }
}
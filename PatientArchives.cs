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
    public partial class PatientArchives : Form
    {
        Variables v = new Variables();
        SqlConnection constring;

        public PatientArchives()
        {
            InitializeComponent();
            constring = v.getConnection;
        }
        private void PatientArchives_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void PatientArchives_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            displayPatient();
        }

        private void displayPatient()
        {
            constring.Open();
            string sql = "SELECT * FROM Patient WHERE status = 0";
            DataTable patients = new DataTable("patients");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(patients);

            foreach (DataRow row in patients.Rows)
            {
                PatientsListArchived patient = new PatientsListArchived();
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
                    MessageBox.Show("You do not have the authorization to open this!");
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
    }
}
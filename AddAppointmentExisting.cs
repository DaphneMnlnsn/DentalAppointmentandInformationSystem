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
    public partial class AddAppointmentExisting : Form
    {
        Variables v = new Variables();
        SqlConnection constring;

        public AddAppointmentExisting()
        {
            InitializeComponent();
            constring = v.getConnection;
        }
        private void AddAppointmentExisting_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AddAppointmentExisting_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(2).ToString().Equals("NULL") || reader1.GetValue(2).ToString().Equals(""))
                {
                    emNameTxtBox.Text = reader1.GetValue(3).ToString() + " " + reader1.GetValue(1).ToString();
                }
                else
                {
                    emNameTxtBox.Text = reader1.GetValue(3).ToString() + " " + reader1.GetValue(2).ToString() + " " + reader1.GetValue(1).ToString();
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            constring.Close();
        }
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            dshbrd.Hide();
        }
        private void apptclndrBtn_Click(object sender, EventArgs e)
        {
            Calendar cldr = new Calendar();
            cldr.Show();
            this.Hide();
        }

        private void ptntBtn_Click(object sender, EventArgs e)
        {
            Patients ptnt = new Patients();
            ptnt.Show();
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
                    MessageBox.Show("You do not have the authorization to open this!");
                    constring.Close();
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
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            v.getsetloggedIn = "";
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void savePatientBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(patientCombo.Text) && !string.IsNullOrWhiteSpace(service1Combo.Text) &&
                !string.IsNullOrWhiteSpace(staff1Combo.Text))
            {
                constring.Open();
                int appointmentID = 0;
                string staff2, staff3, service2, service3;
                SqlCommand command = new SqlCommand("SELECT TOP 1 appointment_id FROM Appointment ORDER BY appointment_id DESC", constring);
                SqlDataReader read;
                read = command.ExecuteReader();
                if (read.Read())
                {
                    appointmentID = read.GetInt32(0) + 1;
                }
                else
                {
                    MessageBox.Show("NO DATA FOUND");
                }
                read.Close();
                if (service2Combo.Text == null || service2Combo.Text == "")
                {
                    service2 = "NULL";
                }
                else
                {
                    service2 = service2Combo.SelectedValue.ToString();
                }

                if (service3Combo.Text == null || service3Combo.Text == "")
                {
                    service3 = "NULL";
                }
                else
                {
                    service3 = service2Combo.SelectedValue.ToString();
                }
                if (staff2Combo.Text == null || staff2Combo.Text == "")
                {
                    staff2 = "NULL";
                }
                else
                {
                    staff2 = staff2Combo.SelectedValue.ToString();
                }

                if (staff3Combo.Text == null || staff3Combo.Text == "")
                {
                    staff3 = "NULL";
                }
                else
                {
                    staff3 = staff3Combo.SelectedValue.ToString();
                }
                string query2 = "INSERT INTO Appointment VALUES('" + appointmentID + "','" + pIDTextBox.Text + "','"
                    + service1Combo.SelectedValue + "'," + service2 + "," + service3 + ",'" + appntmntDate.Text
                    + "','" + startTime.Text + "','" + endTime.Text + "','" + staff1Combo.SelectedValue + "'," + staff2 + "," + staff3 + ",'" + notesTxtBox.Text + "')";

                SqlCommand cmd3 = new SqlCommand(query2, constring);
                cmd3.CommandText = query2;
                if (cmd3.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Appointment Created!");
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                }

                int recordID = 0;
                SqlCommand com = new SqlCommand("SELECT TOP 1 record_id FROM Record ORDER BY record_id DESC", constring);
                SqlDataReader re;
                re = com.ExecuteReader();
                if (re.Read())
                {
                    recordID = re.GetInt32(0) + 1;
                }
                else
                {
                    MessageBox.Show("NO DATA FOUND");
                }
                re.Close();

                string query3 = "INSERT INTO Record VALUES('" + recordID + "','" + pIDTextBox.Text + "','"
                    + service1Combo.Text + " " + service2Combo.Text + " " + service3Combo.Text + "','" + appointmentID
                    + "','0','0',NULL);";

                SqlCommand cmd4 = new SqlCommand(query2, constring);
                cmd4.CommandText = query3;
                if (cmd4.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    Calendar clndr = new Calendar();
                    clndr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void patientCombo_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Patient";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dt.Columns.Add("patient_name", typeof(string), "patient_fname + ' ' + patient_lname");
            patientCombo.DataSource = dt;
            patientCombo.DisplayMember = "patient_name";
            patientCombo.ValueMember = "patient_id";
        }

        private void patientCombo_SelectionChanged(object sender, EventArgs e)
        {
            pIDTextBox.Text = patientCombo.SelectedValue.ToString();
        }

        private void staff1Combo_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Staff";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dt.Columns.Add("employee_name", typeof(string), "employee_fname + ' ' + employee_lname");
            staff1Combo.DataSource = dt;
            staff1Combo.DisplayMember = "employee_name";
            staff1Combo.ValueMember = "employee_num";
        }

        private void staff2Combo_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Staff";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dt.Columns.Add("employee_name", typeof(string), "employee_fname + ' ' + employee_lname");
            staff2Combo.DataSource = dt;
            staff2Combo.DisplayMember = "employee_name";
            staff2Combo.ValueMember = "employee_num";
        }

        private void staff3Combo_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Staff";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dt.Columns.Add("employee_name", typeof(string), "employee_fname + ' ' + employee_lname");
            staff3Combo.DataSource = dt;
            staff3Combo.DisplayMember = "employee_name";
            staff3Combo.ValueMember = "employee_num";
        }

        private void service1Combo_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Service";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            service1Combo.DataSource = dt;
            service1Combo.DisplayMember = "service_name";
            service1Combo.ValueMember = "service_id";
        }

        private void service2Combo_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Service";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            service2Combo.DataSource = dt;
            service2Combo.DisplayMember = "service_name";
            service2Combo.ValueMember = "service_id";
        }

        private void service3Combo_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Service";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            service3Combo.DataSource = dt;
            service3Combo.DisplayMember = "service_name";
            service3Combo.ValueMember = "service_id";
        }
    }
}
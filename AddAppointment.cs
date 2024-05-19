using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DentalAppointmentandInformationSystem
{
    public partial class AddAppointment : Form
    {
        Variables v = new Variables();
        SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daph\source\repos\DentalAppointmentandInformationSystem\DAISdB.mdf;Integrated Security=True");
        public AddAppointment()
        {
            InitializeComponent();
        }
        private void AddAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AddAppointment_Load(object sender, EventArgs e)
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
            List<string> items = new List<string>()
            {
                "Female", "Male"
            };
            genderCombo.DataSource = items;
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
                    Staff stf = new Staff();
                    stf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You do not have the authorization to open this!");
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            constring.Close();
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
            string gender = genderCombo.Items[genderCombo.SelectedIndex].ToString();
            int patientID = 0;
            int appointmentID = 0;
            string service2, service3, staff2, staff3;
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 patient_id FROM Patient ORDER BY patient_id DESC", constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                patientID = reader1.GetInt32(0) + 1;
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            reader1.Close();
            cmd.Dispose();

            String query = "INSERT INTO Patient(patient_id, patient_lname, patient_mname, patient_fname, patient_age, patient_gender, patient_bdate, patient_cnum, patient_email, patient_address, patient_cperson, patient_cpernum, patient_notes) VALUES('" + patientID + "','" + lnameTxtBox.Text + "','"
                + mnameTxtBox.Text + "','" + fnameTxtBox.Text + "','" + ageTxtBox.Text + "','" + gender
                + "','" + birthDate.Text + "','" + phoneTxtBox.Text + "','" + emailTxtBox.Text + "','"
                + addressTxtBox.Text + "','" + contactPrsnTxtBox.Text + "','" + cpersonNumTxtBox.Text + "','')";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;
            if (cmd2.ExecuteNonQuery() == 1)
            {
                string sql = "SELECT * FROM Patient";
                DataTable staffs = new DataTable("staffs");
                SqlDataAdapter da = new SqlDataAdapter(sql, constring);
                da.Fill(staffs);
                System.Text.StringBuilder b = new System.Text.StringBuilder();
                foreach (System.Data.DataRow r in staffs.Rows)
                {
                    foreach (System.Data.DataColumn c in staffs.Columns)
                    {
                        b.Append(c.ColumnName.ToString() + ":" + r[c.ColumnName].ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }

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
            String query2 = "INSERT INTO Appointment VALUES('" + appointmentID + "','" + patientID + "','"
                + service1Combo.SelectedValue + "'," + service2 + "," + service3 + ",'" + appntmntDate.Text
                + "','" + startTime.Text + "','" + endTime.Text + "','" + teethTxtBox.Text + "','"
                + priceTxtBox.Text + "','" + staff1Combo.SelectedValue + "'," + staff2 + "," + staff3 + ",'" + notesTxtBox.Text + "')";

            SqlCommand cmd3 = new SqlCommand(query2, constring);
            cmd3.CommandText = query2;
            if (cmd3.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Appointment Created!");
                Calendar clndr = new Calendar();
                clndr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
            constring.Close();
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
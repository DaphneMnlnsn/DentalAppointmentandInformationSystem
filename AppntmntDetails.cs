using DentalAppointmentandInformationSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalAppointmentandInformationSystem
{
    public partial class AppntmntDetails : Form
    {
        Variables v = new Variables();
        SqlConnection constring;

        public AppntmntDetails()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void AppntmntDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AppntmntDetails_Load(object sender, EventArgs e)
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
            appntmntDate.Text = v.getsetMonth.ToString() + "/" + v.getsetDay.ToString() + "/" + v.getsetYear.ToString() + " Appointments";

            displayAppointments();
        }

        private void displayAppointments()
        {
            constring.Open();
            string sql = "SELECT * FROM Appointment WHERE appointment_date = " + "'" + v.getsetYear.ToString() + "/" + v.getsetMonth.ToString() + "/" + v.getsetDay + "' AND status = 1";
            DataTable appointments = new DataTable("appointments");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(appointments);
            if (appointments.Rows.Count <= 0)
            {
                emptyPic.Visible = true;
                emptyLbl.Visible = true;
            }
            foreach (DataRow row in appointments.Rows)
            {
                Appointment appntmnt = new Appointment();
                int appointment_id = Convert.ToInt32(row["appointment_id"]);
                int service_id = Convert.ToInt32(row["service_id"]);
                string service_id2 = row["service_id2"].ToString();
                string service_id3 = row["service_id3"].ToString();
                int patient_id = Convert.ToInt32(row["patient_id"]);
                int employee_id = Convert.ToInt32(row["employee_num"]);
                string employee_id2 = row["employee_num2"].ToString();
                string employee_id3 = row["employee_num3"].ToString();
                string appointment_notes = row["appointment_notes"].ToString();
                string time = row["appointment_startTime"].ToString()[0] + "" + row["appointment_startTime"].ToString()[1] + "" + row["appointment_startTime"].ToString()[2] + "" + row["appointment_startTime"].ToString()[3] + "" + row["appointment_startTime"].ToString()[4];
                string time2 = row["appointment_endTime"].ToString()[0] + "" + row["appointment_endTime"].ToString()[1] + "" + row["appointment_endTime"].ToString()[2] + "" + row["appointment_endTime"].ToString()[3] + "" + row["appointment_endTime"].ToString()[4];

                string sql2 = "SELECT * FROM Service WHERE service_id = " + "'" + service_id + "'";
                SqlCommand cmd2 = constring.CreateCommand();
                cmd2.CommandText = sql2;
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    string serviceName = reader2["service_name"].ToString();
                    reader2.Dispose();
                    cmd2.Dispose();
                    if (service_id2 != null || service_id2 != "")
                    {
                        string sql3 = "SELECT * FROM Service WHERE service_id = " + "'" + service_id2 + "'";
                        SqlCommand cmd3 = constring.CreateCommand();
                        cmd3.CommandText = sql3;
                        SqlDataReader reader3 = cmd3.ExecuteReader();
                        if (reader3.Read())
                        {
                            serviceName += ", " + reader3["service_name"].ToString();
                        }
                        reader3.Dispose();
                        cmd3.Dispose();
                    }
                    if (service_id3 != null || service_id3 != " ")
                    {
                        string sql4 = "SELECT * FROM Service WHERE service_id = " + "'" + service_id3 + "'";
                        SqlCommand cmd4 = constring.CreateCommand();
                        cmd4.CommandText = sql4;
                        SqlDataReader reader4 = cmd4.ExecuteReader();
                        if (reader4.Read())
                        {
                            serviceName += ", " + reader4["service_name"].ToString();
                        }
                        reader4.Dispose();
                        cmd4.Dispose();
                    }
                    string sql5 = "SELECT * FROM Patient WHERE patient_id = " + "'" + patient_id + "'";
                    SqlCommand cmd5 = constring.CreateCommand();
                    cmd5.CommandText = sql5;
                    SqlDataReader reader5 = cmd5.ExecuteReader();
                    if (reader5.Read())
                    {
                        string patient_name;
                        if (reader5.GetValue(5).ToString().Equals("Female"))
                        {
                            patient_name = "Ms. " + reader5["patient_lname"].ToString() + ", " + reader5["patient_fname"].ToString() + " " + reader5["patient_mname"].ToString();
                        }
                        else
                        {
                            patient_name = "Mr. " + reader5["patient_lname"].ToString() + ", " + reader5["patient_fname"].ToString() + " " + reader5["patient_mname"].ToString();
                        }
                        reader5.Dispose();
                        cmd5.Dispose();
                        string sql6 = "SELECT * FROM Staff WHERE employee_num = " + "'" + employee_id + "'";
                        SqlCommand cmd6 = constring.CreateCommand();
                        cmd6.CommandText = sql6;
                        SqlDataReader reader6 = cmd6.ExecuteReader();
                        if (reader6.Read())
                        {
                            string staffName = reader6.GetValue(3).ToString() + " " + reader6.GetValue(1).ToString();
                            reader6.Dispose();
                            cmd6.Dispose();
                            if (employee_id2 != null || employee_id2 != " ")
                            {
                                string sql7 = "SELECT * FROM Staff WHERE employee_num = " + "'" + employee_id2 + "'";
                                SqlCommand cmd7 = constring.CreateCommand();
                                cmd7.CommandText = sql7;
                                SqlDataReader reader7 = cmd7.ExecuteReader();
                                if (reader7.Read())
                                {
                                    staffName += ", " + reader7.GetValue(3).ToString() + " " + reader7.GetValue(1).ToString();
                                }
                                reader7.Dispose();
                                cmd7.Dispose();
                            }
                            if (employee_id3 != null || employee_id3 != " ")
                            {
                                string sql8 = "SELECT * FROM Staff WHERE employee_num = " + "'" + employee_id3 + "'";
                                SqlCommand cmd8 = constring.CreateCommand();
                                cmd8.CommandText = sql8;
                                SqlDataReader reader8 = cmd8.ExecuteReader();
                                if (reader8.Read())
                                {
                                    staffName += ", " + reader8.GetValue(3).ToString() + " " + reader8.GetValue(1).ToString();
                                }
                                reader8.Dispose();
                                cmd8.Dispose();
                            }
                            appntmnt.setAppointmentInfo(patient_name, serviceName, time, time2, staffName, appointment_notes, appointment_id);
                        }
                    }
                }
                appntmntContainer.Controls.Add(appntmnt);
            }
            constring.Close();

        }
        private void dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            this.Hide();
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
                    MessageBox.Show("You do not have authorization to open this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
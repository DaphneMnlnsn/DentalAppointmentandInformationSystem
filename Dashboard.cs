﻿using DentalAppointmentandInformationSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalAppointmentandInformationSystem
{
    public partial class Dashboard : Form
    {
        Variables v = new Variables();
        SqlConnection constring;
        public Dashboard()
        {
            InitializeComponent();
            constring = v.getConnection;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;

            //Replacing label with staff name in nav bar
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                wlcmLbl.Text = "Welcome, " + reader1.GetValue(3).ToString() + "!";
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
            displayDays();
            displayNotifs();
            displayActs();
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
            //Checking authorization
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

        private void displayDays()
        {
            //Displaying days of the month
            DateTime now = DateTime.Now;
            v.getsetMonth = now.Month;
            v.getsetYear = now.Year;

            int month = v.getsetMonth;
            int year = v.getsetYear;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthLbl.Text = monthName + " " + year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            int daysOfMonth = DateTime.DaysInMonth(year, month);
            int daysOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < daysOfWeek; i++)
            {
                DashboardDays dashDaysBlank = new DashboardDays();
                flowLayoutPanel1.Controls.Add(dashDaysBlank);
            }

            for (int i = 1; i <= daysOfMonth; i++)
            {
                DashboardDaysNotBlank dashDays = new DashboardDaysNotBlank();
                dashDays.days(i);
                flowLayoutPanel1.Controls.Add(dashDays);
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            v.getsetloggedIn = "";
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void displayNotifs()
        {
            constring.Open();
            bool noNotif = true;
            string message = "You have the following appointments:\n\n";
            SqlCommand sqlcom = new SqlCommand("SELECT * FROM Appointment where appointment_date='" + DateTime.Now.ToString("MM-dd-yyyy") + "' AND appointment_startTime > '" + DateTime.Now.ToString("hh:mm tt") + "' AND status = 1 ORDER BY appointment_startTime ASC", constring);
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            dashboardNotifItem notification = new dashboardNotifItem();

            sqlda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string sql5 = "SELECT * FROM Patient WHERE patient_id = " + "'" + dt.Rows[i]["patient_id"].ToString() + "'";
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
                        message += "- " + dt.Rows[i]["appointment_startTime"].ToString() + "-" + dt.Rows[i]["appointment_endTime"].ToString() + " with " + "\n" + patient_name + "\n\n";
                        reader5.Dispose();
                        cmd5.Dispose();
                        notification.setNotifs(message);
                        notifContainer.Controls.Add(notification);
                    }
                }
                noNotifPic.Visible = false;
                noNotifLbl.Visible = false;
                noNotif = false;
            }
            string message2 = "Unmarked Appointments for Today:\n\n";
            SqlCommand sqlcom2 = new SqlCommand("SELECT * FROM Appointment WHERE ((appointment_state = 'Ongoing') OR (appointment_state = 'Pending')) AND (appointment_date <= '" + DateTime.Now.ToString("MM-dd-yyyy") + "' OR appointment_startTime < '" + DateTime.Now.ToString("hh:mm tt") + "') AND status = 1 ORDER BY appointment_date ASC", constring);
            SqlDataAdapter sqlda2 = new SqlDataAdapter(sqlcom2);
            DataTable dt2 = new DataTable();
            dashboardNotifItem notification2 = new dashboardNotifItem();

            sqlda2.Fill(dt2);

            if (dt2.Rows.Count > 0)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    string sql5 = "SELECT * FROM Patient WHERE patient_id = " + "'" + dt2.Rows[i]["patient_id"].ToString() + "'";
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
                        message2 += "- " + DateTime.Parse(dt2.Rows[i]["appointment_date"].ToString()).ToString("MM-dd-yyyy") + ": " + dt2.Rows[i]["appointment_startTime"].ToString() + "-" + dt2.Rows[i]["appointment_endTime"].ToString() + " with " + patient_name + "\n\n";
                        reader5.Dispose();
                        cmd5.Dispose();
                        notification2.setNotifs(message2);
                        notifContainer.Controls.Add(notification2);
                    }
                }
                noNotifPic.Visible = false;
                noNotifLbl.Visible = false;
                noNotif = false;
            }

            if (noNotif == true)
            {
                noNotifPic.Visible = true;
                noNotifLbl.Visible = true;
            }

            constring.Close();
        }

        private void displayActs()
        {
            constring.Open();
            string message = "";
            SqlCommand sqlcom = new SqlCommand("SELECT * FROM Activity_Log ORDER BY activity_time DESC", constring);
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();

            sqlda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dashboardNotifItem notification = new dashboardNotifItem();
                    message = "Staff " + row["employee_num"] + " " + row["activity_performed"] + " at " + DateTime.Parse(row["activity_time"].ToString()).ToString("MM-dd-yyyy HH:mm:ss") + ".";
                    notification.setNotifs(message);
                    activityPanel.Controls.Add(notification);
                }
            }

            constring.Close();
        }
    }
}
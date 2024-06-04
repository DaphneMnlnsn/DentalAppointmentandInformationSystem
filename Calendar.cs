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
    public partial class Calendar : Form
    {
        Variables v = new Variables();
        SqlConnection constring;
        public Calendar()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            displayDays();
            timer1();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            v.getsetMonth = now.Month;
            v.getsetYear = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(v.getsetMonth);
            monthLbl.Text = monthName + " " + v.getsetYear;

            DateTime startOfTheMonth = new DateTime(v.getsetYear, v.getsetMonth, 1);
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                daycontainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.days(i);
                daycontainer.Controls.Add(userControlDays);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Does the patient have an existing record?";
            string caption = "Appointment Creation";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                AddAppointment addappointment = new AddAppointment();
                addappointment.Show();
            }
            else
            {
                AddAppointmentExisting addappointmentE = new AddAppointmentExisting();
                addappointmentE.Show();
            }
            this.Hide();

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            v.getsetMonth--;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(v.getsetMonth);
            monthLbl.Text = monthName + " " + v.getsetYear;

            DateTime startOfTheMonth = new DateTime(v.getsetYear, v.getsetMonth, 1);
            int days = DateTime.DaysInMonth(v.getsetYear, v.getsetMonth);
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                daycontainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.days(i);
                daycontainer.Controls.Add(userControlDays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            v.getsetMonth++;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(v.getsetMonth);
            monthLbl.Text = monthName + " " + v.getsetYear;

            DateTime startOfTheMonth = new DateTime(v.getsetYear, v.getsetMonth, 1);
            int days = DateTime.DaysInMonth(v.getsetYear, v.getsetMonth);
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                daycontainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.days(i);
                daycontainer.Controls.Add(userControlDays);
            }
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

        private void patientBtn_Click(object sender, EventArgs e)
        {
            Patients patient = new Patients();
            patient.Show();
            this.Hide();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
            this.Hide();
        }

        private void Calendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dshbrdBtn_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            this.Hide();
        }

        private void binBtn_Click(object sender, EventArgs e)
        {
            CalendarArchives calArch = new CalendarArchives();
            calArch.Show();
            this.Hide();
        }
        private void timer1()
        {
            constring.Open();
            string message = "Today at " + DateTime.Today.ToLongDateString() + ", you have the following appointments:\n";
            SqlCommand sqlcom = new SqlCommand("SELECT * FROM Appointment where appointment_date='" + DateTime.Now.ToString() + "'", constring);
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();

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
                        reader5.Dispose();
                        cmd5.Dispose();
                        message += dt.Rows[i]["appointment_startTime"].ToString() + "-" + dt.Rows[i]["appointment_endTime"].ToString() + " with " + patient_name + "\n";
                    }
                }
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("You have no appointments for today.");
            }
            constring.Close();
        }
    }
}
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
    public partial class CalendarArchives : Form
    {
        Variables v = new Variables();
        SqlConnection constring;
        public CalendarArchives()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void CalendarArchives_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            displayDays();
        }
        private void displayDays()
        {
            //Displaying the days of the month
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
                UserControlDaysArchived userControlDays = new UserControlDaysArchived();
                userControlDays.days(i);
                daycontainer.Controls.Add(userControlDays);
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            //Displaying days of previous month
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
                UserControlDaysArchived userControlDays = new UserControlDaysArchived();
                userControlDays.days(i);
                daycontainer.Controls.Add(userControlDays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //Displaying days of next month
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
                UserControlDaysArchived userControlDays = new UserControlDaysArchived();
                userControlDays.days(i);
                daycontainer.Controls.Add(userControlDays);
            }
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
                    StaffArchives stf = new StaffArchives();
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
            PatientArchives patient = new PatientArchives();
            patient.Show();
            this.Hide();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            ServiceArchives services = new ServiceArchives();
            services.Show();
            this.Hide();
        }

        private void CalendarArchives_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dshbrdBtn_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Calendar clndr = new Calendar();
            clndr.Show();
            this.Hide();
        }
    }
}
using DentalAppointmentandInformationSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        int month, year;
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;

            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthLbl.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
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
            const string message = "Does the patient have an existing record?";
            const string caption = "Appointment Creation";
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
            month--;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthLbl.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
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
            month++;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthLbl.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
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
            Staff staff = new Staff();
            staff.Show();
            this.Hide();
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
    }
}
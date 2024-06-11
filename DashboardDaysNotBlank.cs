using DentalAppointmentandInformationSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalAppointmentandInformationSystem
{
    public partial class DashboardDaysNotBlank : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;
        public DashboardDaysNotBlank()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void DashboardDaysNotBlank_Load(object sender, EventArgs e)
        {
            displayAppointment();
        }

        public void days(int numday)
        {
            dayLbl.Text = numday + "";
        }
        private void displayAppointment()
        {
            //Displays the number of appointments for that specific day
            constring.Open();

            SqlCommand sqlcom = new SqlCommand("SELECT * FROM Appointment WHERE appointment_date = " + "'" + v.getsetYear.ToString() + "/" + v.getsetMonth.ToString() + "/" + dayLbl.Text + "' AND ((appointment_state = 'Ongoing') OR (appointment_state = 'Pending')) AND status = 1", constring);
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            int appNum = 0;

            sqlda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    appNum++;
                }
                eventLbl.Text = appNum.ToString() + " apps.";
            }
            constring.Close();
        }

        private void DashboardDaysNotBlank_Click(object sender, EventArgs e)
        {
            v.getsetDay = dayLbl.Text;
            AppntmntDetails appointment = new AppntmntDetails();
            this.ParentForm.Hide();
            appointment.Show();
        }
    }
}
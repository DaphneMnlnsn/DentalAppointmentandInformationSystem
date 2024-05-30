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
            constring.Open();
            String sql = "SELECT * FROM Appointment WHERE appointment_date = " + "'" + v.getsetYear.ToString() + "/" + v.getsetMonth.ToString() + "/" + dayLbl.Text + "' AND status = 1";
            SqlCommand cmd = constring.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int id = Convert.ToInt32(reader["service_id"]);
                string time = reader["appointment_startTime"].ToString()[0] + "" + reader["appointment_startTime"].ToString()[1] + "" + reader["appointment_startTime"].ToString()[2] + "" + reader["appointment_startTime"].ToString()[3] + "" + reader["appointment_startTime"].ToString()[4];
                string time2 = reader["appointment_endTime"].ToString()[0] + "" + reader["appointment_endTime"].ToString()[1] + "" + reader["appointment_endTime"].ToString()[2] + "" + reader["appointment_endTime"].ToString()[3] + "" + reader["appointment_endTime"].ToString()[4];
                reader.Dispose();
                String sql2 = "SELECT * FROM Service WHERE service_id = " + "'" + id + "'";
                SqlCommand cmd2 = constring.CreateCommand();
                cmd2.CommandText = sql2;
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    eventLbl.Text = reader2["service_name"].ToString() + "\n" + time + "-" + time2;
                }
                reader2.Dispose();
                cmd2.Dispose();
            }
            cmd.Dispose();
            constring.Close();
        }

        private void DashboardDaysNotBlank_Click(object sender, EventArgs e)
        {
            Calendar clndr = new Calendar();
            clndr.Show();
            this.ParentForm.Hide();
        }
    }
}
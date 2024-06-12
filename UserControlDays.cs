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
    public partial class UserControlDays : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;
        public UserControlDays()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            displayAppointment();
        }
        public void days(int numday)
        {
            lbldays.Text = numday + "";
        }
        private void displayAppointment()
        {
            //Displaying the appointment for that day
            constring.Open();
            string sql = "SELECT * FROM Appointment WHERE appointment_date = " + "'" + v.getsetYear.ToString() + "/" + v.getsetMonth.ToString() + "/" + lbldays.Text + "' AND status = 1 ORDER BY appointment_startTime ASC";
            DataTable appointments = new DataTable("appointments");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(appointments);
            foreach (DataRow row in appointments.Rows)
            {
                int id = Convert.ToInt32(row["service_id"]);
                string time = row["appointment_startTime"].ToString()[0] + "" + row["appointment_startTime"].ToString()[1] + "" + row["appointment_startTime"].ToString()[2] + "" + row["appointment_startTime"].ToString()[3] + "" + row["appointment_startTime"].ToString()[4];
                string time2 = row["appointment_endTime"].ToString()[0] + "" + row["appointment_endTime"].ToString()[1] + "" + row["appointment_endTime"].ToString()[2] + "" + row["appointment_endTime"].ToString()[3] + "" + row["appointment_endTime"].ToString()[4];
                string sql2 = "SELECT * FROM Service WHERE service_id = " + "'" + id + "'";
                SqlCommand cmd2 = constring.CreateCommand();
                cmd2.CommandText = sql2;
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                        lblsched.Text += reader2["service_name"].ToString() + ":\n" + time + "-" + time2 + "\n\n";
                }
                reader2.Dispose();
                cmd2.Dispose();
            }
            constring.Close();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            v.getsetDay = lbldays.Text;
            AppntmntDetails appointment = new AppntmntDetails();
            this.ParentForm.Hide();
            appointment.Show();
        }
    }
}
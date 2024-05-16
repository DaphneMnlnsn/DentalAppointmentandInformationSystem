using System;
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

namespace DentalAppointmentandInformationSystem
{
    public partial class AddAppointment : Form
    {
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
            List<string> items = new List<string>()
            {
                "Female", "Male"
            };
            genderCombo.DataSource = items;
        }

        private void savePatientBtn_Click(object sender, EventArgs e)
        {
            int patientID = 0;
            int appointmentID = 0;
            SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DAISdB.mdf;Integrated Security=True");
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 COLUMN FROM Patient ORDER BY COLUMN DESC", constring);
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
            String query = "INSERT INTO Patient VALUES('" + patientID + "','" + lnameTxtBox.Text + "','"
                + mnameTxtBox.Text + "'," + fnameTxtBox.Text + "," + ageTxtBox.Text + "," + genderCombo.Text
                + "," + birthDate.Text + "," + phoneTxtBox.Text + "," + emailTxtBox.Text + ","
                + addressTxtBox.Text + "," + contactPrsnTxtBox.Text + "," + cpersonNumTxtBox.Text + ")";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            SqlCommand command = new SqlCommand("SELECT TOP 1 COLUMN FROM Appointment ORDER BY COLUMN DESC", constring);
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
            String query2 = "INSERT INTO Appointment VALUES('" + appointmentID + "','" + patientID + "','"
                + service1Combo.Text + "'," + service2Combo.Text + "," + service3Combo.Text + "," + appntmntDate.Text
                + "," + startTime.Text + "," + endTime.Text + "," + teethTxtBox.Text + ","
                + priceTxtBox.Text + "," + staff1Combo.Text + "," + staff2Combo.Text + "," + staff3Combo + "," + notesTxtBox + ")";

            SqlCommand cmd3 = new SqlCommand(query, constring);
            cmd3.CommandText = query;
            if (cmd3.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Appointment Created!");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
            constring.Close();
        }
    }
}
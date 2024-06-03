using System;
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
    public partial class AppointmentArchived : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;
        public AppointmentArchived()
        {
            InitializeComponent();
            constring = v.getConnection;
        }
        
        private void Appointment_Load(object sender, EventArgs e)
        {
        }
        public void setAppointmentInfo(string patientName, string serviceName, string time, string time2, string staffName, string appointment_notes, int appointmentId)
        {
            ptntLbl.Text = patientName;
            srvcLbl.Text = "Service/s Availed: " + serviceName;
            timeLbl.Text = "Time: " + time + "-" + time2;
            stffLbl.Text = "Staff/s Assigned: " + staffName;
            label1.Text = "Notes: " + appointment_notes;
            appntmntIDLbl.Text = appointmentId.ToString();
        }

        private void deleteAppntmnt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this appointment permanently?\nYou will not be able to retrieve this!", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                constring.Open();

                string query2 = "DELETE FROM Record WHERE appointment_id =" + appntmntIDLbl.Text;
                SqlCommand cmd2 = new SqlCommand(query2, constring);
                cmd2.CommandText = query2;
                cmd2.ExecuteNonQuery();
                string query = "DELETE FROM Appointment WHERE appointment_id =" + appntmntIDLbl.Text;
                SqlCommand cmd = new SqlCommand(query, constring);
                cmd.CommandText = query;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    MessageBox.Show("Appointment deleted permanently!");
                    Calendar clndr = new Calendar();
                    clndr.Show();
                    this.ParentForm.Hide();
                }
                else
                {
                    MessageBox.Show("DATA NOT DELETED SUCCESSFULLY");
                }
            }
        }

        private void restoreAppntmnt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to restore this appointment?", "Confirm Restore", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                constring.Open();

                string query2 = "UPDATE Record SET status = 1 WHERE appointment_id =" + appntmntIDLbl.Text;
                SqlCommand cmd2 = new SqlCommand(query2, constring);
                cmd2.CommandText = query2;
                cmd2.ExecuteNonQuery();
                string query = "UPDATE Appointment SET status = 1 WHERE appointment_id =" + appntmntIDLbl.Text;
                SqlCommand cmd = new SqlCommand(query, constring);
                cmd.CommandText = query;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    MessageBox.Show("Appointment restored successfully!");
                    Calendar clndr = new Calendar();
                    clndr.Show();
                    this.ParentForm.Hide();
                }
                else
                {
                    MessageBox.Show("DATA NOT DELETED SUCCESSFULLY");
                }
            }
        }
    }
}
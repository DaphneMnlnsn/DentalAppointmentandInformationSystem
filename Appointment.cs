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
    public partial class Appointment : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;
        public Appointment()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
        }
        public void setAppointmentInfo(string patientName, string serviceName, string time, string time2, string staffName, string appointment_notes, int appointmentId, string appointment_state)
        {
            //Setting the appointment information for the appointment details
            ptntLbl.Text = patientName;
            srvcLbl.Text = "Service/s Availed: " + serviceName;
            timeLbl.Text = "Time: " + time + "-" + time2;
            stffLbl.Text = "Staff/s Assigned: " + staffName;
            label1.Text = "Notes: " + appointment_notes;
            appntmntIDLbl.Text = appointmentId.ToString();
            appntmntState.Text = appointment_state;
            if (appntmntState.Text.ToString().Equals("Completed"))
            {
                appntmntState.ForeColor = Color.FromArgb(45, 204, 255);
                editAppntmnt.Enabled = false;
            }
            else if (appntmntState.Text.ToString().Equals("Ongoing"))
            {
                appntmntState.ForeColor = Color.FromArgb(0, 226, 0);
            }
            else if (appntmntState.Text.ToString().Equals("Cancelled"))
            {
                appntmntState.ForeColor = Color.FromArgb(255, 42, 4);
                editAppntmnt.Enabled = false;
            }
            else if (appntmntState.Text.ToString().Equals("No Show"))
            {
                appntmntState.ForeColor = Color.FromArgb(123, 128, 137);
            }
            else
            {
                appntmntState.ForeColor = Color.FromArgb(255, 175, 61);
            }
        }

        private void editAppntmnt_Click(object sender, EventArgs e)
        {
            //What would happen if edit button is clicked
            v.getsetappointmentSelected = appntmntIDLbl.Text;
            this.ParentForm.Hide();
            EditAppointment edit = new EditAppointment();
            edit.Show();

        }

        private void deleteAppntmnt_Click(object sender, EventArgs e)
        {
            //What would happen if delete button is clicked
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this appointment?\nThis will be moved to the trash bin.", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                constring.Open();

                string query2 = "UPDATE Record SET status = 0 WHERE appointment_id =" + appntmntIDLbl.Text;
                SqlCommand cmd2 = new SqlCommand(query2, constring);
                cmd2.CommandText = query2;
                cmd2.ExecuteNonQuery();
                string query = "UPDATE Appointment SET status = 0 WHERE appointment_id =" + appntmntIDLbl.Text;
                SqlCommand cmd = new SqlCommand(query, constring);
                cmd.CommandText = query;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    MessageBox.Show("Appointment has been moved to the Trash Bin/Archives!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string queryAct = "INSERT INTO Activity_Log VALUES('" + v.getsetloggedIn + "','" + DateTime.Now + "','archived appointment "
                                + appntmntIDLbl.Text + "')";

                    SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                    cmdAct.CommandText = queryAct;
                    cmdAct.ExecuteNonQuery();
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

        private void appntmntState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (appntmntState.Text.ToString().Equals("Completed"))
            {
                appntmntState.ForeColor = Color.FromArgb(45, 204, 255);
                editAppntmnt.Enabled = false;
            }
            else if (appntmntState.Text.ToString().Equals("Ongoing"))
            {
                appntmntState.ForeColor = Color.FromArgb(0, 226, 0);
            }
            else if (appntmntState.Text.ToString().Equals("Cancelled"))
            {
                appntmntState.ForeColor = Color.FromArgb(255, 42, 4);
                editAppntmnt.Enabled = false;
            }
            else if (appntmntState.Text.ToString().Equals("No Show"))
            {
                appntmntState.ForeColor = Color.FromArgb(123, 128, 137);
            }
            else
            {
                appntmntState.ForeColor = Color.FromArgb(255, 175, 61);
            }
            constring.Open();
            string query2 = "UPDATE Appointment SET appointment_state = '" + appntmntState.Text.ToString() + "' WHERE appointment_id =" + appntmntIDLbl.Text;
            SqlCommand cmd2 = new SqlCommand(query2, constring);
            cmd2.CommandText = query2;
            cmd2.ExecuteNonQuery();
            constring.Close();
        }
    }
}
﻿using System;
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
        public void setAppointmentInfo(string patientName, string serviceName, string time, string time2, string staffName, string appointment_notes, int appointmentId, string appointment_state)
        {
            //Setting the appointment details but of archived appointments
            ptntLbl.Text = patientName;
            srvcLbl.Text = "Service/s Availed: " + serviceName;
            timeLbl.Text = "Time: " + time + "-" + time2;
            stffLbl.Text = "Staff/s Assigned: " + staffName;
            label1.Text = "Notes: " + appointment_notes;
            appntmntIDLbl.Text = appointmentId.ToString();
            appntmntState.Text = appointment_state;
            appntmntState.Enabled = false;
            if (appntmntState.Text.ToString().Equals("Completed"))
            {
                appntmntState.ForeColor = Color.FromArgb(45, 204, 255);
            }
            else if (appntmntState.Text.ToString().Equals("Ongoing"))
            {
                appntmntState.ForeColor = Color.FromArgb(0, 226, 0);
            }
            else if (appntmntState.Text.ToString().Equals("Cancelled"))
            {
                appntmntState.ForeColor = Color.FromArgb(255, 42, 4);
            }
            else if (appntmntState.Text.ToString().Equals("No Show"))
            {
                appntmntState.ForeColor = Color.FromArgb(123, 128, 137);
            }
            else
            {
                appntmntState.ForeColor = Color.FromArgb(250, 216, 0);
            }
        }

        private void deleteAppntmnt_Click(object sender, EventArgs e)
        {
            //Deleting an appointment permanently
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
                    MessageBox.Show("Appointment deleted permanently!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string queryAct = "INSERT INTO Activity_Log VALUES('" + v.getsetloggedIn + "','" + DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")) + "','permanently deleted appointment "
                                + appntmntIDLbl.Text + "')";

                    SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                    cmdAct.CommandText = queryAct;
                    cmdAct.ExecuteNonQuery();
                    constring.Close();
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
            //Restoring an appointment permanently
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
                    MessageBox.Show("Appointment restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string queryAct = "INSERT INTO Activity_Log VALUES('" + v.getsetloggedIn + "','" + DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")) + "','restored appointment "
                                + appntmntIDLbl.Text + "')";

                    SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                    cmdAct.CommandText = queryAct;
                    cmdAct.ExecuteNonQuery();
                    constring.Close();
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
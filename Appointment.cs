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
        public void setAppointmentInfo(string patientName, string serviceName, string time, string time2, string staffName, string appointment_notes, int appointmentId)
        {
            //Setting the appointment information for the appointment details
            ptntLbl.Text = patientName;
            srvcLbl.Text = "Service/s Availed: " + serviceName;
            timeLbl.Text = "Time: " + time + "-" + time2;
            stffLbl.Text = "Staff/s Assigned: " + staffName;
            label1.Text = "Notes: " + appointment_notes;
            appntmntIDLbl.Text = appointmentId.ToString();
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
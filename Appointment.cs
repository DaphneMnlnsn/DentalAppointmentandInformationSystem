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
            ptntLbl.Text = patientName;
            srvcLbl.Text = "Service/s Availed: " + serviceName;
            timeLbl.Text = "Time: " + time + "-" + time2;
            stffLbl.Text = "Staff/s Assigned: " + staffName;
            label1.Text = "Notes: " + appointment_notes;
            appntmntIDLbl.Text = appointmentId.ToString();
        }

        private void editAppntmnt_Click(object sender, EventArgs e)
        {
            v.getsetappointmentSelected = appntmntIDLbl.Text;
            this.ParentForm.Hide();
            EditAppointment edit = new EditAppointment();
            edit.Show();

        }

        private void deleteAppntmnt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this appointment?\nThis will be moved to the trash bin.", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                constring.Open();
                string querya = "INSERT INTO Appointment_Archive SELECT * FROM Appointment WHERE appointment_id =" + appntmntIDLbl.Text;
                SqlCommand cmda = new SqlCommand(querya, constring);
                cmda.CommandText = querya;
                cmda.ExecuteNonQuery();
                string querya2 = "INSERT INTO Record_Archive SELECT * FROM Record WHERE appointment_id =" + appntmntIDLbl.Text;
                SqlCommand cmda2 = new SqlCommand(querya2, constring);
                cmda2.CommandText = querya2;
                cmda2.ExecuteNonQuery();

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
                    MessageBox.Show("Appointment has been moved to the Trash Bin/Archives!");
                    Calendar clndr = new Calendar();
                    clndr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("DATA NOT DELETED SUCCESSFULLY");
                }
            }
        }
    }
}
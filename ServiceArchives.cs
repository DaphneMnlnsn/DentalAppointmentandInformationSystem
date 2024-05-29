﻿using DentalAppointmentandInformationSystem;
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

namespace DentalAppointmentandInformationSystem
{
    public partial class ServiceArchives : Form
    {
        Variables v = new Variables();
        SqlConnection constring;

        public ServiceArchives()
        {
            InitializeComponent();
            constring = v.getConnection;
        }


        private void Services_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;

            displayServices();
        }

        private void displayServices()
        {
            constring.Open();
            string sql = "SELECT * FROM Service_Archive";
            DataTable services = new DataTable("services");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(services);

            foreach (DataRow row in services.Rows)
            {
                ServicesListArchived service = new ServicesListArchived();
                service.setServiceInfo(row["service_id"].ToString(), row["service_name"].ToString(), double.Parse(row["service_price"].ToString()).ToString("N0"));
                servicesContainer.Controls.Add(service);
            }
            constring.Close();
        }

        private void clndrBtn_Click(object sender, EventArgs e)
        {
            CalendarArchives clndr = new CalendarArchives();
            clndr.Show();
            this.Hide();
        }

        private void ptntsBtn_Click(object sender, EventArgs e)
        {
            PatientArchives patients = new PatientArchives();
            patients.Show();
            this.Hide();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    constring.Close();
                    StaffArchives stf = new StaffArchives();
                    stf.Show();
                    this.Hide();
                }
                else
                {
                    constring.Close();
                    MessageBox.Show("You do not have the authorization to open this!");
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }

        }

        private void dshbrdbtn_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            this.Hide();
        }
    }
}
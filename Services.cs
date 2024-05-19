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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        Variables v = new Variables();
        SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daph\source\repos\DentalAppointmentandInformationSystem\DAISdB.mdf;Integrated Security=True");

        private void Services_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            addService1.Visible = false;
            editService1.Visible = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;

            displayServices();
        }

        private void displayServices()
        {
            constring.Open();
            string sql = "SELECT * FROM Service";
            DataTable services = new DataTable("services");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(services);

            foreach (DataRow row in services.Rows)
            {
                ServicesList service = new ServicesList();
                service.setServiceInfo(row["service_id"].ToString(), row["service_name"].ToString(), double.Parse(row["service_price"].ToString()).ToString("N0"));
                servicesContainer.Controls.Add(service);
            }
            constring.Close();
        }

        private void clndrBtn_Click(object sender, EventArgs e)
        {
            Calendar clndr = new Calendar();
            clndr.Show();
            this.Hide();
        }

        private void ptntsBtn_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
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
                    Staff stf = new Staff();
                    stf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You do not have the authorization to open this!");
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            constring.Close();
        }

        private void addServiceBtn_Click(object sender, EventArgs e)
        {
            addService1.Visible = true;
        }

        public void editVisible()
        {
            editService1.Visible = true;
            editService1.setValues();
        }
    }
}
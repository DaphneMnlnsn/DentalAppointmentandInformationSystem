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

namespace DentalAppointmentandInformationSystem
{
    public partial class AddService : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daph\source\repos\DentalAppointmentandInformationSystem\DAISdB.mdf;Integrated Security=True");

        public AddService()
        {
            InitializeComponent();
        }


        private void AddService_Load(object sender, EventArgs e)
        {

        }

        private void saveServiceBtn_Click(object sender, EventArgs e)
        {
            int serviceID = 0;
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 service_id FROM Service ORDER BY service_id DESC", constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                serviceID = reader1.GetInt32(0) + 1;
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            reader1.Close();
            cmd.Dispose();

            String query = "INSERT INTO Service VALUES('" + serviceID + "','" + srvcNameTxtBox.Text + "','"
                + srvcPriceTxtBox.Text + "');";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;
            if (cmd2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Service added successfully!");
                this.Visible = false;
                this.Parent.Hide();
                Services srvc = new Services();
                srvc.Show();
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
            constring.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
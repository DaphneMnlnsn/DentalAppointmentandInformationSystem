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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DentalAppointmentandInformationSystem
{
    public partial class ServicesListArchived : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;

        public ServicesListArchived()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void ServicesList_Load(object sender, EventArgs e)
        {
        }

        public void setServiceInfo(string service_id, string service_name, string service_price)
        {
            serviceID.Text = service_id;
            serviceName.Text = service_name;
            servicePrice.Text = service_price;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    reader1.Close();
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this service permanently?\nYou will not be able to retrieve this!", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        v.getsetserviceSelected = serviceID.Text;
                        string query2 = "DELETE FROM Service_Archive WHERE service_id ='" + v.getsetserviceSelected + "';";
                        SqlCommand cmd2 = new SqlCommand(query2, constring);
                        cmd2.CommandText = query2;
                        if (cmd2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Service deleted permanently!");
                            constring.Close();
                            Services srvcs = new Services();
                            srvcs.Show();
                            this.ParentForm.Hide();
                        }
                    }
                    constring.Close();
                }
                else
                {
                    MessageBox.Show("You do not have the authorization to delete services!");
                    constring.Close();
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }

        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            constring.Open();
            DialogResult dialogResult = MessageBox.Show("Restore this service?", "Confirm Restore", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                v.getsetserviceSelected = serviceID.Text;
                string query = "INSERT INTO Service SELECT * FROM Service_Archive WHERE service_id =" + v.getsetserviceSelected;
                SqlCommand cmdd = new SqlCommand(query, constring);
                cmdd.CommandText = query;
                string query2 = "DELETE FROM Service_Archive WHERE service_id ='" + v.getsetserviceSelected + "';";
                SqlCommand cmd2 = new SqlCommand(query2, constring);
                cmd2.CommandText = query2;
                if (cmdd.ExecuteNonQuery() == 1 && cmd2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Service successfully restored!");
                    constring.Close();
                    Services srvcs = new Services();
                    srvcs.Show();
                    this.ParentForm.Hide();
                }
            }
            constring.Close();
        }
    }
}
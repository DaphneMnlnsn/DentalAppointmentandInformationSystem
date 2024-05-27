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
    public partial class EditService : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;

        public EditService()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void EditService_Load(object sender, EventArgs e)
        {
            
        }

        private void saveSrvcBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(srvcNameTxtBox.Text) && !string.IsNullOrWhiteSpace(srvcPriceTxtBox.Text))
            {
                constring.Open();

                string query2 = "UPDATE Service SET service_name = '" + srvcNameTxtBox.Text +
                    "', service_price = '" + srvcPriceTxtBox.Text + "' WHERE service_id = '" + v.getsetserviceSelected + "';";

                SqlCommand cmd3 = new SqlCommand(query2, constring);
                cmd3.CommandText = query2;
                if (cmd3.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Changes Saved!");
                    this.Visible = false;
                    this.ParentForm.Hide();
                    constring.Close();
                    Services srvc = new Services();
                    srvc.Show();
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void setValues()
        {
            constring.Open();
            string query = "SELECT * FROM Service WHERE service_id =" + int.Parse(v.getsetserviceSelected);
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                srvcNameTxtBox.Text = row["service_name"].ToString();
                srvcPriceTxtBox.Text = row["service_price"].ToString();
            }
            constring.Close();
        }
    }
}

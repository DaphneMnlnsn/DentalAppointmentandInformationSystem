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
    public partial class ServicesList : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;

        public ServicesList()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void ServicesList_Load(object sender, EventArgs e)
        {
        }

        public void setServiceInfo(string service_id, string service_name, float service_price, float service_duration)
        {
            serviceID.Text = service_id;
            serviceName.Text = service_name;
            servicePrice.Text = service_price.ToString("#,##0.00");
            srvcDuration.Text = service_duration.ToString();
        }

        private void editBtn_Click(object sender, EventArgs e)
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
                    v.getsetserviceSelected = serviceID.Text;
                    Services mainForm;
                    mainForm = (Services)this.FindForm();
                    mainForm.editVisible();
                }
                else
                {
                    MessageBox.Show("You do not have authorization to open this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    constring.Close();
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //Deleting a service
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    reader1.Close();
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this service?\nThis will be moved to the trash bin.", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        v.getsetserviceSelected = serviceID.Text;
                        string query2 = "UPDATE Service SET status = 0 WHERE service_id ='" + v.getsetserviceSelected + "';";
                        SqlCommand cmd2 = new SqlCommand(query2, constring);
                        cmd2.CommandText = query2;
                        if (cmd2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Service successfully moved to the Trash Bin/Archives!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string queryAct = "INSERT INTO Activity_Log VALUES('" + v.getsetloggedIn + "','" + DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")) + "','archived service "
                                + v.getsetserviceSelected + "')";

                            SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                            cmdAct.CommandText = queryAct;
                            cmdAct.ExecuteNonQuery();
                            constring.Close();
                            Services srvcs = new Services();
                            srvcs.Show();
                            this.ParentForm.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Service cannot be deleted because it is included in a patient's record!","Error",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("You do not have authorization to delete this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    constring.Close();
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            
        }
    }
}
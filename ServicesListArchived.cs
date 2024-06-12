using DentalAppointmentandInformationSystem;
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

        public void setServiceInfo(string service_id, string service_name, float service_price, float service_duration)
        {
            //Setting service information in the user control
            serviceID.Text = service_id;
            serviceName.Text = service_name;
            servicePrice.Text = service_price.ToString("#,##0.00");
            srvcDuration.Text = service_duration.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //Deleting the service permanently
            constring.Open();
            v.getsetserviceSelected = serviceID.Text;

            //Checking if the service is being used in an appointment
            string sql = "SELECT * FROM Appointment WHERE service_id = '" + v.getsetserviceSelected + "' OR service_id2 = '" + v.getsetserviceSelected + "' OR service_id3 = '" + v.getsetserviceSelected + "'";
            DataTable appointments = new DataTable("appointments");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(appointments);

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
                        if (appointments.Rows.Count <= 0)
                        {
                            string query2 = "DELETE FROM Service WHERE service_id ='" + v.getsetserviceSelected + "';";
                            SqlCommand cmd2 = new SqlCommand(query2, constring);
                            cmd2.CommandText = query2;
                            if (cmd2.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Service deleted permanently!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string queryAct = "INSERT INTO Activity_Log VALUES('" + v.getsetloggedIn + "','" + DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")) + "','permanently deleted service "
                                + v.getsetserviceSelected + "')";

                                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                                cmdAct.CommandText = queryAct;
                                cmdAct.ExecuteNonQuery();
                                constring.Close();
                                ServiceArchives srvcs = new ServiceArchives();
                                srvcs.Show();
                                this.ParentForm.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("This service is currently employed by an appointment!\nPlease delete the appointment using it first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    constring.Close();
                }
                else
                {
                    MessageBox.Show("You do not have authorization to delete services!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //Restoring an appointment
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    reader1.Close();
                    DialogResult dialogResult = MessageBox.Show("Restore this service?", "Confirm Restore", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        v.getsetserviceSelected = serviceID.Text;
                        string query2 = "UPDATE Service SET status = 1 WHERE service_id ='" + v.getsetserviceSelected + "';";
                        SqlCommand cmd2 = new SqlCommand(query2, constring);
                        cmd2.CommandText = query2;
                        if (cmd2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Service successfully restored!");
                            string queryAct = "INSERT INTO Activity_Log VALUES('" + v.getsetloggedIn + "','" + DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")) + "','restored service "
                                + v.getsetserviceSelected + "')";

                            SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                            cmdAct.CommandText = queryAct;
                            cmdAct.ExecuteNonQuery();
                            constring.Close();
                            ServiceArchives srvcs = new ServiceArchives();
                            srvcs.Show();
                            this.ParentForm.Hide();
                        }
                    }
                    constring.Close();
                }
                else
                {
                    MessageBox.Show("You do not have the authorization to restore archived services!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
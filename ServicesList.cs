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

        public void setServiceInfo(string service_id, string service_name, string service_price)
        {
            serviceID.Text = service_id;
            serviceName.Text = service_name;
            servicePrice.Text = service_price;
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
                    MessageBox.Show("You do not have the authorization to edit services!");
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
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this service?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        v.getsetserviceSelected = serviceID.Text;
                        string query = "DELETE FROM Service WHERE service_id ='" + v.getsetserviceSelected + "';";
                        SqlCommand cmdd = new SqlCommand(query, constring);
                        cmdd.CommandText = query;
                        if (cmdd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Service Deleted Successfully!");
                            constring.Close();
                            Services srvcs = new Services();
                            srvcs.Show();
                            this.ParentForm.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Service cannot be deleted because it is included in a patient's record!");
                        }

                    }
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
    }
}
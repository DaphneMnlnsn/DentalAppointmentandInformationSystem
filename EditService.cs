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
            //Updating the service details
            if (!string.IsNullOrWhiteSpace(srvcNameTxtBox.Text) && !string.IsNullOrWhiteSpace(srvcPriceTxtBox.Text) && !string.IsNullOrWhiteSpace(srvcDuration.Text))
            {
                float num;
                bool checkInput = float.TryParse(srvcPriceTxtBox.Text, out num);

                if (checkInput == true)
                {
                    constring.Open();

                    string query2 = "UPDATE Service SET service_name = '" + srvcNameTxtBox.Text +
                        "', service_price = '" + srvcPriceTxtBox.Text + "', service_duration = '" +
                        srvcDuration.Text + "' WHERE service_id = '" + v.getsetserviceSelected + "';";

                    SqlCommand cmd3 = new SqlCommand(query2, constring);
                    cmd3.CommandText = query2;
                    if (cmd3.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Changes saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string queryAct = "INSERT INTO Activity_Log VALUES('" + v.getsetloggedIn + "','" + DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")) + "','edited service "
                                + v.getsetserviceSelected + "')";

                        SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                        cmdAct.CommandText = queryAct;
                        cmdAct.ExecuteNonQuery();
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
                    MessageBox.Show("Please input a number for the price!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                srvcDuration.Text = row["service_duration"].ToString();
            }
            constring.Close();
        }
    }
}

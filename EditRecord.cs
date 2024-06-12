using Microsoft.SqlServer.Server;
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
using static System.Net.Mime.MediaTypeNames;

namespace DentalAppointmentandInformationSystem
{
    public partial class EditRecord : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;
        string appointmentID;

        public EditRecord()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void EditService_Load(object sender, EventArgs e)
        {

        }

        private void saveSrvcBtn_Click(object sender, EventArgs e)
        {
            //Saving or updating the patient record/appointment history
            if (!string.IsNullOrWhiteSpace(teethTrtdTxtBox.Text) && !string.IsNullOrWhiteSpace(priceBilledTxtBox.Text))
            {
                float num;
                bool checkInput = float.TryParse(priceBilledTxtBox.Text, out num);

                if (checkInput == true)
                {
                    constring.Open();

                    string query2 = "UPDATE Record SET teeth_treated = '" + teethTrtdTxtBox.Text +
                        "', price_billed = '" + priceBilledTxtBox.Text + "' WHERE record_id = '" + v.getsetrecordSelected + "';";

                    SqlCommand cmd3 = new SqlCommand(query2, constring);
                    cmd3.CommandText = query2;
                    if (cmd3.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Changes saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string queryAct = "INSERT INTO Activity_Log VALUES('" + v.getsetloggedIn + "','" + DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")) + "','edited record of patient "
                                + v.getsetpatientSelected + "')";

                        SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                        cmdAct.CommandText = queryAct;
                        cmdAct.ExecuteNonQuery();

                        if (!teethTrtdTxtBox.Text.Equals("0"))
                        {
                            SqlCommand cmd = new SqlCommand("SELECT * FROM Appointment WHERE appointment_id =" + int.Parse(appointmentID), constring);
                            SqlDataReader read;
                            read = cmd.ExecuteReader();
                            string appointment_service1 = "", appointment_service2 = "", appointment_service3 = "";
                            if (read.Read())
                            {
                                appointment_service1 = read["service_id"].ToString();
                                appointment_service2 = read["service_id2"].ToString();
                                appointment_service3 = read["service_id3"].ToString();
                            }
                            read.Close();

                            string query = "SELECT * FROM Service WHERE service_id ='" + appointment_service1 + "' OR service_id ='" + appointment_service2 + "' OR service_id ='" + appointment_service3 + "'";
                            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
                            DataTable dt = new DataTable();
                            adpt.Fill(dt);
                            bool extracted = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                if (row["service_name"].ToString().Contains("extract") || row["service_name"].ToString().Contains("Extract"))
                                {
                                    extracted = true;
                                }
                            }

                            string[] teeth = teethTrtdTxtBox.Text.Split(' ', ',');

                            foreach (var tooth in teeth)
                            {
                                if (extracted == true)
                                {
                                    string queryDental = "UPDATE Teeth SET tooth_" + tooth + " = '6X' WHERE patient_id = '" + v.getsetpatientSelected + "';";

                                    SqlCommand cmdDental = new SqlCommand(queryDental, constring);
                                    cmdDental.CommandText = queryDental;
                                    cmdDental.ExecuteNonQuery();
                                }
                                else
                                {
                                    string queryDental = "UPDATE Teeth SET tooth_" + tooth + " = '6' WHERE patient_id = '" + v.getsetpatientSelected + "';";

                                    SqlCommand cmdDental = new SqlCommand(queryDental, constring);
                                    cmdDental.CommandText = queryDental;
                                    cmdDental.ExecuteNonQuery();
                                }
                            }
                        }

                        this.Visible = false;
                        this.ParentForm.Hide();
                        constring.Close();
                        PatientDetails ptntDetails = new PatientDetails();
                        ptntDetails.Show();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Please input a number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            string query = "SELECT * FROM Record WHERE record_id =" + int.Parse(v.getsetrecordSelected);
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                teethTrtdTxtBox.Text = row["teeth_treated"].ToString();
                priceBilledTxtBox.Text = row["price_billed"].ToString();
                appointmentID = row["appointment_id"].ToString();
            }
            constring.Close();
        }
    }
}

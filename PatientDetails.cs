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
    public partial class PatientDetails : Form
    {
        Variables v = new Variables();
        SqlConnection constring;
        public PatientDetails()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void PatientDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void PatientDetails_Load(object sender, EventArgs e)
        {
            editRecord1.Visible = false;
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            displayPatientDetails();
        }

        private void editPatientBtn_Click(object sender, EventArgs e)
        {
            EditPatient editptnt = new EditPatient();
            editptnt.Show();
            this.Hide();
        }

        private void displayPatientDetails()
        {
            constring.Open();
            string sql = "SELECT * FROM Patient WHERE patient_id = " + v.getsetpatientSelected;
            DataTable patients = new DataTable("patients");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(patients);

            foreach (DataRow row in patients.Rows)
            {
                string patient_fullname = "";
                if (row["patient_mname"].ToString().Equals(null) || row["patient_mname"].ToString().Equals(""))
                {
                    patient_fullname = row["patient_fname"].ToString() + " " + row["patient_lname"].ToString();
                }
                else
                {
                    patient_fullname = row["patient_fname"].ToString() + " " + row["patient_mname"].ToString() + " " + row["patient_lname"].ToString();

                }
                string lastVisit = "";
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 appointment_date FROM Appointment WHERE patient_id = '" + row["patient_id"].ToString() + "' ORDER BY appointment_id DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    lastVisit += (DateTime.Parse(reader1["appointment_date"].ToString()).ToString("MM/dd/yyyy")).ToString();
                }
                reader1.Close();

                if (row["patient_gender"].ToString().Equals("Male"))
                {
                    picBoxFemale.Visible = false;
                }

                patientName.Text = patient_fullname.ToString();
                patientAge.Text = "Age: " + row["patient_age"].ToString();
                patientGender.Text = "Gender: " + row["patient_gender"].ToString();
                patientBday.Text = "Birthdate: " + DateTime.Parse(row["patient_bdate"].ToString()).ToString("MM/dd/yyyy");
                patientAddress.Text = "Address: " + row["patient_address"].ToString();
                patientEmail.Text = "Email Address: " + row["patient_email"].ToString();
                patientCnum.Text = "Contact Number: " + row["patient_cnum"].ToString();
                patientCper.Text = "Contact Person: " + row["patient_cperson"].ToString();
                patientLV.Text = "Last Visit: " + lastVisit.ToString();

                string sql2 = "SELECT * FROM Record WHERE patient_id = " + v.getsetpatientSelected;
                DataTable records = new DataTable("record");
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, constring);
                da2.Fill(records);

                foreach (DataRow row2 in records.Rows)
                {
                    string sql3 = "SELECT * FROM Appointment WHERE patient_id = " + v.getsetpatientSelected;
                    DataTable apps = new DataTable("appointments");
                    SqlDataAdapter da3 = new SqlDataAdapter(sql3, constring);
                    da3.Fill(apps);

                    string recordsDate = "", recordsTreat = "", recordsTooth, recordsPrice;
                    foreach (DataRow row3 in apps.Rows)
                    {
                        recordsDate += DateTime.Parse(row3["appointment_date"].ToString()).ToString("MM/dd/yyyy");

                        SqlCommand retrieveService = new SqlCommand("SELECT service_name FROM Service WHERE service_id = '" + row3["service_id"].ToString() + "'", constring);
                        SqlDataReader readService;
                        readService = retrieveService.ExecuteReader();
                        if (readService.Read())
                        {
                            recordsTreat += readService["service_name"].ToString();
                        }
                        readService.Close();
                        if (!string.IsNullOrEmpty(row3["service_id2"].ToString()))
                        {
                            SqlCommand retrieveService2 = new SqlCommand("SELECT service_name FROM Service WHERE service_id = '" + row3["service_id2"].ToString() + "'", constring);
                            SqlDataReader readService2;
                            readService2 = retrieveService2.ExecuteReader();
                            if (readService2.Read())
                            {
                                recordsTreat += ", " + readService2["service_name"].ToString();
                            }
                            readService2.Close();
                        }
                        if (!string.IsNullOrEmpty(row3["service_id3"].ToString()))
                        {
                            SqlCommand retrieveService3 = new SqlCommand("SELECT service_name FROM Service WHERE service_id = '" + row3["service_id3"].ToString() + "'", constring);
                            SqlDataReader readService3;
                            readService3 = retrieveService3.ExecuteReader();
                            if (readService3.Read())
                            {
                                recordsTreat += ", " + readService3["service_id3"].ToString();
                            }
                            
                        }
                    }
                    
                    recordsTooth = row2["teeth_treated"].ToString();
                    recordsPrice = row2["price_billed"].ToString();

                    Record record = new Record();
                    record.setPatientInfo(row2["record_id"].ToString(), recordsDate, recordsTreat, recordsTooth, recordsPrice);
                    recordContainer.Controls.Add(record);
                }
            }
            constring.Close();
        }

        private void dshbrdBtn_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            this.Hide();
        }

        private void clndrbtn_Click(object sender, EventArgs e)
        {
            Calendar clndr = new Calendar();
            clndr.Show();
            this.Hide();
        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            Patients patnt = new Patients();
            patnt.Show();
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
                    Staff stf = new Staff();
                    stf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You do not have the authorization to open this!");
                    constring.Close();
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            Services srvcs = new Services();
            srvcs.Show();
            this.Hide();
        }

        public void editVisible()
        {
            editRecord1.Visible = true;
            editRecord1.setValues();
        }

        private void deletePtnt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this patient? \nAll records of the patient will be deleted!", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                constring.Open();
                string query = "DELETE FROM Appointment WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmd = new SqlCommand(query, constring);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                string query2 = "DELETE FROM Record WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmd2 = new SqlCommand(query2, constring);
                cmd2.CommandText = query2;
                cmd2.ExecuteNonQuery();
                string query3 = "DELETE FROM History WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmd3 = new SqlCommand(query3, constring);
                cmd3.CommandText = query3;
                cmd3.ExecuteNonQuery();
                string query4 = "DELETE FROM Patient WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmd4 = new SqlCommand(query4, constring);
                cmd4.CommandText = query4;
                if (cmd4.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Patient Deleted Successfully!");
                    constring.Close();
                    Patients ptnt = new Patients();
                    ptnt.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("DATA NOT DELETED SUCCESSFULLY");
                }
            }
        }
    }
}
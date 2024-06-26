﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalAppointmentandInformationSystem
{
    public partial class EditPatient : Form
    {
        Variables v = new Variables();
        SqlConnection constring;
        byte[] bytes;
        string fileName;
        public EditPatient()
        {
            InitializeComponent();
            constring = v.getConnection;
        }
        private void EditPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void EditPatient_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(2).ToString().Equals("NULL") || reader1.GetValue(2).ToString().Equals(""))
                {
                    emNameTxtBox.Text = reader1.GetValue(3).ToString() + " " + reader1.GetValue(1).ToString();
                }
                else
                {
                    emNameTxtBox.Text = reader1.GetValue(3).ToString() + " " + reader1.GetValue(2).ToString() + " " + reader1.GetValue(1).ToString();
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            constring.Close();
            List<string> items = new List<string>()
            {
                "Female", "Male"
            };
            genderCombo.DataSource = items;
            setValues();
            
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            this.Hide();
        }
        private void apptclndrBtn_Click(object sender, EventArgs e)
        {
            Calendar cldr = new Calendar();
            cldr.Show();
            this.Hide();
        }

        private void ptntBtn_Click(object sender, EventArgs e)
        {
            Patients ptnt = new Patients();
            ptnt.Show();
            this.Hide();
        }

        private void setValues()
        {
            constring.Open();
            string query = "SELECT * FROM Patient WHERE patient_id =" + int.Parse(v.getsetpatientSelected);
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                pIDTextBox.Text = row["patient_id"].ToString();

                string sql2 = "SELECT * FROM Patient WHERE patient_id = " + "'" + pIDTextBox.Text + "'";
                SqlCommand cmd2 = constring.CreateCommand();
                cmd2.CommandText = sql2;
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    patientCombo.Text = reader2["patient_lname"].ToString() + ", " + reader2["patient_fname"].ToString() + " " + reader2["patient_mname"].ToString();
                }
                reader2.Dispose();
                cmd2.Dispose();
                
                phoneTxtBox.Text = row["patient_cnum"].ToString();
                ageTxtBox.Text = row["patient_age"].ToString();
                emailTxtBox.Text = row["patient_email"].ToString();
                genderCombo.Text = row["patient_gender"].ToString();
                birthDate.Text = row["patient_bdate"].ToString();
                addressTxtBox.Text = row["patient_address"].ToString();
                contactPrsnTxtBox.Text = row["patient_cperson"].ToString();
                cpersonNumTxtBox.Text = row["patient_cpernum"].ToString();
                notesTxtBox.Text = row["patient_notes"].ToString();
            }
            constring.Close();
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
                    constring.Close();
                    MessageBox.Show("You do not have authorization to open this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            v.getsetloggedIn = "";
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void savePatientBtn_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            Regex addressRegex = new Regex(pattern, RegexOptions.IgnoreCase);

            if (!string.IsNullOrWhiteSpace(phoneTxtBox.Text) && !string.IsNullOrWhiteSpace(ageTxtBox.Text) &&
                !string.IsNullOrWhiteSpace(addressTxtBox.Text) && !string.IsNullOrWhiteSpace(contactPrsnTxtBox.Text) && 
                !string.IsNullOrWhiteSpace(cpersonNumTxtBox.Text))
            {
                if (addressRegex.IsMatch(emailTxtBox.Text) != true && !string.IsNullOrWhiteSpace(emailTxtBox.Text))
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    emailTxtBox.Focus();
                }
                else
                {
                    string gender = genderCombo.Items[genderCombo.SelectedIndex].ToString();
                    constring.Open();

                    string query2 = "UPDATE Patient SET patient_cnum = '" + phoneTxtBox.Text +
                        "', patient_age = '" + ageTxtBox.Text + "', patient_gender = '" + genderCombo.Text +
                        "', patient_email = '" + emailTxtBox.Text + "', patient_bdate = '" + birthDate.Text +
                        "', patient_address = '" + addressTxtBox.Text + "', patient_cperson = '" + contactPrsnTxtBox.Text +
                        "', patient_cpernum = '" + cpersonNumTxtBox.Text + "', patient_notes = '" + notesTxtBox.Text +
                        "' WHERE patient_id = '" + v.getsetpatientSelected + "';";

                    SqlCommand cmd3 = new SqlCommand(query2, constring);
                    if(cmd3.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Changes saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string queryAct = "INSERT INTO Activity_Log VALUES('" + v.getsetloggedIn + "','" + DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")) + "','edited patient "
                                + v.getsetpatientSelected + "')";

                        SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                        cmdAct.CommandText = queryAct;
                        cmdAct.ExecuteNonQuery();
                        constring.Close();
                        PatientDetails pDetails = new PatientDetails();
                        pDetails.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private int CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            if (dateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
        private void birthDate_Leave(object sender, EventArgs e)
        {
            ageTxtBox.ReadOnly = false;
            ageTxtBox.Text = CalculateAge(DateTime.Parse(birthDate.Text)).ToString();
            ageTxtBox.ReadOnly = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new PatientDetails().Show();
            this.Hide();
        }
    }
}
using System;
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
            setValues();
            List<string> items = new List<string>()
            {
                "Female", "Male"
            };
            genderCombo.DataSource = items;
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
                genderCombo.Text = row["patient_gender"].ToString();
                emailTxtBox.Text = row["patient_email"].ToString();
                birthDate.Text = row["patient_bdate"].ToString();
                addressTxtBox.Text = row["patient_address"].ToString();
                contactPrsnTxtBox.Text = row["patient_cperson"].ToString();
                cpersonNumTxtBox.Text = row["patient_cpernum"].ToString();
                notesTxtBox.Text = row["patient_notes"].ToString();
            }

            string queryy = "SELECT * FROM History WHERE patient_id =" + int.Parse(v.getsetpatientSelected);
            SqlDataAdapter adpty = new SqlDataAdapter(queryy, constring);
            DataTable dtt = new DataTable();
            adpty.Fill(dtt);
            foreach (DataRow row in dtt.Rows)
            {
                dentistTxtBox.Text = row["dentist_name"].ToString();
                pastTreatTxtBox.Text = row["past_treatment"].ToString();
                if (row["medhistory_fileName"] != null )
                {
                    attachFileBtn.Text = row["medhistory_filename"].ToString();
                }
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
                    MessageBox.Show("You do not have the authorization to open this!");
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
        private void attachFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Documents";
            openFileDialog1.Title = "Select medical record file.";
            openFileDialog1.Filter = "Select Valid Document(*.pdf; *.doc; *.xlsx; *.html; *.png; *.jpg)|*.pdf; *.docx; *.xlsx; *.html; *.png; *.jpg";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog1.CheckFileExists)
                {
                    fileName = Path.GetFileName(openFileDialog1.FileName);
                    bytes = File.ReadAllBytes(openFileDialog1.FileName);
                    attachFileBtn.Text = fileName;
                }
            }
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
                    cmd3.ExecuteNonQuery();

                    if (!string.IsNullOrWhiteSpace(dentistTxtBox.Text) && !string.IsNullOrWhiteSpace(pastTreatTxtBox.Text))
                    {
                        int historyID = 0;
                        SqlCommand cm = new SqlCommand("SELECT history_id FROM History WHERE patient_id = '" + pIDTextBox.Text + "'", constring);
                        SqlDataReader read;
                        read = cm.ExecuteReader();
                        if (read.Read())
                        {
                            historyID = read.GetInt32(0);
                            read.Close();
                            cm.Dispose();
                            if (attachFileBtn.Text.Equals("+ Add Attachment"))
                            {
                                SqlCommand command = new SqlCommand("UPDATE History SET dentist_name = '" +
                                    dentistTxtBox.Text + "', past_treatment = '" + pastTreatTxtBox +
                                    "' WHERE patient_id = " + pIDTextBox.Text + ";", constring);
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Changes saved!");
                                }
                            }
                            else
                            {
                                SqlCommand command = new SqlCommand("UPDATE History SET medhistory_filename = '" + fileName +
                                    "',med_history = CONVERT(varbinary, '" + bytes +
                                     "'), dentist_name = '" + dentistTxtBox.Text + "', past_treatment = '" +
                                     pastTreatTxtBox.Text + "' WHERE patient_id = " + pIDTextBox.Text + ";", constring);
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Changes saved!");
                                }
                            }
                        }
                        else
                        {
                            read.Close(); cm.Dispose();
                            int historyIDNew = 0;
                            SqlCommand cmNew = new SqlCommand("SELECT TOP 1 history_id FROM History ORDER BY history_id DESC", constring);
                            SqlDataReader readNew;
                            readNew = cmNew.ExecuteReader();
                            if (readNew.Read())
                            {
                                historyIDNew = readNew.GetInt32(0) + 1;
                            }
                            else
                            {
                                MessageBox.Show("NO DATA FOUND");
                            }
                            readNew.Close();
                            cmNew.Dispose();
                            if (attachFileBtn.Text.Equals("+ Add Attachment"))
                            {
                                SqlCommand command = new SqlCommand("INSERT INTO History VALUES ('" + historyIDNew + "','" + pIDTextBox.Text +
                                    "',NULL,NULL,'" + dentistTxtBox.Text + "','" + pastTreatTxtBox.Text + "')", constring);
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("History added successfully!");
                                }
                            }
                            else
                            {
                                SqlCommand command = new SqlCommand("INSERT INTO History VALUES ('" + historyIDNew + "','" + pIDTextBox.Text +
                                   "','" + fileName + "',CONVERT(varbinary, '" + bytes + "'),'" + dentistTxtBox.Text + "','" + pastTreatTxtBox.Text + "')", constring);
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("History added successfully!");
                                }
                            }
                        }
                        constring.Close();
                        PatientDetails pDetails = new PatientDetails();
                        pDetails.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Changes saved!");
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
    }
}
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
    public partial class NewPatient : Form
    {
        Variables v = new Variables();
        SqlConnection constring;

        public NewPatient()
        {
            InitializeComponent();
            constring = v.getConnection;
        }
        private void NewPatient_Load(object sender, EventArgs e)
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
        }
        /*private void attachFileBtn_Click(object sender, EventArgs e)
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
        }*/

        private void savePatientBtn_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            Regex addressRegex = new Regex(pattern, RegexOptions.IgnoreCase);
            constring.Open();
            string patientExistingQuery = "SELECT COUNT(*) FROM Patient WHERE patient_lname = '" + lnameTxtBox.Text +
                "' AND patient_mname = '" + mnameTxtBox.Text +
                "' AND patient_fname = '" + fnameTxtBox.Text + "'";
            SqlCommand patientExisting = new SqlCommand(patientExistingQuery, constring);
            int patientExists = (int)patientExisting.ExecuteScalar();
            constring.Close();

            if (patientExists <= 0)
            {
                if (!string.IsNullOrWhiteSpace(fnameTxtBox.Text) && !string.IsNullOrWhiteSpace(lnameTxtBox.Text) &&
                    !string.IsNullOrWhiteSpace(phoneTxtBox.Text) && !string.IsNullOrWhiteSpace(ageTxtBox.Text) &&
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
                        int patientID = 0, quadrant1 = 0, quadrant2 = 0, quadrant3 = 0, quadrant4 = 0;
                        constring.Open();

                        //Quadrant 1 Num Creation
                        SqlCommand createQuadrant1 = new SqlCommand("SELECT TOP 1 quadrant1_num FROM Quadrant1 ORDER BY quadrant1_num DESC", constring);
                        SqlDataReader quadrant1Reader;
                        quadrant1Reader = createQuadrant1.ExecuteReader();
                        if (quadrant1Reader.Read())
                        {
                            quadrant1 = quadrant1Reader.GetInt32(0) + 1;
                        }
                        else
                        {
                            MessageBox.Show("NO DATA FOUND");
                        }
                        quadrant1Reader.Close();
                        createQuadrant1.Dispose();

                        string quadrant1Query = "INSERT INTO Quadrant1(quadrant1_num,status) VALUES('" + quadrant1 + "',1)";

                        SqlCommand quadrant1Cmd = new SqlCommand(quadrant1Query, constring);
                        quadrant1Cmd.CommandText = quadrant1Query;
                        quadrant1Cmd.ExecuteNonQuery();

                        //Quadrant 2 Num Creation
                        SqlCommand createQuadrant2 = new SqlCommand("SELECT TOP 1 quadrant2_num FROM Quadrant2 ORDER BY quadrant2_num DESC", constring);
                        SqlDataReader quadrant2Reader;
                        quadrant2Reader = createQuadrant2.ExecuteReader();
                        if (quadrant2Reader.Read())
                        {
                            quadrant2 = quadrant2Reader.GetInt32(0) + 1;
                        }
                        else
                        {
                            MessageBox.Show("NO DATA FOUND");
                        }
                        quadrant2Reader.Close();
                        createQuadrant2.Dispose();

                        string quadrant2Query = "INSERT INTO Quadrant2(quadrant2_num,status) VALUES('" + quadrant2 + "',1)";

                        SqlCommand quadrant2Cmd = new SqlCommand(quadrant2Query, constring);
                        quadrant2Cmd.CommandText = quadrant2Query;
                        quadrant2Cmd.ExecuteNonQuery();

                        //Quadrant 3 Num Creation
                        SqlCommand createQuadrant3 = new SqlCommand("SELECT TOP 1 quadrant3_num FROM Quadrant3 ORDER BY quadrant3_num DESC", constring);
                        SqlDataReader quadrant3Reader;
                        quadrant3Reader = createQuadrant3.ExecuteReader();
                        if (quadrant3Reader.Read())
                        {
                            quadrant3 = quadrant3Reader.GetInt32(0) + 1;
                        }
                        else
                        {
                            MessageBox.Show("NO DATA FOUND");
                        }
                        quadrant3Reader.Close();
                        createQuadrant3.Dispose();

                        string quadrant3Query = "INSERT INTO Quadrant3(quadrant3_num,status) VALUES('" + quadrant3 + "',1)";

                        SqlCommand quadrant3Cmd = new SqlCommand(quadrant3Query, constring);
                        quadrant3Cmd.CommandText = quadrant3Query;
                        quadrant3Cmd.ExecuteNonQuery();

                        //Quadrant 4 Num Creation
                        SqlCommand createQuadrant4 = new SqlCommand("SELECT TOP 1 quadrant4_num FROM Quadrant4 ORDER BY quadrant4_num DESC", constring);
                        SqlDataReader quadrant4Reader;
                        quadrant4Reader = createQuadrant4.ExecuteReader();
                        if (quadrant4Reader.Read())
                        {
                            quadrant4 = quadrant4Reader.GetInt32(0) + 1;
                        }
                        else
                        {
                            MessageBox.Show("NO DATA FOUND");
                        }
                        quadrant4Reader.Close();
                        createQuadrant4.Dispose();

                        string quadrant4Query = "INSERT INTO Quadrant4(quadrant4_num,status) VALUES('" + quadrant4 + "',1)";

                        SqlCommand quadrant4Cmd = new SqlCommand(quadrant4Query, constring);
                        quadrant4Cmd.CommandText = quadrant4Query;
                        quadrant4Cmd.ExecuteNonQuery();

                        //Creation of Patient Record
                        SqlCommand cmd = new SqlCommand("SELECT TOP 1 patient_id FROM Patient ORDER BY patient_id DESC", constring);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            patientID = reader1.GetInt32(0) + 1;
                        }
                        else
                        {
                            MessageBox.Show("NO DATA FOUND");
                        }
                        reader1.Close();
                        cmd.Dispose();

                        string query = "INSERT INTO Patient VALUES('" + patientID + "','" + lnameTxtBox.Text + "','"
                                + mnameTxtBox.Text + "','" + fnameTxtBox.Text + "','" + ageTxtBox.Text + "','" + gender
                                + "','" + birthDate.Text + "','" + phoneTxtBox.Text + "','" + emailTxtBox.Text + "','"
                                + addressTxtBox.Text + "','" + contactPrsnTxtBox.Text + "','" + cpersonNumTxtBox.Text + "','"
                                + notesTxtBox.Text + "','" + quadrant1 + "','" + quadrant2 + "','" + quadrant3 + "','" + quadrant4 + "',1)";

                        SqlCommand cmd2 = new SqlCommand(query, constring);
                        cmd2.CommandText = query;
                        if (cmd2.ExecuteNonQuery() == 1)
                        {
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. Please try again.");
                        }

                        /*if ((!string.IsNullOrEmpty(dentistTxtBox.Text)) && (!string.IsNullOrEmpty(pastTreatTxtBox.Text)))
                        {
                            int historyID = 0;
                            SqlCommand cm = new SqlCommand("SELECT TOP 1 history_id FROM History ORDER BY history_id DESC", constring);
                            SqlDataReader read;
                            read = cm.ExecuteReader();
                            if (read.Read())
                            {
                                historyID = read.GetInt32(0) + 1;
                            }
                            else
                            {
                                MessageBox.Show("NO DATA FOUND");
                            }
                            read.Close();
                            cm.Dispose();
                            if (attachFileBtn.Text.Equals("+ Add Attachment"))
                            {
                                SqlCommand command = new SqlCommand("INSERT INTO History VALUES ('" + historyID + "','" + patientID +
                                    "',NULL,NULL,'" + dentistTxtBox.Text + "','" + pastTreatTxtBox.Text + "',1)", constring);
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Patient added successfully!");
                                }
                            }
                            else
                            {
                                SqlCommand command = new SqlCommand("INSERT INTO History VALUES ('" + historyID + "','" + patientID +
                                   "','" + fileName + "',CONVERT(varbinary, '" + bytes + "',1),'" + dentistTxtBox.Text + "','" + pastTreatTxtBox.Text + "')", constring);
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Patient added successfully!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Patient added successfully!");
                        }*/
                        constring.Close();
                        Patients patients = new Patients();
                        patients.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all required fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("This patient already has a record in the system!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void NewPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            dshbrd.Hide();
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
            new Patients().Show();
            this.Hide();
        }
    }
}
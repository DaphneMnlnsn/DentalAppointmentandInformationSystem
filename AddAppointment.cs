using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DentalAppointmentandInformationSystem
{
    public partial class AddAppointment : Form
    {
        Variables v = new Variables();
        SqlConnection constring;
        string currentService, currentService2, currentService3;
        public AddAppointment()
        {
            InitializeComponent();
            constring = v.getConnection;
        }
        private void AddAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;


            //Replacing nav bar staff name
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

            //Setting minimum date and maximum date to be selected
            appntmntDate.MinDate = DateTime.Now;
            if (DateTime.Now >= DateTime.Parse("10:00:00") && !(DateTime.Now >= DateTime.Parse("17:00:00")) && !(DateTime.Now.AddHours(1) >= DateTime.Parse("16:00:00")))
            {
                startTime.MinDate = DateTime.Now.AddHours(1);
                startTime.MaxDate = DateTime.Parse("16:00:00");
                endTime.MaxDate = DateTime.Parse("17:00:00");
            }
            else
            {
                appntmntDate.MinDate = DateTime.Now.AddDays(1);
                startTime.MinDate = DateTime.Parse("10:00:00");
                startTime.MaxDate = DateTime.Parse("16:00:00");
                endTime.MaxDate = DateTime.Parse("17:00:00");
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
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

        private void staffBtn_Click(object sender, EventArgs e)
        {
            //Check if staff is authorized to open list of staff
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
                    MessageBox.Show("You do not have authorization to open this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            v.getsetloggedIn = "";
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void savePatientBtn_Click(object sender, EventArgs e)
        {
            //pattern for email address
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            Regex addressRegex = new Regex(pattern, RegexOptions.IgnoreCase);

            //checking if the appointment is existing or if the patient is already existing
            constring.Open();
            string compareQuery = "SELECT COUNT(*) FROM Appointment WHERE appointment_date = '" + appntmntDate.Text +
                "' AND ('" + startTime.Text + "' <= appointment_endTime AND appointment_startTime <= '" + endTime.Text + "')";
            SqlCommand compareCmd = new SqlCommand(compareQuery, constring);
            int userCount = (int)compareCmd.ExecuteScalar();

            string patientExistingQuery = "SELECT COUNT(*) FROM Patient WHERE patient_lname = '" + lnameTxtBox.Text +
                "' AND patient_mname = '" + mnameTxtBox.Text +
                "' AND patient_fname = '" + fnameTxtBox.Text + "'";
            SqlCommand patientExisting = new SqlCommand(patientExistingQuery, constring);
            int patientExists = (int)patientExisting.ExecuteScalar();
            constring.Close();

            if (patientExists <= 0)
            {
                if (!string.IsNullOrWhiteSpace(fnameTxtBox.Text) && !string.IsNullOrWhiteSpace(lnameTxtBox.Text) &&
                    !string.IsNullOrWhiteSpace(ageTxtBox.Text) && !string.IsNullOrWhiteSpace(phoneTxtBox.Text) &&
                    !string.IsNullOrWhiteSpace(addressTxtBox.Text) && !string.IsNullOrWhiteSpace(contactPrsnTxtBox.Text) &&
                    !string.IsNullOrWhiteSpace(cpersonNumTxtBox.Text) && !string.IsNullOrWhiteSpace(service1Combo.Text) &&
                    !string.IsNullOrWhiteSpace(staff1Combo.Text))
                {
                    if (addressRegex.IsMatch(emailTxtBox.Text) != true && !string.IsNullOrWhiteSpace(emailTxtBox.Text))
                    {
                        MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        emailTxtBox.Focus();
                    }
                    else
                    {
                        if (userCount <= 0)
                        {
                            string gender = genderCombo.Items[genderCombo.SelectedIndex].ToString();
                            int patientID = 0;
                            int appointmentID = 0;
                            string service2, service3, staff2, staff3;
                            constring.Open();

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
                                + patientNotesTxtBox.Text + "',1)";

                            SqlCommand cmd2 = new SqlCommand(query, constring);
                            cmd2.CommandText = query;
                            cmd2.ExecuteNonQuery();

                            //Teeth Creation
                            string teethQuery = "INSERT INTO Teeth(patient_id,status) VALUES('" + patientID + "',1)";

                            SqlCommand teethCmd = new SqlCommand(teethQuery, constring);
                            teethCmd.CommandText = teethQuery;
                            teethCmd.ExecuteNonQuery();

                            //Creation of Appointment
                            SqlCommand command = new SqlCommand("SELECT TOP 1 appointment_id FROM Appointment ORDER BY appointment_id DESC", constring);
                            SqlDataReader read;
                            read = command.ExecuteReader();
                            if (read.Read())
                            {
                                appointmentID = read.GetInt32(0) + 1;
                            }
                            else
                            {
                                MessageBox.Show("NO DATA FOUND");
                            }
                            read.Close();
                            if (service2Combo.Text == null || service2Combo.Text == "")
                            {
                                service2 = "NULL";
                            }
                            else
                            {
                                service2 = service2Combo.SelectedValue.ToString();
                            }

                            if (service3Combo.Text == null || service3Combo.Text == "")
                            {
                                service3 = "NULL";
                            }
                            else
                            {
                                service3 = service2Combo.SelectedValue.ToString();
                            }
                            if (staff2Combo.Text == null || staff2Combo.Text == "")
                            {
                                staff2 = "NULL";
                            }
                            else
                            {
                                staff2 = staff2Combo.SelectedValue.ToString();
                            }

                            if (staff3Combo.Text == null || staff3Combo.Text == "")
                            {
                                staff3 = "NULL";
                            }
                            else
                            {
                                staff3 = staff3Combo.SelectedValue.ToString();
                            }
                            string query2 = "INSERT INTO Appointment VALUES('" + appointmentID + "','" + patientID + "','"
                                + service1Combo.SelectedValue + "'," + service2 + "," + service3 + ",'" + appntmntDate.Text
                                + "','" + startTime.Text + "','" + endTime.Text + "','" + staff1Combo.SelectedValue + "'," + staff2 + "," + staff3 + ",'" + notesTxtBox.Text + "','Pending',1)";

                            SqlCommand cmd3 = new SqlCommand(query2, constring);
                            cmd3.CommandText = query2;
                            if (cmd3.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Appointment created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string queryAct = "INSERT INTO Activity_Log VALUES('" + v.getsetloggedIn + "','" + DateTime.Now + "','added appointment "
                                + appointmentID + "')";

                                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                                cmdAct.CommandText = queryAct;
                                cmdAct.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("Something went wrong. Please try again.");
                            }

                            //Creation of patient record/appointment history
                            int recordID = 0;
                            SqlCommand com = new SqlCommand("SELECT TOP 1 record_id FROM Record ORDER BY record_id DESC", constring);
                            SqlDataReader re;
                            re = com.ExecuteReader();
                            if (re.Read())
                            {
                                recordID = re.GetInt32(0) + 1;
                            }
                            else
                            {
                                MessageBox.Show("NO DATA FOUND");
                            }
                            re.Close();

                            string sql3 = "SELECT * FROM Appointment WHERE patient_id = " + patientID + " AND appointment_id = " + appointmentID;
                            DataTable apps = new DataTable("appointments");
                            SqlDataAdapter da3 = new SqlDataAdapter(sql3, constring);
                            da3.Fill(apps);

                            string recordsDate = "";
                            float recordsPrice = 0;
                            foreach (DataRow row3 in apps.Rows)
                            {
                                recordsDate += DateTime.Parse(row3["appointment_date"].ToString()).ToString("MM/dd/yyyy");

                                SqlCommand retrieveServiceP = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + row3["service_id"].ToString() + "'", constring);
                                SqlDataReader readServiceP;
                                readServiceP = retrieveServiceP.ExecuteReader();
                                if (readServiceP.Read())
                                {
                                    recordsPrice += float.Parse(readServiceP["service_price"].ToString());
                                }
                                readServiceP.Close();
                                if (!string.IsNullOrEmpty(row3["service_id2"].ToString()))
                                {
                                    SqlCommand retrieveService2P = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + row3["service_id2"].ToString() + "'", constring);
                                    SqlDataReader readService2P;
                                    readService2P = retrieveService2P.ExecuteReader();
                                    if (readService2P.Read())
                                    {
                                        recordsPrice += float.Parse(readService2P["service_price"].ToString());
                                    }
                                    readService2P.Close();
                                }
                                if (!string.IsNullOrEmpty(row3["service_id3"].ToString()))
                                {
                                    SqlCommand retrieveService3P = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + row3["service_id3"].ToString() + "'", constring);
                                    SqlDataReader readService3P;
                                    readService3P = retrieveService3P.ExecuteReader();
                                    if (readService3P.Read())
                                    {
                                        recordsPrice += float.Parse(readService3P["service_price"].ToString());
                                    }
                                    readService3P.Close();
                                }
                            }
                            string query3 = "INSERT INTO Record VALUES('" + recordID + "','" + patientID + "','"
                                + service1Combo.Text + " " + service2Combo.Text + " " + service3Combo.Text + "','" + appointmentID
                                + "','0','" + recordsPrice + "',1);";

                            SqlCommand cmd4 = new SqlCommand(query3, constring);
                            cmd4.CommandText = query3;
                            if (cmd4.ExecuteNonQuery() == 1)
                            {
                                constring.Close();
                                Calendar clndr = new Calendar();
                                clndr.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Something went wrong. Please try again.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("This appointment schedule is taken! Please select another date or time.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
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

        private void staff1Combo_Click(object sender, EventArgs e)
        {
            //Assigning of data in the combo box
            string query = "SELECT * FROM Staff WHERE status = 1 AND employee_num != '10001' AND employee_role = 'Dentist'";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dt.Columns.Add("employee_name", typeof(string), "employee_fname + ' ' + employee_lname");
            staff1Combo.DataSource = dt;
            staff1Combo.DisplayMember = "employee_name";
            staff1Combo.ValueMember = "employee_num";
        }

        private void staff2Combo_Click(object sender, EventArgs e)
        {
            //Assigning data in the combo box
            string query = "SELECT * FROM Staff WHERE status = 1 AND employee_num != '10001'";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dt.Columns.Add("employee_name", typeof(string), "employee_fname + ' ' + employee_lname");
            staff2Combo.DataSource = dt;
            staff2Combo.DisplayMember = "employee_name";
            staff2Combo.ValueMember = "employee_num";
        }

        private void staff3Combo_Click(object sender, EventArgs e)
        {
            //Assigning data in the combo box
            string query = "SELECT * FROM Staff WHERE status = 1 AND employee_num != '10001'";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dt.Columns.Add("employee_name", typeof(string), "employee_fname + ' ' + employee_lname");
            staff3Combo.DataSource = dt;
            staff3Combo.DisplayMember = "employee_name";
            staff3Combo.ValueMember = "employee_num";
        }

        private void service1Combo_Click(object sender, EventArgs e)
        {
            //Assigning data in the combo box
            string query = "SELECT * FROM Service WHERE status = 1";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            service1Combo.DataSource = dt;
            service1Combo.DisplayMember = "service_name";
            service1Combo.ValueMember = "service_id";
        }

        private void service2Combo_Click(object sender, EventArgs e)
        {
            //Assigning data in the combo box
            string query = "SELECT * FROM Service WHERE status = 1 AND service_id != '" + currentService + "'";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            service2Combo.DataSource = dt;
            service2Combo.DisplayMember = "service_name";
            service2Combo.ValueMember = "service_id";
        }

        private void service3Combo_Click(object sender, EventArgs e)
        {
            //Assigning data in the combo box
            string query = "SELECT * FROM Service WHERE status = 1 AND service_id != '" + currentService + "' AND service_id != '" + currentService2 + "'";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            service3Combo.DataSource = dt;
            service3Combo.DisplayMember = "service_name";
            service3Combo.ValueMember = "service_id";
        }
        private int CalculateAge(DateTime dateOfBirth)
        {
            //Calculating the age from the date of birth
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
            //Displaying the age after selecting a date of birth
            ageTxtBox.ReadOnly = false;
            ageTxtBox.Text = CalculateAge(DateTime.Parse(birthDate.Text)).ToString();
            ageTxtBox.ReadOnly = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new Calendar().Show();
            this.Hide();
        }

        private void startTime_ValueChanged(object sender, EventArgs e)
        {
            endTime.MinDate = startTime.Value.AddHours(1);
        }

        private void service1Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Automating Time
            constring.Open();

            SqlCommand retrieveService = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + currentService + "'", constring);
            SqlDataReader readService;
            readService = retrieveService.ExecuteReader();
            if (readService.Read())
            {
                endTime.MinDate = endTime.MinDate.AddHours(-float.Parse(readService["service_duration"].ToString()));
            }
            else
            {
                endTime.MinDate = endTime.MinDate.AddHours(-1);
            }
            readService.Close();

            retrieveService = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + service1Combo.SelectedValue.ToString() + "'", constring);
            readService = retrieveService.ExecuteReader();
            if (readService.Read())
            {
                endTime.MinDate = endTime.MinDate.AddHours(float.Parse(readService["service_duration"].ToString()));
            }
            currentService = service1Combo.SelectedValue.ToString();
            readService.Close();
            constring.Close();
        }

        private void service2Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Automating Time
            constring.Open();

            SqlCommand retrieveService = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + currentService2 + "'", constring);
            SqlDataReader readService;
            readService = retrieveService.ExecuteReader();
            if (readService.Read())
            {
                endTime.MinDate = endTime.MinDate.AddHours(-float.Parse(readService["service_duration"].ToString()));
            }
            readService.Close();

            retrieveService = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + service2Combo.SelectedValue.ToString() + "'", constring);
            readService = retrieveService.ExecuteReader();
            if (readService.Read())
            {
                endTime.MinDate = endTime.MinDate.AddHours(float.Parse(readService["service_duration"].ToString()));
            }
            currentService2 = service2Combo.SelectedValue.ToString();
            readService.Close();
            constring.Close();
        }

        private void service3Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Automating Time
            constring.Open();

            SqlCommand retrieveService = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + currentService3 + "'", constring);
            SqlDataReader readService;
            readService = retrieveService.ExecuteReader();
            if (readService.Read())
            {
                endTime.MinDate = endTime.MinDate.AddHours(-float.Parse(readService["service_duration"].ToString()));
            }
            readService.Close();

            retrieveService = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + service3Combo.SelectedValue.ToString() + "'", constring);
            readService = retrieveService.ExecuteReader();
            if (readService.Read())
            {
                endTime.MinDate = endTime.MinDate.AddHours(float.Parse(readService["service_duration"].ToString()));
            }
            currentService3 = service3Combo.SelectedValue.ToString();
            readService.Close();
            constring.Close();
        }
    }
}
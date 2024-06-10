using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DentalAppointmentandInformationSystem
{
    public partial class EditAppointment : Form
    {
        Variables v = new Variables();
        SqlConnection constring;
        int changed = 0;
        string currentService, currentService2, currentService3;
        public EditAppointment()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void EditAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void EditAppointment_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;

            //Replacing label with staff name
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

            //Assigning default values of combo box and time limits
            startTime.MaxDate = DateTime.Parse("16:00:00");
            endTime.MaxDate = DateTime.Parse("17:00:00");
            setService1Combo();
            setService2Combo();
            setService3Combo();
            setStaff1Combo();
            setStaff2Combo();
            setStaff3Combo();
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

        private void staffBtn_Click(object sender, EventArgs e)
        {
            //Checking authorization
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

        private void setValues()
        {
            //Displaying current values of the appointment for the textboxes
            constring.Open();
            string query = "SELECT * FROM Appointment WHERE appointment_id =" + int.Parse(v.getsetappointmentSelected);
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                pIDTextBox.Text = row["patient_id"].ToString();

                string sql2 = "SELECT * FROM Patient WHERE patient_id = " + "'" + pIDTextBox.Text + "'";
                SqlCommand cmd2 = constring.CreateCommand();
                cmd2.CommandText = sql2;
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if(reader2.Read())
                {
                    patientCombo.Text = reader2["patient_lname"].ToString() + ", " + reader2["patient_fname"].ToString() + " " + reader2["patient_mname"].ToString();
                }
                reader2.Dispose();
                cmd2.Dispose();

                appntmntDate.Text = row["appointment_date"].ToString();
                startTime.Text = row["appointment_startTime"].ToString();
                endTime.MinDate = DateTime.Parse(appntmntDate.MinDate.ToString());
                endTime.Text = row["appointment_endTime"].ToString();
                staff1Combo.Text = "";
                staff2Combo.Text = "";
                staff3Combo.Text = "";
                service1Combo.Text = "";
                service2Combo.Text = "";
                service3Combo.Text = "";
                string sql6 = "SELECT * FROM Staff WHERE employee_num = " + "'" + row["employee_num"].ToString() + "'";
                SqlCommand cmd6 = constring.CreateCommand();
                cmd6.CommandText = sql6;
                SqlDataReader reader6 = cmd6.ExecuteReader();
                if (reader6.Read())
                {
                    staff1Combo.Text = reader6.GetValue(3).ToString() + " " + reader6.GetValue(1).ToString();
                    reader6.Dispose();
                    cmd6.Dispose();
                    if (row["employee_num2"].ToString() != null || row["employee_num2"].ToString() != " ")
                    {
                        string sql7 = "SELECT * FROM Staff WHERE employee_num = " + "'" + row["employee_num2"].ToString() + "'";
                        SqlCommand cmd7 = constring.CreateCommand();
                        cmd7.CommandText = sql7;
                        SqlDataReader reader7 = cmd7.ExecuteReader();
                        if (reader7.Read())
                        {
                            staff2Combo.Text = reader7.GetValue(3).ToString() + " " + reader7.GetValue(1).ToString();
                        }
                        reader7.Dispose();
                        cmd7.Dispose();
                    }
                    else if (row["employee_num3"].ToString() != null || row["employee_num3"].ToString() != " ")
                    {
                        string sql8 = "SELECT * FROM Staff WHERE employee_num = " + "'" + row["employee_num3"].ToString() + "'";
                        SqlCommand cmd8 = constring.CreateCommand();
                        cmd8.CommandText = sql8;
                        SqlDataReader reader8 = cmd8.ExecuteReader();
                        if (reader8.Read())
                        {
                            staff3Combo.Text = reader8.GetValue(3).ToString() + " " + reader8.GetValue(1).ToString();
                        }
                        reader8.Dispose();
                        cmd8.Dispose();
                    }
                }

                string q = "SELECT * FROM Service WHERE service_id = " + "'" + row["service_id"].ToString() + "'";
                SqlCommand command = constring.CreateCommand();
                command.CommandText = q;
                SqlDataReader read = command.ExecuteReader();
                if (read.Read())
                {
                    service1Combo.Text = read["service_name"].ToString();
                    service1Combo.SelectedValue = row["service_id"];
                    read.Dispose();
                    if (row["service_id2"].ToString() != null || row["service_id2"].ToString() != " ")
                    {
                        string sql3 = "SELECT * FROM Service WHERE service_id = " + "'" + row["service_id2"].ToString() + "'";
                        SqlCommand cmd4 = constring.CreateCommand();
                        cmd4.CommandText = sql3;
                        SqlDataReader reader3 = cmd4.ExecuteReader();
                        if (reader3.Read())
                        {
                            service2Combo.Text = reader3["service_name"].ToString();
                        }
                        reader3.Dispose();
                        cmd4.Dispose();
                    }
                    if (row["service_id3"].ToString() != null || row["service_id3"].ToString() != "")
                    {
                        string sql4 = "SELECT * FROM Service WHERE service_id = " + "'" + row["service_id3"].ToString() + "'";
                        SqlCommand cmd5 = constring.CreateCommand();
                        cmd5.CommandText = sql4;
                        SqlDataReader reader4 = cmd5.ExecuteReader();
                        if (reader4.Read())
                        {
                            service3Combo.Text = reader4["service_name"].ToString();
                        }
                        reader4.Dispose();
                        cmd5.Dispose();
                    }
                    notesTxtBox.Text = row["appointment_notes"].ToString();
                    currentService = service1Combo.SelectedValue.ToString();
                    currentService2 = service2Combo.SelectedValue.ToString();
                    currentService3 = service3Combo.SelectedValue.ToString();
                }
            }
            constring.Close();
        }

        private void saveAppnmtntBtn_Click(object sender, EventArgs e)
        {
            //Checking if the appointment date (if changed) is still available
            constring.Open();
            string compareQuery = "SELECT COUNT(*) FROM Appointment WHERE appointment_date = '" + appntmntDate.Text +
            "' AND ('" + startTime.Text + "' <= appointment_endTime AND appointment_startTime <= '" + endTime.Text + "')";
            SqlCommand compareCmd = new SqlCommand(compareQuery, constring);
            int userCount = (int)compareCmd.ExecuteScalar();
            constring.Close();

            if (!string.IsNullOrWhiteSpace(service1Combo.Text) &&
                !string.IsNullOrWhiteSpace(staff1Combo.Text))
            {
                if (userCount <= 0)
                {
                    //Updating the appointment details
                    constring.Open();
                    string staff2, staff3, service2, service3;
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
                        service3 = service3Combo.SelectedValue.ToString();
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

                    string query2 = "UPDATE Appointment SET appointment_date = '" + appntmntDate.Text +
                        "', appointment_startTime = '" + startTime.Text + "', appointment_endTime = '" + endTime.Text +
                        "', employee_num = '" + staff1Combo.SelectedValue.ToString() + "', employee_num2 = " + staff2 +
                        ", employee_num3 = " + staff3 + ", service_id = '" + service1Combo.SelectedValue.ToString() +
                        "', service_id2 = " + service2 + ", service_id3 = " + service3 + ", appointment_notes = '" +
                        notesTxtBox.Text + "' WHERE appointment_id = '" + v.getsetappointmentSelected + "';";

                    SqlCommand cmd3 = new SqlCommand(query2, constring);
                    cmd3.CommandText = query2;

                    string sql3 = "SELECT * FROM Appointment WHERE patient_id = " + pIDTextBox.Text + " AND appointment_date = '" + appntmntDate.Text + "'";
                    DataTable apps = new DataTable("appointments");
                    SqlDataAdapter da3 = new SqlDataAdapter(sql3, constring);
                    da3.Fill(apps);


                    //Updating the patient record/appointment history
                    string recordsDate = "";
                    float recordsPrice = 0;
                    foreach (DataRow row3 in apps.Rows)
                    {
                        recordsDate += DateTime.Parse(row3["appointment_date"].ToString()).ToString("MM/dd/yyyy");

                        SqlCommand retrieveService = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + row3["service_id"].ToString() + "'", constring);
                        SqlDataReader readService;
                        readService = retrieveService.ExecuteReader();
                        if (readService.Read())
                        {
                            recordsPrice += float.Parse(readService["service_price"].ToString());
                        }
                        readService.Close();
                        if (!string.IsNullOrEmpty(row3["service_id2"].ToString()))
                        {
                            SqlCommand retrieveService2 = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + row3["service_id2"].ToString() + "'", constring);
                            SqlDataReader readService2;
                            readService2 = retrieveService2.ExecuteReader();
                            if (readService2.Read())
                            {
                                recordsPrice += float.Parse(readService2["service_price"].ToString());
                            }
                            readService2.Close();
                        }
                        if (!string.IsNullOrEmpty(row3["service_id3"].ToString()))
                        {
                            SqlCommand retrieveService3 = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + row3["service_id3"].ToString() + "'", constring);
                            SqlDataReader readService3;
                            readService3 = retrieveService3.ExecuteReader();
                            if (readService3.Read())
                            {
                                recordsPrice += float.Parse(readService3["service_price"].ToString());
                            }
                            readService3.Close();
                        }
                    }

                    string query3 = "UPDATE Record SET price_billed = '" + recordsPrice + "' WHERE patient_id = '" + pIDTextBox.Text +
                        "' AND appointment_id = '" + v.getsetappointmentSelected + "';";

                    SqlCommand cmd4 = new SqlCommand(query2, constring);
                    cmd4.CommandText = query3;
                    cmd4.ExecuteNonQuery();

                    if (cmd3.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Changes saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Please fill out all required fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void setStaff1Combo()
        {
            string query = "SELECT * FROM Staff WHERE status = 1";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dt.Columns.Add("employee_name", typeof(string), "employee_fname + ' ' + employee_lname");
            staff1Combo.DataSource = dt;
            staff1Combo.DisplayMember = "employee_name";
            staff1Combo.ValueMember = "employee_num";
        }

        private void setStaff2Combo()
        {
            string query = "SELECT * FROM Staff WHERE status = 1";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dt.Columns.Add("employee_name", typeof(string), "employee_fname + ' ' + employee_lname");
            staff2Combo.DataSource = dt;
            staff2Combo.DisplayMember = "employee_name";
            staff2Combo.ValueMember = "employee_num";
        }

        private void setStaff3Combo()
        {
            string query = "SELECT * FROM Staff WHERE status = 1";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dt.Columns.Add("employee_name", typeof(string), "employee_fname + ' ' + employee_lname");
            staff3Combo.DataSource = dt;
            staff3Combo.DisplayMember = "employee_name";
            staff3Combo.ValueMember = "employee_num";
        }

        private void setService1Combo()
        {
            string query = "SELECT * FROM Service WHERE status = 1";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            service1Combo.DataSource = dt;
            service1Combo.DisplayMember = "service_name";
            service1Combo.ValueMember = "service_id";
        }

        private void setService2Combo()
        {
            string query = "SELECT * FROM Service WHERE status = 1 AND service_id != '" + currentService + "'";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            service2Combo.DataSource = dt;
            service2Combo.DisplayMember = "service_name";
            service2Combo.ValueMember = "service_id";
        }

        private void setService3Combo()
        {
            string query = "SELECT * FROM Service WHERE status = 1 AND service_id != '" + currentService + "' AND service_id != '" + currentService2 + "'";
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            service3Combo.DataSource = dt;
            service3Combo.DisplayMember = "service_name";
            service3Combo.ValueMember = "service_id";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new AppntmntDetails().Show();
            this.Hide();
        }

        private void startTime_ValueChanged(object sender, EventArgs e)
        {
            if (changed != 0)
            {
                if (DateTime.Now >= DateTime.Parse("10:00:00") && !(DateTime.Now >= DateTime.Parse("17:00:00")))
                {
                    appntmntDate.MinDate = DateTime.Now;
                    startTime.MinDate = DateTime.Now.AddHours(1);
                }
                else
                {
                    appntmntDate.MinDate = DateTime.Now.AddDays(1);
                    startTime.MinDate = DateTime.Parse("10:00:00");
                }
                endTime.MinDate = startTime.Value.AddHours(1);
            }

            changed++;
        }
        private void service1Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Automating Time
            constring.Open();
            endTime.MinDate = DateTime.Parse(endTime.Text.ToString());
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
                endTime.Text = DateTime.Parse(endTime.MinDate.AddHours(float.Parse(readService["service_duration"].ToString())).ToString()).ToString();
            }
            currentService = service1Combo.SelectedValue.ToString();
            readService.Close();
            constring.Close();
        }

        private void service2Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Automating Time
            constring.Open();
            endTime.MinDate = DateTime.Parse(endTime.Text.ToString());
            SqlCommand retrieveService = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + currentService2 + "'", constring);
            SqlDataReader readService;
            readService = retrieveService.ExecuteReader();
            if (readService.Read() && !string.IsNullOrWhiteSpace(currentService2))
            {
                endTime.MinDate = endTime.MinDate.AddHours(-float.Parse(readService["service_duration"].ToString()));
            }
            readService.Close();

            retrieveService = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + service2Combo.SelectedValue.ToString() + "'", constring);
            readService = retrieveService.ExecuteReader();
            if (readService.Read())
            {
                endTime.Text = DateTime.Parse(endTime.MinDate.AddHours(float.Parse(readService["service_duration"].ToString())).ToString()).ToString();
            }
            currentService2 = service2Combo.SelectedValue.ToString();
            readService.Close();
            constring.Close();
        }

        private void service3Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Automating Time
            constring.Open();
            endTime.MinDate = DateTime.Parse(endTime.Text.ToString());
            SqlCommand retrieveService = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + currentService3 + "'", constring);
            SqlDataReader readService;
            readService = retrieveService.ExecuteReader();
            if (readService.Read() && !string.IsNullOrWhiteSpace(currentService3))
            {
                endTime.MinDate = endTime.MinDate.AddHours(-float.Parse(readService["service_duration"].ToString()));
            }
            readService.Close();

            retrieveService = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + service3Combo.SelectedValue.ToString() + "'", constring);
            readService = retrieveService.ExecuteReader();
            if (readService.Read())
            {
                endTime.Text = DateTime.Parse(endTime.MinDate.AddHours(float.Parse(readService["service_duration"].ToString())).ToString()).ToString();
            }
            currentService3 = service3Combo.SelectedValue.ToString();
            readService.Close();
            constring.Close();
        }

    }
}
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
    public partial class NewStaff : Form
    {
        Variables v = new Variables();
        SqlConnection constring;

        public NewStaff()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void NewStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void NewStaff_Load(object sender, EventArgs e)
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
                "Dentist", "Assistant"
            };
            staffRoleCombo.DataSource = items;
        }

        private void saveStaffBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(fnameTxtBox.Text) && !string.IsNullOrWhiteSpace(lnameTxtBox.Text) &&
                !string.IsNullOrWhiteSpace(phoneTxtBox.Text) && !string.IsNullOrWhiteSpace(ageTxtBox.Text))
            {
                int staffID = 0, staffPassNum = 0;
                string staffPass = "";
                constring.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 employee_num, employee_role, employee_pass FROM Staff ORDER BY employee_num DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    staffID = reader1.GetInt32(0) + 1;
                    staffPassNum = int.Parse(staffID.ToString()[2] + "" + staffID.ToString()[3] + "" + staffID.ToString()[4]) + 100;

                }
                else
                {
                    MessageBox.Show("NO DATA FOUND");
                }
                reader1.Close();
                cmd.Dispose();

                if (staffRoleCombo.Text.Equals("Dentist"))
                {
                    staffPass += "dentist";
                    staffPass += staffPassNum.ToString();
                }
                if (staffRoleCombo.Text.Equals("Assistant"))
                {
                    staffPass += "assist";
                    staffPass += staffPassNum.ToString();
                }

                String query = "INSERT INTO Staff VALUES('" + staffID + "','" + lnameTxtBox.Text + "','"
                    + mnameTxtBox.Text + "','" + fnameTxtBox.Text + "','" + phoneTxtBox.Text + "','" + ageTxtBox.Text + "','"
                    + (DateTime.Parse(birthDateTxtBox.Text).ToString("MM/dd/yyyy")) + "','" + staffRoleCombo.Text + "','" + staffPass + "',1);";

                SqlCommand cmd2 = new SqlCommand(query, constring);
                cmd2.CommandText = query;
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    MessageBox.Show("Staff Member added!\nThe employee's credentials are:\nEmployee Number: " + staffID + "\nPassword: " + staffPass);
                    Staff staff = new Staff();
                    staff.Show();
                    this.Hide();

                }
                else
                {
                    constring.Close();
                    MessageBox.Show("Something went wrong. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void birthDateTxtBox_Leave(object sender, EventArgs e)
        {
            ageTxtBox.ReadOnly = false;
            ageTxtBox.Text = CalculateAge(DateTime.Parse(birthDateTxtBox.Text)).ToString();
            ageTxtBox.ReadOnly = true;
        }
    }
}
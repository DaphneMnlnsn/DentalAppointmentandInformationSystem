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
    public partial class EditStaff : Form
    {
        Variables v = new Variables();
        SqlConnection constring;

        public EditStaff()
        {
            InitializeComponent();
            constring = v.getConnection;
        }
        private void EditStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void EditStaff_Load(object sender, EventArgs e)
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
            constring.Open();
            string query = "SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetstaffSelected);
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                fnameTxtBox.Text = row["employee_fname"].ToString();
                mnameTxtBox.Text = row["employee_mname"].ToString();
                lnameTxtBox.Text = row["employee_lname"].ToString();
                phoneTxtBox.Text = row["employee_contact"].ToString();
                birthDateTxtBox.Text = row["employee_bdate"].ToString();
                ageTxtBox.Text = row["employee_age"].ToString();
                passTxtBox.Text = row["employee_pass"].ToString();
            }
            constring.Close();
        }

        private void saveStaffBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fnameTxtBox.Text) && !string.IsNullOrWhiteSpace(lnameTxtBox.Text) &&
                !string.IsNullOrWhiteSpace(phoneTxtBox.Text) && !string.IsNullOrWhiteSpace(ageTxtBox.Text) &&
                !string.IsNullOrWhiteSpace(passTxtBox.Text))
            {
                constring.Open();
                string query2 = "UPDATE Staff SET employee_fname = '" + fnameTxtBox.Text +
                    "', employee_mname = '" + mnameTxtBox.Text + "', employee_lname = '" + lnameTxtBox.Text +
                    "', employee_contact = '" + phoneTxtBox.Text + "', employee_bdate = '" +
                    birthDateTxtBox.Text + "', employee_age = '" + ageTxtBox.Text + "', employee_pass = '" + passTxtBox.Text +
                    "' WHERE employee_num = '" + v.getsetstaffSelected + "';";

                SqlCommand cmd3 = new SqlCommand(query2, constring);
                cmd3.CommandText = query2;
                if (cmd3.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Changes Saved!");
                    constring.Close();
                    Staff stff = new Staff();
                    stff.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void deleteStffBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this staff record?\nThis will be moved to the trash bin.", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                constring.Open();
                string query2 = "UPDATE Staff SET status = 0 WHERE employee_num =" + v.getsetstaffSelected;
                SqlCommand cmd2 = new SqlCommand(query2, constring);
                cmd2.CommandText = query2;
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Staff Record succesfully moved to the Trash Bin/Archives!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    constring.Close();
                    Staff stff = new Staff();
                    stff.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("DATA NOT DELETED SUCCESSFULLY");
                }
                
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

        private void birthDateTxtBox_Leave(object sender, EventArgs e)
        {
            ageTxtBox.ReadOnly = false;
            ageTxtBox.Text = CalculateAge(DateTime.Parse(birthDateTxtBox.Text)).ToString();
            ageTxtBox.ReadOnly = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new Staff().Show();
            this.Hide();
        }

        private void showPass_Click(object sender, EventArgs e)
        {
                passTxtBox.PasswordChar = '\0';
                showPass.Visible = false;
                hidePass.Visible = true;
        }

        private void hidePass_Click(object sender, EventArgs e)
        {
                passTxtBox.PasswordChar = '•';
                hidePass.Visible = false;
                showPass.Visible = true;
        }
    }
}
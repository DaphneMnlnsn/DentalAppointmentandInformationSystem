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
        SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daph\source\repos\DentalAppointmentandInformationSystem\DAISdB.mdf;Integrated Security=True");

        public EditStaff()
        {
            InitializeComponent();
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
                    Staff stf = new Staff();
                    stf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You do not have the authorization to open this!");
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            constring.Close();
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
                Staff stff = new Staff();
                stff.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }

            constring.Close();
        }

        private void deleteStffBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this staff record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                constring.Open();
                string query = "DELETE FROM Staff WHERE employee_num =" + v.getsetstaffSelected;
                SqlCommand cmd = new SqlCommand(query, constring);
                cmd.CommandText = query;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Staff Deleted Successfully!");
                    Staff stff = new Staff();
                    stff.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("DATA NOT DELETED SUCCESSFULLY");
                }
                constring.Close();
            }
        }
    }
}
using DentalAppointmentandInformationSystem;
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
    public partial class Staff : Form
    {
        Variables v = new Variables();
        SqlConnection constring;

        public Staff()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            displayStaff();
        }
        private void displayStaff()
        {
            constring.Open();
            string sql = "SELECT * FROM Staff WHERE status = 1";
            DataTable staffs = new DataTable("staffs");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(staffs);

            foreach (DataRow row in staffs.Rows)
            {
                StaffList staff = new StaffList();
                string employee_fullname = "";
                if (row["employee_mname"].ToString().Equals(null) || row["employee_mname"].ToString().Equals(""))
                {
                    employee_fullname = row["employee_fname"].ToString() + " " + row["employee_lname"].ToString();
                }
                else
                {
                    employee_fullname = row["employee_fname"].ToString() + " " + row["employee_mname"].ToString() + " " + row["employee_lname"].ToString();

                }
                staff.setStaffInfo(row["employee_num"].ToString(), employee_fullname, row["employee_age"].ToString(),
                    ((DateTime)row["employee_bdate"]).ToString("MM/dd/yyyy"), row["employee_role"].ToString(), row["employee_contact"].ToString());
                staffContainer.Controls.Add(staff);
            }
            constring.Close();
        }

        private void clndrBtn_Click(object sender, EventArgs e)
        {
            Calendar clndr = new Calendar();
            clndr.Show();
            this.Hide();
        }

        private void patientBtn_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
            this.Hide();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            Services srvcs = new Services();
            srvcs.Show();
            this.Hide();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            NewStaff newStaff = new NewStaff();
            newStaff.Show();
            this.Hide();
        }

        private void dshbrdBtn_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            this.Hide();
        }

        private void binBtn_Click(object sender, EventArgs e)
        {
            StaffArchives staffArch = new StaffArchives();
            staffArch.Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            constring.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE (employee_num LIKE @StaffID OR employee_fname LIKE @FirstName"
                + " OR employee_mname LIKE @MiddleName OR employee_lname LIKE @LastName OR employee_age LIKE @Age OR"
                + " employee_contact LIKE @Contact OR employee_bdate LIKE @Birthdate OR employee_role LIKE @Role) AND status = 1", constring))
            {
                cmd.Parameters.AddWithValue("StaffID", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("FirstName", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("MiddleName", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("LastName", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("Age", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("Contact", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("Birthdate", string.Format("%{0}%", searchTxtBox.Text));
                cmd.Parameters.AddWithValue("Role", string.Format("%{0}%", searchTxtBox.Text));

                DataTable staffs = new DataTable("staffs");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(staffs);
                staffContainer.Controls.Clear();

                foreach (DataRow row in staffs.Rows)
                {
                    StaffList staff = new StaffList();
                    string employee_fullname = "";
                    if (row["employee_mname"].ToString().Equals(null) || row["employee_mname"].ToString().Equals(""))
                    {
                        employee_fullname = row["employee_fname"].ToString() + " " + row["employee_lname"].ToString();
                    }
                    else
                    {
                        employee_fullname = row["employee_fname"].ToString() + " " + row["employee_mname"].ToString() + " " + row["employee_lname"].ToString();

                    }
                    staff.setStaffInfo(row["employee_num"].ToString(), employee_fullname, row["employee_age"].ToString(),
                        ((DateTime)row["employee_bdate"]).ToString("MM/dd/yyyy"), row["employee_role"].ToString(), row["employee_contact"].ToString());
                    staffContainer.Controls.Add(staff);
                }
                constring.Close();
            }
        }
    }
}
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
        SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daph\source\repos\DentalAppointmentandInformationSystem\DAISdB.mdf;Integrated Security=True");

        public Staff()
        {
            InitializeComponent();
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
            string sql = "SELECT * FROM Staff";
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
                    ((DateTime)row["employee_bdate"]).ToString("MM/dd/yyyy"), row["employee_role"].ToString(), row["employee_contact"].ToString(),
                    row["employee_pass"].ToString());
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
    }
}
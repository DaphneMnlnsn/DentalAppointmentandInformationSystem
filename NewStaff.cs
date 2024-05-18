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
        SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daph\source\repos\DentalAppointmentandInformationSystem\DAISdB.mdf;Integrated Security=True");

        public NewStaff()
        {
            InitializeComponent();
        }

        private void NewStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void NewStaff_Load(object sender, EventArgs e)
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
                "Administrator", "Dentist", "Assistant"
            };
            staffRoleCombo.DataSource = items;
        }

        private void saveStaffBtn_Click(object sender, EventArgs e)
        {
            int staffID = 0;
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 employee_num FROM Staff ORDER BY employee_num DESC", constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                staffID = reader1.GetInt32(0) + 1;
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            reader1.Close();
            cmd.Dispose();

            String query = "INSERT INTO Staff VALUES('" + staffID + "','" + lnameTxtBox.Text + "','"
                + mnameTxtBox.Text + "','" + fnameTxtBox.Text + "','" + ageTxtBox.Text + "','"
                + (DateTime.Parse(birthDateTxtBox.Text).ToString("MM/dd/yyyy")) + "','" + phoneTxtBox.Text + ",)";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;
            if (cmd2.ExecuteNonQuery() == 1)
            {
                string sql = "SELECT * FROM Patient";
                DataTable staffs = new DataTable("staffs");
                SqlDataAdapter da = new SqlDataAdapter(sql, constring);
                da.Fill(staffs);
                System.Text.StringBuilder b = new System.Text.StringBuilder();
                foreach (System.Data.DataRow r in staffs.Rows)
                {
                    foreach (System.Data.DataColumn c in staffs.Columns)
                    {
                        b.Append(c.ColumnName.ToString() + ":" + r[c.ColumnName].ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }
    }
}
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
    public partial class Services : Form
    {
        Variables v = new Variables();
        SqlConnection constring;

        public Services()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        
        private void Services_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            addService1.Visible = false;
            editService1.Visible = false;
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;

            displayServices();
        }

        private void displayServices()
        {
            constring.Open();
            string sql = "SELECT * FROM Service WHERE status = 1";
            DataTable services = new DataTable("services");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(services);

            foreach (DataRow row in services.Rows)
            {
                ServicesList service = new ServicesList();
                service.setServiceInfo(row["service_id"].ToString(), row["service_name"].ToString(), float.Parse(row["service_price"].ToString()));
                servicesContainer.Controls.Add(service);
            }
            constring.Close();
        }

        private void clndrBtn_Click(object sender, EventArgs e)
        {
            Calendar clndr = new Calendar();
            clndr.Show();
            this.Hide();
        }

        private void ptntsBtn_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
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

        private void addServiceBtn_Click(object sender, EventArgs e)
        {
            addService1.Visible = true;
        }

        public void editVisible()
        {
            editService1.Visible = true;
            editService1.setValues();
        }

        private void dshbrdbtn_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            this.Hide();
        }

        private void binBtn_Click(object sender, EventArgs e)
        {
            ServiceArchives servArch = new ServiceArchives();
            servArch.Show();
            this.Hide();
        }
    }
}
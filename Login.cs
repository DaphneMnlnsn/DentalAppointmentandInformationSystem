using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Xml.Linq;
using DentalAppointmentandInformationSystem;

namespace DentalAppointmentandInformationSystem
{
    public partial class Login : Form
    {            
        SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daph\source\repos\DentalAppointmentandInformationSystem\DAISdB.mdf;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        private void eNumTxtBox_Enter(object sender, System.EventArgs e)
        {
            if (eNumTxtBox.Text.Equals("Employee Number"))
            {
                eNumTxtBox.Text = "";
                eNumTxtBox.ForeColor = Color.Black;
            }
        }
        private void eNumTxtBox_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(eNumTxtBox.Text))
            {
                eNumTxtBox.Text = "Employee Number";
                eNumTxtBox.ForeColor = Color.FromArgb(217, 217, 217);
            }
        }

        private void passTxtbox_Enter(object sender, System.EventArgs e)
        {
            if (passTxtbox.Text.Equals("Password"))
            {
                passTxtbox.Text = "";
                passTxtbox.ForeColor = Color.Black;
                passTxtbox.PasswordChar = '•';
            }
        }

        private void passTxtbox_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(passTxtbox.Text))
            {
                passTxtbox.Text = "Password";
                passTxtbox.ForeColor = Color.FromArgb(217, 217, 217);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Staff WHERE employee_num ='" + eNumTxtBox.Text + "' AND employee_pass ='" + passTxtbox.Text + "'", constring);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Variables v = new Variables();
                v.getsetloggedIn = eNumTxtBox.Text;
                Dashboard dshbrd = new Dashboard();
                dshbrd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
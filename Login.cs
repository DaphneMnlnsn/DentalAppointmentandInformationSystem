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
        Variables v = new Variables();
        SqlConnection constring;

        public Login()
        {
            InitializeComponent();
            constring = v.getConnection;
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
                showPass.Visible = true;
            }
        }

        private void passTxtbox_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(passTxtbox.Text))
            {
                passTxtbox.Text = "Password";
                passTxtbox.PasswordChar = '\0';
                passTxtbox.ForeColor = Color.FromArgb(217, 217, 217);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            int num;
            bool checkInput = int.TryParse(eNumTxtBox.Text, out num);

            //Checking if the inputs are null or blank
            if (!eNumTxtBox.Text.Equals("Employee Number") && !passTxtbox.Text.Equals("Password"))
            {
                if (checkInput == true)
                {
                    //Verifying if user exists in the database
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Staff WHERE employee_num ='" + eNumTxtBox.Text + "' AND employee_pass ='" + passTxtbox.Text + "' AND status = 1", constring);
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
                        MessageBox.Show("Invalid employee number of password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter only employee number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please make sure the data you entered is complete!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            }

        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void forgotPassLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please ask your administrator for a password reset.");
        }

        private void passTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                loginBtn.PerformClick();
            }
        }

        private void showPass_Click(object sender, EventArgs e)
        {
            if (!passTxtbox.Text.Equals("Password") && !string.IsNullOrEmpty(passTxtbox.Text))
            {
                passTxtbox.PasswordChar = '\0';
                showPass.Visible = false;
                hidePass.Visible = true;
            }
        }

        private void hidePass_Click(object sender, EventArgs e)
        {
            if (!passTxtbox.Text.Equals("Password") && !string.IsNullOrEmpty(passTxtbox.Text))
            {
                passTxtbox.PasswordChar = '•';
                hidePass.Visible = false;
                showPass.Visible = true;
            }
        }
    }
}
﻿using System;
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
    public partial class StaffListArchived : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;
        public StaffListArchived()
        {
            InitializeComponent();
            constring = v.getConnection;
        }
        public void setStaffInfo(string employee_num, string employee_fullname, string employee_age, string employee_bday, string employee_role, string employee_contact, string employee_pass)
        {
            employeeNum.Text = employee_num;
            fullName.Text = employee_fullname;
            ageLbl.Text = employee_age;
            birthDate.Text = employee_bday;
            staffRole.Text = employee_role;
            contactNum.Text = employee_contact;
            passwordLbl.Text = employee_pass;

        }
        private void restoreStaff_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Restore this staff record?", "Confirm Restore", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                v.getsetstaffSelected = employeeNum.Text;
                string query = "INSERT INTO Staff SELECT * FROM Staff_Archive WHERE employee_num =" + v.getsetstaffSelected;
                SqlCommand cmdd = new SqlCommand(query, constring);
                cmdd.CommandText = query;
                string query2 = "DELETE FROM Staff_Archive WHERE employee_num ='" + v.getsetstaffSelected + "';";
                SqlCommand cmd2 = new SqlCommand(query2, constring);
                cmd2.CommandText = query2;
                if (cmdd.ExecuteNonQuery() == 1 && cmd2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Staff record successfully restored!");
                    constring.Close();
                    Staff staff = new Staff();
                    staff.Show();
                    this.ParentForm.Hide();
                }
            }
            constring.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                reader1.Close();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this service permanently?\nYou will not be able to retrieve this!", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    v.getsetstaffSelected = employeeNum.Text;
                    string query2 = "DELETE FROM Staff_Archive WHERE employee_num ='" + v.getsetstaffSelected + "';";
                    SqlCommand cmd2 = new SqlCommand(query2, constring);
                    cmd2.CommandText = query2;
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Staff record deleted permanently!");
                        constring.Close();
                        Staff srvcs = new Staff();
                        srvcs.Show();
                        this.ParentForm.Hide();
                    }
                }
                constring.Close();
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
        }


    }
}
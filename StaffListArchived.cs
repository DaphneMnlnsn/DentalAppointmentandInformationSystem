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
        public void setStaffInfo(string employee_num, string employee_fullname, string employee_age, string employee_bday, string employee_role, string employee_contact)
        {
            //Setting info of the archived staff
            employeeNum.Text = employee_num;
            fullName.Text = employee_fullname;
            ageLbl.Text = employee_age;
            birthDate.Text = employee_bday;
            staffRole.Text = employee_role;
            contactNum.Text = "09" + employee_contact;
        }
        private void restoreStaff_Click(object sender, EventArgs e)
        {
            //What happens after clicking the restore button
            constring.Open();
            DialogResult dialogResult = MessageBox.Show("Restore this staff record?", "Confirm Restore", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                v.getsetstaffSelected = employeeNum.Text;
                string query2 = "UPDATE Staff SET status = 1 WHERE employee_num ='" + v.getsetstaffSelected + "';";
                SqlCommand cmd2 = new SqlCommand(query2, constring);
                cmd2.CommandText = query2;
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Staff restored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string queryAct = "INSERT INTO Activity_Log VALUES('" + v.getsetloggedIn + "','" + DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")) + "','restored staff "
                                + v.getsetstaffSelected + "')";

                    SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                    cmdAct.CommandText = queryAct;
                    cmdAct.ExecuteNonQuery();
                    constring.Close();
                    StaffArchives staff = new StaffArchives();
                    staff.Show();
                    this.ParentForm.Hide();
                }
            }
            constring.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //What happens after clicking delete button
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                reader1.Close();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this staff record permanently?\nYou will not be able to retrieve this!", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    v.getsetstaffSelected = employeeNum.Text;
                    string query2 = "DELETE FROM Staff WHERE employee_num ='" + v.getsetstaffSelected + "';";
                    SqlCommand cmd2 = new SqlCommand(query2, constring);
                    cmd2.CommandText = query2;
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Staff record deleted permanently!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string queryAct = "INSERT INTO Activity_Log VALUES('" + v.getsetloggedIn + "','" + DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")) + "','permanently deleted staff "
                                + v.getsetstaffSelected + "')";

                        SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                        cmdAct.CommandText = queryAct;
                        cmdAct.ExecuteNonQuery();
                        constring.Close();
                        StaffArchives srvcs = new StaffArchives();
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
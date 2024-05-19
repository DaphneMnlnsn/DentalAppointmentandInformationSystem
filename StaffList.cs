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
    public partial class StaffList : UserControl
    {
        Variables v = new Variables();
        public StaffList()
        {
            InitializeComponent();
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
        private void editStaff_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Edit this staff record?", "Confirm Edit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                v.getsetstaffSelected = employeeNum.Text;
                this.ParentForm.Hide();
                EditStaff edit = new EditStaff();
                edit.Show();
            }
        }
    }
}
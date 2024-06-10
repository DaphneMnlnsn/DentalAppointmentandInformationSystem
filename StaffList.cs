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
        public void setStaffInfo(string employee_num, string employee_fullname, string employee_age, string employee_bday, string employee_role, string employee_contact)
        {
            //Displaying staff info
            employeeNum.Text = employee_num;
            fullName.Text = employee_fullname;
            ageLbl.Text = employee_age;
            birthDate.Text = employee_bday;
            staffRole.Text = employee_role;
            contactNum.Text = "09" + employee_contact;
            
        }
        private void editStaff_Click(object sender, EventArgs e)
        {
            //What happens after clicking the edit button
            DialogResult dialogResult = MessageBox.Show("Edit this staff record?", "Confirm Edit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                v.getsetstaffSelected = employeeNum.Text;
                if ((v.getsetstaffSelected.Equals("10001") && v.getsetloggedIn.Equals("10001")) || !v.getsetstaffSelected.Equals("10001"))
                {
                    this.ParentForm.Hide();
                    EditStaff edit = new EditStaff();
                    edit.Show();
                }
                else
                {
                    MessageBox.Show("Administrator account can only be edited by the account owner itself!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
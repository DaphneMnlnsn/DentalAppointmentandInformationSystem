using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalAppointmentandInformationSystem
{
    public partial class StaffList : UserControl
    {
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
    }
}
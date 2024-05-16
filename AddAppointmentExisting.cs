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
    public partial class AddAppointmentExisting : Form
    {
        public AddAppointmentExisting()
        {
            InitializeComponent();
        }
        private void AddAppointmentExisting_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AddAppointmentExisting_Load(object sender, EventArgs e)
        {
        }
    }
}
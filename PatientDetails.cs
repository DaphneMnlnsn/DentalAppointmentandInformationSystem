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
    public partial class PatientDetails : Form
    {
        public PatientDetails()
        {
            InitializeComponent();
        }

        private void PatientDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void PatientDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
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
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        private void editPatientBtn_Click(object sender, EventArgs e)
        {
            EditPatient editptnt = new EditPatient();
            editptnt.Show();
            this.Hide();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DentalAppointmentandInformationSystem.DAISdBDataSet;

namespace DentalAppointmentandInformationSystem
{
    public partial class PatientsList : UserControl
    {
        Variables v = new Variables();
        public PatientsList()
        {
            InitializeComponent();
        }
        public void setPatientInfo(string patient_id, string patient_fullname, string patient_age, string patient_gender, string patient_lv, string patient_contact)
        {
            patientId.Text = patient_id;
            patientName.Text = patient_fullname;
            patientAge.Text = patient_age;
            patientGender.Text = patient_gender;
            patientLastVisit.Text = patient_lv;
            patientContact.Text = "09" + patient_contact;
        }

        private void patientDetails_Click(object sender, EventArgs e)
        {
            v.getsetpatientSelected = patientId.Text;
            PatientDetails patientDetails = new PatientDetails();
            patientDetails.Show();
            this.ParentForm.Hide();
        }
    }
}

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
    public partial class PatientDentalHistoryItem : UserControl
    {
        Variables v = new Variables();
        string historyID;
        public PatientDentalHistoryItem()
        {
            InitializeComponent();
        }
        public void setDentalHistory(string historyID, string treatment, string dentist)
        {
            this.historyID = historyID;
            treatmentName.Text = treatment;
            dentistName.Text = dentist;
        }

        private void PatientDentalHistoryItem_Click(object sender, EventArgs e)
        {
            /*v.getsethistorySelected = historyID;
            PatientDetails mainForm;
            mainForm = (PatientDetails)this.FindForm();
            mainForm.editHistoryVisible();*/
        }
    }
}
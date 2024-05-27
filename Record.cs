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
    public partial class Record : UserControl
    {
        Variables v = new Variables();
        string recordID;
        public Record()
        {
            InitializeComponent();
        }

        public void setPatientInfo(string recordID, string recordDate, string recordsTreat, string recordsTooth, float recordsPrice)
        {
            this.recordID = recordID;
            records_date.Text = recordDate;
            records_treat.Text = recordsTreat;
            records_tooth.Text = recordsTooth;
            records_price.Text = recordsPrice.ToString();
        }

        private void Record_Click(object sender, EventArgs e)
        {
            v.getsetrecordSelected = recordID;
            PatientDetails mainForm;
            mainForm = (PatientDetails)this.FindForm();
            mainForm.editVisible();
        }
    }
}
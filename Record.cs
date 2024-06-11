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
        SqlConnection constring;
        string recordID;
        public Record()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        public void setPatientInfo(string recordID, string recordDate, string recordsTreat, string recordsTooth, float recordsPrice, string recordsStatus)
        {
            this.recordID = recordID;
            records_date.Text = recordDate;
            records_treat.Text = recordsTreat;
            records_tooth.Text = recordsTooth;
            records_price.Text = recordsPrice.ToString("#,##0.00");
            records_status.Text = recordsStatus;
            if (records_status.Text.ToString().Equals("Completed"))
            {
                records_status.ForeColor = Color.FromArgb(45, 204, 255);
            }
            else if (records_status.Text.ToString().Equals("Ongoing"))
            {
                records_status.ForeColor = Color.FromArgb(0, 226, 0);
            }
            else if (records_status.Text.ToString().Equals("Cancelled"))
            {
                records_status.ForeColor = Color.FromArgb(255, 42, 4);
            }
            else if (records_status.Text.ToString().Equals("No Show"))
            {
                records_status.ForeColor = Color.FromArgb(123, 128, 137);
            }
            else
            {
                records_status.ForeColor = Color.FromArgb(255, 175, 61);
            }
        }

        private void Record_Click(object sender, EventArgs e)
        {
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    reader1.Close();
                    v.getsetrecordSelected = recordID;
                    constring.Close();
                    PatientDetails mainForm;
                    mainForm = (PatientDetails)this.FindForm();
                    mainForm.editVisible();
                }
                else
                {
                    constring.Close();
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
        }
    }
}
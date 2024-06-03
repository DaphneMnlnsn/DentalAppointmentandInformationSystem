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
                    PatientDetails mainForm;
                    mainForm = (PatientDetails)this.FindForm();
                    mainForm.editVisible();
                    constring.Close();
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
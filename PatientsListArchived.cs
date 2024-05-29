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
using static DentalAppointmentandInformationSystem.DAISdBDataSet;

namespace DentalAppointmentandInformationSystem
{
    public partial class PatientsListArchived : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring; 
        public PatientsListArchived()
        {
            InitializeComponent();
            constring = v.getConnection;
        }
        public void setPatientInfo(string patient_id, string patient_fullname, string patient_age, string patient_gender, string patient_lv, string patient_contact)
        {
            patientId.Text = patient_id;
            patientName.Text = patient_fullname;
            patientAge.Text = patient_age;
            patientGender.Text = patient_gender;
            patientLastVisit.Text = patient_lv;
            patientContact.Text = patient_contact;
        }
        private void deleteBtn_Click(object sender, EventArgs e)
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
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this service permanently?\nYou will not be able to retrieve this!", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        v.getsetpatientSelected = patientId.Text;
                        string query2 = "DELETE FROM Patient_Archive WHERE patient_id ='" + v.getsetpatientSelected + "';";
                        SqlCommand cmd2 = new SqlCommand(query2, constring);
                        cmd2.CommandText = query2;
                        if (cmd2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Patient deleted permanently!");
                            constring.Close();
                            Patients ptnt = new Patients();
                            ptnt.Show();
                            this.ParentForm.Hide();
                        }
                    }
                    constring.Close();
                }
                else
                {
                    MessageBox.Show("You do not have the authorization to delete patient records!");
                    constring.Close();
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }

        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            constring.Open();
            DialogResult dialogResult = MessageBox.Show("Restore this patient record?", "Confirm Restore", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                v.getsetpatientSelected = patientId.Text;
                string querya4 = "INSERT INTO Patient SELECT * FROM Patient_Archive WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmda4 = new SqlCommand(querya4, constring);
                cmda4.CommandText = querya4;
                cmda4.ExecuteNonQuery();
                string querya = "INSERT INTO Appointment SELECT * FROM Appointment_Archive WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmdda = new SqlCommand(querya, constring);
                cmdda.CommandText = querya;
                cmdda.ExecuteNonQuery();
                string querya2 = "INSERT INTO Record SELECT * FROM Record_Archive WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmda2 = new SqlCommand(querya2, constring);
                cmda2.CommandText = querya2;
                cmda2.ExecuteNonQuery();
                string querya3 = "INSERT INTO History SELECT * FROM History_Archive WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmda3 = new SqlCommand(querya3, constring);
                cmda3.CommandText = querya3;
                cmda3.ExecuteNonQuery();

                string query2 = "DELETE FROM Record_Archive WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmd2 = new SqlCommand(query2, constring);
                cmd2.CommandText = query2;
                cmd2.ExecuteNonQuery();
                string query = "DELETE FROM Appointment_Archive WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmdd = new SqlCommand(query, constring);
                cmdd.CommandText = query;
                cmdd.ExecuteNonQuery();
                string query3 = "DELETE FROM History_Archive WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmd3 = new SqlCommand(query3, constring);
                cmd3.CommandText = query3;
                cmd3.ExecuteNonQuery();
                string query4 = "DELETE FROM Patient_Archive WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmd4 = new SqlCommand(query4, constring);
                cmd4.CommandText = query4;
                if (cmd4.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Patient record successfully restored!");
                    constring.Close();
                    Patients ptnt = new Patients();
                    ptnt.Show();
                    this.ParentForm.Hide();
                }
            }
            constring.Close();
        }
    }
}

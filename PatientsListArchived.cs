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
            patientContact.Text = "09" + patient_contact;
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
                        string query2 = "DELETE FROM Record WHERE patient_id =" + v.getsetpatientSelected;
                        SqlCommand cmd2 = new SqlCommand(query2, constring);
                        cmd2.CommandText = query2;
                        cmd2.ExecuteNonQuery();
                        string query = "DELETE FROM Appointment WHERE patient_id =" + v.getsetpatientSelected;
                        SqlCommand cmdd = new SqlCommand(query, constring);
                        cmdd.CommandText = query;
                        cmdd.ExecuteNonQuery();
                        string query3 = "DELETE FROM [File] WHERE patient_id =" + v.getsetpatientSelected;
                        SqlCommand cmd3 = new SqlCommand(query3, constring);
                        cmd3.CommandText = query3;
                        cmd3.ExecuteNonQuery();
                        string query4 = "DELETE FROM Patient WHERE patient_id =" + v.getsetpatientSelected;
                        SqlCommand cmd4 = new SqlCommand(query4, constring);
                        cmd4.CommandText = query4;
                        if (cmd4.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Patient record deleted permanently!");
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

                string query2 = "UPDATE Record SET status = 1 WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmd2 = new SqlCommand(query2, constring);
                cmd2.CommandText = query2;
                cmd2.ExecuteNonQuery();
                string query = "UPDATE Appointment SET status = 1 WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmdd = new SqlCommand(query, constring);
                cmdd.CommandText = query;
                cmdd.ExecuteNonQuery();
                /*string query3 = "UPDATE History SET status = 1 WHERE patient_id =" + v.getsetpatientSelected;
                SqlCommand cmd3 = new SqlCommand(query3, constring);
                cmd3.CommandText = query3;
                cmd3.ExecuteNonQuery();*/
                string query4 = "UPDATE Patient SET status = 1 WHERE patient_id =" + v.getsetpatientSelected;
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

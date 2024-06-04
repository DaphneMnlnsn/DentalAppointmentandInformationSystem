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
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this patient record permanently?\nYou will not be able to retrieve this!", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        v.getsetpatientSelected = patientId.Text;
                        int quadrant1Num = 0, quadrant2Num = 0, quadrant3Num = 0, quadrant4Num = 0;

                        string querySelect = "SELECT * FROM Patient WHERE patient_id =" + int.Parse(v.getsetpatientSelected);
                        SqlDataAdapter adpt = new SqlDataAdapter(querySelect, constring);
                        DataTable dt = new DataTable();
                        adpt.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            quadrant1Num = int.Parse(row["quadrant1_num"].ToString());
                            quadrant2Num = int.Parse(row["quadrant2_num"].ToString());
                            quadrant3Num = int.Parse(row["quadrant3_num"].ToString());
                            quadrant4Num = int.Parse(row["quadrant4_num"].ToString());
                        }

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
                        string query8 = "DELETE FROM Patient WHERE patient_id =" + v.getsetpatientSelected;
                        SqlCommand cmd8 = new SqlCommand(query8, constring);
                        cmd8.CommandText = query8;
                        cmd8.ExecuteNonQuery();
                        string query4 = "DELETE FROM Quadrant1 WHERE quadrant1_num =" + quadrant1Num;
                        SqlCommand cmd4 = new SqlCommand(query4, constring);
                        cmd4.CommandText = query4;
                        cmd4.ExecuteNonQuery();
                        string query5 = "DELETE FROM Quadrant2 WHERE quadrant2_num =" + quadrant2Num;
                        SqlCommand cmd5 = new SqlCommand(query5, constring);
                        cmd5.CommandText = query5;
                        cmd5.ExecuteNonQuery();
                        string query6 = "DELETE FROM Quadrant3 WHERE quadrant3_num =" + quadrant3Num;
                        SqlCommand cmd6 = new SqlCommand(query6, constring);
                        cmd6.CommandText = query6;
                        cmd6.ExecuteNonQuery();
                        string query7 = "DELETE FROM Quadrant4 WHERE quadrant4_num =" + quadrant4Num;
                        SqlCommand cmd7 = new SqlCommand(query7, constring);
                        cmd7.CommandText = query7;
                        if (cmd7.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Patient record deleted permanently!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            constring.Close();
                            PatientArchives ptnt = new PatientArchives();
                            ptnt.Show();
                            this.ParentForm.Hide();
                        }
                    }
                    constring.Close();
                }
                else
                {
                    MessageBox.Show("You do not have authorization to delete this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    reader1.Close();
                    DialogResult dialogResult = MessageBox.Show("Restore this patient record?", "Confirm Restore", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        v.getsetpatientSelected = patientId.Text;
                        int quadrant1Num = 0, quadrant2Num = 0, quadrant3Num = 0, quadrant4Num = 0;

                        string querySelect = "SELECT * FROM Patient WHERE patient_id =" + int.Parse(v.getsetpatientSelected);
                        SqlDataAdapter adpt = new SqlDataAdapter(querySelect, constring);
                        DataTable dt = new DataTable();
                        adpt.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            quadrant1Num = int.Parse(row["quadrant1_num"].ToString());
                            quadrant2Num = int.Parse(row["quadrant2_num"].ToString());
                            quadrant3Num = int.Parse(row["quadrant3_num"].ToString());
                            quadrant4Num = int.Parse(row["quadrant4_num"].ToString());
                        }

                        string query2 = "UPDATE Record SET status = 1 WHERE patient_id =" + v.getsetpatientSelected;
                        SqlCommand cmd2 = new SqlCommand(query2, constring);
                        cmd2.CommandText = query2;
                        cmd2.ExecuteNonQuery();
                        string query = "UPDATE Appointment SET status = 1 WHERE patient_id =" + v.getsetpatientSelected;
                        SqlCommand cmdd = new SqlCommand(query, constring);
                        cmdd.CommandText = query;
                        cmdd.ExecuteNonQuery();
                        string query3 = "UPDATE Quadrant1 SET status = 1 WHERE quadrant1_num =" + quadrant1Num;
                        SqlCommand cmd3 = new SqlCommand(query3, constring);
                        cmd3.CommandText = query3;
                        cmd3.ExecuteNonQuery();
                        string query5 = "UPDATE Quadrant2 SET status = 1 WHERE quadrant2_num =" + quadrant2Num;
                        SqlCommand cmd5 = new SqlCommand(query5, constring);
                        cmd5.CommandText = query5;
                        cmd5.ExecuteNonQuery();
                        string query6 = "UPDATE Quadrant3 SET status = 1 WHERE quadrant3_num =" + quadrant3Num;
                        SqlCommand cmd6 = new SqlCommand(query6, constring);
                        cmd6.CommandText = query6;
                        cmd6.ExecuteNonQuery();
                        string query7 = "UPDATE Quadrant4 SET status = 1 WHERE quadrant4_num =" + quadrant4Num;
                        SqlCommand cmd7 = new SqlCommand(query7, constring);
                        cmd7.CommandText = query7;
                        cmd7.ExecuteNonQuery();
                        string query4 = "UPDATE Patient SET status = 1 WHERE patient_id =" + v.getsetpatientSelected;
                        SqlCommand cmd4 = new SqlCommand(query4, constring);
                        cmd4.CommandText = query4;
                        if (cmd4.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Patient record successfully restored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            constring.Close();
                            PatientArchives ptnt = new PatientArchives();
                            ptnt.Show();
                            this.ParentForm.Hide();
                        }
                    }
                    constring.Close();
                }
                else
                {
                    MessageBox.Show("You do not have authorization to restore this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

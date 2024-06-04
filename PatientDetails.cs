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
    public partial class PatientDetails : Form
    {
        Variables v = new Variables();
        SqlConnection constring;
        public PatientDetails()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void PatientDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void PatientDetails_Load(object sender, EventArgs e)
        {
            editRecord1.Visible = false;
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            displayPatientDetails();
        }

        private void editPatientBtn_Click(object sender, EventArgs e)
        {
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    constring.Close();
                    EditPatient editptnt = new EditPatient();
                    editptnt.Show();
                    this.Hide();
                }
                else
                {
                    constring.Close();
                    MessageBox.Show("You do not have authorization to open this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            reader1.Close();
        }

        private void displayPatientDetails()
        {
            //Displaying patient info
            constring.Open();
            string sql = "SELECT * FROM Patient WHERE patient_id = " + v.getsetpatientSelected;
            DataTable patients = new DataTable("patients");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(patients);

            foreach (DataRow row in patients.Rows)
            {
                string patient_fullname = "";
                if (row["patient_mname"].ToString().Equals(null) || row["patient_mname"].ToString().Equals(""))
                {
                    patient_fullname = row["patient_fname"].ToString() + " " + row["patient_lname"].ToString();
                }
                else
                {
                    patient_fullname = row["patient_fname"].ToString() + " " + row["patient_mname"].ToString() + " " + row["patient_lname"].ToString();

                }
                string lastVisit = "";
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 appointment_date FROM Appointment WHERE patient_id = '" + row["patient_id"].ToString() + "' ORDER BY appointment_id DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    lastVisit += (DateTime.Parse(reader1["appointment_date"].ToString()).ToString("MM/dd/yyyy")).ToString();
                }
                reader1.Close();

                if (row["patient_gender"].ToString().Equals("Male"))
                {
                    picBoxFemale.Visible = false;
                }

                patientName.Text = patient_fullname.ToString();
                patientAge.Text = "Age: " + row["patient_age"].ToString();
                patientGender.Text = "Gender: " + row["patient_gender"].ToString();
                patientBday.Text = "Birthdate: " + DateTime.Parse(row["patient_bdate"].ToString()).ToString("MM/dd/yyyy");
                patientAddress.Text = "Address: " + row["patient_address"].ToString();
                patientEmail.Text = "Email Address: " + row["patient_email"].ToString();
                patientCnum.Text = "Contact Number: 09" + row["patient_cnum"].ToString();
                patientCper.Text = "Contact Person: " + row["patient_cperson"].ToString();
                contactPNumLbl.Text = "Contact Person Number: 09" + row["patient_cpernum"].ToString();
                patientLV.Text = "Last Visit: " + lastVisit.ToString();
                patientNotes.Text = row["patient_notes"].ToString();
                
                //Displaying appointment history/records
                string sql2 = "SELECT * FROM Record WHERE patient_id = " + v.getsetpatientSelected + " AND status = 1";
                DataTable records = new DataTable("record");
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, constring);
                da2.Fill(records);


                foreach (DataRow row2 in records.Rows)
                {
                    float recordsPrice;
                    string recordsDate = "", recordsTreat = "", recordsTooth;
                    string sql3 = "SELECT * FROM Appointment WHERE appointment_id = '" + row2["appointment_id"].ToString() + "'";
                    DataTable apps = new DataTable("appointments");
                    SqlDataAdapter da3 = new SqlDataAdapter(sql3, constring);
                    da3.Fill(apps);
                    recordsTooth = row2["teeth_treated"].ToString();
                    recordsPrice = float.Parse(row2["price_billed"].ToString());

                    foreach (DataRow row3 in apps.Rows)
                    {

                        recordsDate += DateTime.Parse(row3["appointment_date"].ToString()).ToString("MM/dd/yyyy");

                        SqlCommand retrieveService = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + row3["service_id"].ToString() + "'", constring);
                        SqlDataReader readService;
                        readService = retrieveService.ExecuteReader();
                        if (readService.Read())
                        {
                            recordsTreat += readService["service_name"].ToString();
                        }
                        readService.Close();
                        if (!string.IsNullOrEmpty(row3["service_id2"].ToString()))
                        {
                            SqlCommand retrieveService2 = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + row3["service_id2"].ToString() + "'", constring);
                            SqlDataReader readService2;
                            readService2 = retrieveService2.ExecuteReader();
                            if (readService2.Read())
                            {
                                recordsTreat += ", " + readService2["service_name"].ToString();
                            }
                            readService2.Close();
                        }
                        if (!string.IsNullOrEmpty(row3["service_id3"].ToString()))
                        {
                            SqlCommand retrieveService3 = new SqlCommand("SELECT * FROM Service WHERE service_id = '" + row3["service_id3"].ToString() + "'", constring);
                            SqlDataReader readService3;
                            readService3 = retrieveService3.ExecuteReader();
                            if (readService3.Read())
                            {
                                recordsTreat += ", " + readService3["service_name"].ToString();
                            }
                            readService3.Close();
                        }

                    }
                    Record record = new Record();
                    record.setPatientInfo(row2["record_id"].ToString(), recordsDate, recordsTreat, recordsTooth, recordsPrice);
                    recordContainer.Controls.Add(record);
                }

                //Displaying patient files
                string sqll = "SELECT * FROM [File] WHERE patient_id = " + v.getsetpatientSelected + " AND status = 1";
                DataTable files = new DataTable("file");
                SqlDataAdapter daa = new SqlDataAdapter(sqll, constring);
                daa.Fill(files);


                foreach (DataRow roww in files.Rows)
                {
                    PatientDetailsAttachment pda = new PatientDetailsAttachment();
                    pda.setAttachment(roww["file_id"].ToString(), roww["file_name"].ToString());
                    attachmentContainer.Controls.Add(pda);
                }
            }
            constring.Close();
        }

        private void dshbrdBtn_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            this.Hide();
        }

        private void clndrbtn_Click(object sender, EventArgs e)
        {
            Calendar clndr = new Calendar();
            clndr.Show();
            this.Hide();
        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            Patients patnt = new Patients();
            patnt.Show();
            this.Hide();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    constring.Close();
                    Staff stf = new Staff();
                    stf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You do not have authorization to open this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    constring.Close();
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            reader1.Close();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            Services srvcs = new Services();
            srvcs.Show();
            this.Hide();
        }

        public void editVisible()
        {
            editRecord1.Visible = true;
            editRecord1.setValues();
        }

        private void deletePtnt_Click(object sender, EventArgs e)
        {
            //Deleting a patient
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this patient?\nThis will be moved to the trash bin.", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        reader1.Close();
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

                        string query2 = "UPDATE Record SET status = 0 WHERE patient_id =" + v.getsetpatientSelected;
                        SqlCommand cmd2 = new SqlCommand(query2, constring);
                        cmd2.CommandText = query2;
                        cmd2.ExecuteNonQuery();
                        string query = "UPDATE Appointment SET status = 0 WHERE patient_id =" + v.getsetpatientSelected;
                        SqlCommand cmdd = new SqlCommand(query, constring);
                        cmdd.CommandText = query;
                        cmdd.ExecuteNonQuery();
                        string query3 = "UPDATE [File] SET status = 0 WHERE patient_id =" + v.getsetpatientSelected;
                        SqlCommand cmd3 = new SqlCommand(query3, constring);
                        cmd3.CommandText = query3;
                        cmd3.ExecuteNonQuery();
                        string query8 = "UPDATE Quadrant1 SET status = 0 WHERE quadrant1_num =" + quadrant1Num;
                        SqlCommand cmd8 = new SqlCommand(query8, constring);
                        cmd8.CommandText = query8;
                        cmd8.ExecuteNonQuery();
                        string query5 = "UPDATE Quadrant2 SET status = 0 WHERE quadrant2_num =" + quadrant2Num;
                        SqlCommand cmd5 = new SqlCommand(query5, constring);
                        cmd5.CommandText = query5;
                        cmd5.ExecuteNonQuery();
                        string query6 = "UPDATE Quadrant3 SET status = 0 WHERE quadrant3_num =" + quadrant3Num;
                        SqlCommand cmd6 = new SqlCommand(query6, constring);
                        cmd6.CommandText = query6;
                        cmd6.ExecuteNonQuery();
                        string query7 = "UPDATE Quadrant4 SET status = 0 WHERE quadrant4_num =" + quadrant4Num;
                        SqlCommand cmd7 = new SqlCommand(query7, constring);
                        cmd7.CommandText = query7;
                        cmd7.ExecuteNonQuery();
                        string query4 = "UPDATE Patient SET status = 0 WHERE patient_id =" + v.getsetpatientSelected;
                        SqlCommand cmd4 = new SqlCommand(query4, constring);
                        cmd4.CommandText = query4;
                        if (cmd4.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Patient has been added to the Trash Bin/Archives!");

                            MessageBox.Show("");
                            constring.Close();
                            Patients ptnt = new Patients();
                            ptnt.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("DATA NOT DELETED SUCCESSFULLY");
                        }
                    }
                    constring.Close();
                }
                else
                {
                    MessageBox.Show("You do not have authorization to open this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    constring.Close();
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
        }

        private void openDental_Click(object sender, EventArgs e)
        {
            DentalRecord dr = new DentalRecord();
            dr.Show();
            this.Hide();
        }

        private void addAttachment_Click(object sender, EventArgs e)
        {
            //Adding attachment of a patient file
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    reader1.Close();
                    OpenFileDialog openFile = new OpenFileDialog();
                    openFile.Filter = "Pdf Files |*.pdf;|Image Files| *.jpg; *.jpeg; *.png;";

                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        int fileID = 0;
                        SqlCommand cmdd = new SqlCommand("SELECT TOP 1 file_id FROM [File] ORDER BY file_id DESC", constring);
                        SqlDataReader readerr1;
                        readerr1 = cmdd.ExecuteReader();
                        if (readerr1.Read())
                        {
                            fileID = readerr1.GetInt32(0) + 1;
                        }
                        else
                        {
                            MessageBox.Show("NO DATA FOUND");
                        }
                        readerr1.Close();
                        cmdd.Dispose();

                        string query = "INSERT INTO [File] VALUES('" + fileID + "','" + v.getsetpatientSelected + "','"
                            + System.IO.Path.GetFileName(openFile.FileName) + "','" + openFile.FileName + "',1);";
                        SqlCommand addAttach = new SqlCommand(query, constring);
                        if (addAttach.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("File added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            constring.Close();
                            this.Hide();
                            PatientDetails pd = new PatientDetails();
                            pd.Show();

                        }
                    }
                    constring.Close();
                }
                else
                {
                    MessageBox.Show("You do not have authorization to open this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    constring.Close();
                }
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            
        }

        private void archiveBtn_Click(object sender, EventArgs e)
        {
            FileArchives file = new FileArchives();
            file.Show();
            this.Hide();
        }
    }
}
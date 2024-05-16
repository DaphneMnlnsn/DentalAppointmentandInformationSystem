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
    public partial class Appointment : UserControl
    {
        Variables v = new Variables();
        public Appointment()
        {
            InitializeComponent();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            displayAppointment();
        }

        private void displayAppointment()
        {
            SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DAISdB.mdf;Integrated Security=True");
            constring.Open();
            string sql = "SELECT * FROM Appointment WHERE appointment_date = " + "'" + v.getsetYear.ToString() + "/" + v.getsetMonth.ToString() + "/" + v.getsetDay + "'";
            SqlCommand cmd = constring.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int service_id = Convert.ToInt32(reader["service_id"]);
                string service_id2 = reader["service_id2"].ToString();
                string service_id3 = reader["service_id3"].ToString();
                int patient_id = Convert.ToInt32(reader["patient_id"]);
                int employee_id = Convert.ToInt32(reader["employee_num"]);
                string employee_id2 = reader["employee_num2"].ToString();
                string employee_id3 = reader["employee_num3"].ToString();

                string time = reader["appointment_startTime"].ToString()[0] + "" + reader["appointment_startTime"].ToString()[1] + "" + reader["appointment_startTime"].ToString()[2] + "" + reader["appointment_startTime"].ToString()[3] + "" + reader["appointment_startTime"].ToString()[4];
                string time2 = reader["appointment_endTime"].ToString()[0] + "" + reader["appointment_endTime"].ToString()[1] + "" + reader["appointment_endTime"].ToString()[2] + "" + reader["appointment_endTime"].ToString()[3] + "" + reader["appointment_endTime"].ToString()[4];
                reader.Dispose();
                cmd.Dispose();
                string sql2 = "SELECT * FROM Service WHERE service_id = " + "'" + service_id + "'";
                SqlCommand cmd2 = constring.CreateCommand();
                cmd2.CommandText = sql2;
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    string serviceName = reader2["service_name"].ToString();
                    reader2.Dispose();
                    cmd2.Dispose();
                    if (service_id2 != null || service_id2 != "")
                    {
                        string sql3 = "SELECT * FROM Service WHERE service_id = " + "'" + service_id2 + "'";
                        SqlCommand cmd3 = constring.CreateCommand();
                        cmd3.CommandText = sql3;
                        SqlDataReader reader3 = cmd3.ExecuteReader();
                        if (reader3.Read())
                        {
                            serviceName += ", " + reader3["service_name"].ToString();
                        }
                        reader3.Dispose();
                        cmd3.Dispose();
                    }
                    else if (service_id3 != null || service_id3 != " ")
                    {
                        string sql4 = "SELECT * FROM Service WHERE service_id = " + "'" + service_id3 + "'";
                        SqlCommand cmd4 = constring.CreateCommand();
                        cmd4.CommandText = sql4;
                        SqlDataReader reader4 = cmd4.ExecuteReader();
                        if (reader4.Read())
                        {
                            serviceName += ", " + reader4["service_name"].ToString();
                        }
                        reader4.Dispose();
                        cmd4.Dispose();
                    }
                    string sql5 = "SELECT * FROM Patient WHERE patient_id = " + "'" + patient_id + "'";
                    SqlCommand cmd5 = constring.CreateCommand();
                    cmd5.CommandText = sql5;
                    SqlDataReader reader5 = cmd5.ExecuteReader();
                    if (reader5.Read())
                    {
                        string patient_name;
                        if (reader5.GetValue(5).ToString().Equals("Female"))
                        {
                            patient_name = "Ms. " + reader5["patient_lname"].ToString() + ", " + reader5["patient_fname"].ToString() + " " + reader5["patient_mname"].ToString();
                        }
                        else
                        {
                            patient_name = "Mr. " + reader5["patient_lname"].ToString() + ", " + reader5["patient_fname"].ToString() + " " + reader5["patient_mname"].ToString();
                        }
                        reader5.Dispose();
                        cmd5.Dispose();
                        string sql6 = "SELECT * FROM Staff WHERE employee_num = " + "'" + employee_id + "'";
                        SqlCommand cmd6 = constring.CreateCommand();
                        cmd6.CommandText = sql6;
                        SqlDataReader reader6 = cmd6.ExecuteReader();
                        if (reader6.Read())
                        {
                            string staffName;
                            if (reader6.GetValue(2).ToString().Equals("NULL") || reader6.GetValue(2).ToString().Equals(""))
                            {
                                staffName = reader6.GetValue(3).ToString() + " " + reader6.GetValue(1).ToString();
                            }
                            else
                            {
                                staffName = reader6.GetValue(3).ToString() + " " + reader6.GetValue(2).ToString() + " " + reader6.GetValue(1).ToString();
                            }
                            reader6.Dispose();
                            cmd6.Dispose();
                            if (employee_id2 != null || employee_id2 != " ")
                            {
                                string sql7 = "SELECT * FROM Staff WHERE employee_num = " + "'" + employee_id2 + "'";
                                SqlCommand cmd7 = constring.CreateCommand();
                                cmd7.CommandText = sql7;
                                SqlDataReader reader7 = cmd7.ExecuteReader();
                                if (reader7.Read())
                                {
                                    if (reader7.GetValue(2).ToString().Equals("NULL") || reader7.GetValue(2).ToString().Equals(""))
                                    {
                                        staffName += ", " + reader7.GetValue(3).ToString() + " " + reader7.GetValue(1).ToString();
                                    }
                                    else
                                    {
                                        staffName += ", " + reader7.GetValue(3).ToString() + " " + reader7.GetValue(2).ToString() + " " + reader7.GetValue(1).ToString();
                                    }
                                }
                                reader7.Dispose();
                                cmd7.Dispose();
                            }
                            else if (employee_id3 != null || employee_id3 != " ")
                            {
                                string sql8 = "SELECT * FROM Staff WHERE employee_num = " + "'" + employee_id3 + "'";
                                SqlCommand cmd8 = constring.CreateCommand();
                                cmd8.CommandText = sql8;
                                SqlDataReader reader8 = cmd8.ExecuteReader();
                                if (reader8.Read())
                                {
                                    if (reader8.GetValue(2).ToString().Equals("NULL") || reader8.GetValue(2).ToString().Equals(""))
                                    {
                                        staffName.Concat(", " + reader8.GetValue(3).ToString() + " " + reader8.GetValue(1).ToString());
                                    }
                                    else
                                    {
                                        staffName.Concat(", " + reader8.GetValue(3).ToString() + " " + reader8.GetValue(2).ToString() + " " + reader8.GetValue(1).ToString());
                                    }
                                }
                                reader8.Dispose();
                                cmd8.Dispose();
                            }
                            ptntLbl.Text = patient_name;
                            srvcLbl.Text = serviceName;
                            timeLbl.Text = time + "-" + time2;
                            stffLbl.Text = staffName;
                        }
                    }
                }
            }
            constring.Close();
        }

        private void editAppntmnt_Click(object sender, EventArgs e)
        {
            EditAppointment editAppointment = new EditAppointment();
            editAppointment.Show();
            this.Parent.Hide();
        }
    }
}
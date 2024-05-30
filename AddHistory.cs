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
    public partial class AddHistory : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;

        public AddHistory()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void AddService_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void saveHistoryBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pastTrtmntTxtBox.Text) && !string.IsNullOrWhiteSpace(dentistNameTxtBox.Text))
            {
                int historyID = 0;
                constring.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 history_id FROM History ORDER BY history_id DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    historyID = reader1.GetInt32(0) + 1;
                }
                else
                {
                    MessageBox.Show("NO DATA FOUND");
                }
                reader1.Close();
                cmd.Dispose();

                String query = "INSERT INTO History VALUES('" + historyID + "','" + v.getsetpatientSelected + "','',NULL,'" + dentistNameTxtBox.Text + "','"
                    + pastTrtmntTxtBox.Text + "',1);";

                SqlCommand cmd2 = new SqlCommand(query, constring);
                cmd2.CommandText = query;
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("History added successfully!");
                    this.Visible = false;
                    this.ParentForm.Hide();
                    constring.Close();
                    PatientDetails ptntdeets = new PatientDetails();
                    ptntdeets.Show();
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

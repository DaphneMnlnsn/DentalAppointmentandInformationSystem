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
    public partial class EditHistory : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;

        public EditHistory()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void EditService_Load(object sender, EventArgs e)
        {

        }

        private void saveSrvcBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pastTrtmntTxtBox.Text) && !string.IsNullOrWhiteSpace(dentistNameTxtBox.Text))
            {
                /*constring.Open();

                string query2 = "UPDATE History SET past_treatment = '" + pastTrtmntTxtBox.Text +
                    "', dentist_name = '" + dentistNameTxtBox.Text + "' WHERE history_id = '" + v.getsethistorySelected + "';";

                SqlCommand cmd3 = new SqlCommand(query2, constring);
                cmd3.CommandText = query2;
                if (cmd3.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Changes Saved!");
                    this.Visible = false;
                    this.ParentForm.Hide();
                    constring.Close();
                    PatientDetails ptntDetails = new PatientDetails();
                    ptntDetails.Show();
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                }*/
            }
            else
            {
                MessageBox.Show("Please fill out all required fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void setValues()
        {
            /*constring.Open();
            string query = "SELECT * FROM History WHERE history_id =" + int.Parse(v.getsethistorySelected);
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                pastTrtmntTxtBox.Text = row["past_treatment"].ToString();
                dentistNameTxtBox.Text = row["dentist_name"].ToString();
            }
            constring.Close();
            */
        }
    }
}

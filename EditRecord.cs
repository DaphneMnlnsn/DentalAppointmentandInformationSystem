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
    public partial class EditRecord : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring;

        public EditRecord()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void EditService_Load(object sender, EventArgs e)
        {

        }

        private void saveSrvcBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(teethTrtdTxtBox.Text) && !string.IsNullOrWhiteSpace(priceBilledTxtBox.Text))
            {
                float num;
                bool checkInput = float.TryParse(priceBilledTxtBox.Text, out num);

                if (checkInput == true)
                {
                    constring.Open();

                    string query2 = "UPDATE Record SET teeth_treated = '" + teethTrtdTxtBox.Text +
                        "', price_billed = '" + priceBilledTxtBox.Text + "' WHERE record_id = '" + v.getsetrecordSelected + "';";

                    SqlCommand cmd3 = new SqlCommand(query2, constring);
                    cmd3.CommandText = query2;
                    if (cmd3.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Changes saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Visible = false;
                        this.ParentForm.Hide();
                        constring.Close();
                        PatientDetails ptntDetails = new PatientDetails();
                        ptntDetails.Show();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Please input a number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
            constring.Open();
            string query = "SELECT * FROM Record WHERE record_id =" + int.Parse(v.getsetrecordSelected);
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                teethTrtdTxtBox.Text = row["teeth_treated"].ToString();
                priceBilledTxtBox.Text = row["price_billed"].ToString();
            }
            constring.Close();
        }
    }
}

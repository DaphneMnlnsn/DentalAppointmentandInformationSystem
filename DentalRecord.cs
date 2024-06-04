using DentalAppointmentandInformationSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalAppointmentandInformationSystem
{
    public partial class DentalRecord : Form
    {
        Variables v = new Variables();
        SqlConnection constring;
        public DentalRecord()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void DentalRecord_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            setValues();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            //Checking authorization
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
        }

        private void patientBtn_Click(object sender, EventArgs e)
        {
            Patients patient = new Patients();
            patient.Show();
            this.Hide();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
            this.Hide();
        }

        private void Calendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dshbrdBtn_Click(object sender, EventArgs e)
        {
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
            this.Hide();
        }

        private void editDentalRecBtn_Click(object sender, EventArgs e)
        {
            //Checking authorization if staff can edit
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE employee_num =" + int.Parse(v.getsetloggedIn), constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1.GetValue(7).ToString().Equals("Dentist") || reader1.GetValue(7).ToString().Equals("Administrator"))
                {
                    constring.Close();
                    EditDentalRecord editDR = new EditDentalRecord();
                    editDR.Show();
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
        }
        private void setValues()
        {
            //Setting the values of the textboxes based on existing data in the database
            constring.Open();
            int quadrant1Num = 0, quadrant2Num = 0, quadrant3Num = 0, quadrant4Num = 0;

            string query = "SELECT * FROM Patient WHERE patient_id =" + int.Parse(v.getsetpatientSelected);
            SqlDataAdapter adpt = new SqlDataAdapter(query, constring);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                quadrant1Num = int.Parse(row["quadrant1_num"].ToString());
                quadrant2Num = int.Parse(row["quadrant2_num"].ToString());
                quadrant3Num = int.Parse(row["quadrant3_num"].ToString());
                quadrant4Num = int.Parse(row["quadrant4_num"].ToString());
            }

            //Setting values for quadrant 1
            string setquadrant1 = "SELECT * FROM Quadrant1 WHERE quadrant1_num =" + quadrant1Num;
            SqlDataAdapter quadrant1adpt = new SqlDataAdapter(setquadrant1, constring);
            DataTable quadrant1DT = new DataTable();
            quadrant1adpt.Fill(quadrant1DT);
            foreach (DataRow row in quadrant1DT.Rows)
            {
                S18.Text = string.Join("", row["tooth_18"].ToString().Where(Char.IsLetter).ToArray());
                TM18.Text = string.Join("", row["tooth_18"].ToString().Where(Char.IsDigit).ToArray());
                S17.Text = string.Join("", row["tooth_17"].ToString().Where(Char.IsLetter).ToArray());
                TM17.Text = string.Join("", row["tooth_17"].ToString().Where(Char.IsDigit).ToArray());
                S16.Text = string.Join("", row["tooth_16"].ToString().Where(Char.IsLetter).ToArray());
                TM16.Text = string.Join("", row["tooth_16"].ToString().Where(Char.IsDigit).ToArray());
                S15.Text = string.Join("", row["tooth_15"].ToString().Where(Char.IsLetter).ToArray());
                TM15.Text = string.Join("", row["tooth_15"].ToString().Where(Char.IsDigit).ToArray());
                S14.Text = string.Join("", row["tooth_14"].ToString().Where(Char.IsLetter).ToArray());
                TM14.Text = string.Join("", row["tooth_14"].ToString().Where(Char.IsDigit).ToArray());
                S13.Text = string.Join("", row["tooth_13"].ToString().Where(Char.IsLetter).ToArray());
                TM13.Text = string.Join("", row["tooth_13"].ToString().Where(Char.IsDigit).ToArray());
                S12.Text = string.Join("", row["tooth_12"].ToString().Where(Char.IsLetter).ToArray());
                TM12.Text = string.Join("", row["tooth_12"].ToString().Where(Char.IsDigit).ToArray());
                S11.Text = string.Join("", row["tooth_11"].ToString().Where(Char.IsLetter).ToArray());
                TM11.Text = string.Join("", row["tooth_11"].ToString().Where(Char.IsDigit).ToArray());
                S55.Text = string.Join("", row["tooth_55"].ToString().Where(Char.IsLetter).ToArray());
                TM55.Text = string.Join("", row["tooth_55"].ToString().Where(Char.IsDigit).ToArray());
                S54.Text = string.Join("", row["tooth_54"].ToString().Where(Char.IsLetter).ToArray());
                TM54.Text = string.Join("", row["tooth_54"].ToString().Where(Char.IsDigit).ToArray());
                S53.Text = string.Join("", row["tooth_53"].ToString().Where(Char.IsLetter).ToArray());
                TM53.Text = string.Join("", row["tooth_53"].ToString().Where(Char.IsDigit).ToArray());
                S52.Text = string.Join("", row["tooth_52"].ToString().Where(Char.IsLetter).ToArray());
                TM52.Text = string.Join("", row["tooth_52"].ToString().Where(Char.IsDigit).ToArray());
                S51.Text = string.Join("", row["tooth_51"].ToString().Where(Char.IsLetter).ToArray());
                TM51.Text = string.Join("", row["tooth_51"].ToString().Where(Char.IsDigit).ToArray());
                checkDigit(TM18.Text, t18); checkDigit(TM17.Text, t17); checkDigit(TM16.Text, t16);
                checkDigit(TM15.Text, t15); checkDigit(TM14.Text, t14); checkDigit(TM13.Text, t13);
                checkDigit(TM12.Text, t12); checkDigit(TM11.Text, t11); checkDigit(TM55.Text, t55);
                checkDigit(TM54.Text, t54); checkDigit(TM53.Text, t53); checkDigit(TM52.Text, t52);
                checkDigit(TM51.Text, t51);

            }

            //Setting values for quadrant 2
            string setquadrant2 = "SELECT * FROM Quadrant2 WHERE quadrant2_num =" + quadrant2Num;
            SqlDataAdapter quadrant2adpt = new SqlDataAdapter(setquadrant2, constring);
            DataTable quadrant2DT = new DataTable();
            quadrant2adpt.Fill(quadrant2DT);
            foreach (DataRow row in quadrant2DT.Rows)
            {
                S21.Text = string.Join("", row["tooth_21"].ToString().Where(Char.IsLetter).ToArray());
                TM21.Text = string.Join("", row["tooth_21"].ToString().Where(Char.IsDigit).ToArray());
                S22.Text = string.Join("", row["tooth_22"].ToString().Where(Char.IsLetter).ToArray());
                TM22.Text = string.Join("", row["tooth_22"].ToString().Where(Char.IsDigit).ToArray());
                S23.Text = string.Join("", row["tooth_23"].ToString().Where(Char.IsLetter).ToArray());
                TM23.Text = string.Join("", row["tooth_23"].ToString().Where(Char.IsDigit).ToArray());
                S24.Text = string.Join("", row["tooth_24"].ToString().Where(Char.IsLetter).ToArray());
                TM24.Text = string.Join("", row["tooth_24"].ToString().Where(Char.IsDigit).ToArray());
                S25.Text = string.Join("", row["tooth_25"].ToString().Where(Char.IsLetter).ToArray());
                TM25.Text = string.Join("", row["tooth_25"].ToString().Where(Char.IsDigit).ToArray());
                S26.Text = string.Join("", row["tooth_26"].ToString().Where(Char.IsLetter).ToArray());
                TM26.Text = string.Join("", row["tooth_26"].ToString().Where(Char.IsDigit).ToArray());
                S27.Text = string.Join("", row["tooth_27"].ToString().Where(Char.IsLetter).ToArray());
                TM27.Text = string.Join("", row["tooth_27"].ToString().Where(Char.IsDigit).ToArray());
                S28.Text = string.Join("", row["tooth_28"].ToString().Where(Char.IsLetter).ToArray());
                TM28.Text = string.Join("", row["tooth_28"].ToString().Where(Char.IsDigit).ToArray());
                S61.Text = string.Join("", row["tooth_61"].ToString().Where(Char.IsLetter).ToArray());
                TM61.Text = string.Join("", row["tooth_61"].ToString().Where(Char.IsDigit).ToArray());
                S62.Text = string.Join("", row["tooth_62"].ToString().Where(Char.IsLetter).ToArray());
                TM62.Text = string.Join("", row["tooth_62"].ToString().Where(Char.IsDigit).ToArray());
                S63.Text = string.Join("", row["tooth_63"].ToString().Where(Char.IsLetter).ToArray());
                TM63.Text = string.Join("", row["tooth_63"].ToString().Where(Char.IsDigit).ToArray());
                S64.Text = string.Join("", row["tooth_64"].ToString().Where(Char.IsLetter).ToArray());
                TM64.Text = string.Join("", row["tooth_64"].ToString().Where(Char.IsDigit).ToArray());
                S65.Text = string.Join("", row["tooth_65"].ToString().Where(Char.IsLetter).ToArray());
                TM65.Text = string.Join("", row["tooth_65"].ToString().Where(Char.IsDigit).ToArray());
                checkDigit(TM21.Text, t21); checkDigit(TM22.Text, t22); checkDigit(TM23.Text, t23);
                checkDigit(TM24.Text, t24); checkDigit(TM25.Text, t25); checkDigit(TM26.Text, t26);
                checkDigit(TM27.Text, t27); checkDigit(TM28.Text, t28); checkDigit(TM61.Text, t61);
                checkDigit(TM62.Text, t62); checkDigit(TM63.Text, t63); checkDigit(TM64.Text, t64);
                checkDigit(TM65.Text, t65);
            }

            //Setting values for quadrant 3
            string setquadrant3 = "SELECT * FROM Quadrant3 WHERE quadrant3_num =" + quadrant3Num;
            SqlDataAdapter quadrant3adpt = new SqlDataAdapter(setquadrant3, constring);
            DataTable quadrant3DT = new DataTable();
            quadrant3adpt.Fill(quadrant3DT);
            foreach (DataRow row in quadrant3DT.Rows)
            {
                S31.Text = string.Join("", row["tooth_31"].ToString().Where(Char.IsLetter).ToArray());
                TM31.Text = string.Join("", row["tooth_31"].ToString().Where(Char.IsDigit).ToArray());
                S32.Text = string.Join("", row["tooth_32"].ToString().Where(Char.IsLetter).ToArray());
                TM32.Text = string.Join("", row["tooth_32"].ToString().Where(Char.IsDigit).ToArray());
                S33.Text = string.Join("", row["tooth_33"].ToString().Where(Char.IsLetter).ToArray());
                TM33.Text = string.Join("", row["tooth_33"].ToString().Where(Char.IsDigit).ToArray());
                S34.Text = string.Join("", row["tooth_34"].ToString().Where(Char.IsLetter).ToArray());
                TM34.Text = string.Join("", row["tooth_34"].ToString().Where(Char.IsDigit).ToArray());
                S35.Text = string.Join("", row["tooth_35"].ToString().Where(Char.IsLetter).ToArray());
                TM35.Text = string.Join("", row["tooth_35"].ToString().Where(Char.IsDigit).ToArray());
                S36.Text = string.Join("", row["tooth_36"].ToString().Where(Char.IsLetter).ToArray());
                TM36.Text = string.Join("", row["tooth_36"].ToString().Where(Char.IsDigit).ToArray());
                S37.Text = string.Join("", row["tooth_37"].ToString().Where(Char.IsLetter).ToArray());
                TM37.Text = string.Join("", row["tooth_37"].ToString().Where(Char.IsDigit).ToArray());
                S38.Text = string.Join("", row["tooth_38"].ToString().Where(Char.IsLetter).ToArray());
                TM38.Text = string.Join("", row["tooth_38"].ToString().Where(Char.IsDigit).ToArray());
                S71.Text = string.Join("", row["tooth_71"].ToString().Where(Char.IsLetter).ToArray());
                TM71.Text = string.Join("", row["tooth_71"].ToString().Where(Char.IsDigit).ToArray());
                S72.Text = string.Join("", row["tooth_72"].ToString().Where(Char.IsLetter).ToArray());
                TM72.Text = string.Join("", row["tooth_72"].ToString().Where(Char.IsDigit).ToArray());
                S73.Text = string.Join("", row["tooth_73"].ToString().Where(Char.IsLetter).ToArray());
                TM73.Text = string.Join("", row["tooth_73"].ToString().Where(Char.IsDigit).ToArray());
                S74.Text = string.Join("", row["tooth_74"].ToString().Where(Char.IsLetter).ToArray());
                TM74.Text = string.Join("", row["tooth_74"].ToString().Where(Char.IsDigit).ToArray());
                S75.Text = string.Join("", row["tooth_75"].ToString().Where(Char.IsLetter).ToArray());
                TM75.Text = string.Join("", row["tooth_75"].ToString().Where(Char.IsDigit).ToArray());
                checkDigit(TM31.Text, t31); checkDigit(TM32.Text, t32); checkDigit(TM33.Text, t33);
                checkDigit(TM34.Text, t34); checkDigit(TM35.Text, t35); checkDigit(TM36.Text, t36);
                checkDigit(TM37.Text, t37); checkDigit(TM38.Text, t38); checkDigit(TM71.Text, t71);
                checkDigit(TM72.Text, t72); checkDigit(TM73.Text, t73); checkDigit(TM74.Text, t74);
                checkDigit(TM75.Text, t75);
            }

            //Setting values for quadrant 4
            string setquadrant4 = "SELECT * FROM Quadrant4 WHERE quadrant4_num =" + quadrant4Num;
            SqlDataAdapter quadrant4adpt = new SqlDataAdapter(setquadrant4, constring);
            DataTable quadrant4DT = new DataTable();
            quadrant4adpt.Fill(quadrant4DT);
            foreach (DataRow row in quadrant4DT.Rows)
            {
                S48.Text = string.Join("", row["tooth_48"].ToString().Where(Char.IsLetter).ToArray());
                TM48.Text = string.Join("", row["tooth_48"].ToString().Where(Char.IsDigit).ToArray());
                S47.Text = string.Join("", row["tooth_47"].ToString().Where(Char.IsLetter).ToArray());
                TM47.Text = string.Join("", row["tooth_47"].ToString().Where(Char.IsDigit).ToArray());
                S46.Text = string.Join("", row["tooth_46"].ToString().Where(Char.IsLetter).ToArray());
                TM46.Text = string.Join("", row["tooth_46"].ToString().Where(Char.IsDigit).ToArray());
                S45.Text = string.Join("", row["tooth_45"].ToString().Where(Char.IsLetter).ToArray());
                TM45.Text = string.Join("", row["tooth_45"].ToString().Where(Char.IsDigit).ToArray());
                S44.Text = string.Join("", row["tooth_44"].ToString().Where(Char.IsLetter).ToArray());
                TM44.Text = string.Join("", row["tooth_44"].ToString().Where(Char.IsDigit).ToArray());
                S43.Text = string.Join("", row["tooth_43"].ToString().Where(Char.IsLetter).ToArray());
                TM43.Text = string.Join("", row["tooth_43"].ToString().Where(Char.IsDigit).ToArray());
                S42.Text = string.Join("", row["tooth_42"].ToString().Where(Char.IsLetter).ToArray());
                TM42.Text = string.Join("", row["tooth_42"].ToString().Where(Char.IsDigit).ToArray());
                S41.Text = string.Join("", row["tooth_41"].ToString().Where(Char.IsLetter).ToArray());
                TM41.Text = string.Join("", row["tooth_41"].ToString().Where(Char.IsDigit).ToArray());
                S85.Text = string.Join("", row["tooth_85"].ToString().Where(Char.IsLetter).ToArray());
                TM85.Text = string.Join("", row["tooth_85"].ToString().Where(Char.IsDigit).ToArray());
                S84.Text = string.Join("", row["tooth_84"].ToString().Where(Char.IsLetter).ToArray());
                TM84.Text = string.Join("", row["tooth_84"].ToString().Where(Char.IsDigit).ToArray());
                S83.Text = string.Join("", row["tooth_83"].ToString().Where(Char.IsLetter).ToArray());
                TM83.Text = string.Join("", row["tooth_83"].ToString().Where(Char.IsDigit).ToArray());
                S82.Text = string.Join("", row["tooth_82"].ToString().Where(Char.IsLetter).ToArray());
                TM82.Text = string.Join("", row["tooth_82"].ToString().Where(Char.IsDigit).ToArray());
                S81.Text = string.Join("", row["tooth_81"].ToString().Where(Char.IsLetter).ToArray());
                TM81.Text = string.Join("", row["tooth_81"].ToString().Where(Char.IsDigit).ToArray());
                checkDigit(TM48.Text, t48); checkDigit(TM47.Text, t47); checkDigit(TM46.Text, t46);
                checkDigit(TM45.Text, t45); checkDigit(TM44.Text, t44); checkDigit(TM43.Text, t43);
                checkDigit(TM42.Text, t42); checkDigit(TM41.Text, t41); checkDigit(TM85.Text, t85);
                checkDigit(TM84.Text, t84); checkDigit(TM83.Text, t83); checkDigit(TM82.Text, t82);
                checkDigit(TM81.Text, t81);
            }

            constring.Close();
        }
        private void checkDigit(string TM, PictureBox picture)
        {
            //Setting the picture box based on the number inputted
            if(TM.Equals("1"))
            {
                setPictureBoxTop(picture);
            }
            else if (TM.Equals("2"))
            {
                setPictureBoxLeft(picture);
            }
            else if (TM.Equals("3"))
            {
                setPictureBoxRight(picture);
            }
            else if (TM.Equals("4"))
            {
                setPictureBoxBottom(picture);
            }
            else if (TM.Equals("5"))
            {
                setPictureBoxCenter(picture);
            }
            else if (TM.Equals("6"))
            {
                setPictureBoxFull(picture);
            }
            else
            {
                picture.Image = Properties.Resources.blank_tooth;
                picture.Refresh();
                picture.Visible = true;
            }
        }
        private void setPictureBoxLeft(PictureBox picture)
        {
                picture.Image = Properties.Resources.left_tooth;
                picture.Refresh();
                picture.Visible = true;
        }
        private void setPictureBoxRight(PictureBox picture)
        {
            picture.Image = Properties.Resources.right_tooth;
            picture.Refresh();
            picture.Visible = true;
        }
        private void setPictureBoxTop(PictureBox picture)
        {
            picture.Image = Properties.Resources.top_tooth;
            picture.Refresh();
            picture.Visible = true;
        }
        private void setPictureBoxBottom(PictureBox picture)
        {
            picture.Image = Properties.Resources.bottom_tooth;
            picture.Refresh();
            picture.Visible = true;
        }
        private void setPictureBoxCenter(PictureBox picture)
        {
            picture.Image = Properties.Resources.center_tooth;
            picture.Refresh();
            picture.Visible = true;
        }
        private void setPictureBoxFull(PictureBox picture)
        {
            picture.Image = Properties.Resources.full_tooth;
            picture.Refresh();
            picture.Visible = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new PatientDetails().Show();
            this.Hide();
        }
    }
}
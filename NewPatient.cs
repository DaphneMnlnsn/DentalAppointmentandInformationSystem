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
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }
        private void NewPatient_Load(object sender, EventArgs e)
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }
        private void attachFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Documents";
            openFileDialog1.Title = "Select medical record file.";
            openFileDialog1.Filter = "Select Valid Document(*.pdf; *.doc; *.xlsx; *.html; *.png; *.jpg)|*.pdf; *.docx; *.xlsx; *.html; *.png; *.jpg";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog1.CheckFileExists)
                {
                    string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                }
            }
            else
            {
                MessageBox.Show("Please Upload document.");
            }
        }

        private void savePatientBtn_Click(object sender, EventArgs e)
        {
            SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daph\source\repos\DentalAppointmentandInformationSystem\DAISdB.mdf;Integrated Security=True");
            string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
            if (filename == null)
            {
                MessageBox.Show("Please select a valid document.");
            }
            else
            {
                //we already define our connection globaly. We are just calling the object of connection.
                constring.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO History(med_history) VALUES ('\\Document\\" + filename + "')", constring);
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                System.IO.File.Copy(openFileDialog1.FileName, path + "\\Document\\" + filename);
                cmd.ExecuteNonQuery();
                constring.Close();
            }
        }
        private void NewPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


    }
}
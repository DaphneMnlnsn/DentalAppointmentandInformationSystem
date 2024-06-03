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
    public partial class AttachmentDisplay : Form
    {
        Variables v = new Variables();
        SqlConnection constring;
        public AttachmentDisplay()
        {
            InitializeComponent();
            constring = v.getConnection;
        }

        private void AttachmentDisplay_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }
        public void DisplayAttachedFile(string fileSelected)
        {
            string filePath = "";
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT file_path FROM [File] WHERE file_id = '" + fileSelected + "';", constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                filePath = reader1["file_path"].ToString();
            }
            
            string fileExtension = System.IO.Path.GetExtension(filePath).ToLower();

            if (fileExtension == ".pdf")
            {
                webBrowser1.Visible = true;
                pictureBox1.Visible = false;
                webBrowser1.Navigate(filePath);
            }
            else if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" ||
                     fileExtension == ".bmp" || fileExtension == ".gif")
            {
                pictureBox1.Visible = true;
                webBrowser1.Visible = false;
                pictureBox1.Image = Image.FromFile(filePath);
            }
            constring.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AttachmentDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            constring.Close();
        }

        private void AttachmentDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            constring.Close();
        }
    }
}
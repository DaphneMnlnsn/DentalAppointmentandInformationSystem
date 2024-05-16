using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Xml.Linq;
using DentalAppointmentandInformationSystem;

namespace DentalAppointmentandInformationSystem
{
    public partial class Login : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        private PrivateFontCollection fonts2 = new PrivateFontCollection();
        public Login()
        {
            InitializeComponent();
            initializeFont();
            initializeFont2();
        }
        private void initializeFont()
        {
            byte[] fontData = Properties.Resources.Inter_VariableFont_slnt_wght;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Inter_VariableFont_slnt_wght.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Inter_VariableFont_slnt_wght.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
        }
        private void initializeFont2()
        {
            byte[] fontData = Properties.Resources.Metrophobic_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts2.AddMemoryFont(fontPtr, Properties.Resources.Metrophobic_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Metrophobic_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            clinicName.Font = new Font(fonts2.Families[0], clinicName.Font.Size);
            mottoLabel.Font = new Font(fonts2.Families[0], mottoLabel.Font.Size);
            loginLabel.Font = new Font(fonts.Families[0], loginLabel.Font.Size, FontStyle.Bold);
            eNumTxtBox.Font = new Font(fonts.Families[0], eNumTxtBox.Font.Size);
            passTxtbox.Font = new Font(fonts.Families[0], passTxtbox.Font.Size);
            forgotPassLbl.Font = new Font(fonts.Families[0], forgotPassLbl.Font.Size, FontStyle.Italic);
            loginBtn.Font = new Font(fonts.Families[0], loginBtn.Font.Size, FontStyle.Bold);
        }

        private void eNumTxtBox_Enter(object sender, System.EventArgs e)
        {
            if (eNumTxtBox.Text.Equals("Employee Number"))
            {
                eNumTxtBox.Text = "";
                eNumTxtBox.ForeColor = Color.Black;
            }
        }
        private void eNumTxtBox_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(eNumTxtBox.Text))
            {
                eNumTxtBox.Text = "Employee Number";
                eNumTxtBox.ForeColor = Color.FromArgb(217, 217, 217);
            }
        }

        private void passTxtbox_Enter(object sender, System.EventArgs e)
        {
            if (passTxtbox.Text.Equals("Password"))
            {
                passTxtbox.Text = "";
                passTxtbox.ForeColor = Color.Black;
                passTxtbox.PasswordChar = '•';
            }
        }

        private void passTxtbox_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(passTxtbox.Text))
            {
                passTxtbox.Text = "Password";
                passTxtbox.ForeColor = Color.FromArgb(217, 217, 217);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DAISdB.mdf;Integrated Security=True";
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Staff WHERE employee_num ='" + eNumTxtBox.Text + "' AND employee_pass ='" + passTxtbox.Text + "'", constring);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Variables v = new Variables();
                v.getsetloggedIn = eNumTxtBox.Text;
                Dashboard dshbrd = new Dashboard();
                dshbrd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
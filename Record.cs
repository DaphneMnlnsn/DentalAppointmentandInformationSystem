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
    public partial class Record : UserControl
    {
        Variables v = new Variables();
        SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daph\source\repos\DentalAppointmentandInformationSystem\DAISdB.mdf;Integrated Security=True");

        public Record()
        {
            InitializeComponent();
        }

        public void setPatientInfo(string recordDate, string recordsTreat, string recordsTooth, string recordsPrice)
        { 
            records_date.Text = recordDate;
            records_treat.Text = recordsTreat;
            records_tooth.Text = recordsTooth;
            records_price.Text = recordsPrice;
        }
    }
}
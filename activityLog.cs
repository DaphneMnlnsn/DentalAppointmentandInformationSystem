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
    public partial class activityLog : UserControl
    {
        public activityLog()
        {
            InitializeComponent();
        }
        public void setActivity(string activity)
        {
            actText.Text = activity;
        }

        private void activityLog_Load(object sender, EventArgs e)
        {

        }
    }
}
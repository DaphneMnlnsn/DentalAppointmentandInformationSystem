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
    public partial class dashboardNotifItem : UserControl
    {
        public dashboardNotifItem()
        {
            InitializeComponent();
        }

        private void notifText_Click(object sender, EventArgs e)
        {

        }

        private void dashboardNotifItem_Load(object sender, EventArgs e)
        {

        }
        public void setNotifs(string notif)
        {
            notifText.Text = notif;
        }
    }
}
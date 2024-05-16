using DentalAppointmentandInformationSystem;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DentalAppointmentandInformationSystem
{
    public partial class ServicesList : UserControl
    {

        public ServicesList()
        {
            InitializeComponent();
        }

        private void ServicesList_Load(object sender, EventArgs e)
        {
        }

        public void setServiceInfo(string service_id, string service_name, string service_price)
        {
            serviceID.Text = service_id;
            serviceName.Text = service_name;
            servicePrice.Text = service_price;
        }

    }
}
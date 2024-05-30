using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalAppointmentandInformationSystem
{
    internal class Variables
    {
        private static string loggedIn;
        private static string patientSelected;
        private static int month, year;
        private static string day;
        private static string appointmentSelected;
        private static string staffSelected;
        private static string serviceSelected;
        private static string recordSelected;
        private static SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daph\source\repos\DentalAppointmentandInformationSystem\DAISdB.mdf;Integrated Security=True");


        public string getsetloggedIn
        {
            get { return loggedIn; }
            set { loggedIn = value; }
        }

        public int getsetMonth
        {
            get { return month; }
            set { month = value; }
        }

        public int getsetYear
        {
            get { return year; }
            set { year = value; }
        }

        public string getsetDay
        {
            get { return day; }
            set { day = value; }
        }

        public string getsetpatientSelected
        {
            get { return patientSelected; }
            set { patientSelected = value; }
        }

        public string getsetappointmentSelected
        {
            get { return appointmentSelected; }
            set { appointmentSelected = value; }
        }

        public string getsetstaffSelected
        {
            get { return staffSelected; }
            set { staffSelected = value; }
        }

        public string getsetserviceSelected
        {
            get { return serviceSelected; }
            set { serviceSelected = value; }
        }

        public string getsetrecordSelected
        {
            get { return recordSelected; }
            set { recordSelected = value; }
        }

        public SqlConnection getConnection
        {
            get { return constring; }
        }
    }
}
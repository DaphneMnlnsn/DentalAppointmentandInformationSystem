using System;
using System.Collections.Generic;
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
    }
}
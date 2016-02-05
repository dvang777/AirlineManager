using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class Flight
    {
        public string AssignedAircraft { get; set; }
        public string FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Time { get; set; }
        public string Distance { get; set; }
        public DateTime departure { get; set; }
        public DateTime arrival { get; set; }

        //public void addPassengerInfo()
        //{
            
        //}
    }
}

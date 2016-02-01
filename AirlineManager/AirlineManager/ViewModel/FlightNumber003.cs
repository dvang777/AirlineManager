using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FlightNumber003 : Flight
    {
        public FlightNumber003()
        {
            assignedAircraft = "MD90";
            flightNumber = 003;
            origin = "Milwaukee, Wisconsin";
            destination = "San Francisco, California";
            time = 221;
            miles = 1843;
        }
    }
}

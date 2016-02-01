using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FlightNumber009 : Flight
    {
        public FlightNumber009()
        {
            assignedAircraft = "MD90";
            flightNumber = 009;
            origin = "Phoenix, Arizona";
            destination = "Milwaukee, Wisconsin";
            time = 196;
            miles = 1460;
        }
    }
}

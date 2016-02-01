using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FlightNumber006 : Flight
    {
        public FlightNumber006()
        {
            assignedAircraft = "MD90";
            flightNumber = 006;
            origin = "San Francisco, California";
            destination = "Phoenix, Arizona";
            time = 104;
            miles = 651;
        }
    }
}

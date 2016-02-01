using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FlightNumber010 : Flight
    {
        public FlightNumber010()
        {
            assignedAircraft =  "A320";
            flightNumber = 010;
            origin = "Orlando, Florida";
            destination = "Milwaukee, Wisconsin";
            time = 151;
            miles = 1069;
        }
    }
}

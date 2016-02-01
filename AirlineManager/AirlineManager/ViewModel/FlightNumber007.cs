using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FlightNumber007 : Flight
    {
        public FlightNumber007()
        {
            assignedAircraft = "A320";
            flightNumber = 007;
            origin = "Washington D.C.";
            destination = "Orlando, Florida";
            time = 116;
            miles = 761;
        }
    }
}

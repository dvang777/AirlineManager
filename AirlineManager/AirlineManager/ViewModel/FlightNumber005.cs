using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FlightNumber005 : Flight
    {
        public FlightNumber005()
        {
            assignedAircraft = "Boeing 747";
            flightNumber = 005;
            origin = "Atlanta, Georgia";
            destination = "Dallas, Texas";
            time = 108;
            miles = 721;
        }
    }
}

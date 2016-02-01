using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FlightNumber008 : Flight
    {
        public FlightNumber008()
        {
            assignedAircraft = "Boeing 747";
            flightNumber = 008;
            origin = "Dallas, Texas";
            destination = "Denver, Colorado";
            time = 79;
            miles = 662;
        }
    }
}

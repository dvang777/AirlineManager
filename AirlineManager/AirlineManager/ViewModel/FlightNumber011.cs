using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FlightNumber011 : Flight
    {
        public FlightNumber011()
        {
            assignedAircraft = "Boeing 747";
            flightNumber = 011;
            origin = "Denver, Colorado";
            destination = "Milwaukee, Wisconsin";
            time = 132;
            miles = 777;
        }
    }
}

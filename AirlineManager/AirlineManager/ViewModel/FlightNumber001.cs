using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FlightNumber001 : Flight
    {
        public FlightNumber001()
        {
            assignedAircraft = "A320";
            flightNumber = 001;
            origin = "Milwaukee, Wisconsin";
            destination = "Newark, New Jersey";
            time = 87;
            miles = 725;
        }
    }
}

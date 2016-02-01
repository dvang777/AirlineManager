using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FlightNumber004 : Flight
    {
        public FlightNumber004()
        {
            assignedAircraft = "A320";
            flightNumber = 004;
            origin = "Newark, New Jersey";
            destination = "Washington D.C.";
            time = 36;
            miles = 167;
        }
    }
}

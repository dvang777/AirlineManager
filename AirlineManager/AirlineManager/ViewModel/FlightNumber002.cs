using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FlightNumber002 : Flight
    {
        public FlightNumber002()
        {
            assignedAircraft = "747";
            flightNumber = 002;
            origin = "Milwaukee, Wisconsin";
            destination = "Atlanta, Georgia";
            time = 106;
            miles = 671;
        }
    }
}

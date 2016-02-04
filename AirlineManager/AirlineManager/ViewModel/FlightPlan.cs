using AirlineManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FlightPlan
    {

        public List<Flight> FlightList { get; set; }

        public FlightPlan()
        {
            FlightList = new List<Flight>
            {
            {new Flight {FlightNumber = "001", AssignedAircraft = "MD90", Origin = "Milwaukee, Wisconsin", Destination = "Newark, New Jersey", Time = "87 mins", Distance = "725 miles", departure = DateTime.Now.AddHours(2.5), arrival = DateTime.Now.AddHours(4)}},
            {new Flight {FlightNumber = "002", AssignedAircraft = "Boeing 747", Origin = "Milwaukee, Wisconsin", Destination = "Atlanta, Georgia", Time = "106 mins", Distance = "671 miles", departure = DateTime.Now.AddHours(2), arrival = DateTime.Now.AddHours(4)}},
            {new Flight {FlightNumber = "003", AssignedAircraft = "A320", Origin = "Milwaukee, Wisconsin", Destination = "San Francisco, California", Time = "221 mins", Distance = "1843 miles", departure = DateTime.Now.AddHours(1.5), arrival = DateTime.Now.AddHours(6)}},
            {new Flight {FlightNumber = "004", AssignedAircraft = "MD90", Origin = "Newark, New Jersey", Destination = "Washington D.C.", Time = "36 mins", Distance = "167 miles", departure = DateTime.Now.AddHours(5.5), arrival = DateTime.Now.AddHours(6.25)}},
            {new Flight {FlightNumber = "005", AssignedAircraft = "Boeing 747", Origin = "Atlanta, Georgia", Destination = "Dallas, Texas", Time = "108 mins", Distance = "721 miles", departure = DateTime.Now.AddHours(6), arrival = DateTime.Now.AddHours(7.75)}},
            {new Flight {FlightNumber = "006", AssignedAircraft = "A320", Origin = "San Francisco, California", Destination = "Phoenix, Arizona", Time = "104 mins", Distance = "651 miles", departure = DateTime.Now.AddHours(7.5), arrival = DateTime.Now.AddHours(9.5)}},
            {new Flight {FlightNumber = "007", AssignedAircraft = "MD90", Origin = "Washington D.C.", Destination = "Orlando, Florida", Time = "116 mins", Distance = "761 miles", departure = DateTime.Now.AddHours(8), arrival = DateTime.Now.AddHours(10)}},
            {new Flight {FlightNumber = "008", AssignedAircraft = "Boeing 747", Origin = "Dallas, Texas", Destination = "Denver, Colorado", Time = "79 mins", Distance = "662 miles", departure = DateTime.Now.AddHours(9), arrival = DateTime.Now.AddHours(10.5)}},
            {new Flight {FlightNumber = "009", AssignedAircraft = "A320", Origin = "Phoenix, Arizona", Destination = "Milwaukee, Wisconsin", Time = "196 mins", Distance = "1460 miles", departure = DateTime.Now.AddHours(11), arrival = DateTime.Now.AddHours(14.5) }},
            {new Flight {FlightNumber = "010", AssignedAircraft = "MD90", Origin = "Orlando, Florida", Destination = "Milwaukee, Wisconsin", Time = "151 mins", Distance = "1069 miles", departure = DateTime.Now.AddHours(11.5), arrival = DateTime.Now.AddHours(13)}},
            {new Flight {FlightNumber = "011", AssignedAircraft = "Boeing 747", Origin = "Denver, Colorado", Destination = "Milwaukee, Wisconsin", Time = "132 mins", Distance = "777 miles", departure = DateTime.Now.AddHours(12), arrival = DateTime.Now.AddHours(14.2)}}
            };
        }
    }
}
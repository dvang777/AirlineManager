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

        List<Flight> flight { get; set; }

        public FlightPlan()
        {
            flight = new List<Flight>
            {
            {new Flight {FlightNumber = 001, AssignedAircraft = "MD90", Origin = "Milwaukee, Wisconsin", Destination = "Newark, New Jersey", Time = 87, Distance = 725, departure = DateTime.Now.AddHours(2.5), arrival = DateTime.Now.AddHours(5)}},
            {new Flight {FlightNumber = 002, AssignedAircraft = "Boeing 747", Origin = "Milwaukee, Wisconsin", Destination = "Atlanta, Georgia", Time = 106, Distance = 671, departure = DateTime.Now.AddHours(2), arrival = DateTime.Now.AddHours(5)}},
            {new Flight {FlightNumber = 003, AssignedAircraft = "A320", Origin = "Milwaukee, Wisconsin", Destination = "San Francisco, California", Time = 221, Distance = 1843, departure = DateTime.Now.AddHours(1.5), arrival = DateTime.Now.AddHours(6)}},
            {new Flight {FlightNumber = 004, AssignedAircraft = "MD90", Origin = "Newark, New Jersey", Destination = "Washington D.C.", Time = 36, Distance = 167, departure = DateTime.Now.AddHours(6.5), arrival = DateTime.Now.AddHours(7.5)}},
            {new Flight {FlightNumber = 005, AssignedAircraft = "Boeing 747", Origin = "Atlanta, Georgia", Destination = "Dallas, Texas", Time = 108, Distance = 721, departure = DateTime.Now.AddHours(7), arrival = DateTime.Now.AddHours(9.5)}},
            {new Flight {FlightNumber = 006, AssignedAircraft = "A320", Origin = "San Francisco, California", Destination = "Phoenix, Arizona", Time = 104, Distance = 651, departure = DateTime.Now.AddHours(7.5), arrival = DateTime.Now.AddHours(10)}},
            {new Flight {FlightNumber = 007, AssignedAircraft = "MD90", Origin = "Washington D.C.", Destination = "Orlando, Florida", Time = 116, Distance = 761, departure = DateTime.Now.AddHours(8.5), arrival = DateTime.Now.AddHours(11)}},
            {new Flight {FlightNumber = 008, AssignedAircraft = "Boeing 747", Origin = "Dallas, Texas", Destination = "Denver, Colorado", Time = 79, Distance = 662, departure = DateTime.Now.AddHours(10.5), arrival = DateTime.Now.AddHours(12.5)}},
            {new Flight {FlightNumber = 009, AssignedAircraft = "A320", Origin = "Phoenix, Arizona", Destination = "Milwaukee, Wisconsin", Time = 196, Distance = 1460, departure = DateTime.Now.AddHours(11), arrival = DateTime.Now.AddHours(15.5) }},
            {new Flight {FlightNumber = 010, AssignedAircraft = "MD90", Origin = "Orlando, Florida", Destination = "Milwaukee, Wisconsin", Time = 151, Distance = 1069, departure = DateTime.Now.AddHours(12), arrival = DateTime.Now.AddHours(16)}},
            {new Flight {FlightNumber = 011, AssignedAircraft = "Boeing 747", Origin = "Denver, Colorado", Destination = "Milwaukee, Wisconsin", Time = 132, Distance = 777, departure = DateTime.Now.AddHours(13.5), arrival = DateTime.Now.AddHours(16.5)}}
            };

        }
    }
}
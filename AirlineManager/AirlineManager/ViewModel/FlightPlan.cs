﻿using AirlineManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class FlightPlan
    {
        Dictionary<int, Flight> flightNumber = new Dictionary<int, Flight>()
        {
            {001, new Flight {FlightNumber = 001, AssignedAircraft = "MD90", Origin = "Milwaukee, Wisconsin", Destination = "Newark, New Jersey", Time = 87, Distance = 725  }},
            {002, new Flight {FlightNumber = 002, AssignedAircraft = "Boeing 747", Origin = "Milwaukee, Wisconsin", Destination = "Atlanta, Georgia", Time = 106, Distance = 671 }},
            {003, new Flight {FlightNumber = 003, AssignedAircraft = "A320", Origin = "Milwaukee, Wisconsin", Destination = "San Francisco, California", Time = 221, Distance = 1843 }},
            {004, new Flight {FlightNumber = 004, AssignedAircraft = "MD90", Origin = "Newark, New Jersey", Destination = "Washington D.C.", Time = 36, Distance = 167 }},
            {005, new Flight {FlightNumber = 005, AssignedAircraft = "Boeing 747", Origin = "Atlanta, Georgia", Destination = "Dallas, Texas", Time = 108, Distance = 721 }},
            {006, new Flight {FlightNumber = 006, AssignedAircraft = "A320", Origin = "San Francisco, California", Destination = "Phoenix, Arizona", Time = 104, Distance = 651 }},
            {007, new Flight {FlightNumber = 007, AssignedAircraft = "MD90", Origin = "Washington D.C.", Destination = "Orlando, Florida", Time = 116, Distance = 761 }},
            {008, new Flight {FlightNumber = 008, AssignedAircraft = "Boeing 747", Origin = "Dallas, Texas", Destination = "Denver, Colorado", Time = 79, Distance = 662 }},
            {009, new Flight {FlightNumber = 009, AssignedAircraft = "A320", Origin = "Phoenix, Arizona", Destination = "Milwaukee, Wisconsin", Time = 196, Distance = 1460 }},
            {010, new Flight {FlightNumber = 010, AssignedAircraft = "MD90", Origin = "Orlando, Florida", Destination = "Milwaukee, Wisconsin", Time = 151, Distance = 1069 }},
            {011, new Flight {FlightNumber = 011, AssignedAircraft = "Boeing 747", Origin = "Denver, Colorado", Destination = "Milwaukee, Wisconsin", Time = 132, Distance = 777 }}
        };            
    }
}
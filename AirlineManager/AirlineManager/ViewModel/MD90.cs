﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class MD90 : Aircraft
    {
        public MD90(string flightNo, int fClass, int econ, string orig, string dest, string minutes, string dist, DateTime depart, DateTime arrive)
        {
            aircraft = "McDonald Douglas MD90";
            flightNumber = "F001";
            capacity = 30;
            firstClass = 10;
            economy = 20;
            origin = "Milwaukee, WI";
            destination = "Atlanta, GA";
            mins = "106 mins";
            distance = "671 miles";
            departure = DateTime.Now.AddHours(2);
            arrival = DateTime.Now.AddHours(3.43);
            airplaneStatus = "On Time.";
        }
        public override string ToString()
        {
            return "Flight Number: " + flightNumber + Environment.NewLine + "Aircraft: " + aircraft + Environment.NewLine + "First Class Capacity: " + firstClass + Environment.NewLine + "Economy Class Capacity: " + economy + Environment.NewLine + "Origin: " + origin + Environment.NewLine + "Destination: " + destination + Environment.NewLine + "Distance(miles): " + distance + Environment.NewLine + "Time(minutes): " + mins + Environment.NewLine + "Departure Time: " + departure + Environment.NewLine + "Expected Time of Arrival: " + arrival + Environment.NewLine + "Airplane Status: " + airplaneStatus;
        }
    }
}

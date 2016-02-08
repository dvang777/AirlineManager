using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class A320 : Aircraft
    {
        public A320(string flightNo, int fClass, int econ, string orig, string dest, string minutes, string dist, DateTime depart, DateTime arrive)
        {
            aircraft = "Airbus A320";
            flightNumber = "F002";
            capacity = 70;
            firstClass = 20;
            economy = 50;
            origin = "Milwaukee, WI";
            destination = "Newark, NJ";
            mins = "87 mins";
            distance = "725 miles";
            departure = DateTime.Now.AddHours(2.5);
            arrival = DateTime.Now.AddHours(3.95);
            airplaneStatus = "On Time.";
        }
        public override string ToString()
        {
            return "Flight Number: " + flightNumber + Environment.NewLine + "Aircraft: " + aircraft + Environment.NewLine + "First Class Capacity: " + firstClass + Environment.NewLine + "Economy Class Capacity: " + economy + Environment.NewLine + "Origin: " + origin + Environment.NewLine + "Destination: " + destination + Environment.NewLine + "Distance(miles): " + distance + Environment.NewLine + "Time(minutes): " + mins + Environment.NewLine + "Departure Time: " + departure + Environment.NewLine + "Expected Time of Arrival: " + arrival + Environment.NewLine + "Airplane Status: " + airplaneStatus;
        }
    }
}


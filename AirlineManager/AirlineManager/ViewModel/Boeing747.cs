using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class Boeing747 : Aircraft
    {


        public Boeing747(string flightNo, int fClass, int econ, string orig, string dest, string minutes, string dist, DateTime depart, DateTime arrive)
        {
            aircraft = "Boeing 747";
            flightNumber = "F003";
            capacity = 100;
            firstClass = 20;
            economy = 80;
            origin = "Milwaukee, WI";
            destination = "Atlanta, GA";
            mins = "106 mins";
            distance = "671 miles";
            departure = DateTime.Now.AddHours(4);
            arrival = DateTime.Now.AddHours(6);
            airplaneStatus = "On Time.";
        }
        public override string ToString()
        {
            return "Flight Number: " + flightNumber + Environment.NewLine + "Aircraft: " + aircraft + Environment.NewLine + "First Class Capacity: " + firstClass + Environment.NewLine + "Economy Class Capacity: " + economy + Environment.NewLine + "Origin: " + origin + Environment.NewLine + "Destination: " + departure + Environment.NewLine + "Distance(miles): " + distance + Environment.NewLine + "Time(minutes): " + mins + Environment.NewLine + "Departure Time: " + departure + Environment.NewLine + "Expected Time of Arrival: " + arrival + Environment.NewLine + "Airplane Status: " + airplaneStatus;
        }
    }
}

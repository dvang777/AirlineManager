﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class Flight
    {
        public string AssignedAircraft { get; set; }
        public int FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string[] passenger;
        public int Time { get; set; }
        public int Distance { get; set; }

        //public void addPassengerInfo()
        //{
            
        //}
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class SeatChart
    {
        public List<Seat> SeatConfig { get; set; }
        public string[] SeatLetter;
        public string[] SeatNumber;

        public SeatChart()
        {
            SeatLetter = new string[3] { "A", "B", "C" };
            SeatNumber = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            foreach (string seatLetter in SeatLetter)
            {
                foreach (string seatNo in SeatNumber)
                {
                    Seat newSeat = new Seat(seatNo, seatLetter);
                    SeatConfig.Add(newSeat);

                }
            }

        }
    }
}

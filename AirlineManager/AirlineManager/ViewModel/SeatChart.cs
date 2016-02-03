using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class SeatChart
    {
        public string [,] SeatConfig;
        public string[] SeatLetter;
        public string[] SeatNumber;
        public int[] SeatPrice;

        public void SeatMap()
        {
            SeatLetter = new string[3] { "A", "B", "C" };
            SeatNumber = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            SeatPrice = new int[2] { 100, 300 };

            foreach(string seatLetter in SeatLetter)
            {
                foreach(string seatNo in SeatNumber)
                {

                }
            }
        }
    }
}

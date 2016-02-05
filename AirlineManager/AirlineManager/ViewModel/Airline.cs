using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class Airline
    {
        SeatChart seatRes = new SeatChart();
        Passenger passenger = new Passenger();
        A320 a320 = new A320();
        public int seatAvailable;

        public void removeSeat()
        {
            seatAvailable = seatRes.SeatConfig.Count - passenger.addPassenger.Count;
            
        }
    }
}

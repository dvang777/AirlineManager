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
        public double seatAvailable;
        public double firstClass;
        public double econClass;
        public double firstClassPrice;
        public double econPrice;

        public void seatsLeft()
        {
            seatAvailable = seatRes.SeatConfig.Count - passenger.addPassenger.Count;
            
        }
        public void sellSeat()
        {
            firstClass = seatAvailable * .3;
            econClass = seatAvailable * .7;
        }
    }
}

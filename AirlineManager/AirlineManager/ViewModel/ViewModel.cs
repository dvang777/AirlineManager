using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class Viewmodel
    {
        FileWrite write = new FileWrite();
        FileRead read = new FileRead();

        public string A320()
        {
            A320 a320 = new A320("", 0, 0, "", "", "", "", DateTime.Now, DateTime.Now);
            return a320.ToString();
        }
        public string MD90()
        {
            MD90 md90 = new MD90("", 0, 0, "", "", "", "", DateTime.Now, DateTime.Now);
            return md90.ToString();
        }
        public string Boeing747()
        {
            Boeing747 boeing747 = new Boeing747("", 0, 0, "", "", "", "", DateTime.Now, DateTime.Now);
            return boeing747.ToString();
        }
        public string A320ticketSales()
        {
            int firstClassPrice;
            int econPrice;
            int totalFirstClass;
            int totalEcon;
            int totalSold;
            int seatsAvail;

            A320 a = new A320("", 0, 0, "", "", "", "", DateTime.Now, DateTime.Now);
            Passenger aPassenger = new Passenger();
            int i = 0;

            while (i < a.capacity)
            {
                write.writeFlightA320(aPassenger.passengerInfo().ToString());
                read.readFlightA320();
                i++;
            }
            firstClassPrice = 500;
            totalFirstClass = firstClassPrice * a.firstClass;
            econPrice = 250;
            totalEcon = econPrice * a.economy;
            totalSold = totalFirstClass + totalEcon;
            seatsAvail = (a.firstClass + a.economy) - a.capacity;
            return ("First Class Price $" + firstClassPrice + Environment.NewLine + "Economy Class Price $" + econPrice + Environment.NewLine + "Total tickets Sold " + a.capacity + Environment.NewLine + "Total Revenue $" + totalSold + Environment.NewLine + "Seats Available: " + seatsAvail);
        }
        public string BoeingTicketSales()
        {
            Boeing747 b = new Boeing747("", 0, 0, "", "", "", "", DateTime.Now, DateTime.Now);
            Passenger bPassenger = new Passenger();
            int firstClassPrice;
            int firstClassTotal;
            int econPrice;
            int econTotal;
            int totalSold;
            int i = 0;
            int seatsAvail;

            while (i < b.capacity)
            {
                write.writeFlightBoeing(bPassenger.passengerInfo().ToString());
                read.readFlightBoeing();
                i++;
            }
            firstClassPrice = 600;
            firstClassTotal = firstClassPrice * b.firstClass;
            econPrice = 300;
            econTotal = econPrice * b.economy;
            totalSold = firstClassTotal + econTotal;
            seatsAvail = (b.firstClass + b.economy) - b.capacity;
            return ("First Class Price $" + firstClassPrice + Environment.NewLine + "Economy Class Price $" + econPrice + Environment.NewLine + "Total Tickets Sold " + b.capacity + Environment.NewLine + "Total Revenue $" + totalSold + Environment.NewLine + "Seats Available: " + seatsAvail);
        }
        public string MD90TicketSales()
        {
            MD90 m = new MD90("", 0, 0, "", "", "", "", DateTime.Now, DateTime.Now);
            Passenger mPassenger = new Passenger();
            int firstClassPrice;
            int firstClassTotal;
            int econPrice;
            int econTotal;
            int totalSold;
            int i = 0;
            int seatsAvail;

            while (i < m.capacity)
            {
                write.writeFlightMD90(mPassenger.passengerInfo().ToString());
                read.readFlightMD90();
                i++;
            }
            firstClassPrice = 400;
            firstClassTotal = firstClassPrice * m.firstClass;
            econPrice = 200;
            econTotal = econPrice * m.economy;
            totalSold = firstClassTotal + econTotal;
            seatsAvail = (m.firstClass + m.economy) - m.capacity;
            return ("First Class Price $" + firstClassPrice + Environment.NewLine + "Economy Class Price $" + econPrice + Environment.NewLine + "Total Tickets Sold " + m.capacity + Environment.NewLine + "Total Revenue $" + totalSold + Environment.NewLine + "Seats Available: " + seatsAvail);
        }
    }
}

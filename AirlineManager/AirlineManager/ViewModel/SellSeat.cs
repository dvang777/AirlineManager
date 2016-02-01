using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class SellSeat
    {
        int firstClassPrice;
        int businessPrice;
        int coachPrice;
        string passangerInfo;

        public bool[] seats;
        public int totalAssignedFirstClass;
        public int totalAssingedEconomyClass;

        public void Seats()
        {
            seats = new bool[10]; //number of seats is 10
            string selectedClass = ""; //input of which class to select first or economy

            for (int i = 0; i < 10; i++)
            {
                seats[i] = false;
            }
            for (int i = 1; i <= 10; i++)
            {
                // Have user select first class or economy;
            }
            if(selectedClass == "First Class")//1 is userinput 1 is first class, 2 is economy
            {
                if (totalAssignedFirstClass == 5 && totalAssingedEconomyClass < 5)//total seats 10, 5 first, 5 econ
                {

                }
                    //"First Class is full, do you want to fly economy?" can do the same reverse for economy

            }
            else if(totalAssignedFirstClass < 5)
            {
                assignFirstClass();
            }
        }
        public void assignFirstClass()
        {
            bool noDouble = false;
            Random rand = new Random();
            int index = 0;
            while (noDouble)
            {
                noDouble = true; //if seats avaialble
                index = rand.Next(1, 5); // it'll randomize a seat between 1-5 or whatever range we want
                if(seats[index] == true)
                {
                    noDouble = false;
                    // seats won't be duplicate, will run loop until finds non assigned seat.
                }
            }
            seats[index] = true;
            totalAssignedFirstClass++;

        }
    }
}

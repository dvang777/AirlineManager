using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.ViewModel
{
    public class Passenger
    {
        public string[] firstName = new string[15] { "Matt", "John", "David", "Dan", "Aimee", "Jessica", "Cathy", "Mary", "Tony", "Chang", "Michael", "Wendy", "Aaron", "Emmit", "Terrance" };
        public string [] lastName = new string[15] { "Jackson", "Marion", "Johnson", "Rodgers", "Lee", "Gretzky", "Jordan", "Smith", "Johnson", "Franklin", "Williams", "Vang", "Nguyen", "Mayer", "Lopez" };
        public string[] email = new string[4] { " @yahoo.com", " @gmail.com", " @hotmail.com", " @aol.com" };
        public string [] birthMonth = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public int birthDay;
        public int birthYear;
        public List<NewPassenger> addPassenger;

        public void Person()
        {
            
            Random rand = new Random();
            string Fname;
            string last;
            string eMail;
            string month;
            int date;
            int year;

            foreach (string name in firstName)
            {
                Fname = firstName[rand.Next(15)];
                last = lastName[rand.Next(15)];
                eMail = email[rand.Next(4)];
                month = birthMonth[rand.Next(12)];
                date = rand.Next(1, 30);
                year = rand.Next(1970, 2010);
                NewPassenger newPassenger = new NewPassenger(Fname, last, eMail, month, date, year);
                addPassenger.Add(newPassenger);
            }
        }
    }
}

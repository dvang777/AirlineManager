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
        public int? age;
        public string[] email = new string[4] { " @yahoo.com", " @gmail.com", " @hotmail.com", " @aol.com" };
        public string country;
        public string phoneNumber;
        public string [] birthMonth = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public int birthDay;
        public int birthYear;
        public string[] passengers;

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
                Console.WriteLine("{0} {1}" + " email: {0}{1}{2}" + " birthday {3} {4}, {5}", Fname, last, eMail, month, date, year);
            }
        }
        public void addPerson(string FirstName, string LastName, string EMail, string Month, string Day, string Year)
        {
            Passenger passenger = new Passenger();
            
            

        }
    }
}

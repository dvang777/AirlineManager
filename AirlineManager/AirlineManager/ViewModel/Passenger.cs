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
        public string[] lastName = new string[15] { "Jackson", "Marion", "Johnson", "Rodgers", "Lee", "Gretzky", "Jordan", "Smith", "Johnson", "Franklin", "Williams", "Vang", "Nguyen", "Mayer", "Lopez" };
        public string[] email = new string[4] { " @yahoo.com", " @gmail.com", " @hotmail.com", " @aol.com" };
        public string[] birthMonth = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public int birthDay;
        public int birthYear;
        Random rand = new Random();
        public string Fname;
        public string last;
        public string eMail;
        public string month;
        public int date;
        public int year;
        public Passenger()
        {
            
        }

        public string passengerName()
        {
            string fullName;
            Fname = firstName[rand.Next(15)];
            last = lastName[rand.Next(15)];
            fullName = Fname + " " + last;
            return fullName;
        }
        public string passengerEmail()
        {
            string fullEmail;
            eMail = email[rand.Next(4)];
            fullEmail = Fname + last + eMail;
            return fullEmail;
        }
        public string birthday()
        {
            string birthDay;
            month = birthMonth[rand.Next(12)];
            date = rand.Next(1, 30);
            year = rand.Next(1970, 2010);
            birthDay = month + " " + date.ToString() + ", " + year.ToString();
            return birthDay.ToString();
        }
        public string passengerInfo()
        {
            string name;
            string bday;
            string email;

            name = passengerName();
            bday = birthday();
            email = passengerEmail();
            return name + " " + bday + " " + email;
        }
    }
}


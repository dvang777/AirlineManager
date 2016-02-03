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


    }
}

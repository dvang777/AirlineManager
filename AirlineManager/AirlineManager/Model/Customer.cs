using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager.Model
{
    public class Customer
    {
        public static Customer createCustomer (string firstName, string lastName, string birthday, string email)
        {
            return new Customer { FirstName = firstName, LastName = lastName, Birthday = birthday, Email = email };
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
    }
}

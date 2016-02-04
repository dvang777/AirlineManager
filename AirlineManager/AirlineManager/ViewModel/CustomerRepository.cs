using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineManager.Model;

namespace AirlineManager.ViewModel
{
    public class CustomerRepository
    {
        readonly List<Customer> _customers;

        public CustomerRepository()
        {
            if (_customers == null)
            {
                _customers = new List<Customer>();
            }
            _customers.Add(Customer.createCustomer("Dan", "Vang", "Oct. 16", "dvang@hotmail.com"));
            _customers.Add(Customer.createCustomer("Fred", "Flinstone", "Dec 12 602", "fred@bedrock.com"));
        }
    }
}

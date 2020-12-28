using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    public static class NewMethods
    {
        public static IEnumerable<string> GetData(this CustomerRepository customerRepo, List<Customer> customersList)
        {
            var customerRepository = from customer in customersList
                                   select customer.Name + "    " + customer.MobileNumber +"     " +customer.Address; 
            return customerRepository;
        }
        public static void Show(this CustomerRepository customerRepository, IEnumerable<String> customersData)
        {
            foreach (var customer in customersData)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
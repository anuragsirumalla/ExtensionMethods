using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    public class CustomerRepository
    {
        public List<Customer> customersList;
        public CustomerRepository()
        {
            customersList = new List<Customer>();
        }
        public void SetCustomerOrderDetails()
        {
            Console.WriteLine("Hey! Please Enter Customer Details");
            Console.Write("Enter customer's Name : ");
            String name = Console.ReadLine();
            Console.Write("Enter customer's PhoneNumber : ");
            long MobileNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter customer's Address : ");
            String Address = Console.ReadLine();
            customersList.Add(new Customer(name, MobileNumber, Address));
        }
        public void Operations()
        {
            Console.WriteLine("1. Add customers   2.Get Customers Data   3.Exit");
            Console.Write("please, Enter your choice  :  ");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("To Add Customers, please Enter Details");
                    SetCustomerOrderDetails();
                    break;
                case 2:
                    CustomerRepository repo = new CustomerRepository();
                    IEnumerable<String> customersData = repo.GetData(customersList);
                    if (customersList.Count > 0)
                    {
                        Console.WriteLine("              CUSTOMERS DATA   ");
                        repo.Show(customersData);
                    }

                    else
                        Console.WriteLine("No customers, till now !");
                    break;
                case 3:
                    Console.WriteLine("Application Stopped !");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("please, Enter a valid choice ");
                    break;
            }
        }
    }
}
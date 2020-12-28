using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerRepository repo = new CustomerRepository();
            while(true)
            {
                repo.Operations();
            }
            
        }
    }
}

namespace ExtensionMethods
{
    public class Customer
    {
        public Customer()
        {

        }
        public string Name
        {
            set;
            get;
        }
        public long MobileNumber
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public Customer(string Name, long MobileNumber, string Address)
        {
            this.Name = Name;
            this.MobileNumber = MobileNumber;
            this.Address = Address;
        }

    }

}
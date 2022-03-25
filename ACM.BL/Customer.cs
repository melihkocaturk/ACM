using ACM.Common;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {

        }

        public Customer(int id)
        {
            Id = id;
            AddressList = new List<Address>();
        }

        public int Id { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public List<Address> AddressList { get; set; }
        public static int InstanceCount { get; set; }

        public override string ToString()
        {
            return FullName;
        }

        /* -- Moved to Customer Repository
        public bool Save()
        {
            return true;
        }

        public Customer Retrieve(int id)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        */

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

            return isValid;
        }

        public string Log() => $"{Id} | {FullName} Email : {EmailAddress}";
    }
}
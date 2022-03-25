using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            _addressRepository = new AddressRepository();
        }
        private AddressRepository _addressRepository { get; set; }
        public Customer Retrieve(int id)
        {
            Customer customer = new Customer(id);

            if (id == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = _addressRepository.RetriveByCustomerId(id).ToList();
            }

            Console.WriteLine(customer.ToString());

            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}

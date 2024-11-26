using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTransactionManagement
{
    internal class Customer
    {
        private string name;
        private string id;
        private string address;
        private string phoneNumber;

        public Customer(string name, string id, string address, string phoneNumber) 
        {
            this.name = name;
            this.id = id;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public string Name { get { return name; } }
        public string Id { get { return id; } } 
        public string Address { get { return address; } }
        public string PhoneNumber { get { return phoneNumber; } }
    }
}

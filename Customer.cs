using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_Console_App
{
    public class Customer : ICloneable
    {
        private String name;
        private String address;
        private String phoneNumber;
        private String email;
        private int customerID;
        private static int nextCustomerID = 1;
        public Customer(String name, String address, String phoneNumber, String email = "")
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.customerID = nextCustomerID;
            nextCustomerID++;
        }

        private Customer(Customer customer)
        {
            this.name = customer.name;
            this.address = customer.address;
            this.phoneNumber = customer.phoneNumber;
            this.email = customer.email;
            this.customerID = nextCustomerID;
        }

        public string GetName
        {
            get { return name; }
        }

        public string GetAddress
        {
            get { return address; }
        }

        public string GetPhoneNumber
        {
            get { return phoneNumber; }
        }

        public string GetEmail
        {
            get { return email; }
        }

        public int GetCustomerID
        {
            get { return customerID; }
        }

        public object Clone()
        {
            return new Customer(this);
        }
    }
}

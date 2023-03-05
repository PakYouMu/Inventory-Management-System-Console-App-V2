using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_Console_App
{
    public class Customer
    {
        private String name;
        private String address;
        private String phoneNumber;
        private String email;
        public Customer(String name, String address, String phoneNumber, String email = "")
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
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
    }
}

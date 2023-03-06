using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_Console_App
{
    public class User : ICloneable
    {
        private string username;
        private string password;
        private string email;
        private string phoneNumber;
        private string address;

        public enum Role
        {
            Admin,
            Employee,
            Customer
        }

        private Role role;
        private int userID;
        private static int nextUserID = 0;

        public User(string username, string password, string email, string phoneNumber, string address, Role role)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.role = role;
            this.userID = nextUserID++;
        }

        public User(User user)
        {
            this.username = user.username;
            this.password = user.password;
            this.email = user.email;
            this.phoneNumber = user.phoneNumber;
            this.address = user.address;
            this.role = user.role;
            this.userID = user.userID;
        }

        public string GetUsername
        {
            get { return username; }
        }

        public string GetPassword
        {
            get { return password; }
        }

        public string GetEmail
        {
            get { return email; }
        }

        public string GetPhoneNumber
        {
            get { return phoneNumber; }
        }

        public string GetAddress
        {
            get { return address; }
        }

        public Role GetRole
        {
            get { return role; }
        }

        public int GetUserID
        {
            get { return userID; }
        }

        public bool isAdmin(User userRole)
        {
            string role = this.role.ToString().ToLower();
            return role == "admin";
        }

        public bool isEmployee(User userRole)
        {
            string role = this.role.ToString().ToLower();
            return role == "employee";
        }

        public object Clone()
        {
            return new User(this);
        }
    }
}

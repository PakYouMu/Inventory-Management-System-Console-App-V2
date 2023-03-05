using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Inventory_Management_System_Console_App.User;

namespace Inventory_Management_System_Console_App
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //public Product(string name, int quantity, double price, string category)
            //public Order(Product product, Customer customer, int quantity, double price)
            //public Customer(String name, String address, String phoneNumber, String email)

            //create a program to use all the functions in Order.cs
/*
            Product product1 = new Product("Apple", 1000, 0.99, "Fruit");
            Product product2 = new Product("Orange", 900, 0.55, "Fruit");
            Product product3 = new Product("Banana", 2000, 0.50, "Fruit");
            Product product4 = new Product("Apple", 2000, 1000, "Smartphone");
            Product product5 = new Product("Android", 5000, 1000, "Smartphone");
            Customer customer1 = new Customer("Arvin Angelo C. Arguilles", "Purok 2, Brgy. Kadaohan, Ormoc City", "09186106374", "arguilles1112@gmail.com");
            Order order1 = new Order(product1, customer1, 50, product1.GetPrice);
            Order order2 = new Order(product2, customer1, 25, product2.GetPrice);
            Order order3 = new Order(product3, customer1, 45, product3.GetPrice);
            Order order4 = new Order(product4, customer1, 5, product4.GetPrice);
            Order order5 = new Order(product5, customer1, 10, product5.GetPrice);

            Console.WriteLine(order1 + "\n");
            order1.RemoveProduct(product1, order1, 1);
            Console.WriteLine(order1);

            Console.WriteLine(order2);
            Console.WriteLine(order3);
            Console.WriteLine(order4);
            Console.WriteLine(order5);
*/




            //create a program to use all the functions in User.cs
/*
            User user1 = new User("John Doe", "password123", "john.doe@email.com", "555-1234", "123 Main St.", Role.Admin);
            User user2 = new User("Jane Smith", "yehlol", "janeawesome@email.com", "555-1442", "90 Sub St.", Role.Employee);

            Console.WriteLine("Username: " + user1.GetUsername);
            Console.WriteLine("Password: " + user1.GetPassword);
            Console.WriteLine("Email: " + user1.GetEmail);
            Console.WriteLine("Phone Number: " + user1.GetPhoneNumber);
            Console.WriteLine("Address: " + user1.GetAddress);
            Console.WriteLine("Role: " + user1.GetRole);
            Console.WriteLine("User ID: " + user1.GetUserID);

            Console.WriteLine();

            Console.WriteLine("Username: " + user2.GetUsername);
            Console.WriteLine("Password: " + user2.GetPassword);
            Console.WriteLine("Email: " + user2.GetEmail);
            Console.WriteLine("Phone Number: " + user2.GetPhoneNumber);
            Console.WriteLine("Address: " + user2.GetAddress);
            Console.WriteLine("Role: " + user2.GetRole);
            Console.WriteLine("User ID: " + user2.GetUserID);

            Console.WriteLine();

            Console.WriteLine("Is user1 an Admin? " + user1.isAdmin(user1));
            Console.WriteLine("Is user2 an Employee? " + user2.isEmployee(user2));
*/

            //create a program to use all the functions in Category.cs

            Category electronics = new Category("Electronics");

            // Add some subcategories to the Electronics category
            electronics.AddSubCategory("Smartphones");
            electronics.AddSubCategory("Laptops");
            electronics.AddSubCategory("Tablets");

            // Display the name of the category and its subcategories
            Console.WriteLine($"Category: {electronics.GetName}");
            Console.WriteLine("Subcategories:");
            foreach (string subcategory in electronics.AddSubCategory(""))
                Console.WriteLine($"- {subcategory}");

            // Remove a subcategory from the Electronics category
            electronics.RemoveSubCategory("Tablets");

            // Display the updated list of subcategories
            Console.WriteLine("\nUpdated list of subcategories:");
            foreach (string subcategory in electronics.AddSubCategory(""))
                Console.WriteLine($"- {subcategory}");
        }
    }
}
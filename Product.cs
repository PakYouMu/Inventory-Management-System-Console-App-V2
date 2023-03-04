using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_Console_App
{
    public class Product
    {
        private string name;
        private int quantity;
        private double price;
        private string category;
        private int productID;
        private static int nextProductID = 1;

        public Product(string name, int quantity, double price, string category)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.category = category;
            this.productID = nextProductID;
            nextProductID++;
        }

        public Product(Product product)
        { 
            this.name= product.name;
            this.quantity = product.quantity;
            this.price = product.price;
            this.category = product.category;
            this.productID = nextProductID;
            nextProductID++;
        }

        public string GetName
        {
            get { return name; }
        }

        public int GetQuantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double GetPrice
        {
            get { return price; }
            set { price = value; }
        }

        public string GetCategory
        {
            get { return category; }
        }

        public int GetID
        {
            get { return productID; }
        }
    }
 }

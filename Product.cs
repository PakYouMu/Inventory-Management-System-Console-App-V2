using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_Console_App
{
    public class Product : ICloneable
    {
        private string name;
        private int quantity;
        private double price;
        private Category category;
        private int productID;
        private static int nextProductID = 1;

        public Product(string name, int quantity, double price, Category category)
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
            this.name = product.name;
            this.quantity = product.quantity;
            this.price = product.price;
            this.category = product.category;
            this.productID = nextProductID;
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

        public Category GetCategory
        {
            get { return category; }
        }

        public int GetID
        {
            get { return productID; }
        }

        public object Clone()
        {
            return new Product(this);
        }

        public override bool Equals(object? obj)
        {
            return obj != null && obj is Product;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, quantity, price, category, productID);
        }
    }
 }

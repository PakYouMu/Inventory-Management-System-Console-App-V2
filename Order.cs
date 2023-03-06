using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_Console_App
{
    public class Order : ICloneable
    {
        private Product product;
        private Customer customer;
        private int quantity;
        private double price;
        private int orderID;
        private static int nextOrderID = 1;

        private List<Product> listOfProducts = new List<Product>();
       
        public Order(Product product, Customer customer, int quantity, double price)
        {
            this.product = product;
            this.customer = customer;
            this.quantity = quantity;
            this.price = this.quantity * price;
            this.orderID = nextOrderID;
            Order.nextOrderID++;

            this.listOfProducts.Add(this.product);
            product.GetQuantity -= quantity;
        }

        private Order(Order order)
        {
            this.product = order.product;
            this.listOfProducts.Add(order.product);
            this.customer = order.customer;
            this.quantity = order.quantity;
            this.price = order.price;
            this.orderID = order.orderID;
        }

        public void AddProduct(Product product)
        {
            listOfProducts.Add(product);
        }

        //Doesn't remove the product, the logic is wrong; but at least there's no error
        public void RemoveProduct(Product product, Order order, int productID)
        {
            Product? productToRemove = listOfProducts.Find(p => p.GetID == productID);
            if (productToRemove != null)
                listOfProducts.Remove(productToRemove);
        }

        public void UpdateQuantity(Product productQuantity)
        {
            Product product = new Product(productQuantity);
            product.GetQuantity += productQuantity.GetQuantity;

        }

        public void UpdatePrice(Product productPrice)
        {
            Product product = new Product(productPrice);
            product.GetPrice += productPrice.GetPrice;
        }

        public Product GetProduct
        {
            get { return product; }
        }

        public Customer GetCustomer
        {
            get { return customer; }
        }

        public int GetQuantity
        {
            get { return quantity; }
        }

        public double GetPrice
        {
            get {return price; }
        }

        public int GetID
        {
            get { return orderID; }
        }

        public object Clone()
        {
            return new Order(this);
        }
    }
}

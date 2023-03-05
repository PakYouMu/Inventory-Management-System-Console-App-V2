using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_Console_App
{
    public class Order
    {
        private Product product;
        private Customer customer;
        private int quantity;
        private double price;
        private int orderID;
        private static int nextOrderID = 1;

        private List<Product> listOfProducts = new List<Product>();
        private List<Order> listOfOrders = new List<Order>();
        public Order(Product product, Customer customer, int quantity, double price)
        {
            this.product = product;
            this.customer = customer;
            this.quantity = quantity;
            this.price = this.quantity * price;
            this.orderID = nextOrderID;
            Order.nextOrderID++;

            product.GetQuantity -= quantity;
        }

        //Order constructor to add a list of products
        //dont know how to do this yet
        /*public Order(List<Product> products, Customer customer, int quantity, double price)
        {
            this.product = new Product();
            this.customer = customer;
            this.listOfProducts = products;
            this.customer = customer;
            this.quantity = quantity;
            this.price = price;
            this.orderID = nextOrderID;
            nextOrderID++;
        }*/

        public Order(Order order)
        {
            this.product = order.product;
            this.customer = order.customer;
            this.quantity = order.quantity;
            this.price = order.price;
            this.orderID = order.orderID;
            Order.nextOrderID++;
        }

        public void AddProduct(Product product)
        {
            listOfOrders.Add(new Order(product, customer, quantity, price));
        }

        //Doesn't remove the product, the logic is wrong; but at least there's no error...yet
        public void RemoveProduct(Product product, Order order, int productID)
        {
            //Initialize objects to be used
            Order order1 = new Order(order);
            Product product1 = new Product(product);

            //Cycle through the list of orders
            foreach (Order orders in listOfOrders)
            {
                //Remove the order if the product ID matches
                if (order1.GetID == product1.GetID)
                {
                    this.listOfOrders.Remove(order1);
                }
            }
        }

        /*public void RemoveProduct(Product product, Order order, int productID)
        {
            //Initialize objects to be used
            Order order1 = new Order(order);
            Product product1 = new Product(product);

            //Remove the order if the product ID matches
            orders.RemoveAll(o => o.GetID == product1.GetID);
        }*/

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

        public void RemoveOrder()
        {
            this.listOfOrders.Remove(new Order(product, customer, quantity, price));
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

        public List<Order> GetListOfOrders
        {
            get { return listOfOrders; }
        }
    }
}

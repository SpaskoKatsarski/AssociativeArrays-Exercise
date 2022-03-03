using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace T04._Orders
{
    class Product
    {
        public Product(decimal price, int quantity)
        {
            this.Price = price;
            this.Quantity = quantity;                  
        }
        
        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string command;

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] productData = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string productName = productData[0];

                decimal productPrice = decimal.Parse(productData[1]);
                int productQuantity = int.Parse(productData[2]);
                
                if (products.ContainsKey(productName))
                {
                    products[productName].Price = productPrice;
                    products[productName].Quantity += productQuantity;
                }
                else
                {
                    products.Add(productName, new Product(productPrice, productQuantity));
                }
            }

            foreach (KeyValuePair<string, Product> product in products)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value.Price * product.Value.Quantity):f2}");
            }
        }
    }
}

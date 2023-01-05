﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Model
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            this.Name = name; this.Price = price;
        }

        public override string ToString()
        {
            return "Product { Name : " + this.Name + ", Price : Rp " + this.Price + " }";
        }

        public static List<Product> GetData()
        {
            List<Product> products = new List<Product>()
            {
                new Product("Susu Bubuk", 79000),
                new Product("Susu Full Cream", 87000),
                new Product("Sereal", 58000),
                new Product("Biskuit Mora", 43000),
            };

            return products;
        }

        public static void SampleFilterProduct()
        {
            // Create data source
            List<Product> products = GetData();

            // Create query
            IEnumerable<Product> productFilter = from item in products
                                                 where item.Price >= 55000
                                                 select item;

            // Execute
            foreach (var product in productFilter)
            {
                Console.WriteLine(product);
            }
        }
    }
}

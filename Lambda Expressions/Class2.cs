using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda_Expressions
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price {  get; set; }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        internal class Class2
        {
            static void Main(string[] args)
            {
                List<Product> products = new List<Product>() { new Product("Apple", 100), new Product("Banana", 50) };
                products.ForEach(s=>s.Price=(int)(s.Price*0.90));
                foreach(Product p in products)
                {
                    Console.WriteLine(p.Name+" "+p.Price);
                }
            }
        }
    }
}

using System;
using System.Collections;

class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price{ get; set; }
        
    }
    class Program
    {
        static void Main()
        {

            List<Product> products = new List<Product>();

            products.Add(new Product { Id = 1, Name = "Laptop", Price = 50000.0 });
            products.Add(new Product { Id = 2, Name = "TV", Price = 40000.0 });
            products.Add(new Product { Id = 3, Name = "AC", Price = 80000.0 });
            products.Add(new Product { Id = 4, Name = "Headset", Price = 6000.0 });
            products.Add(new Product { Id = 5, Name = "mobile", Price = 40000.0 });

            //Descending order by their name
            var descProducts =  products.OrderByDescending(e => e.Price);

            foreach (var descProduct in descProducts)
            {
                Console.WriteLine($"{descProduct.Id}, {descProduct.Name}, {descProduct.Price}");
            }

            Console.WriteLine();

            //Highest price and lowest
            double  maxPrice = products.Max(e => e.Price);

            Console.WriteLine("The highest Price:" + maxPrice);

            double minPrice = products.Min(e => e.Price);

            Console.WriteLine("The Lowest Price:" + minPrice);

        }
    }

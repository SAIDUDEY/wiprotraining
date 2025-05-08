using System;
using System.Diagnostics;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }

    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();
        {
          products.Add(  new Product { ID = 1, Name = "laptop", Price = 50000.00 });
          products.Add(  new Product { ID = 2, Name = "TV", Price = 43000.00 });
          products.Add(  new.Product {ID = 3, Name = "mobile", Price = 80000.00});
          products.Add( new.Product {ID = 3, Name = "AC", Price = 40000.00});
          products.Add( new.Product {ID = 3, Name = "fridge", Price = 20000.00});
        };

        var decendingorder = products.OrderByDescending(p => p.Price);

        Console.WriteLine("desencingorder : ");

        foreach (var item in decendingorder)
        {
            Console.WriteLine(item.price);


        }
        var max = products.Max(p => p.Price);
        Console.WriteLine("highest price :" + max);
        
        var min = products.Min(p => p.Price);
        Console.WriteLine("lowest price :" + min);



    }
}
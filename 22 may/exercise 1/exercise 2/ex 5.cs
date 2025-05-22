class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();

        products.Add(new Product { Id = 1, Name = "plates", Price = 500 });
        products.Add(new Product {Id =2, Name = "glass", Price = 700 });
        products.Add(new Product { Id = 3, Name = "tv", Price = 30000 });
        products.Add(new Product { Id = 4, Name = "phone", Price = 3000 });
        products.Add(new Product {Id = 5, Name = "buds", Price = 1300 });

        var linqProduct = products.OrderByDescending(p => p.Price);

        foreach (var product in linqProduct)
        {
            Console.WriteLine("product ID : "  + product.Id + " " + "product names : " + product.Name + " ");
        }


    }
}
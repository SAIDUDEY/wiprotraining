class Product
{
    public string Name { get; set; }

    public decimal Price { get; set; }
}

class Program
{ 
static void Main()
{
    List<Product> products = new List<Product>();

    products.Add(new Product { Name = "plates", Price = 500 });
    products.Add(new Product { Name = "glass", Price = 700 });
    products.Add(new Product { Name = "tv", Price = 30000 });
        products.Add(new Product { Name = "phone", Price = 3000 });
        products.Add(new Product { Name = "buds", Price = 1300 });

        var linqProduct = products.Where(p => p.Price > 500);

        foreach (var product in linqProduct)
        {
            Console.WriteLine("product price > 500 : " + product.Name + " ");
        }


    }
}
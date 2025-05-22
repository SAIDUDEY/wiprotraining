

using System;
using System.Collections.Generic;
using System.Linq;

// 1. Product class
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

// 2. CartItem class
class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public double GetTotalPrice()
    {
        return Product.Price * Quantity;
    }
}

// 3. ShoppingCart class
class ShoppingCart
{
    private List<CartItem> items = new List<CartItem>();

    public void AddItem(Product product, int quantity)
    {
        // Check if the product already exists
        var existingItem = items.FirstOrDefault(i => i.Product.Id == product.Id);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            items.Add(new CartItem { Product = product, Quantity = quantity });
        }
    }

    public void RemoveItem(int productId)
    {
        var itemToRemove = items.FirstOrDefault(i => i.Product.Id == productId);
        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
        }
    }

    public double GetCartTotal()
    {
        return items.Sum(item => item.GetTotalPrice());
    }

    public void DisplayCart()
    {
        Console.WriteLine("Cart Items:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Product.Name} x {item.Quantity} = {item.GetTotalPrice():C}");
        }
        Console.WriteLine($"Total Cart Value: {GetCartTotal():C}\n");
    }
}

// 4. Main method
class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product p1 = new Product { Id = 1, Name = "Laptop", Price = 75000 };
        Product p2 = new Product { Id = 2, Name = "Smartphone", Price = 25000 };
        Product p3 = new Product { Id = 3, Name = "Headphones", Price = 3000 };

        // Create shopping cart
        ShoppingCart cart = new ShoppingCart();

        // Add items to cart
        cart.AddItem(p1, 1);
        cart.AddItem(p2, 2);
        cart.AddItem(p3, 3);

        // Display total
        cart.DisplayCart();

        // Example: remove a product
        cart.RemoveItem(2); // Remove Smartphone
        Console.WriteLine("After removing Smartphone:");
        cart.DisplayCart();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class FoodOrder
{
    public abstract void PlaceOrder(string item);

    public void OrderInfo()
    {
        Console.WriteLine("placing food order");
    }

}

class FastFoodOrder : FoodOrder
{
    public override void PlaceOrder (string item)
    {
        Console.WriteLine($"order placed for { item } at fast food outlet" );
    }

}

class FineDiningOrder : FoodOrder
{
    public override void PlaceOrder(string item)
    {
        Console.WriteLine($"order placed for {item} at fine dining restorant");
    }
}

class Program
{
    static void Main()
    {

        FoodOrder food;

        food = new FastFoodOrder();
        food.OrderInfo();
        food.PlaceOrder("noodles");

        Console.WriteLine();

        food = new FineDiningOrder();
        food.OrderInfo();
        food.PlaceOrder("pizza");

    }
}

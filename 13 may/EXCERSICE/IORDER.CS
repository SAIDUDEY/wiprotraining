using System;

interface IOrder
{
    public void PlaceOrder(string item);

    public void CancelOrder(string item);

}

class DineInOrder : IOrder
{
    public void PlaceOrder(string item)
    {
        
        Console.WriteLine("Placing DineInOrder for item : " + item);
    }
    public void CancelOrder(string item)
    {
         
        Console.WriteLine("Canceling dine in order for item :" + item);

    }
}

class TakeawayOrder : IOrder
{
    public void PlaceOrder(string item)
    {
        
        Console.WriteLine("Placing takeawayOrder for item : " + item);
    }
    public void CancelOrder(string item)
    {
         
        Console.WriteLine("Canceling take away order for item :" + item);

 }
}
class Program
{
    static void Main()
    {
        IOrder order;

        order = new DineInOrder();
        order.PlaceOrder("pizza");
        order.CancelOrder("biryani");

        order = new TakeawayOrder();
        order.PlaceOrder("biryani");
        order.CancelOrder("curd rice");
        


    }
}
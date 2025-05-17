interface IMaintenance
{
    public void Service();
    public void Repair();
}
class CarMaintainance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Car is being serviced");
    }
    public void Repair()
    {
        Console.WriteLine("Car is being repaired");
    }

}
class BikeMaintainance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("bike is being serviced");
    }
    public void Repair()
    {
        Console.WriteLine("bike is being repaired");
    }
}

class Program
{
    static void Main()
    {
        IMaintenance maintainance;

        maintainance = new CarMaintainance();
        maintainance.Service();
        maintainance.Repair();

        Console.WriteLine();

        maintainance = new BikeMaintainance(); 
        maintainance.Service();
        maintainance.Repair();
    }
}
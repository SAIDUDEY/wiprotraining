interface IAnimalActions
{
    public void Eat();
    public void Sleep();
}

class Lion : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Lion is eating meat");
    }
    public void Sleep()
    {
        Console.WriteLine("Lion is sleeping");
    }
}
class Elepant : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Elephant is eating grass");
    }

    public void Sleep()
    {
        Console.WriteLine("Elepant is Sleeping");
    }
}
class Program
{
    static void Main()
    {
        IAnimalActions animal;

        animal = new Lion();
        animal.Eat();
        animal.Sleep();

        animal = new Elepant();
        animal.Eat();
        animal.Sleep();
    }
}
interface ICalculator
{
    void calculation(int num1, int num2);
}

class Addition : ICalculator
{
    public void calculation(int num1, int num2)
    {
        Console.WriteLine("Addition : " + num1+ num2);
    }
}
class Substraction : ICalculator
{
    public void calculation(int num1, int num2)
    {
        Console.Write("substract : ");
        Console.WriteLine( num1 - num2);
    }
}
class Multiply : ICalculator
{
    public void calculation(int num1, int num2)
    {
        Console.WriteLine("Multiply :" + num1 * num2);
    }
}
class Divide : ICalculator
{
    public void calculation(int num1, int num2)
    {
        Console.WriteLine("Divide : " + num1 / num2);
    }
}

class Program
{
    static void Main()
    {
        ICalculator SimpleCalculator;

        SimpleCalculator = new Addition();
        SimpleCalculator.calculation(1, 2);


        SimpleCalculator = new Substraction();
        SimpleCalculator.calculation(1, 2);

        SimpleCalculator = new Multiply();
        SimpleCalculator.calculation(1, 2);

        SimpleCalculator = new Divide();
        SimpleCalculator.calculation(1, 2);

    }
}

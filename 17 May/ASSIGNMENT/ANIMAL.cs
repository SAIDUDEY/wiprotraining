public abstract class Animal
{
    public abstract void MakeSound(string sound);

    public void Eat(string name)
    {
        Console.WriteLine(name + " is Eating");
    }

}
class Dog : Animal
{
    public override void MakeSound(string sound)
    {
        Console.WriteLine(sound);
    }
}

class Cat : Animal
{
    public override void MakeSound(string sound)
    {
        Console.WriteLine(sound);

    }
}

class Program
{
    static void Main()
    {
        Animal animal;

        animal = new Dog();
        animal.MakeSound("Barks");
        animal.Eat("Dog");

        Console.WriteLine();

        animal = new Cat();
        animal.MakeSound("Meows");
        animal.Eat("Cat");
    }
}
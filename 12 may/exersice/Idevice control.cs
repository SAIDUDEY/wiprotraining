interface IDeviceControl
{
    public void TurnOn();
    public void TurnOff();
}

class SmartTV : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("smart tv is on");
    }
    public void TurnOff()
    {
        Console.WriteLine("smart tv is off");
    }
}
class Speaker : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("speaker is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("speaker is off");
    }
}
class Program
{
    static void Main()
    {
        IDeviceControl control;

        control = new SmartTV();
        control.TurnOn();
        control.TurnOff();

        control = new Speaker();
        control.TurnOn();
        control.TurnOff();
    }
}
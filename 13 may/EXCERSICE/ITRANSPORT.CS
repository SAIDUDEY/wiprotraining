using System;

interface ITransport
{
    public void Start()
    {
        Console.WriteLine("Starting the Transport");

    }

    public void Stop()
    {
        Console.WriteLine("Stopping the transport");
    }

}
class Bus : ITransport
{
    public void Start()
    {
        Console.WriteLine("bus is starting");
    }
    public void Stop()
    {
        Console.WriteLine("bus is stopping");

    }

}

class Train : ITransport
{
    public void Start()
    {
        Console.WriteLine("train is starting");
    }
    public void Stop()
    {
        Console.WriteLine("train is stopping");
    }
}


class Program
{
    static void Main()
    {
        ITransport transport;

        transport = new Bus();
        transport.Start();
        transport.Stop();

        transport = new Train();
        transport.Start();
        transport.Stop();


    }
}
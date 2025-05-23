
////printing number
class Program
{
    static void Printnumber()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("1 :" + i);
            Thread.Sleep(1000);
        }
    }
        static void Main()
        {
            Thread thread = new Thread(Printnumber);
        thread.Start();
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("2 :" + i);
                Thread.Sleep(500);
            }
        }
        }
    }



//printing message
    class Program
{
    static void Printmessage(object message)
    {
        string msg = (string)message;
        Console.WriteLine("message : " + msg);

    }
        static void Main()
        {
            Thread thread = new Thread(new ParameterizedThreadStart(Printmessage));
        thread.Start("hello from thread");

        
        }
    }

    //addition

    class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;

        Thread thread = new Thread(() =>
            {
                Console.WriteLine($"add : { a + b}");
            });
        thread.Start();
    }
}
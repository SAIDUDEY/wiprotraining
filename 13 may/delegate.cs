using System.Net.Security;

delegate void CustomDel(string s);

class TestClass
{
    static void Hello(string s)
    {
        Console.WriteLine("hello " + s);
    }
    static void GoodBye(string s)
    {
        Console.WriteLine("good bye" + s);
    }


static void Main()
    {
        CustomDel Hidel, byedel, multidel;

       Hidel = Hello;

        byedel = GoodBye;

        multidel = Hidel+byedel;

        multiMinusHidel = multidel - Hidel;

        Console.WriteLine("invoking delegate hidel: ");
        Hidel("A");

        Console.WriteLine("invoking delegate byedel: ");
        byedel("b");

        Console.WriteLine("invoking delegate multidel: ");
        multidel("c");
        Console.WriteLine("invoking delegate multiMinusHidel: ");
        multiMinusHidel("d");



    }
}
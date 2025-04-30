using System;

public class SWitchCase
{
    public static void Main(string[] args)
    {
        int num=5;
        
        switch(num){
            case 1:
            Console.WriteLine(num + " januvary");
            break;
            case 2:
            Console.WriteLine(num + " feb");
            break;
            case 3:
            Console.WriteLine(num + " march");
            break;
            case 4:
            Console.WriteLine(num + " april");
            break;
            case 5:
            Console.WriteLine(num + " may");
            break;
            case 6:
            Console.WriteLine(num + " june");
            break;
            case 7:
            Console.WriteLine(num + " july");
            break;
            case 8:
            Console.WriteLine(num + " aug");
            break;
            case 9:
            Console.WriteLine(num + " sept");
            break;
            case 10:
            Console.WriteLine(num + " oct");
            break;
            case 11:
            Console.WriteLine(num + " nov");
            break;
            case 12:
            Console.WriteLine(num + " dec");
            break;
            
            default:
            Console.WriteLine(num + " invalid number");
            break;
        }
     
}
}     
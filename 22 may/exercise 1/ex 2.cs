using System.Security.Cryptography.X509Certificates;

class Phone

{
    static void Main()
    { 

    Dictionary<string, string> phonebook = new Dictionary<string, string>();
        phonebook.Add("seshu", "73992892992929");
        phonebook.Add("vinay", "3772882828");
        phonebook.Add("rahul", " 683588887");

        foreach(var phone in phonebook)
                {
            Console.WriteLine(phone);
                
        }

        Console.WriteLine("enter the name :");
        string name = Console.ReadLine();
        
        if(phonebook.ContainsKey(name))
        {
           Console.Write(phonebook[name]);


        }
        else
        {
            Console.WriteLine("invalid");
        }

    }
}
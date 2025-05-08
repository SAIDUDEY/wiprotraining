using System;

class Program
{
    static void Main()
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        contacts.Add("bob", "701384333");
        contacts.Add("alice", "983332292");
        contacts.Add("charlie", "7399201817");
        contacts.Add("seshu", "8382929292");
        contacts.Add("vinay","9338483234");

        //update
       
        contacts["vinay"] = "83333999293";

        if (contacts.ContainsKey("bob"))
        {
            Console.WriteLine(" bob is exists");

        }
        else
        {
            Console.WriteLine("not exists");
        }

        foreach (var contact in contacts)
        {
            Console.WriteLine(contact);
        }

        
    }

}
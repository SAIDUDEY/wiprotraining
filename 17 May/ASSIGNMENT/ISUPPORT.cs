interface ISupportTicket
{
    public void CreateTicket(string isssue);

    public void RaiseTicket(int ticketid);
}

class EmailSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine("creating ticket voa email : " + issue);
    }
    public void RaiseTicket(int ticketid)
    {
        Console.WriteLine("Resolving ticket" + ticketid + "via Email");

    }
}
class PhoneSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine("creating ticket via phone : " + issue);
    }
    public void RaiseTicket(int ticketid)
    {
        Console.WriteLine("Resolving ticket" + " " + ticketid +" via phone" );

    }
}

class Program
{
    static void Main()
    {
        ISupportTicket support;

        support = new EmailSupport();
        support.CreateTicket("feature failure");
        support.RaiseTicket(12);

        Console.WriteLine();

        support = new PhoneSupport();
        support.CreateTicket("speaker failure");
        support.RaiseTicket(10);
    }
}

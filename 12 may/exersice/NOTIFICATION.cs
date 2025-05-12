abstract class Notification
{
    public abstract void Send();

    public void ShowType()
    {
        Console.WriteLine("sending notification");
    }

}

class EmailNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("sending email notification");
        
    }
}

class SMSNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending SMS Notification");
    }
}

class Program
{
    static void Main()
    {
        Notification notification;

        notification = new EmailNotification();
        notification.Send();
        notification.ShowType();


        notification = new SMSNotification();
        notification.Send();
        notification.ShowType();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class TicketBooking
{
    public abstract void BookTicket(int seats);

    public void ShowBookingInfo()
    {
        Console.WriteLine("Booking tickets");
    }

}

class BusBooking : TicketBooking
{
    public override void BookTicket (int seats)
    {
        Console.WriteLine($"Booking * bus ticket = {seats} ");
    }

}

class FlightBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine($"Booking * flight ticket = {seats} ");
    }
}

class Program
{
    static void Main()
    {

        TicketBooking book;

        book = new BusBooking();
        book.ShowBookingInfo();
        book.BookTicket(2);

        book = new FlightBooking();
        book.ShowBookingInfo();
        book.BookTicket(2);

    }
}

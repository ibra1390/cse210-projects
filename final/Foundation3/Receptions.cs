using System;


public class Reception : Event
{
    private string email;

    public Reception(string _eventType, string _eventTitle, string _eventDescription, string _eventDate, string _eventTime,  Address _address, string _email) : base(_eventType, _eventTitle, _eventDescription, _eventDate, _eventTime, _address)
    {
        email = _email;
    }

    public void ReceptionFullDetails()
    {
        Console.WriteLine($"{getEventType()}\n{getEventTitle()}\n{getEventDescription()}\n{getEventDate()}\n{getEventTime()}\n{getEventAddress().GetAddress()}");        
        Console.WriteLine($"Reservations at {email}");
        Console.WriteLine();
    }
}
using System;


public class Outdoor : Event
{
    public string weather;

    public Outdoor(string _eventType, string _eventTitle, string _eventDescription, string _eventDate, string _eventTime, Address _address, string _weather) : base(_eventType, _eventTitle, _eventDescription, _eventDate, _eventTime, _address)
    {
        weather = _weather;
    }
    public void OutdoorFullDetails()
    {
    Console.WriteLine($"{getEventType()}\n{getEventTitle()}\n{getEventDescription()}\n{getEventDate()}\n{getEventTime()}\n{getEventAddress().GetAddress()}");        
    Console.WriteLine($"The Weather will be {weather}");
    Console.WriteLine();
    }
}

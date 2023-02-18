using System;


public class Event
{
    private string eventType, eventTitle, eventDescription, eventDate, eventTime;
    private Address eventAddress;

     public Event(string _eventType, string _eventTitle, string _eventDescription, string _eventDate, string _eventTime, Address _eventAddress)
    {
        eventType = _eventType;
        eventTitle = _eventTitle;
        eventDescription = _eventDescription;
        eventDate = _eventDate;
        eventTime = _eventTime;
        eventAddress = _eventAddress;
    }
    
    public string getEventTitle()
    {
        return eventTitle;
    }
    public string getEventDescription()
    {
        return eventDescription;
    }
    public string getEventDate()
    {
        return eventDate;
    }
    public string getEventTime()
    {
        return eventTime;
    }
    public string getEventType()
    {
        return eventType;
    }
    public Address getEventAddress()
    {
        return eventAddress;
    }
    


    public void shortDescription()
    {
        Console.WriteLine($"{eventType}\n{eventDescription}\n{eventDate}");
        Console.WriteLine();
    }

    public void standardDetails()
    {
        Console.WriteLine($"{eventTitle}\n{eventDescription}\n{eventDate}\n{eventTime}\n{eventAddress.GetAddress()}");
        Console.WriteLine();
    }


}
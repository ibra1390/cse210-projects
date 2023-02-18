using System;

public class Lectures : Event
{
    private string speaker;
    private int capacity;

    public Lectures(string _eventType, string _eventTitle, string _eventDescription, string _eventDate, string _eventTime, Address _address, string _speaker, int _capacity) : base(_eventType, _eventTitle, _eventDescription, _eventDate, _eventTime, _address)
    {
        speaker = _speaker;
        capacity = _capacity;
    }

    public void LectureFullDetails()
    {
        Console.WriteLine($"{getEventType()}\n{getEventTitle()}\n{getEventDescription()}\n{getEventDate()}\n{getEventTime()}\n{getEventAddress().GetAddress()}");
        Console.WriteLine($"Speaker: {speaker} - Capacity: {capacity} persons.");
        Console.WriteLine();
    }
}
using System;


public class Running : Activity
{
    private double distance;

    public Running(string _date, float _length, double _distance) : base(_date, _length)
    {
        distance = _distance;
    }

    public override double GetDistance()
    {
        return distance;
    }
    public override double GetSpeed()
    {
        double mph = Math.Round((GetDistance() / GetLength()) * 60, 2);
        return mph;
    }
    public override double GetPace()
    {
        double pace = Math.Round(GetLength() / GetDistance(), 2);
        return pace;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
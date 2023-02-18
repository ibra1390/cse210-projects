using System;


public class Swimming : Activity
{
    private int laps;

    public Swimming(string _date, float _length, int _laps) : base(_date, _length)
    {
        laps = _laps;
    }

    public override double GetDistance()
    {
        double miles = Math.Round(laps * 50 / 1000 * 0.62, 2);
        return miles;
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
        return $"{GetDate()} Swimming ({GetLength()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
using System;


public class Cycling : Activity
{
    private int speed;

    public Cycling(string _date, float _length, int _speed) : base(_date, _length)
    {
        speed = _speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }
    public override double GetDistance()
    {
        double miles = Math.Round((GetSpeed() * GetLength()) / 60, 2);
        return miles;
    }
    public override double GetPace()
    {
        double pace = Math.Round(GetLength() / GetDistance(), 2);
        return pace;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}

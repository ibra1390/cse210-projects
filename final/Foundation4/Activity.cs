using System;


public class Activity
{
    private string date;
    private float length;

    public Activity(string _date, float _length)
    {
        date = _date;
        length = _length;
    }

    public string GetDate()
    {
        return date;
    }
    public float GetLength()
    {
        return length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return "";
    }
}

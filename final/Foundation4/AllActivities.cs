using System;


public class AllActivities
{
    public List<Activity> allActivities = new List<Activity>();

    public void addActivity(Activity _activity)
    {
        allActivities.Add(_activity);
    }

    public void DisplayActivities()
    {
        Console.WriteLine("This week you did the following activities:");
        Console.WriteLine();
        foreach (Activity activity in allActivities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
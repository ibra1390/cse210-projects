using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("------EXERCISE TRACKING--------");
        Console.WriteLine();

        AllActivities allActivities = new AllActivities();

        
        Running r1 = new Running("February 13th, 2023", 70, 15);
        allActivities.addActivity(r1);
        Cycling b1 = new Cycling("February 15th, 2023", 90, 25);
        allActivities.addActivity(b1);
        Swimming s1 = new Swimming("February 17th, 2023", 60, 89);
        allActivities.addActivity(s1);

        
        allActivities.DisplayActivities();
        Console.WriteLine();
    }
}
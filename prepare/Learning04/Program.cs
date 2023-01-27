using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment();
        a1.SetStudentName("Juan");
        a1.SetTopic("Math");
        Console.WriteLine(a1.GetSummary());
    }
}
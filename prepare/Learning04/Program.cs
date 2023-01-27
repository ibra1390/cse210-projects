using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Juan", "math");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Roberto Rojas", "Fractions", "8.4", "8-20");
         Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
    }
} 

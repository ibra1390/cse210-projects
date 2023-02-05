using System;
using System.Diagnostics;

class BreathingActivity : Activity
{

    public BreathingActivity() : base()
    {
        setActivityName("Breathing Activity");

        setDescription("This activity will help you relax by walking your through breathing in and out slowly." +
        " Clear your mind and focus on your breathing.");
    
    }

    public void runActivity()
    {
        runActivityParentStart();
        Console.Clear();
        displayBreath();
        runActivityParentEnd();

    }

    public void breatheIn(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {  
            Console.Write(string.Format("Breathe in...: {0}",i));   
            Console.SetCursorPosition(0, Console.CursorTop); 
            Thread.Sleep(1000);      
                 
        }     
    }

    public void breatheOut(int seconds)
    {   
        
        for (int i = seconds; i >= 1; i--)
        {   
            Console.Write(string.Format("Now breathe out...: {0}",i));   
            Console.SetCursorPosition(0, Console.CursorTop); 
            Thread.Sleep(1000);           
        }     
    }
   
    public void displayBreath()
    {
         Stopwatch timer = new Stopwatch();
         timer.Start();

        while (timer.ElapsedMilliseconds / 1000 < getUserSessionLengthInput())
        {
            breatheIn(4);
            Console.WriteLine();
            breatheOut(6);
            Console.WriteLine();
        }
        timer.Stop();
        Thread.Sleep(200);
    }
    

}
using System;
using System.Diagnostics;

class ListingActivity : Activity
{
    List<string> prompt, questions;
    
    public ListingActivity() : base()
    {
        setActivityName("Listing Activity");

        setDescription("This activity will help you reflect on the good things in your life" +
        " by having you list as many things as you can in a certain area.");

        prompt = new List<string>
        {
            "--- Who are people that you appreciate? ---",
            "--- What are personal strengths of yours?. ---",
            "--- Who are people that you have helped this week? ---",
            "--- When have you felt the Holy Ghost this month? ---",
            "--- Who are some of your personal heroes? ---"
        };
    }
    public void runActivity()
    {
        runActivityParentStart();
        displayPrompt();
        ListingItems();
        runActivityParentEnd();

    }

    public void displayPrompt()
    {
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:");
        int randomIndex = new Random().Next(0, prompt.Count());
        Console.WriteLine(prompt[randomIndex]);
        displayCountDown(5);
        Console.WriteLine();
        
    }

    public void ListingItems()
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();

        List<string> ItemList = new List<string>();
        
        while (timer.ElapsedMilliseconds / 1000 < getUserSessionLengthInput())
        {
            for (int i = 0; i < 4; i++)
            {
                string ListInput = Console.ReadLine();
                ItemList.Add(ListInput);
            }

        }

        Console.WriteLine(string.Format("You listed {0} items!", ItemList.Count));
        Console.WriteLine();

    }    

}
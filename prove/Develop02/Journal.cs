using System;
using System.IO;
using System.Text;

public class Journal
{
    PromptGenerator gen = new PromptGenerator();
    public string filePath = "C:\\Users\\inggo\\Documents\\myfile.csv";
    public void DisplayIntro()
    {
        Console.WriteLine("Welcome to the Journal Program!");  
    }

    public void GetChoice()
    {
        string answer;
        do
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();
            
            switch (answer)
            {
                case "1":
                    gen.DisplayRandom();
                    AddEntry();

                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    LoadCSV();
                    break;
                case "4":
                    SaveCSV();
                    
                    break;
                default:
                    break;       

            }
            
        } while (answer !="5");

        
    }

    public void DisplayJournal()
    {
        StreamReader streamReader = new StreamReader(filePath);

        while (!streamReader.EndOfStream)
        {
            var line = streamReader.ReadLine();
            var values = line.Split("");

            Console.WriteLine("{0}", values[0]);
        }
    }

    public void AddEntry()
    {   
        StringBuilder builder = new StringBuilder();
        DateTime date = DateTime.Now;

        string newDate = date.ToString("MM/dd/yyyy");
        string userAnswer = Console.ReadLine();
        
 
        builder.AppendLine(string.Format("Date: {0}, {1}", newDate, userAnswer));

        File.AppendAllText(filePath, builder.ToString());
        
    }

    public void SaveCSV()
    {
        StreamWriter writer = new StreamWriter(filePath);

        Console.WriteLine("Write the name of the file: ");
        string newFile = Console.ReadLine();
        string newPath = "C:\\Users\\inggo\\Documents\\"+newFile+".csv";
        File.Create(newPath).Dispose();
        filePath = newPath;
     
    }

    public void LoadCSV()
    {
        StreamReader streamReader = new StreamReader(filePath);

        Console.WriteLine("Write the name of the file: ");
        filePath = Console.ReadLine();
        
    }
}
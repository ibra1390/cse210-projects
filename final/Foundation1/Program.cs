using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("YOUTUBE VIDEOS ");
        Console.WriteLine();

         Video video1 = new Video("How to get the master sword in Zelda BOTW?", "Link123", 20);
       
        Comments commentVideo1 = new Comments("Pedo Pascal", "Awesome, here's your like good man");
        Comments comment2Video1 = new Comments("Ellie Portman", "Thanks for the help! you saved me");
        Comments comment3Video1 = new Comments("Pokemaniac14", "LoL took me 2 hours but I figured it out");
        video1.CommentsList.Add(commentVideo1);
        video1.CommentsList.Add(comment2Video1);
        video1.CommentsList.Add(comment3Video1);

        

        Video video2 = new Video("Doggy dancing", "AnimalLover", 10);
        
        Comments CommentVideo2 = new Comments("Merlina Adams", "So cute!!!");
        Comments Comment2Video2 = new Comments("Johny Boy", "Where I get one of those?");
        Comments Comment3Video2 = new Comments("Spike", "My dog dances too" );
        Comments Comment4Video2 = new Comments("Marlene Rojas", "I'm in love with that doggy" );
        video2.CommentsList.Add(CommentVideo2);
        video2.CommentsList.Add(Comment2Video2);
        video2.CommentsList.Add(Comment3Video2);
        video2.CommentsList.Add(Comment4Video2);
        

        Video video3 = new Video("The best restaurants to visit in NY", "YourTravelGuide", 60);
        
        Comments CommentVideo3 = new Comments("Sarah Connors", "Thanks for the recommendations");
        Comments Comment2Video3 = new Comments("KPop fan", "I'd like to go but don't have any money");
        Comments Comment3Video3 = new Comments("Carlos142", "How much does it cost the last one?" );
        video3.CommentsList.Add(CommentVideo3);
        video3.CommentsList.Add(Comment2Video3);
        video3.CommentsList.Add(Comment3Video3);
        

        List<Video> VideosList = new List<Video>();
        VideosList.Add(video1);
        VideosList.Add(video2);
        VideosList.Add(video3);


        foreach (Video video in VideosList)
        {
            Console.WriteLine(video.displayVideoInfo());
            foreach (Comments comment in video.CommentsList)
            {
                Console.WriteLine(comment.FormatComment());
                Console.WriteLine();
            }
            
        }

        
    }
}
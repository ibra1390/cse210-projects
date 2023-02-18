using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("EVENT PLANNING");
        Console.WriteLine();

        Address address1 = new Address("BYU-Idaho University", "Rexburg", "Idaho", "USA");
        Address address2 = new Address("Col. Maravillas No. 311", "San Ramon", "Puebla", "Mexico");
        Address address3 = new Address("Saginaw Rd 740", "Oxford", "Philadelphia", "USA");
        

        Lectures lectures1 = new Lectures("Lecture","'How to be more patient?'", "Come to the conference room to learn how you can be more patient and improve your skills while studying or working","March 21st, 2023","10:00 a.m. to 11:00 a.m.", address1, "Professor Hegwit",200);
        Reception reception1 = new Reception("Reception", "Mara and Ibra's wedding", "You're invited to celebrate the love between two persons who love each other","December 1st, 2023","5:00 p.m. - 12:00 am", address2, "SalonLosGirasoles@gmail.com");
        Outdoor outdoor1 = new Outdoor("Outdoor Gathering", "Rock n' Roll Concert", "Come to listen all of your favorite rock bands in one place","June 15th, 2023","7:00 pm - 10:00 pm", address3, "cloudy and fresh");

        //standard details 
        lectures1.standardDetails();
        reception1.standardDetails();
        outdoor1.standardDetails();
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine();

        //full details 
        lectures1.LectureFullDetails();
        reception1.ReceptionFullDetails();
        outdoor1.OutdoorFullDetails();
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine();

        //short description 
        lectures1.shortDescription();
        reception1.shortDescription();
        outdoor1.shortDescription();
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine();

    }
}
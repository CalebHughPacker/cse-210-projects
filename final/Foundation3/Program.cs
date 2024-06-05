using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("120", "Business Pkwy", "Babylon Falls", "ID", "83359");
        Lecture lecture = new Lecture("Innovative Analytics that Facilitate Streamlined Scalability to Maximize Synergy and Engagement", "Join us for a paradigm-shifting lecture"+
         " on how groundbreaking analytics can revolutionize your business ecosystem by synergistically streamlining scalability and maximizing both holistic synergy and deep "+
         "engagement. This high-impact session will drill down into the cutting-edge innovations in data analytics and demonstrate how they can be leveraged to drive operational "+
         "excellence and catalyze seamless cross-functional collaboration across your organizational matrix.", "12 June", "7:00 PM", lectureAddress, "John Lectureman", 120);

        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("-");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("-");
        Console.WriteLine(lecture.GetFullDetails());

        Console.WriteLine("\n<><><><><><><><><><><><><><><><><><><><><><>\n");

        Address receptionAddress = new Address("601", "Corporate Ave", "Corporatesboro", "CO", "80134");
        Reception reception = new Reception("Software Engineering Networking Mixer", "We know that y'all need to network. If you care about your career, get yourself on over here and "+
        "talk to some folks. We know that y'all a bunch a nerds who wouldn't step out of your caves if you didn't have to, but we promise that if by some chance you do know how to "+
        "act in the presence of another human being that you might be able to get something outta this. ", "Friday, June 31st", "6:00-8:00", receptionAddress,"events@businessreceptions.com");
        
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("-");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("-");
        Console.WriteLine(reception.GetFullDetails());

        Console.WriteLine("\n<><><><><><><><><><><><><><><><><><><><><><>\n");

        Address outdoorGatheringAddress = new Address("3150", "Gulf View Dr", "Gatorsville", "MS", "38701", "Gatorsville Beach @ Better Western Hotel");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Superficial Intelligence", "A series of outdoor lectures on the moral ramifications of using AI to generate lecture titles and descriptions. " +
        "Swedish Powermetal Karaoke and Cosplay Beach Volleyball will be held at the conclusion of the final speaker (participation mandatory). In the event of inclement weather, paticipants will be expected"+
        "to wear raincoats or bring umbrellas. ", "June 12th", "3:00", outdoorGatheringAddress, "49°C, Wind Speed 111 mph, Heavy Rain");
    
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine("-");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("-");
        Console.WriteLine(outdoorGathering.GetFullDetails());

    }
}
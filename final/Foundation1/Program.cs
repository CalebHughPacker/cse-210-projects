using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Software Drying Tutorial", "HardenSoft", 0, 11, 28);
        video1.AddComment("lukain4", "this is great, can we get a tutorial on how to dry your hardware as well?");
        video1.AddComment("parksooarmy09", "im confused i dont think this ever happens with software");    
        video1.AddComment("Mike_Carmichael", "Thanks! I'll make sure to use this next time my software gets wet.");
        video1.AddComment("Epic Dude", "first comment?");

     
        Video video2 = new Video("Introducing Sour Cream and Onion O's Ceral!", "Admiral Mills", 0, 0, 33);
        video2.AddComment("Carlos Games", "Uuuuuuuuhhhh what? Do people want this?");
        video2.AddComment("MacandSneeze", "ion know if this is it yall");    
        video2.AddComment("Bob Stevens", "I'll never understand this new generation. The woke left has destroyed yet another core american value.");
        video2.AddComment("joao0418", "ainda bem q nunca vai chegar no br kkkk" );
        video2.AddComment("Epic Dude", "lol i havent even watched the video yet");

        Video video3 = new Video("New Pizza Delivery Gamemode and Skins | Weeknite x Little Kaiser's", "Milquetoast Games", 1, 2, 2);
        video3.AddComment("BrunchLady", "How on earth did yall get Little Kaiser's for this lol");
        video3.AddComment("Liam Thompson", "wa t  this is crezy but my mom wont give me mony for b-zucks 😭");    
        video3.AddComment("dracopotter<3", "Does no one else find the new skins a bit culturally insensitive?");
        video3.AddComment("Shadowman8787", "can you collab with Re;gaiden no densetsu: another world 0? :3" );
        video3.AddComment("nigelcromsworth", "what on earth is little kaiser's? is that some sort of american thing?" );
        video3.AddComment("Epic Dude", "who even plays this game still looooool");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine($"Number of comments: {video.CountComments()}");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}
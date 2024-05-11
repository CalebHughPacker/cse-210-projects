using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {   
        //Scriptures to be randomly selected (EXCEEDING REQUIREMENTS)
        List<string> passages = new List<string>{"Let us hear the conclusion of the whole matter: Fear God, and keep his commandments: " +
        "for this is the whole duty of man. For God shall bring every work into judgment, with every secret thing, whether it be good,"+
        "or whether it be evil.", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not "+
        "perish, but have everlasting life.", "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal"+
        "Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having "+
        "faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."};

        List<string> books = new List<string>{"Ecclesiates", "John", "Moroni"}; //book names
        List<int> chapters = new List<int>{12, 3, 10}; //chapter numbers
        List<int> verses = new List<int>{13, 16, 5}; //verse numbers
        List<int> endVerses = new List<int>{14, 0, 0}; //ending verse numbers; 0 if the passage is only a single verse
        
        //select random scripture
        Random random = new();
        int index = random.Next(passages.Count);

        //create reference and scripture objects
        Reference reference = new(books[index], chapters[index], verses[index], endVerses[index]);
        Scripture scripture = new(reference, passages[index]);

        //display full scripture
        Console.Clear();
        Console.Write(reference.GetDisplayText());
        Console.WriteLine(" " + scripture.GetDisplayText());
        Console.WriteLine("\nPress ENTER to continue or type 'QUIT' to finish: ");
        string quit = Console.ReadLine();

        //loop until user types 'quit'
        while (quit.ToLower() != "quit")
        {
            Console.Clear();
            bool done = scripture.HideRandomWords(scripture._words.Count()/5);
            Console.Write(reference.GetDisplayText());
            Console.WriteLine(" " + scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to continue or type 'QUIT' to finish: ");
            quit = Console.ReadLine();

            //logic to break the loop if all the words are hidden
            if (done)
            {
                break;
            }
        }
    }
}
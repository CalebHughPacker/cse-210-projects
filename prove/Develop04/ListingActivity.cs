using System;

public class ListingActivity : Activity
{   
    private int _count; //Counts the amount of items the user has listed
    private List<string> _prompts = new List<string>(); //List of prompts
    
    //Constructor assigns the activity name and description, sets the count to 0, and populates _prompts 
    public ListingActivity ()
    {
        _count = 0;
        _name = "Listing Activity";
        _description = "This activity will help you reflect on some of the most important "+
        "things in your life by having you list as many things as you can in a certain area.";
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _prompts.Add("What are some of your favorite things?");
        Name = _name;
    } 

    //Gets and sets Name
     public string Name 
    {
        get {return _name; }
        set {_name = value; }
    }

    //Runs Listing Activity    
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        //Gives user instructions and displays a prompt
        Console.WriteLine("\nList as many responses as you can to the following Prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        //Finds how many things the user listed and displays the number
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
        _count = 0;

        DisplayEndingMessage();
        ShowTimesCompleted(_name, ListingActivityIndex);
    }

    //Returns a prompt from _prompts 
    public void GetRandomPrompt()
    {
        Random random = new Random();
        Console.WriteLine($" --- {_prompts[random.Next(_prompts.Count-1)]} --- ");
    }

    //Collects responses from the user and returns them as a list
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        //Loops until the entered time is expired
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine()); //Adds user input into list
            _count++; //counts each entry
        }
        return responses;
    }
}
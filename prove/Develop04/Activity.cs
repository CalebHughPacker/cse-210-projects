using System;
using System.Security.Cryptography.X509Certificates;
public class Activity
{
    //Variables used by the three activities
    protected string _name; 
    protected string _description; 
    protected int _duration; 

    //A list to record how many times the user performed each activity and uses constants to denote the indices [EXCEEDING REQUIREMENTS]
    public const int BreathingActivityIndex = 0;
    public const int ReflectingActivityIndex = 1;
    public const int ListingActivityIndex = 2;
    private List<int> _log = new List<int>{0, 0, 0};

    //Constructor
    public Activity ()
    {
        Log = _log;
    }

    //Get and Set the Log list
    public List<int> Log
    {
        get { return _log; }
        set {_log = value; }
    }

    //Writes a message into the console
    //Called at the beginning of each activity
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);

        //loops until the user enters a valid number
        bool loop = true;
        do
        {
            loop = true;
            Console.Write("\nHow long, in seconds, would you like for your session? ");

            //Error handling in the case the user does not enter an integer
            try
            {
                _duration = int.Parse(Console.ReadLine()); //collect duration from the user
            }

            catch (FormatException)
            {
                Console.WriteLine("Session time must be a number. \nPress ENTER");
                Console.ReadLine();
                Console.Clear();
                loop = false;
            }
          
        } while (!loop);
        
        Console.WriteLine("Get Ready... ");
        ShowSpinner(2);
    }

    //Writes a message into the console
    //Called at the end of each activity
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!");
        ShowSpinner(2);

        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(4);
    }

    //Creates a spinning animation using text characters 
    public void ShowSpinner(int seconds)
    {
        List<string> spin = new List<string>{"|", "/", "—", "\\"}; 

        //loops until the target time is reached
        DateTime startTime = DateTime.Now; 
        DateTime endTime = startTime.AddSeconds(seconds); //takes in the seconds argument to determine how long to show the animation
        while (DateTime.Now < endTime)
        {
            //Parses through the list of strings and displays them in order to create animation
            foreach (string icon in spin)
            {
                Console.Write(icon);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }

    //Creates a countdown animation in the console
    public void ShowCountDown(int seconds)
    {
        //loops until the iterator (starting at the seconds argument) reaches 0
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

     //[EXCEEDING REQUIREMENTS]
     //Displays how many times an activity has been completed during the current session
     //Called after each activity and when the user quits the program
    public void ShowTimesCompleted(string name, int index)
    {
        _log[index]++; //Records the activity completion in the _log list
        
        //removes plural if the user has only completed the activity once
        string s = "s";
        if (_log[index] == 1)
        {
            s = "";
        }

        //Display message
        Console.WriteLine($"You have done the {name} {_log[index]} time{s}!\n(Press ENTER to continue)");
        Console.ReadLine();
    }

}
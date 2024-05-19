using System;

public class BreathingActivity : Activity
{
    //Constructor assigns the activity name and description
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you calm your mind by helping "+
        "you breath in and out slowly. Clear your mind and focus on just your breathing.";
        Name = _name;
    }
    
    //Gets and sets Name
    public string Name 
    {
        get {return _name; }
        set {_name = value; }
    }

    //Runs the Breathing Activity
    public void Run()
    {
        
        
        Console.Clear();
        DisplayStartingMessage();

        //Tells the user to Breath in and out 
        //Loops until the entered time is expired
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)

        {
            Console.Write("\nBreath in... ");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Now breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();
        ShowTimesCompleted(_name, BreathingActivityIndex);
    }
}
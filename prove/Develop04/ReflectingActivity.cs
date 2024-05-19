using System;

public class ReflectingActivity : Activity
{
    //Lists to be filled with various prompts and questions
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    //Constructor assigns the activity name and description and uses the .Add method to populate the _prompts and _questions lists
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life"+
         "when you have shown strength and resilience. This will help you recognize"+ 
         "the power you have and how you can use it in other aspects of your life.";
        _prompts.Add("Think of a time when you felt satisfied with your actions. ");
        _prompts.Add("Think of a time when you were able to overcome a great obstacle. ");
        _prompts.Add("Think of a time when you helped someone else");
        _prompts.Add("Think of a time when you demonstrated maturity");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        Name = _name;
    }

    //Gets and sets Name
    public string Name 
    {
        get {return _name; }
        set {_name = value; }
    }

    //Runs Reflecting Activity
    public void Run()
    {   
        Console.Clear();
        DisplayStartingMessage();

        //Gives the user a prompt and instructions
        Console.WriteLine("\nConsider the following Prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press ENTER to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions and how they are related to this experience. ");
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.Clear();

        //Gives the user various questions to reflect on
        //Loops until the entered time is expired
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(10);
        }
        DisplayEndingMessage();
        ShowTimesCompleted(_name, ReflectingActivityIndex);

    }

    //Returns a prompt from _prompts 
    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count-1)]; 
    }
    
    //Returns a question from _questions
    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count-1)]; 
    }

    //Stylizes a prompt and displays it in the console 
    public void DisplayPrompt()
    {
        Console.WriteLine($"\n --- {GetRandomPrompt()} --- \n");
    }

    //Stylizes a question and displays it in the console 
    public void DisplayQuestions()
    {
        Console.Write($"\n> {GetRandomQuestion()}");
    }
}
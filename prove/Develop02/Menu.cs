using System;

public class Menu 
{
    public Menu ()
    {

    }

    public void DisplayMenu()
    {

         //Give menu options. 
            Console.WriteLine("Please select on of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Custom Prompt");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do: ");
            
            
    }
    public int PromptUser()
    {
        return int.Parse(Console.ReadLine());
    }
}
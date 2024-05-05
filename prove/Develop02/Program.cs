using System;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //initialize objects 
        Menu menu = new Menu();
        Journal journal = new Journal();
        Entry entry = new Entry();
        PromptGenerator promptGenerator = new PromptGenerator();

        int response = 0;
        bool custom = false;
        while (response != 6)
        {
            
            menu.DisplayMenu();
            response = menu.PromptUser();

            //If user picked "WRITE"
            if (response == 1)
            {
                Entry newEntry = new Entry();
                string prompt = promptGenerator.GetRandomPrompt();
                newEntry._promptText = prompt;
                entry._promptText = prompt;
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                newEntry._entryText = input;
                entry._entryText = input;
                journal.AddEntry(newEntry);
            }

            //If user picked "DISPLAY"
            else if (response == 2)
            {
                journal.DisplayAll();
            }
            
            //If user picked "LOAD"
            else if (response == 3)
            {
                Console.Write("What is the file name?: ");
                journal.LoadFromFile(Console.ReadLine());
            }

            //If user picked "SAVE"
            else if (response == 4)
            {
                Console.Write("What is the file name?: ");
                journal.SaveToFile(Console.ReadLine());
            }

            else if (response == 5)
            {
                Console.WriteLine("Enter a prompt you would like to see: ");
                string userPrompt = Console.ReadLine();
                promptGenerator.AddPrompt(userPrompt);
                custom = true;
            }

            //If user picked "QUIT"
            else if (response == 6)
            {

            }

            if (custom)
            {
                Entry newEntry = new Entry();
                string prompt = promptGenerator._prompts[promptGenerator._prompts.Count()-1];
                newEntry._promptText = prompt;
                entry._promptText = prompt;
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                newEntry._entryText = input;
                entry._entryText = input;
                journal.AddEntry(newEntry);
            }

            else 
            {
                Console.WriteLine("Not a Valid Input");
            }
           
        }
    }
}
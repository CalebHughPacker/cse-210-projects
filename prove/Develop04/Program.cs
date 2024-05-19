using System;

class Program
{
    static void Main(string[] args)
    {   
        //Creates instances of each of the three Activity Child Classes
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        //Loops until the user inputs '4' to quit the program
        string userChoice = "";
        while (userChoice != "4")
        {
            
            //Clears screen and displays menu options
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit\n");

            userChoice = Console.ReadLine(); //takes in user input and saves it to userChoice

            //Breathing Activity
            if (userChoice == "1")
            {
                breathingActivity.Run();
                userChoice = "";
            }

            //Reflecting Activity
            else if (userChoice == "2")
            {
                reflectingActivity.Run();
                userChoice = "";
            }
            
            //Listing Activity
            else if (userChoice == "3")
            {   
                listingActivity.Run();
                userChoice = "";
            }

            //Quit Program
            else if (userChoice == "4")
            {
                Console.WriteLine("Thanks for taking the time to be mindful!");
                breathingActivity.ShowSpinner(2);

                // [EXCEEDING REQUIREMENTS]
                //Shows the user how many times they completed each activity during the session
                breathingActivity.ShowTimesCompleted(breathingActivity.Name, Activity.BreathingActivityIndex);
                reflectingActivity.ShowTimesCompleted(reflectingActivity.Name, Activity.ReflectingActivityIndex);
                listingActivity.ShowTimesCompleted(listingActivity.Name, Activity.ListingActivityIndex);
                break;
            }

            //Handles case that the user inputs something other than one of the menu options
            else 
            {
                Console.WriteLine("Not an option. Did you mean to quit?\n(Press ENTER)");
                Console.ReadLine();
            }
        }
    }
}
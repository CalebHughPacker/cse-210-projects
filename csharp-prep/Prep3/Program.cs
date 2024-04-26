using System;

class Program
{
    static void Main(string[] args)
    {
        String again = "";
        do 
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1,11);
            int guess = 0;
            int guessCount = 0;
            again = "";
            do 
            {
                guessCount++;
                Console.Write("What is your guess? ");
                guess =  int.Parse(Console.ReadLine());

                if (guess > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess == magicNum)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Guesses: {guessCount}");
                }
                
                } while (guess != magicNum);
            while (again != "y" && again != "n")
            {
                Console.Write("Do you want to play again? (y/n)");
                again = Console.ReadLine();
                if (again != "y" && again != "n")
                {
                    Console.WriteLine("Please enter 'y' or 'n'");
                }
            }
        } while (again == "y");
    }
}
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number grade: ");
        int userInput = int.Parse(Console.ReadLine());
        String letter = "";
        if (userInput >= 90)
        {
            letter = "A";
        }
        else if (userInput >= 80)
        {
            letter = "B";
        }
        else if (userInput >= 70)
        {
            letter = "C";
        }
        else if (userInput >= 60)
        {
            letter = "D";
        }
        else if (userInput < 60)
        {
            letter = "F";
        }
        else
        {
            letter = "error";
        }

        if (userInput % 10 >= 7 && userInput < 90 && userInput >= 60)
        {
            letter += "+";
        }
        else if (userInput % 10 < 3 && userInput >= 60)
        {
            letter += "-";
        }
        Console.WriteLine(letter);

        if (userInput >= 60)
        {
            Console.WriteLine("Congratulations! You passed");
        }
        else 
        {
            Console.WriteLine("You didn't pass this time. You'll get it next time!");
        }
    }
}
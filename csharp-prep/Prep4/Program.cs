using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [];
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userInput = 1;
        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput == 0)
            {
                break;
            }
            numbers.Add(userInput);
        }

        float sum = 0;
        int largest = -999999999;
        int smallest = 999999999;
        foreach (int num in numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
            if (num < smallest && num > 0)
            {
                smallest = num;
            }
        }

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {sum/numbers.Count}");
        Console.WriteLine($"The largest number is {largest}");
        Console.WriteLine($"The smallest positive number is {smallest}");
        Console.WriteLine($"The sorted list is:");

        numbers.Sort();
        foreach (int nums in numbers)
        {
            Console.WriteLine(nums);
        }

    }
}
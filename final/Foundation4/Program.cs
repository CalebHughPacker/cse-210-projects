using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(30, 3);
        Cycling cycling = new Cycling(60, 12);
        Swimming swimming = new Swimming(20, 14);
        List<Activity> workouts = new List<Activity>{running, cycling, swimming};

        foreach (Activity workout in workouts)
        {
            workout.Record();
            Console.WriteLine(workout.GetSummary());
            Console.WriteLine();
        }
    }
}
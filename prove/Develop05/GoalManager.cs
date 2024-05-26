using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        string userInput;
        do 
        {
            Console.Clear();
            DisplayPlayerInfo(0);
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the Menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1" || userInput.ToLower() == "create new goal")
            {
                Console.Clear();
                CreateGoal();
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
            }

            else if (userInput == "2" || userInput.ToLower() == "list goals")
            {
                Console.Clear();
                ListGoalDetails();
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
            }

            else if (userInput == "3" || userInput.ToLower() == "save goals")
            {
                Console.Clear();
                SaveGoals();
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
            }

            else if (userInput == "4" || userInput.ToLower() == "load goals")
            {
                Console.Clear();
                try
                {
                    LoadGoals();
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not found.");
                }
                ListGoalDetails();
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
            }

            else if (userInput == "5" || userInput.ToLower() == "record event")
            {
                Console.Clear();
                RecordEvent();
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
            }

            else if (userInput == "6" || userInput.ToLower() == "quit")
            {
                break;
            }

            else 
            {
                Console.WriteLine("Not a valid input.\n");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
            }
        } while (userInput != "6");
    }

    private void DisplayPlayerInfo(int points)
    {
        Console.WriteLine($"You have {_score} xp. \n");
        int level = FindLevel(_score);
        if (points == 0)
        {
            //do nothing
        }
        else if (level > FindLevel(points))
        {
            Console.WriteLine("Congratulations! You are now level " + level);
            Console.WriteLine($"Next level in {FindPointsNeeded(level)} xp");
        }
        else
        {
            Console.WriteLine($"You are level {level}. Next level in {FindPointsNeeded(level)} xp");
        }
    }

    private int FindPointsNeeded(int level)
    {
        return (int)Math.Exp(level + 1) - _score ;
    }

    private int FindLevel(int points)
    {
        return (int)Math.Log(points);
    }

    private void ListGoalNames()
    {
        Console.WriteLine("Goals: ");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.Name}");
            i++;
        }
        if (i == 1)
        {
            Console.WriteLine("You don't have any goals!");
        }
    }

    private void ListGoalDetails()
    {
        int i = 1;
       foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString(i));
            i++;
        }
    }

    private void CreateGoal()
    {
        Goal goal;
        string goalType;
        Console.WriteLine("The types of Goals are: ");
        do
        {
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            do 
            {
                goalType = Console.ReadLine();

                if (goalType != "1" && goalType != "2" && goalType != "3" && goalType.ToLower()
                != "simple goal" && goalType.ToLower() != "eternal goal" && goalType.ToLower() != "checklist goal")
                {
                    Console.Write("Not a Valid input.\nSelect a choice from the menu: ");
                }
            } while (goalType != "1" && goalType != "2" && goalType != "3" && goalType.ToLower()
            != "simple goal" && goalType.ToLower() != "eternal goal" && goalType.ToLower() != "checklist goal");

            
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string goalPoints = Console.ReadLine();
            goalPoints = HandleIntInput(goalPoints);

            if (goalType == "1" || goalType.ToLower() == "simple goal")
            {
                goal = new SimpleGoal(goalName, goalDescription, goalPoints);
                _goals.Add(goal);
            }

            else if (goalType == "2" || goalType.ToLower() == "eternal goal")
            {
                goal = new EternalGoal(goalName, goalDescription, goalPoints);
                _goals.Add(goal);
            }

            else if (goalType == "3" || goalType.ToLower() == "checklist goal")
            {
            int goalTarget;
            int goalBonus;
                do 
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    bool targetParsed = int.TryParse(Console.ReadLine(), out goalTarget);
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    bool bonusParsed = int.TryParse(Console.ReadLine(), out goalBonus);

                    if (!targetParsed || !bonusParsed)
                    {
                        Console.WriteLine("Target and Bonus must both be integers");
                    }
                    else
                    {
                        break;
                    }

                } while (true);
                goal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
                _goals.Add(goal);
            }

            else 
            {
                Console.WriteLine("Not a valid input.\n");
            }

        } while (goalType != "1" && goalType != "2" && goalType != "3" && goalType.ToLower()
         != "simple goal" && goalType.ToLower() != "eternal goal" && goalType.ToLower() != "checklist goal");
         
    }

    private void RecordEvent()
    {
        ListGoalNames();

        try 
        {
            Console.Write("Which goal did you accomplish? ");
            string goalAccomplished = Console.ReadLine();
            int goalAccomplishedInt = int.Parse(HandleIntInput(goalAccomplished))-1;
            _score += int.Parse(_goals[goalAccomplishedInt].Points);
            _goals[goalAccomplishedInt].RecordEvent();
            Console.WriteLine($"Congratulations! You earned {_goals[goalAccomplishedInt].Points} points");
            DisplayPlayerInfo(int.Parse(_goals[goalAccomplishedInt].Points));
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Please make sure that you have first created a goal");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Please make sure that you have first created a goal");
        }
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        File.Create(filename).Dispose();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

    }

    private void LoadGoals()
    {
        const int NameIndex = 0;
        const int DescriptionIndex = 1;
        const int PointsIndex = 2;
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            
            if (line.Contains(":"))
            {
                _score = int.Parse(File.ReadLines(filename).First());
                string[] objects = line.Split(":");
                string[] parts = objects[1].Split(",");
                string goalType = objects[0].Trim();
                if (goalType == "SimpleGoal")
                {
                    SimpleGoal goal = new SimpleGoal(parts[NameIndex].Trim(), parts[DescriptionIndex].Trim(), parts[PointsIndex].Trim());
                    goal.IsCompleted = bool.Parse(parts[3].Trim());
                    _goals.Add(goal); 
                } 

                else if (goalType == "EternalGoal")
                {
                    Goal goal = new EternalGoal(parts[NameIndex].Trim(), parts[DescriptionIndex].Trim(), parts[PointsIndex].Trim());
                    _goals.Add(goal); 
                } 

                else if (goalType == "ChecklistGoal")
                {
                    ChecklistGoal goal = new ChecklistGoal(parts[NameIndex].Trim(), parts[DescriptionIndex].Trim(), parts[PointsIndex].Trim(), int.Parse(parts[3].Trim()), int.Parse(parts[4].Trim()));
                    goal.AmountCompleted = int.Parse(parts[5].Trim());
                    _goals.Add(goal);
                }
            }
        }
    }

    private string HandleIntInput(string userInput)
    {
        do 
        {
            bool inputParsed = int.TryParse(userInput, out _);

            if (!inputParsed)
            {
                Console.WriteLine("Entry must be an integer");
                userInput = Console.ReadLine();
            }
            else
            {
                return userInput;
            }

        } while (true);
    }
}
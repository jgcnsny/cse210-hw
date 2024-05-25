using System;
using System.Linq.Expressions;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string  choice = " ";

        do
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                CreateGoal();
            }
            else if(choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if(choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid Choice. Try Again!");
            }
        }
        while (choice!="6");
    
    }

    public void DisplayPlayerInfo()
    {
       Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            string status;
            if (_goals[i].isComplete())
            {
                status = "[X]";
            }
            else
            {
                status = "[ ]";
            }

            Console.WriteLine($"{i + 1}.{status} {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        string type = " ";
        while(true)
        {
            
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goals");

            Console.Write("Which type of goal would you like to create? ");
            type = Console.ReadLine();
            if (type == "1" || type == "2" || type == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Choice. Try Again!");
            }
        }
        
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if(type == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name,description,points);
            _goals.Add(simpleGoal);
        }
        else if(type == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name,description,points);
            _goals.Add(eternalGoal);
        }
        else if(type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            CheckListGoals checklistGoals = new CheckListGoals(name,description,points,target,bonus);
            _goals.Add(checklistGoals);
        }
        else
        {
            Console.WriteLine("Invalid Choice. Try Again!");
        }
    }

    public void RecordEvent()
    {
        
        Console.WriteLine("The goals are:");
        ListGoalNames();

        Console.WriteLine("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            int pointsGained = _goals[choice].RecordEvent();
            _score += pointsGained;
            Console.WriteLine($"Congratulations! You have earned {pointsGained} points");
            Console.WriteLine($"You now have {_score} points");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    
        
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter goalFile = new StreamWriter(filename))
        {
            goalFile.WriteLine($"{_score}");
            for (int i = 0; i < _goals.Count; i++)
            {
                goalFile.WriteLine($"{_goals[i].GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        

        using (StreamReader loadGoal = new StreamReader(filename))
        {
            string line;
            int score = 0;
            bool firstLine = true;
            
            while ((line = loadGoal.ReadLine()) != null)
            {
                var goalParts = line.Split("|");

                if (firstLine) // Process initial score
                {
                    score = int.Parse(goalParts[0]);
                    firstLine = false;
                    continue;
                }
                _score = score;
                
                if(goalParts[0]=="SimpleGoal")
                {
                    
                    string name = goalParts[1];
                    string description = goalParts[2];
                    int points = int.Parse(goalParts[3]);
                    bool isComplete = bool.Parse(goalParts[4]);


                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    if(isComplete)
                    {
                        simpleGoal.RecordEvent();
                    }
                    _goals.Add(simpleGoal);
                    
                }
                else if(goalParts[0] == "EternalGoal")
                {
                    string name = goalParts[1];
                    string description = goalParts[2];
                    int points = int.Parse(goalParts[3]);

                    EternalGoal eternalGoal = new EternalGoal(name, description,points);
                    _goals.Add(eternalGoal);
                }
                else if(goalParts[0] == "ChecklistGoal")
                {
                    string name = goalParts[1];
                    string description = goalParts[2];
                    int points = int.Parse(goalParts[3]);
                    int target = int.Parse(goalParts[4]);
                    int bonus = int.Parse(goalParts[5]);
                    int amountCompleted = int.Parse(goalParts[6]);

                    CheckListGoals checkListGoals = new CheckListGoals(name, description, points, target,bonus);
                    for(int i = 0; i < amountCompleted; i++)
                    {
                        checkListGoals.RecordEvent();
                    }
                    _goals.Add(checkListGoals);
        
                }
            
            }
        }
    }
}

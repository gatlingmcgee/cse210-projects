using System;

// A class for the main program
class Program
{
    // A public static variable to store the user's score
    public static int score;

    // A private static variable to store the list of goals
    private static List<Goal> goals;

    // A private static variable to store the file name for saving and loading
    private static string fileName = "goals.txt";

    // The main method
    static void Main(string[] args)
    {
        // Initialize the score and the goals
        score = 0;
        goals = new List<Goal>();

        // Display a welcome message
        Console.WriteLine("Welcome to the Goal Tracker Program!");

        // Display the menu and prompt the user for an option
        DisplayMenu();
        Console.Write("Enter an option: ");
        string option = Console.ReadLine();

        // Loop until the user enters Q to quit
        while (option.ToUpper() != "Q")
        {
            // Perform different actions based on the option
            switch (option.ToUpper())
            {
                case "A":
                    // Add a new goal
                    AddGoal();
                    break;
                case "R":
                    // Record an event for a goal
                    RecordEvent();
                    break;
                case "S":
                    // Show the list of goals and the score
                    ShowGoals();
                    break;
                case "L":
                    // Load the goals and the score from a file
                    LoadGoals();
                    break;
                case "W":
                    // Save the goals and the score to a file
                    SaveGoals();
                    break;
                default:
                    // Display an invalid option message
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            // Display the menu and prompt the user for another option
            DisplayMenu();
            Console.Write("Enter an option: ");
            option = Console.ReadLine();
        }

        // Display a goodbye message
        Console.WriteLine("Thank you for using the Goal Tracker Program!");
    }

    // A method to display the menu
    static void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("A - Add a new goal");
        Console.WriteLine("R - Record an event for a goal");
        Console.WriteLine("S - Show the list of goals and the score");
        Console.WriteLine("L - Load the goals and the score from a file");
        Console.WriteLine("W - Save the goals and the score to a file");
        Console.WriteLine("Q - Quit the program");
    }

    // A method to add a new goal
    static void AddGoal()
    {
        // Prompt the user for the type of the goal
        Console.WriteLine("What type of goal do you want to add?");
        Console.WriteLine("1 - Simple goal");
        Console.WriteLine("2 - Eternal goal");
        Console.WriteLine("3 - Checklist goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        // Prompt the user for the name and points of the goal
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        // Create a new goal object based on the type
        Goal goal = null;
        switch (choice)
        {
            case "1":
                // Create a simple goal object
                goal = new SimpleGoal(name, points);
                break;
            case "2":
                // Create an eternal goal object
                goal = new EternalGoal(name, points);
                break;
            case "3":
                // Prompt the user for the target and bonus of the goal
                Console.Write("Enter the target number of times to complete the goal: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing the goal: ");
                int bonus = int.Parse(Console.ReadLine());

                // Create a checklist goal object
                goal = new ChecklistGoal(name, points, target, bonus);
                break;
            default:
                // Display an invalid choice message
                Console.WriteLine("Invalid choice. No goal added.");
                return;
        }

        // Add the goal object to the list of goals
        goals.Add(goal);

        // Display a confirmation message
        Console.WriteLine("Goal added successfully.");
    }

    // A method to record an event for a goal
    static void RecordEvent()
    {
        // Prompt the user for the index of the goal
        Console.Write("Enter the index of the goal (starting from 1): ");
        int index = int.Parse(Console.ReadLine());

        // Check if the index is valid
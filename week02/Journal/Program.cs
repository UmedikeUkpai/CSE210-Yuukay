using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        // Create the PromptGenerator instance
        PromptGenerator promptGenerator = new PromptGenerator();

        // Adding prompts using a method instead of direct field access
        promptGenerator.AddPrompt("What is one thing you accomplished today that you’re proud of?");
        promptGenerator.AddPrompt("Did you experience any moments of joy or gratitude today? What were they?");
        promptGenerator.AddPrompt("What was the most challenging part of your day, and how did you handle it?");
        promptGenerator.AddPrompt("What is something you learned or realized today that you didn't know before?");
        promptGenerator.AddPrompt("If you could restart your days, at what point would you hit the restart button and why?");
        promptGenerator.AddPrompt("What are three things you want to focus on or improve tomorrow based on the experience you had today?");
        promptGenerator.AddPrompt("What is one small goal you want to achieve tomorrow?");
        promptGenerator.AddPrompt("How do you want to feel at the end of tomorrow, and what can you do to make that happen?");
        promptGenerator.AddPrompt("What is one thing you can do tomorrow to take care of yourself?");
        promptGenerator.AddPrompt("What experience would you like to recreate from today?");

        Journal myJournal = new Journal(promptGenerator);

        while (true)
        {
            Console.WriteLine("\nPlease select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out int choice))
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
                continue;
            }

            if (choice == 1)
            {
                myJournal.AddEntry();
            }
            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                myJournal.LoadFromFile();
                myJournal.DisplayAll();
            }
            else if (choice == 4)
            {
                myJournal.SaveToFile();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye! Have a Lovely day!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please select a number between 1 and 5.");
            }
        }
    }
}
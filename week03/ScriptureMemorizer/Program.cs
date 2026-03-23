
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // List of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Jeremiah", 29, 11), "For I know the plans I have for you,” declares the LORD, “plans to prosper you and not to harm you, plans to give you hope and a future."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Micah", 6, 8), "He has shown you, O man, what is good; and what does the Lord require of you but to do justice, and to love kindness, and to walk humbly with your God?"),
            new Scripture(new Reference("Psalm", 119, 105), "Your word is a lamp to my feet and a light to my path."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Romans", 8, 35), "Who shall separate us from the love of Christ? Shall tribulation, or distress, or persecution, or famine, or nakedness, or danger, or sword?")
        };

        // Randomly select a scripture
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear(); // Clear the console screen
            Console.WriteLine(scripture.GetDisplayText()); // Display the scripture
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit")
                break;

            scripture.HideRandomWord(2); // Hide 2 random words

            if (scripture.isCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Memorization complete!");
                break;
            }
        }
    }
}
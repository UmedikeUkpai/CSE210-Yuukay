using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
    
        Assignment Ass = new Assignment("Lionel Richie", "Multiplication");
        Console.WriteLine(Ass.GetSummary());
        Console.WriteLine();

        MathAssignment Math = new MathAssignment("Lucious Lion","Fractions","7.3","8-19");
        Console.WriteLine(Math.GetSummary());
        Console.WriteLine(Math.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment("Arthur Pendragon","European History", "The French Revolution (1789–1799)");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int percent = int.Parse(response);

        string letter = "";

        if (percent >= 90) 
        {
            //Console.WriteLine("You scored an A");
            letter = "A";
        }
        else if (percent >= 80)
        {
            //Console.WriteLine("You scored a B");
            letter = "B";
        }
        else if (percent >= 70)
        {
            //Console.WriteLine("You scored a C");
            letter = "C";
        }
        else if (percent >= 60)
        {
            //Console.WriteLine("You scored a D");
            letter = "D";
        }
        else
        {
            //Console.WriteLine("You scored an F");
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("Try harder next time!");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string answer = Console.ReadLine();
        int gradePercentage = int.Parse(answer);
        string letter = "";
        string sign = "";

         // Determine the letter grade based on the grade percentage
        if ( gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Check if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with a {letter}.");
        }
        else
        {
            Console.WriteLine($"Keep working hard for next time! Your grade is {letter}.");
        }

        // Determine the sign (+, -, or none) based on the last digit of the percentage
        int lastDigit = (int)(gradePercentage % 10);

        if (lastDigit >= 7 && letter != "F")
        {
            sign = "+";
        }
        else if (lastDigit < 3 && letter != "A" && letter != "F")
        {
            sign = "-";
        }

        // Display the grade letter and sign
        if (letter == "A" && sign == "+")
        {
            Console.WriteLine("A+");
        }
        else if (letter == "F" && sign == "-")
        {
            Console.WriteLine("F-");
        }
        else if (letter == "F")
        {
            Console.WriteLine("F");
        }
        else
        {
            Console.WriteLine($"{letter}{sign}");
        }
    }
}
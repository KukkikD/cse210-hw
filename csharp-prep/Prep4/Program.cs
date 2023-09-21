using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the entered numbers
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input != 0)
                {
                    // Add the entered number to the list
                    numbers.Add(input);
                }
                else
                {
                    // Break the loop when the user enters 0
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (true);

        if (numbers.Count > 0)
        {
            // Calculate the sum of the numbers using LINQ's Sum method
            int sum = numbers.Sum();

            // Calculate the average of the numbers using LINQ's Average method
            double average = numbers.Average();

            // Find the maximum number using LINQ's Max method
            int max = numbers.Max();

            // Find the smallest positive number
            // We use LINQ's Where to filter positive numbers,
            // DefaultIfEmpty to handle the case where no positive numbers are present,
            // and Min to find the smallest positive number.
            int smallestPositive = numbers.Where(x => x > 0).DefaultIfEmpty(int.MaxValue).Min();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            Console.WriteLine("The sorted list is:");

            // Sort and display the list of numbers
            numbers.Sort();

            // Display the sorted list
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}

using System;

class Program

    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Random randomGenerator = new Random();
                int magicNumber = randomGenerator.Next(1, 101);
                int guess = -1;
                int numberOfGuesses = 0;

                Console.WriteLine("Welcome to Guess My Number!");
                Console.WriteLine("I'm thinking of a number between 1 and 100.");

                while (guess != magicNumber)
                {
                    Console.Write("What is your guess? ");
                    if (int.TryParse(Console.ReadLine(), out guess))
                    {
                        numberOfGuesses++;

                        if (magicNumber > guess)
                        {
                            Console.WriteLine("Higher");
                        }
                        else if (magicNumber < guess)
                        {
                            Console.WriteLine("Lower");
                        }
                        else
                        {
                            Console.WriteLine("You guessed it!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }

                Console.WriteLine($"It took you {numberOfGuesses} guesses.");
                Console.Write("Do you want to play again? (yes/no): ");
                string playAgainResponse = Console.ReadLine().ToLower();
                playAgain = (playAgainResponse == "yes");
            }
        }
    }

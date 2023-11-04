using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

// Reflection Activity class
class ReflectionActivity : Activity
{
    
    private string[] prompts = {
        "-- Think of a time when you stood up for someone else. --",
        "-- Think of a time when you did something really difficult. --",
        "-- Think of a time when you helped someone in need. --",
        "-- Think of a time when you did something truly selfless. --"
    };

    private string[] questions = {
        "> Why was this experience meaningful to you?",
        "> Have you ever done anything like this before?",
        "> How did you get started?",
        "> How did you feel when it was complete?",
        "> What made this time different than other times when you were not as successful?",
        "> What is your favorite thing about this experience?",
        "> What could you learn from this experience that applies to other situations?",
        "> What did you learn about yourself through this experience?",
        "> How can you keep this experience in mind in the future?"
    };

    

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public override void StartActivity(int duration)
    {
    
        Random random = new Random();
        
            // Randomly select a prompt
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine("Consider the following propt:");
            Console.WriteLine(prompt);
            Console.WriteLine("When you have something in mind, press enter to continue");
            Console.ReadLine(); // Wait for user input

            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            
            // Countdown before questions
            Console.Write("You may begin in  ");
            for (int j = 4; j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b \b \b");
            }

            Console.WriteLine();

        for (int i = 0; i < duration; i++)
        {    
            
            // Randomly select a question
            string firstQuestion = questions[random.Next(questions.Length)];
            Console.WriteLine(firstQuestion);
            
            List<String> animationStrings = new List<String>(1);
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("-");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("-");
            // Display the spinner animation
                foreach (String S in animationStrings)
            {
                Console.Write(S);
                Thread.Sleep(1000); 
                Console.Write("\b \b \b \b");
            }     
        }
    }
}
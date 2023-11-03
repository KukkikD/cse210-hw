using System;
using System.Threading;

// Breathing Activity class
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.")
    {
     }

    public override void StartActivity(int duration)
    {
        for (int i = duration; i > 0; --i)
        {
            Console.Write("Breathe in ");
           
            // Countdown for "Breathe in"
            for (int j = 5; j > 0; --j)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b  \b");
            }
            
            Console.WriteLine();
            Console.Write("Breathe out ");

            
            // Countdown for "Breathe out"
            for (int k = 5; k > 0; --k)
            {
                
                Console.Write(k);
                Thread.Sleep(1000);
                Console.Write("\b  \b");
            }
                Console.WriteLine();
        }
    }
}
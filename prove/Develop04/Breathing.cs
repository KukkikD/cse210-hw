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

            // Stretch Challenge #2 : Emoji-based animation for breathing in
            List<String> animationBreathIn = new List<string>(1);
            {
                animationBreathIn.Add ("(-^-) 5" );
                animationBreathIn.Add ("(^-^) 4" );
                animationBreathIn.Add ("(-^-) 3" );
                animationBreathIn.Add ("(^-^) 2" );
                animationBreathIn.Add ("(-^-)  " );
            }

                     
            
            // Countdown and animation for "Breathe in" on the same line
            foreach(String S in animationBreathIn)
            {
            
            Console.Write(S);
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b");
            }
            
        
        
            Console.WriteLine();
            Console.Write("Breathe out ");

            List<String> animationBreathOut = new List<string>(1);
            {
                animationBreathOut.Add ("(^-^) 5" );
                animationBreathOut.Add ("(-^-) 4" );
                animationBreathOut.Add ("(^-^) 3" );
                animationBreathOut.Add ("(-^-) 2" );
                animationBreathOut.Add ("(^-^)  " );
            }

            // Countdown and animation for "Breathe in" on the same line
            foreach(String S in animationBreathOut)
            {
            
            Console.Write(S);
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b");
            }

            Console.WriteLine();
        }
    }
}
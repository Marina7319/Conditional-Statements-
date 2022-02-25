using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            double time = double.Parse(Console.ReadLine());
            double rest = double.Parse(Console.ReadLine());
            double lunchTime = rest * 0.125;
            double sleep = rest * 0.25;
            double timeleft = rest - lunchTime - sleep;
            if (timeleft >= time)
            {
                double timeTotal = timeleft - time;
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeTotal)} minutes free time.");
            }
            else
            {
                double timeTotal = time - timeleft ;
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeTotal)} more minutes.");
            }
        }
    }
}

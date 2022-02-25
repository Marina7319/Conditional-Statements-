using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int fisherMen = int.Parse(Console.ReadLine());
            double disscount = 0;
            if (text == "Spring")
            {
                if (fisherMen <= 6)
                {
                    disscount = 3000 - 3000 * 0.1;
                    if (fisherMen % 2 == 0)
                    {
                        disscount = disscount - disscount * 0.05;
                    }
                }
                if (fisherMen >= 7 && fisherMen <= 11)
                {
                    disscount = 3000- 3000 * 0.15;
                    if (fisherMen % 2 == 0)
                    {
                        disscount = disscount - disscount * 0.05;
                    }
                }
                if (fisherMen >= 12)
                {
                    disscount = 3000 - 3000 * 0.25;
                    if (fisherMen % 2 == 0)
                    {
                        disscount = disscount - disscount * 0.05;
                    }
                }
            }
            if (text == "Summer" || text == "Autumn")
            {
                if (fisherMen <= 6)
                {
                    disscount = 4200 - 4200 * 0.1;
                    if (fisherMen % 2 == 0 && text != "Autumn")
                    {
                        disscount = disscount - disscount * 0.05;
                    }
                }
                if (fisherMen >= 7 && fisherMen <= 11)
                {
                    disscount = 4200 - 4200 * 0.15;
                    if (fisherMen % 2 == 0 && text != "Autumn")
                    {
                        disscount = disscount - disscount * 0.05;
                    }
                }
                if (fisherMen >= 12)
                {
                    disscount = 4200 - 4200 * 0.25;
                    if (fisherMen % 2 == 0 && text != "Autumn")
                    {
                        disscount = disscount - disscount * 0.05;
                    }
                }
            }
            if (text == "Winter")
            {
                if (fisherMen <= 6)
                {
                    disscount = 2600 - 2600 * 0.1;
                    if (fisherMen % 2 == 0)
                    {
                        disscount = disscount - disscount * 0.05;
                    }
                }
                if (fisherMen >= 7 && fisherMen <= 11)
                {
                    disscount = 2600 - 2600 * 0.15;
                    if (fisherMen % 2 == 0)
                    {
                        disscount = disscount - disscount * 0.05;
                    }
                }
                if (fisherMen >= 12)
                {
                    disscount = 2600 - 2600 * 0.25;
                    if (fisherMen % 2 == 0)
                    {
                        disscount = disscount - disscount * 0.05;
                    }
                }
            }
            if (budget >= disscount)
            {
                double left = budget - disscount;
                Console.WriteLine($"Yes! You have {left:f2} leva left.");
            }
            else
            {
                double need = disscount - budget;
                Console.WriteLine($"Not enough money! You need {need:f2} leva.");
            }
        }
    }
}

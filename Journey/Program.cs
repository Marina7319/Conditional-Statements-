using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = "";
            string sleeping = "";
            if(budget <= 100)
            {
                if (season == "summer")
                {
                    place = "Bulgaria";
                    double price = budget - budget * 0.7;
                    sleeping = "Camp - " + Math.Round(price, 2);
                }
                if (season == "winter")
                {
                    place = "Bulgaria";
                    double price =budget - budget * 0.3;
                    sleeping = "Hotel - " + Math.Round(price, 2);
                }
             }
            if (budget >100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    place = "Balkans";
                    double price = budget -budget * 0.6;
                    sleeping = "Camp - " + Math.Round(price, 2);
                }
                if (season == "winter")
                {
                    place = "Balkans";
                    double price = budget - budget * 0.2;
                    sleeping = "Camp - " + Math.Round(price, 2);
                }
            }
            if (budget > 1000)
            {
                if (season == "summer")
                {
                    place = "Europe";
                    double price =budget - budget * 0.1;
                    sleeping = "Hotel - " + Math.Round(price, 2);
                }
            }
            Console.WriteLine("Somewhere in "+place);
            Console.WriteLine(sleeping);
        }
    }
}

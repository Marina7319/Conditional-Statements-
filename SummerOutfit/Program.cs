using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            if (10 <= celsius && celsius <= 18)
            {
                if (text == "Morning")
                {
                    string outfit = "Sweatshirt";
                    string shoes = "Sneakers";
                    Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                }
                if (text == "Afternoon")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                }
                if (text == "Evening")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                }
            }
            if (18 < celsius && celsius <= 24)
            {
                if (text == "Morning")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                }
                if (text == "Afternoon")
                {
                    string outfit = "T-Shirt";
                    string shoes = "Sandals";
                    Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                }
                if (text == "Evening")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                }
            }
            if (celsius >= 25)
            {
                if (text == "Morning")
                {
                    string outfit = "T-Shirt";
                    string shoes = "Sandals";
                    Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                }
                if (text == "Afternoon")
                {
                    string outfit = "Swim Suit";
                    string shoes = "Barefoot";
                    Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                }
                if (text == "Evening")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
                }
            }
        }
    }
}

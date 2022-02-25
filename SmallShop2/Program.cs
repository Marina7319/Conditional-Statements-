using System;

namespace SmallShop2
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            switch (city)
            {
                case "Sofia":
                    if (product == "coffee")
                    {
                        double price = 0.5;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (product == "water")
                    {
                        double price = 0.8;
                        double sum = price * quantity;
                        Console.WriteLine($"{sum:f1}");
                    }
                    if (product == "beer")
                    {
                        double price = 1.2;
                        double sum = price * quantity;
                        Console.WriteLine($"{sum:f1}");
                    }
                    if (product == "sweets")
                    {
                        double price = 1.45;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (product == "peanuts")
                    {
                        double price = 1.6;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    break;
                case "Plovdiv":
                    if (product == "coffee")
                    {
                        double price = 0.4;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (product == "water")
                    {
                        double price = 0.7;
                        double sum = price * quantity;
                        Console.WriteLine($"{sum:f1}");
                    }
                    if (product == "beer")
                    {
                        double price = 1.15;
                        double sum = price * quantity;
                        Console.WriteLine($"{sum:f1}");
                    }
                    if (product == "sweets")
                    {
                        double price = 1.3;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (product == "peanuts")
                    {
                        double price = 1.5;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    break;
                case "Varna":
                    if (product == "coffee")
                    {
                        double price = 0.45;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (product == "water")
                    {
                        double price = 0.7;
                        double sum = price * quantity;
                        Console.WriteLine($"{sum:f1}");
                    }
                    if (product == "beer")
                    {
                        double price = 1.1;
                        double sum = price * quantity;
                        Console.WriteLine($"{sum:f1}");//1.1x6=6.6
                    }
                    if (product == "sweets")
                    {
                        double price = 1.35;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (product == "peanuts")
                    {
                        double price = 1.55;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    break;
            }
        }
    }
}

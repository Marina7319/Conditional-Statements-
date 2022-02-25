using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());
            switch (city)
            {
                case "Sofia":
                    if (0 <= num && num <= 500)
                    {
                        double percent = 0.05;
                        double formula = percent * num;
                        Console.WriteLine($"{formula:f2}");
                    }
                    if (500 < num && num <= 1000)
                    {
                        double percent = 0.07;
                        double formula = percent * num;
                        Console.WriteLine($"{formula:f2}");
                    }
                    if (1000 < num && num <= 10000)
                    {
                        double percent = 0.08;
                        double formula = percent * num;
                        Console.WriteLine($"{formula:f2}");
                    }
                    if (num > 10000)
                    {
                        double percent = 0.12;
                        double formula = percent * num;
                        Console.WriteLine($"{formula:f2}");
                    }
                    else if (num < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (0 <= num && num <= 500)
                    {
                        double percent = 0.045;
                        double formula = percent * num;
                        Console.WriteLine($"{formula:f2}");
                    }
                    if (500 < num && num <= 1000)
                    {
                        double percent = 0.075;
                        double formula = percent * num;
                        Console.WriteLine($"{formula:f2}");
                    }
                    if (1000 < num && num <= 10000)
                    {
                        double percent = 0.1;
                        double formula = percent * num;
                        Console.WriteLine($"{formula:f2}");
                    }
                    if (num > 10000)
                    {
                        double percent = 0.13;
                        double formula = percent * num;
                        Console.WriteLine($"{formula:f2}");
                    }
                    else if (num < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (0 <= num && num <= 500)
                    {
                        double percent = 0.055;
                        double formula = percent * num;
                        Console.WriteLine($"{formula:f2}");
                    }
                    if (500 < num && num <= 1000)
                    {
                        double percent = 0.08;
                        double formula = percent * num;
                        Console.WriteLine($"{formula:f2}");
                    }
                    if (1000 < num && num <= 10000)
                    {
                        double percent = 0.12;
                        double formula = percent * num;
                        Console.WriteLine($"{formula:f2}");
                    }
                    if (num > 10000)
                    {
                        double percent = 0.145;
                        double formula = percent * num;
                        Console.WriteLine($"{formula:f2}");
                    }
                    else if (num < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}

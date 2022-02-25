using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            switch (product)
            {
                case "coffee":
                    if (city == "Sofia")
                    {
                        double price = 0.5;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (city == "Plovdiv")
                    {
                        double price = 0.4;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (city == "Varna")
                    {
                        double price = 0.45;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    break;
                case "water":
                    if (city == "Sofia")
                    {
                        double price = 0.8;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (city == "Plovdiv")
                    {
                        double price = 0.7;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (city == "Varna")
                    {
                        double price = 0.7;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    break;
                case "beer":
                    if (city == "Sofia")
                    {
                        double price = 1.2;
                        double sum = quantity * price;
                        Console.WriteLine(sum);
                    }
                    if (city == "Plovdiv")
                    {
                        double price = 1.15;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (city == "Varna")
                    {
                        double price = 1.1;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    break;
                case "sweets":
                    if (city == "Sofia")
                    {
                        double price = 1.45;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (city == "Plovdiv")
                    {
                        double price = 1.3;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (city == "Varna")
                    {
                        double price = 1.35;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    break;
                case "peanuts":
                    if (city == "Sofia")
                    {
                        double price = 1.6;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (city == "Plovdiv")
                    {
                        double price = 1.5;
                        double sum = price * quantity;
                        Console.WriteLine(sum);
                    }
                    if (city == "Varna")
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
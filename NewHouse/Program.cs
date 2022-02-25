using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            switch (flowers)
            {
                case "Roses":
                    if (flowersCount > 80)
                    {
                        double endPrice = (flowersCount * 5) - (flowersCount * 5)*0.1;
                        if (budget >= endPrice)
                        {
                            double sumLeft = budget - endPrice;
                            Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {sumLeft:f2} leva left.");
                        }
                        else
                        {
                            double sumNeed = endPrice - budget;
                            Console.WriteLine($"Not enough money, you need {sumNeed:f2} leva more.");
                        }
                    }
                    else
                    {
                        double endPrice = flowersCount * 5;
                        if (budget >= endPrice)
                        {
                            double sumLeft = budget - endPrice;
                            Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {sumLeft:f2} leva left.");
                        }
                        else
                        {
                            double sumNeed = endPrice - budget;
                            Console.WriteLine($"Not enough money, you need {sumNeed:f2} leva more.");
                        }
                    }
                    break;
                case "Daglias":
                    if (flowersCount > 90)
                    {
                        double endPrice = flowersCount * 3.8 - (flowersCount * 3.8)*0.15;
                        if (budget >= endPrice)
                        {
                            double sumLeft = budget - endPrice;
                            Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {sumLeft:f2} leva left.");
                        }
                        else
                        {
                            double sumNeed = endPrice - budget;
                            Console.WriteLine($"Not enough money, you need {sumNeed:f2} leva more.");
                        }
                    }
                    else
                    {
                        double endPrice = flowersCount * 3.8;
                        if (budget >= endPrice)
                        {
                            double sumLeft = budget - endPrice;
                            Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {sumLeft:f2} leva left.");
                        }
                        else
                        {
                            double sumNeed = endPrice - budget;
                            Console.WriteLine($"Not enough money, you need {sumNeed:f2} leva more.");
                        }
                    }
                    break;
                case "Tulips":
                    if (flowersCount > 90)
                    {
                        double endPrice = flowersCount * 2.8;
                        double disscount = endPrice * 0.15;
                        double sumPrice = endPrice - disscount;
                        if (budget >= sumPrice)
                        {
                            double sumLeft = budget - sumPrice;
                            Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {sumLeft:f2} leva left.");
                        }
                        else
                        {
                            double sumNeed = sumPrice - budget;
                            Console.WriteLine($"Not enough money, you need {sumNeed:f2} leva more.");
                        }
                    }
                    else
                    {
                        double endPrice = flowersCount * 2.8;
                        if (budget >= endPrice)
                        {
                            double sumLeft = budget - endPrice;
                            Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {sumLeft:f2} leva left.");
                        }
                        else
                        {
                            double sumNeed = endPrice - budget;
                            Console.WriteLine($"Not enough money, you need {sumNeed:f2} leva more.");
                        }
                    }
                    break;
                case "Narcissus":
                    if (flowersCount >= 120)
                    {
                        double endPrice = flowersCount * 3 + (flowersCount * 3)*0.15;
                        if (budget >= endPrice)
                        {
                            double sumLeft = budget - endPrice;
                            Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {sumLeft:f2} leva left.");
                        }
                        else
                        {
                            double sumNeed = endPrice - budget;
                            Console.WriteLine($"Not enough money, you need {sumNeed:f2} leva more.");
                        }
                    }
                    else
                    {
                        double endPrice = flowersCount * 3;
                        if (budget >= endPrice)
                        {
                            double sumLeft = budget - endPrice;
                            Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {sumLeft:f2} leva left.");
                        }
                        else
                        {
                            double sumNeed = endPrice - budget;
                            Console.WriteLine($"Not enough money, you need {sumNeed:f2} leva more.");
                        }
                    }
                    break;
                case "Gladiolus":
                    if (flowersCount > 80)
                    {
                        double endPrice = flowersCount * 2.5 + (flowersCount * 2.5)*0.2;

                        if (budget >= endPrice)
                        {
                            double sumLeft = budget - endPrice;
                            Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {sumLeft:f2} leva left.");
                        }
                        else
                        {
                            double sumNeed = endPrice - budget;
                            Console.WriteLine($"Not enough money, you need {sumNeed:f2} leva more.");
                        }
                    }
                    else
                    {
                        double endPrice = flowersCount * 2.5;

                        if (budget >= endPrice)
                        {
                            double sumLeft = budget - endPrice;
                            Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {sumLeft:f2} leva left.");
                        }
                        else
                        {
                            double sumNeed = endPrice - budget;
                            Console.WriteLine($"Not enough money, you need {sumNeed:f2} leva more.");
                        }
                    }
                    break;
            }
        }
    }
}

using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetMovie = double.Parse(Console.ReadLine());
            double actors = double.Parse(Console.ReadLine());
            double actorsClothes = double.Parse(Console.ReadLine());
            double furniture = budgetMovie * 10 / 100;
            if (actors > 150)
            {
                double disscountOnClothes = actorsClothes - actorsClothes * 10 / 100;
                double totalSum = actors * disscountOnClothes + furniture;
                if (totalSum > budgetMovie)
                {
                    Console.WriteLine("Not enough money!");
                    double moneyMovie = totalSum - budgetMovie;
                    Console.WriteLine($"Wingard needs {moneyMovie:f2} leva more.");
                }
                else
                {
                    double restMoney = budgetMovie - totalSum;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {restMoney:f2} leva left.");
                }
            }
            else
            {
                double totalSum = actors * actorsClothes + furniture;
                if (totalSum > budgetMovie)
                {

                    Console.WriteLine("Not enough money!");
                    double moneyMovie = totalSum - budgetMovie;
                    Console.WriteLine($"Wingard needs {moneyMovie:f2} leva more.");
                }
                else
                {
                    double restMoney = budgetMovie - totalSum;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {restMoney:f2} leva left.");
                }
            }
        }
    }
}

using System;

namespace FishingBoatSolutionTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            switch (season)
            {
                case "Summer":
                    if (fishermans <= 6 && fishermans % 2 == 0)
                    {
                        double discount = 4200 - 4200 * 0.1 - 4200 * 0.5;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:F2} leva left.");
                        }
                        else
                        {
                            double result = discount - budget;
                            Console.WriteLine($"Not enough money! You need {result:F2} leva.");
                        }
                    }
                    else if (fishermans <= 6)
                    {
                        double discount = 4200 - 4200 * 0.1;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:F2} leva left.");
                        }
                        else
                        {
                            double result = discount - budget;
                            Console.WriteLine($"Not enough money! You need {result:F2} leva.");
                        }
                    }
                    if (fishermans > 7 && fishermans <= 11 && fishermans % 2 == 0)
                    {
                        double discount = 4200 - 4200 * 0.15 - 4200 * 0.5;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:F2} leva left.");
                        }
                        else
                        {
                            double result = discount -budget;
                            Console.WriteLine($"Not enough money! You need {result:F2} leva.");
                        }

                    }
                    else if (fishermans > 7 && fishermans <= 11)
                    {
                        double discount = 4200 - 4200 * 0.15;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = discount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }

                    }
                    if (fishermans > 12 && fishermans % 2 == 0)
                    {
                        double disscount = 4200 - 4200 * 0.25 - 4200 * 0.5;
                        if (disscount <= budget)
                        {
                            double result = budget - disscount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = disscount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }
                    }
                    else if (fishermans > 12)
                    {
                        double disscount = 4200 - 4200 * 0.25;
                        if (disscount <= budget)
                        {
                            double result = budget - disscount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = disscount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }
                    }
                    break;
                case "Autumn":
                   
                     if (fishermans <= 6)
                    {
                        double discount = 4200 - 4200 * 0.1;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = discount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }
                    }
                    else if (fishermans > 7 && fishermans <= 11)
                    {
                        double discount = 4200 - 4200 * 0.15;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = discount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }

                    }
                    else if (fishermans > 12)
                    {
                        double disscount = 4200 - 4200 * 0.25;
                        if (disscount <= budget)
                        {
                            double result = budget - disscount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = disscount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }
                    }
                    break;
                case "Spring":
                    if (fishermans <= 6 && fishermans % 2 == 0)
                    {
                        double discount = 3000 - 3000 * 0.1 - 3000 * 0.5;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = discount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }
                    }
                    else if (fishermans <= 6)
                    {
                        double discount = 3000 - 3000 * 0.1;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = discount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }
                    }
                    if (fishermans > 7 && fishermans <= 11 && fishermans % 2 == 0)
                    {
                        double discount = 3000 - 3000 * 0.15 - 3000 * 0.5;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = discount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                       }
                    }
                    else if (fishermans > 7 && fishermans <= 11)
                    {
                        double discount = 3000 - 3000 * 0.15;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = discount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }

                    }
                    if (fishermans > 12 && fishermans % 2 == 0)
                    {
                        double disscount = 3000 - 3000 * 0.25 - 3000 * 0.5;
                        if (disscount <= budget)
                        {
                            double result = budget - disscount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = disscount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }
                    }
                    else if (fishermans > 12)
                    {
                        double disscount = 3000 - 3000 * 0.25;
                        if (disscount <= budget)
                        {
                            double result = budget - disscount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = disscount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }
                    }
                    break;
                case "Winter":
                    if (fishermans <= 6 && fishermans % 2 == 0)
                    {
                        double discount = 2600 - 2600 * 0.1 - 2600 * 0.5;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = discount - budget;
                            Console.WriteLine($"Not enough money! You need {result:F2} leva.");
                        }
                    }
                    else if (fishermans <= 6)
                    {
                        double discount = 2600 - 2600 * 0.1;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = discount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }
                    }
                    if (fishermans > 7 && fishermans <= 11 && fishermans % 2 == 0)
                    {
                        double discount = 2600 - 2600 * 0.15 - 2600 * 0.5;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = discount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }
                    }
                    else if (fishermans > 7 && fishermans <= 11)
                    {
                        double discount = 2600 - 2600 * 0.15;
                        if (discount <= budget)
                        {
                            double result = budget - discount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = discount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }

                    }
                    if (fishermans > 12 && fishermans % 2 == 0)
                    {
                        double disscount = 2600 - 2600 * 0.25 - 2600 * 0.5;
                        if (disscount <= budget)
                        {
                            double result = budget - disscount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = disscount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }
                    }
                    else if (fishermans > 12)
                    {
                        double disscount = 2600 - 2600 * 0.25;
                        if (disscount <= budget)
                        {
                            double result = budget - disscount;
                            Console.WriteLine($"Yes! You have {result:f2} leva left.");
                        }
                        else
                        {
                            double result = disscount - budget;
                            Console.WriteLine($"Not enough money! You need {result:f2} leva.");
                        }
                    }
                    break;

            }
        }
    }
}

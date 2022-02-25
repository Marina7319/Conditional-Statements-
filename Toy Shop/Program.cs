using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayWeekendPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingBarbies = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minnions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double puzzleTotal = puzzles * 2.60;
            int talkingBarbiesTotal = talkingBarbies * 3;
            double bearsTotal = bears * 4.10;
            double minionsTotal = minnions * 8.20;
            int trucksTotal = trucks * 2;
            double totalPrice = puzzleTotal + talkingBarbiesTotal + bearsTotal + minionsTotal + trucksTotal;
            int numberToys = puzzles + talkingBarbies + bears + minnions + trucks;
            if (numberToys >= 50)
            {
                double disscount = totalPrice - totalPrice * 0.250;
                double rent = disscount - disscount * 0.10;
                double difference = rent - holidayWeekendPrice;
                if (difference >= 0)
                {
                    Console.WriteLine($"Yes! {difference:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {holidayWeekendPrice - rent:f2} lv needed.");
                }

            }
            else
            {
                double rent = totalPrice - totalPrice * 0.10;
                if (rent >= holidayWeekendPrice)
                {
                    Console.WriteLine($"Yes! {rent >= holidayWeekendPrice} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {holidayWeekendPrice - rent:f2} lv needed.");
                }
            }

        }
    }
}

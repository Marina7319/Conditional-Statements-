using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double fastestSwimming = double.Parse(Console.ReadLine());
            double metersLength = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double syprotivlenie = Math.Floor(metersLength / 15);
            double total = metersLength * time;
            double syprotivlenieSecunds = syprotivlenie * 12.5;
            double SumTime = total + syprotivlenieSecunds;         
            if (SumTime < fastestSwimming)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {SumTime:f2} seconds.");
            }
            else
            {
                double notEnought = SumTime - fastestSwimming;
                Console.WriteLine($"No, he failed! He was {notEnought:f2} seconds slower.");
            }
        }
    }
}

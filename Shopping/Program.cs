using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double PeterBudget = double.Parse(Console.ReadLine());
            int videocarts = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ramMemory = int.Parse(Console.ReadLine());
            double totalSumVideo = 250 * videocarts;
            double processorPrice = 0.35 * totalSumVideo;
            double processorsTotalSum = processorPrice * processors;
            double ramMemoryPrice = 0.1 * totalSumVideo;
            double remMemoryTotalSum = ramMemoryPrice * ramMemory;
            double totalSum = totalSumVideo + processorsTotalSum + remMemoryTotalSum;
            if (videocarts > processors)
            {
                double disscountPrice = totalSum - totalSum * 0.15;
                if (disscountPrice <= PeterBudget)
                {
                    double change = PeterBudget- disscountPrice;
                    Console.WriteLine($"You have {change:f2} leva left!");
                }
                else
                {
                    double sumNeeded = disscountPrice - PeterBudget;
                    Console.WriteLine($"Not enough money! You need {sumNeeded:f2} leva more!");
                }
            }
            else
            {
                if (totalSum <= PeterBudget)
                {
                    double change = PeterBudget - totalSum;
                    Console.WriteLine($"You have {change:f2} leva left!");
                }
                else
                {
                    double sumNeeded = totalSum - PeterBudget;
                    Console.WriteLine($"Not enough money! You need {sumNeeded:f2} leva more!");
                }
            }
        }
    }
}

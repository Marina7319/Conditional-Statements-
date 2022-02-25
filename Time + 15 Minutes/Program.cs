using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //чете час и минути 
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            //изчислява колко ще е часът след 15 минути 
            int hoursToMinutes = hour * 60;
            int totalMinutes = hoursToMinutes + minutes + 15;
            int hoursSum = totalMinutes / 60;
            int minutesSum = totalMinutes % 60;
            if (hoursSum > 23)
            {
                hoursSum = 0;
                if (minutesSum < 10)
                {
                    Console.WriteLine($"{hoursSum}:0{minutesSum}");
                }
                else
                {
                    Console.WriteLine($"{hoursSum}:{minutesSum}");
                }
            }
            else
            {
                if (minutesSum < 10)
                {
                    Console.WriteLine($"{hoursSum}:0{minutesSum}");
                }
                else
                {
                    Console.WriteLine($"{hoursSum}:{minutesSum}");
                }
            }
        }
    }
}


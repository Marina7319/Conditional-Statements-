using System;

namespace Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            //число за оценка > 5,50
            double input = double.Parse(Console.ReadLine());
            //изчисляваме стойността на оценката
            if (input >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}

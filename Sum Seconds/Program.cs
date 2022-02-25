using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //трима спортисти брои секунди (1;50) 
            int firstSportsMan = int.Parse(Console.ReadLine());
            int secondSportsMan = int.Parse(Console.ReadLine());
            int thirdSportsMan = int.Parse(Console.ReadLine());
            //изчисляване на времето за тримъта състезатели 
            int sumSeconds = firstSportsMan + secondSportsMan + thirdSportsMan;
            double seconds = sumSeconds % 60;
            double sumMinutes = sumSeconds / 60;
            //Секундите с водещя нула 01, 04 , 06 
            //отпечатване на резултата 
            if (seconds >= 10)
            {
                Console.WriteLine($"{sumMinutes}:{seconds}");
            }
            else
            {
                Console.WriteLine($"{sumMinutes}:0{seconds}");
            }
        }
    }
}

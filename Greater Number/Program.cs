using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //четене две цели числа
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            //изчисляване кое число е по-голямо от двете
            if (numOne > numTwo)
            {
                Console.WriteLine(numOne);
            }
            else
            {
                Console.WriteLine(numTwo);
            }
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //цяло число 
            int num = int.Parse(Console.ReadLine());
            //число + бонус точки 
            double bonus = 0;
            //изчисляване на бонус точките за числото и общия брои точки число + бонус точки
            if (num <= 100)
            {
                //•Ако числото е до 100 включително, бонус точките са 5.
                bonus = 5;
            }
            else if (num > 1000)
            {
                //•	Ако числото е по-голямо от 100, бонус точките са 20 % от числото.
                bonus = num * 10 / 100.0;
            }
            else
            {
                bonus = num * 0.2;
                //•	Ако числото е по-голямо от 1000, бонус точките са 10 % от числото.
            }
            if (num % 2 == 0)
            {
                bonus = bonus + 1;
                //•	Допълнителни бонус точки(начисляват се отделно от предходните):
            }
            else if (num % 10 == 5)
            {
                bonus += 2;
            }
            // За четно число  +1 т.
            // За число, което завършва на 5  +2 т.
            //отпечатване на конзолата
            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
        }
    }
}

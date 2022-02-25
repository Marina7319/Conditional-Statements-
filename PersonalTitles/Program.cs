using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double ages = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            if(ages >= 16 && gender == 'm')
            {
                Console.WriteLine("Mr.");
            }else if (ages < 16 && gender == 'm')
            {
                Console.WriteLine("Master");
            }
            else if (ages >= 16 && gender == 'f')
            {
                Console.WriteLine("Ms.");
            }
            else if (ages < 16 && gender == 'f')
            {
                Console.WriteLine("Miss");
            }
        }
    }
}

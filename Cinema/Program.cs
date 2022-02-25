using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string shows = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int sits = rows * cols;
            switch (shows)
            {
                case "Premiere":
                    double pricePremiere = 12.00;                   
                    double totalIncomePremiere = pricePremiere * sits;
                    Console.WriteLine($"{totalIncomePremiere:f2} leva");
                    break;
                case "Normal":
                    double priceNormal = 7.50;                 
                    double totalIncomeNormal = priceNormal * sits;
                    Console.WriteLine($"{totalIncomeNormal:f2} leva");
                    break;
                case "Discount":
                    double priceDiscountDiscount = 5.00;
                    double totalIncomeDiscount = priceDiscountDiscount * sits;
                    Console.WriteLine($"{totalIncomeDiscount:f2} leva");
                    break;
            }
        }
    }
}

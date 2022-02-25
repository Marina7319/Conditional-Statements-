using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            //четене вид и лицето на геометрична фигура
            string figure = Console.ReadLine();//square 
            //да се намери лицето на квадрат, правоъгълник, кръг, триъгълник
            //четери фигури
            //квадрат (square), дължина на  страната
            //правоъгълник (rectangle), дължина на страната а и б 
            //кръг (circle), радиусът на кръгът
            //триъгълник (triangle), дължината на транната и дължината на височината 
            if (figure == "square")
            {
                //чете дължината на странната му 
                double numA = double.Parse(Console.ReadLine());//5
                double area = numA * numA;//5x5=25
                //отпечатване резултата 
                Console.WriteLine($"{area:f3}");
            }
            if (figure == "rectangle")
            {
                //дължина на страната а и б 
                double numA = double.Parse(Console.ReadLine());//7
                double numb = double.Parse(Console.ReadLine());//2.5
                double area = numA * numb;//7x2.5=15
                //отпечатване резултата 
                Console.WriteLine($"{area:f3}");
            }
            if (figure == "circle")
            {
                //радиусът на кръгът
                double radius = double.Parse(Console.ReadLine());//6
                double area = Math.PI * radius * radius;//3.14x6x6=113.097
                //отпечатване резултата 
                Console.WriteLine($"{area:f3}");
            }
            if (figure == "triangle")
            {
                //дължината на транната и дължината на височината 
                double numA = double.Parse(Console.ReadLine());//4.5
                double numH = double.Parse(Console.ReadLine());//20
                double area = (numA * numH) / 2;//4.5*20/2=45
                //отпечатване резултата 
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}

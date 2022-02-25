using System;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дума която е ключова
            string wordPassword = "s3cr3t!P@ssw0rd";
            //четене на дума от конзолата
            string word = Console.ReadLine();
            //изчисляване еднаквост низовете за еднаквост
            if (word == wordPassword)
            {
                //отпечатване на резултата 
                Console.WriteLine("Welcome");
            }
            else
            {
                //отпечатване на резултата 
                Console.WriteLine("Wrong password!");
            }
        }
    }
}

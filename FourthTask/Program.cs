using System;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter a number");
            double randomNumber = double.Parse(Console.ReadLine());


            if (randomNumber % 3 == 0 && randomNumber % 5 == 0)
            {
                Console.WriteLine("Tik-Tak");
            }
            else if(randomNumber % 5 == 0)
            {
                Console.WriteLine("Tak");
            }
            else if (randomNumber % 3 == 0)
            {
                Console.WriteLine("Tik");
            }

            else //(randomNumber % 3 != 0 || randomNumber % 5 != 0)
            {
                Console.WriteLine("Bad Number");

            }

            Console.ReadLine();
        }
    }
}

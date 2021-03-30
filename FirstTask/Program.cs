using System;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Create new console application “RealCalculator” that takes two
            //numbers from the input and asks what operation would the user
            //want to be done( +, - , * , / ). Then it returns the result.


            //int parsedInt = int.Parse(numberString);
            //Console.WriteLine(parsedInt.GetType());

            Console.WriteLine("Enter your first number: ");
            int firsUserNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number ");

            int secondUserNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Which operator are you going to use: +, - , * , / " );
            char userInput = Convert.ToChar(Console.ReadLine());

           
            if (userInput == '+')
            {
                Console.WriteLine(firsUserNumber + secondUserNumber);
            }
            else if (userInput == '-')
            {
                Console.WriteLine(firsUserNumber - secondUserNumber);
            }
            else if (userInput == '*')
            {
                Console.WriteLine(firsUserNumber * secondUserNumber);
            }
            else
                Console.WriteLine(firsUserNumber / secondUserNumber);

            

           



            Console.ReadLine();
        }
    }
}

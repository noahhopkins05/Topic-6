using System;
using System.ComponentModel;

namespace Topic_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber, maxNumber, generatedNumber, guessedNumber, numberOfGuesses;
            int loop = 0;
            Random generator = new Random();


            Console.WriteLine("Enter min number:");
            minNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max number:");
            maxNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount of guesses you would like to have:");
            numberOfGuesses = Convert.ToInt32(Console.ReadLine());
            generatedNumber = generator.Next(minNumber, maxNumber);

            while (loop < numberOfGuesses)
            {
                Console.WriteLine("Enter your guess:");
                guessedNumber = Convert.ToInt32(Console.ReadLine());

                if (guessedNumber == generatedNumber)
                {
                    Console.WriteLine("Correct. Well done!");
                    break;
                }
                else if (guessedNumber > generatedNumber)
                {
                    Console.WriteLine("Too high.");
                    loop = loop + 1;
                }
                else if (guessedNumber < generatedNumber)
                {
                    Console.WriteLine("Too low.");
                    loop = loop + 1;    
                }
            }




        }
    }
}